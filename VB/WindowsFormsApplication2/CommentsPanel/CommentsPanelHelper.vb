Imports DevExpress.Pdf
Imports DevExpress.XtraBars.Navigation
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApplication2
    Public Class CommentsPanelHelper
        Private Const imagePlaceholder As String = "<image =#Comment_16x16>"
        Private acControl As AccordionControl
        Public Sub New(ByVal acControl As AccordionControl)
            Me.acControl = acControl
            AddHandler acControl.CustomDrawElement, AddressOf AcControl_CustomDrawElement
        End Sub

        Private Sub AcControl_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            Dim selectedCommentName As String = If(acControl.Tag IsNot Nothing, acControl.Tag.ToString(), "")
            If e.Element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Group AndAlso e.Element.Name = selectedCommentName Then
                Dim viewInfo As AccordionGroupViewInfo = TryCast(e.ObjectInfo, AccordionGroupViewInfo)
                e.DrawHeaderBackground()
                Using brush As Brush = New SolidBrush(Color.FromArgb(30, Color.Gray))
                    e.Cache.FillRectangle(brush, viewInfo.HeaderBounds)
                End Using
                e.DrawText()
                e.DrawImage()
                e.DrawExpandCollapseButton()
                e.Handled = True
            End If
        End Sub

        Public Sub ClearPanel()
            acControl.BeginUpdate()
            acControl.Elements.Clear()
            acControl.EndUpdate()
        End Sub
        Public Sub InitPanel(ByVal comments As List(Of CommentData))
            acControl.BeginUpdate()

            Dim fakeGroup As New AccordionControlElement()
            fakeGroup.HeaderVisible = False
            acControl.Elements.Add(fakeGroup)
            For Each comment As CommentData In comments
                Dim acgroup As AccordionControlElement = CreateReplyItem(comment, True, New PdfDocumentPosition(comment.PageNumber, comment.BoundingBox.TopLeft))
                For Each reply As ReplyData In comment.Replies
                    acgroup.Elements.Add(CreateReplyItem(reply, False, New PdfDocumentPosition(comment.PageNumber, comment.BoundingBox.TopLeft)))
                Next reply
                fakeGroup.Elements.Add(acgroup)
            Next comment

           acControl.EndUpdate()
        End Sub

        Private Function CreateReplyItem(ByVal reply As ReplyData, ByVal isGroupItem As Boolean, ByVal posiiton As PdfDocumentPosition) As AccordionControlElement
            Dim acItem As New AccordionControlElement()
            acItem.Style = If(isGroupItem, ElementStyle.Group, ElementStyle.Item)
            acItem.Tag = posiiton
            acItem.Name = reply.Name
            Dim creationDate As DateTimeOffset = If(reply.CreationDate, Date.MinValue)
            Dim htmlText As String = String.Format("{0} <b>{1}</b> {2}<br>{3}", imagePlaceholder, reply.Subject, creationDate.DateTime.ToShortDateString(), reply.Text)
            acItem.Text = htmlText

            acItem.Expanded = True
            Return acItem
        End Function
    End Class
End Namespace
