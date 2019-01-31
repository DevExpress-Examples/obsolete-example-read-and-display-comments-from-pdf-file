Imports DevExpress.Pdf
Imports System.Collections.Generic

Namespace WindowsFormsApplication2
    Public Class CommentReader
        Public Function ReadComments(ByVal fileName As String) As List(Of CommentData)
            Dim comments As New List(Of CommentData)()
            Using pServer As New PdfDocumentProcessor()
                pServer.LoadDocument(fileName)
                For i As Integer = 0 To pServer.Document.Pages.Count - 1
                    Dim page As PdfPage = pServer.Document.Pages(i)
                    Dim pageNumber As Integer = i + 1
                    For Each annotation As PdfAnnotation In page.Annotations
                        If TypeOf annotation Is PdfTextAnnotation Then
                            Dim comment As PdfTextAnnotation = CType(annotation, PdfTextAnnotation)
                            If comment.InReplyTo Is Nothing Then
                                If comments.FindIndex(Function(item) item.Name = comment.Name) = -1 Then
                                    comments.Add(CreateCommentData(comment, pageNumber))
                                End If
                            Else
                                Dim replyData As ReplyData = CreateReplyData(comment, pageNumber)
                                Dim parentAnnotation As PdfTextAnnotation = CType(comment.InReplyTo, PdfTextAnnotation)
                                Dim name As String = parentAnnotation.Name
                                Dim parentComment As CommentData = comments.Find(Function(item) item.Name = name)
                                If parentComment Is Nothing Then
                                    parentComment = CreateCommentData(comment, pServer.Document.Pages.IndexOf(parentAnnotation.Page) + 1)
                                    comments.Add(parentComment)
                                End If
                                parentComment.Replies.Add(replyData)
                            End If
                        End If
                    Next annotation
                Next i
            End Using
            Return comments
        End Function
        Private Function CreateReplyData(ByVal comment As PdfTextAnnotation, ByVal pageNumber As Integer) As ReplyData
            Dim reply As New ReplyData()
            InitData(reply, comment, pageNumber)
            Return reply
        End Function
        Private Function CreateCommentData(ByVal comment As PdfTextAnnotation, ByVal pageNumber As Integer) As CommentData
            Dim data As New CommentData()
            InitData(data, comment, pageNumber)
            Dim pageCropBoxBottomLeft As PdfPoint = comment.Page.CropBox.BottomLeft
            Dim rectangle As New PdfRectangle(comment.Rect.Left - pageCropBoxBottomLeft.X, comment.Rect.Bottom - pageCropBoxBottomLeft.Y, comment.Rect.Right - pageCropBoxBottomLeft.X, comment.Rect.Top - pageCropBoxBottomLeft.Y)
            data.BoundingBox = rectangle
            Return data
        End Function
        Private Sub InitData(ByVal data As ReplyData, ByVal comment As PdfTextAnnotation, ByVal pageNumber As Integer)
            data.Subject = comment.Title
            data.Text = comment.Contents
            data.Name = comment.Name
            data.CreationDate = comment.CreationDate
            data.PageNumber = pageNumber
        End Sub

    End Class
End Namespace
