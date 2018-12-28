using DevExpress.Pdf;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication2 {
    public class ReplyData {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? CreationDate { get; set; }
        public int PageNumber { get; set; }
    }

    public class CommentData : ReplyData {
        public PdfRectangle BoundingBox { get; set; }
        public List<ReplyData> Replies { get; private set; }

        public CommentData() {
            Replies = new List<ReplyData>();
        }
    }
}
