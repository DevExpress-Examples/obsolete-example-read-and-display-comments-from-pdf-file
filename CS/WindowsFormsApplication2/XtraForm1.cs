using DevExpress.Pdf;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraPdfViewer;
using System.Collections.Generic;

namespace WindowsFormsApplication2 {
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        List<CommentData> comments = null;
        CommentsPanelHelper helper = null;
        public XtraForm1() {
            InitializeComponent();
            string fileName = "Comments.pdf";
            helper = new CommentsPanelHelper(accordionControl1);
            pdfViewer1.DocumentChanged += PdfViewer1_DocumentChanged;
            pdfViewer1.MouseDown += PdfViewer1_MouseDown;
            accordionControl1.ElementClick += AccordionControl1_ElementClick;
            pdfViewer1.ZoomMode = PdfZoomMode.FitToVisible;

            pdfViewer1.LoadDocument(fileName);
        }

        private void PdfViewer1_DocumentChanged(object sender, PdfDocumentChangedEventArgs e) {
            pdfViewer1.NavigationPaneInitialVisibility = PdfNavigationPaneVisibility.Hidden;
            InitAccordionControl(e.DocumentFilePath);
        }
        private void PdfViewer1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            PdfDocumentContent content = pdfViewer1.GetContentInfo(e.Location);
            if (content.ContentType == PdfDocumentContentType.Annotation) {
                CommentData stickyNote = comments.Find((item) => item.BoundingBox.Contains(content.DocumentPosition.Point));
                if (stickyNote == null) return;
                string annotationName = stickyNote.Name;
                AccordionControlElement element = accordionControl1.GetElements().Find((item) => item.Name == annotationName);
                if (element != null)
                {
                    accordionControl1.Tag = element.Name;
                    accordionControl1.Refresh();
                }
            }
        }
        void SelectTextAnnotation(AccordionControlElement element)
        {
            PdfDocumentPosition position = (PdfDocumentPosition)element.Tag;
            pdfViewer1.EnsureVisibility(position);
            pdfViewer1.SelectAnnotation(position.PageNumber, element.Name);
            accordionControl1.Tag = element.Name;
        }
        private void AccordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e) {
            AccordionControlElement element = e.Element;
            if (element.Style == ElementStyle.Group)
                SelectTextAnnotation(element);
            else
                SelectTextAnnotation(element.OwnerElement);

        }
        private void InitAccordionControl(string fileName) {
            CommentReader reader = new CommentReader();
            comments = new List<CommentData>();
            comments = reader.ReadComments(fileName);
            helper.ClearPanel();
            helper.InitPanel(comments);
        }
    }
}