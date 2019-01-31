Imports DevExpress.Pdf
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraPdfViewer
Imports System.Collections.Generic

Namespace WindowsFormsApplication2
    Partial Public Class XtraForm1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private comments As List(Of CommentData) = Nothing
        Private helper As CommentsPanelHelper = Nothing
        Public Sub New()
            InitializeComponent()
            Dim fileName As String = "Comments.pdf"
            helper = New CommentsPanelHelper(accordionControl1)
            AddHandler pdfViewer1.DocumentChanged, AddressOf PdfViewer1_DocumentChanged
            AddHandler pdfViewer1.MouseDown, AddressOf PdfViewer1_MouseDown
            AddHandler accordionControl1.ElementClick, AddressOf AccordionControl1_ElementClick
            pdfViewer1.ZoomMode = PdfZoomMode.FitToVisible

            pdfViewer1.LoadDocument(fileName)
        End Sub

        Private Sub PdfViewer1_DocumentChanged(ByVal sender As Object, ByVal e As PdfDocumentChangedEventArgs)
            pdfViewer1.NavigationPaneInitialVisibility = PdfNavigationPaneVisibility.Hidden
            InitAccordionControl(e.DocumentFilePath)
        End Sub
        Private Sub PdfViewer1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            Dim content As PdfDocumentContent = pdfViewer1.GetContentInfo(e.Location)
            If content.ContentType = PdfDocumentContentType.Annotation Then
                Dim stickyNote As CommentData = comments.Find(Function(item) item.BoundingBox.Contains(content.DocumentPosition.Point))
                If stickyNote Is Nothing Then
                    Return
                End If
                Dim annotationName As String = stickyNote.Name
                Dim element As AccordionControlElement = accordionControl1.GetElements().Find(Function(item) item.Name = annotationName)
                If element IsNot Nothing Then
                    accordionControl1.Tag = element.Name
                    accordionControl1.Refresh()
                End If
            End If
        End Sub
        Private Sub SelectTextAnnotation(ByVal element As AccordionControlElement)
            Dim position As PdfDocumentPosition = CType(element.Tag, PdfDocumentPosition)
            pdfViewer1.EnsureVisibility(position)
            pdfViewer1.SelectAnnotation(position.PageNumber, element.Name)
            accordionControl1.Tag = element.Name
        End Sub
        Private Sub AccordionControl1_ElementClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Navigation.ElementClickEventArgs)
            Dim element As AccordionControlElement = e.Element
            If element.Style = ElementStyle.Group Then
                SelectTextAnnotation(element)
            Else
                SelectTextAnnotation(element.OwnerElement)
            End If

        End Sub
        Private Sub InitAccordionControl(ByVal fileName As String)
            Dim reader As New CommentReader()
            comments = New List(Of CommentData)()
            comments = reader.ReadComments(fileName)
            helper.ClearPanel()
            helper.InitPanel(comments)
        End Sub
    End Class
End Namespace