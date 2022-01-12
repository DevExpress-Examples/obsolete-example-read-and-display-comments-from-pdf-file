<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/165073130/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830480)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to read and display comments from a PDF file

**This example is obsolete. Starting with version 20.2, the DevExpress PDF Document API and PDF Viewer support sticky notes (comments) out of the box. PDF Viewer has the Comments Pane to add, edit and remove sticky notes in UI. Please refer to this blog to learn more: [PDF – Sticky Notes and Comments](https://community.devexpress.com/blogs/office/archive/2020/11/17/pdf-sticky-notes-and-comments.aspx)**

This example demonstrates how to read comments ([sticky notes](https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfTextAnnotation.class)) from a PDF document with help of the [PDF Document API](https://docs.devexpress.com/OfficeFileAPI/16491/pdf-document-api) library. Retrieved comments' data is displayed in an [AccordionControl](https://docs.devexpress.com/WindowsForms/114553/controls-and-libraries/navigation-controls/accordion-control) next to the PDF document loaded into [PDF Viewer](https://www.devexpress.com/products/net/controls/winforms/pdf-viewer/).

![](./Comments_Panel.png)
