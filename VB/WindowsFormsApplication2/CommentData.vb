Imports DevExpress.Pdf
Imports System
Imports System.Collections.Generic

Namespace WindowsFormsApplication2
    Public Class ReplyData
        Public Property Subject() As String
        Public Property Text() As String
        Public Property Name() As String
        Public Property CreationDate() As DateTimeOffset?
        Public Property PageNumber() As Integer
    End Class

    Public Class CommentData
        Inherits ReplyData

        Public Property BoundingBox() As PdfRectangle
        Private privateReplies As List(Of ReplyData)
        Public Property Replies() As List(Of ReplyData)
            Get
                Return privateReplies
            End Get
            Private Set(ByVal value As List(Of ReplyData))
                privateReplies = value
            End Set
        End Property

        Public Sub New()
            Replies = New List(Of ReplyData)()
        End Sub
    End Class
End Namespace
