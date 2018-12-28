using DevExpress.Pdf;
using System.Collections.Generic;

namespace WindowsFormsApplication2 {
    public class CommentReader {
        public List<CommentData> ReadComments(string fileName) {
            List<CommentData> comments = new List<CommentData>();
            using (PdfDocumentProcessor pServer = new PdfDocumentProcessor()) {
                pServer.LoadDocument(fileName);
                for (int i = 0; i < pServer.Document.Pages.Count; i++) {
                    PdfPage page = pServer.Document.Pages[i];
                    int pageNumber = i + 1;
                    foreach (PdfAnnotation annotation in page.Annotations) {
                        if (annotation is PdfTextAnnotation) {
                            PdfTextAnnotation comment = (PdfTextAnnotation)annotation;
                            if (comment.InReplyTo == null) {
                                if (comments.FindIndex((item) => item.Name == comment.Name) == -1)
                                    comments.Add(CreateCommentData(comment, pageNumber));
                            }
                            else {
                                ReplyData replyData = CreateReplyData(comment, pageNumber);
                                PdfTextAnnotation parentAnnotation = (PdfTextAnnotation)comment.InReplyTo;
                                string name = parentAnnotation.Name;
                                CommentData parentComment = comments.Find((item) => item.Name == name);
                                if (parentComment == null) {
                                    parentComment = CreateCommentData(comment, pServer.Document.Pages.IndexOf(parentAnnotation.Page) + 1);
                                    comments.Add(parentComment);
                                }
                                parentComment.Replies.Add(replyData);
                            }
                        }
                    }
                }
            }
            return comments;
        }
        ReplyData CreateReplyData(PdfTextAnnotation comment, int pageNumber) {
            ReplyData reply = new ReplyData();
            InitData(reply, comment, pageNumber);
            return reply;
        }
        CommentData CreateCommentData(PdfTextAnnotation comment, int pageNumber) {
            CommentData data = new CommentData();
            InitData(data, comment, pageNumber);
            PdfPoint pageCropBoxBottomLeft = comment.Page.CropBox.BottomLeft;
            PdfRectangle rectangle = new PdfRectangle(comment.Rect.Left - pageCropBoxBottomLeft.X, comment.Rect.Bottom - pageCropBoxBottomLeft.Y, comment.Rect.Right - pageCropBoxBottomLeft.X, comment.Rect.Top - pageCropBoxBottomLeft.Y);
            data.BoundingBox = rectangle;
            return data;
        }
        void InitData(ReplyData data, PdfTextAnnotation comment, int pageNumber) {
            data.Subject = comment.Title;
            data.Text = comment.Contents;
            data.Name = comment.Name;
            data.CreationDate = comment.CreationDate;
            data.PageNumber = pageNumber;
        }

    }
}
