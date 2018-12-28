using DevExpress.Pdf;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class CommentsPanelHelper
    {
        const string imagePlaceholder = "<image =#Comment_16x16>";
        AccordionControl acControl;
        public CommentsPanelHelper(AccordionControl acControl)
        {
            this.acControl = acControl;
            acControl.CustomDrawElement += AcControl_CustomDrawElement;
        }

        private void AcControl_CustomDrawElement(object sender, CustomDrawElementEventArgs e)
        {
            string selectedCommentName = acControl.Tag != null ? acControl.Tag.ToString() : "";
            if (e.Element.Style == DevExpress.XtraBars.Navigation.ElementStyle.Group &&
                e.Element.Name == selectedCommentName)
            {
                AccordionGroupViewInfo viewInfo = e.ObjectInfo as AccordionGroupViewInfo;
                e.DrawHeaderBackground();
                using (Brush brush = new SolidBrush(Color.FromArgb(30, Color.Gray)))
                    e.Cache.FillRectangle(brush, viewInfo.HeaderBounds);
                e.DrawText();
                e.DrawImage();
                e.DrawExpandCollapseButton();
                e.Handled = true;
            }
        }

        public void ClearPanel()
        {
            acControl.BeginUpdate();
            acControl.Elements.Clear();
            acControl.EndUpdate();
        }
        public void InitPanel(List<CommentData> comments)
        {
            acControl.BeginUpdate();

            AccordionControlElement fakeGroup = new AccordionControlElement();
            fakeGroup.HeaderVisible = false;
            acControl.Elements.Add(fakeGroup);
            foreach (CommentData comment in comments)
            {
                AccordionControlElement acgroup = CreateReplyItem(comment, true, new PdfDocumentPosition(comment.PageNumber, comment.BoundingBox.TopLeft));
                foreach(ReplyData reply in comment.Replies)
                {
                    acgroup.Elements.Add(CreateReplyItem(reply, false, new PdfDocumentPosition(comment.PageNumber, comment.BoundingBox.TopLeft)));
                }
                fakeGroup.Elements.Add(acgroup);
            }

           acControl.EndUpdate();
        }
       
        private AccordionControlElement CreateReplyItem(ReplyData reply, bool isGroupItem, PdfDocumentPosition posiiton)
        {
            AccordionControlElement acItem = new AccordionControlElement();
            acItem.Style = isGroupItem ? ElementStyle.Group : ElementStyle.Item;
            acItem.Tag = posiiton;
            acItem.Name = reply.Name;
            DateTimeOffset creationDate = reply.CreationDate ?? DateTime.MinValue;
            string htmlText = string.Format("{0} <b>{1}</b> {2}<br>{3}", imagePlaceholder, reply.Subject,
            creationDate.DateTime.ToShortDateString(), reply.Text);
            acItem.Text = htmlText;

            acItem.Expanded = true;
            return acItem;
        }
    }
}
