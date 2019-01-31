Namespace WindowsFormsApplication2
    Partial Public Class XtraForm1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.pdfFileOpenBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem()
            Me.pdfFileSaveAsBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem()
            Me.pdfFilePrintBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem()
            Me.pdfFindTextBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem()
            Me.pdfPreviousPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem()
            Me.pdfNextPageBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem()
            Me.pdfSetPageNumberBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem()
            Me.repositoryItemPageNumberEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit()
            Me.pdfZoomOutBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem()
            Me.pdfZoomInBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem()
            Me.pdfExactZoomListBarSubItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem()
            Me.pdfZoom10CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem()
            Me.pdfZoom25CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem()
            Me.pdfZoom50CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem()
            Me.pdfZoom75CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem()
            Me.pdfZoom100CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem()
            Me.pdfZoom125CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem()
            Me.pdfZoom150CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem()
            Me.pdfZoom200CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem()
            Me.pdfZoom400CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem()
            Me.pdfZoom500CheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem()
            Me.pdfSetActualSizeZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem()
            Me.pdfSetPageLevelZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem()
            Me.pdfSetFitWidthZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem()
            Me.pdfSetFitVisibleZoomModeCheckItem1 = New DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem()
            Me.pdfTextHighlightBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem()
            Me.pdfTextStrikethroughBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem()
            Me.pdfTextUnderlineBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem()
            Me.pdfExportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem()
            Me.pdfImportFormDataBarItem1 = New DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem()
            Me.pdfRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfRibbonPage()
            Me.pdfFileRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup()
            Me.pdfFindRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup()
            Me.pdfNavigationRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup()
            Me.pdfZoomRibbonPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup()
            Me.pdfCommentRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfCommentRibbonPage()
            Me.pdfTextCommentPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfTextCommentPageGroup()
            Me.pdfFormDataRibbonPage1 = New DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage()
            Me.pdfFormDataBarPageGroup1 = New DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup()
            Me.pdfBarController1 = New DevExpress.XtraPdfViewer.Bars.PdfBarController(Me.components)
            Me.pdfViewer1 = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.pdfFileOpenBarItem1, Me.pdfFileSaveAsBarItem1, Me.pdfFilePrintBarItem1, Me.pdfFindTextBarItem1, Me.pdfPreviousPageBarItem1, Me.pdfNextPageBarItem1, Me.pdfSetPageNumberBarItem1, Me.pdfZoomOutBarItem1, Me.pdfZoomInBarItem1, Me.pdfExactZoomListBarSubItem1, Me.pdfZoom10CheckItem1, Me.pdfZoom25CheckItem1, Me.pdfZoom50CheckItem1, Me.pdfZoom75CheckItem1, Me.pdfZoom100CheckItem1, Me.pdfZoom125CheckItem1, Me.pdfZoom150CheckItem1, Me.pdfZoom200CheckItem1, Me.pdfZoom400CheckItem1, Me.pdfZoom500CheckItem1, Me.pdfSetActualSizeZoomModeCheckItem1, Me.pdfSetPageLevelZoomModeCheckItem1, Me.pdfSetFitWidthZoomModeCheckItem1, Me.pdfSetFitVisibleZoomModeCheckItem1, Me.pdfTextHighlightBarItem1, Me.pdfTextStrikethroughBarItem1, Me.pdfTextUnderlineBarItem1, Me.pdfExportFormDataBarItem1, Me.pdfImportFormDataBarItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 31
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.pdfRibbonPage1, Me.pdfCommentRibbonPage1, Me.pdfFormDataRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemPageNumberEdit1})
            Me.ribbonControl1.Size = New System.Drawing.Size(983, 143)
            ' 
            ' pdfFileOpenBarItem1
            ' 
            Me.pdfFileOpenBarItem1.Id = 1
            Me.pdfFileOpenBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.pdfFileOpenBarItem1.Name = "pdfFileOpenBarItem1"
            ' 
            ' pdfFileSaveAsBarItem1
            ' 
            Me.pdfFileSaveAsBarItem1.Id = 2
            Me.pdfFileSaveAsBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
            Me.pdfFileSaveAsBarItem1.Name = "pdfFileSaveAsBarItem1"
            ' 
            ' pdfFilePrintBarItem1
            ' 
            Me.pdfFilePrintBarItem1.Id = 3
            Me.pdfFilePrintBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.pdfFilePrintBarItem1.Name = "pdfFilePrintBarItem1"
            ' 
            ' pdfFindTextBarItem1
            ' 
            Me.pdfFindTextBarItem1.Id = 4
            Me.pdfFindTextBarItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.pdfFindTextBarItem1.Name = "pdfFindTextBarItem1"
            ' 
            ' pdfPreviousPageBarItem1
            ' 
            Me.pdfPreviousPageBarItem1.Id = 5
            Me.pdfPreviousPageBarItem1.Name = "pdfPreviousPageBarItem1"
            ' 
            ' pdfNextPageBarItem1
            ' 
            Me.pdfNextPageBarItem1.Id = 6
            Me.pdfNextPageBarItem1.Name = "pdfNextPageBarItem1"
            ' 
            ' pdfSetPageNumberBarItem1
            ' 
            Me.pdfSetPageNumberBarItem1.Edit = Me.repositoryItemPageNumberEdit1
            Me.pdfSetPageNumberBarItem1.EditValue = 0
            Me.pdfSetPageNumberBarItem1.Enabled = False
            Me.pdfSetPageNumberBarItem1.Id = 7
            Me.pdfSetPageNumberBarItem1.Name = "pdfSetPageNumberBarItem1"
            ' 
            ' repositoryItemPageNumberEdit1
            ' 
            Me.repositoryItemPageNumberEdit1.AutoHeight = False
            Me.repositoryItemPageNumberEdit1.Mask.EditMask = "########;"
            Me.repositoryItemPageNumberEdit1.Name = "repositoryItemPageNumberEdit1"
            ' 
            ' pdfZoomOutBarItem1
            ' 
            Me.pdfZoomOutBarItem1.Id = 8
            Me.pdfZoomOutBarItem1.Name = "pdfZoomOutBarItem1"
            ' 
            ' pdfZoomInBarItem1
            ' 
            Me.pdfZoomInBarItem1.Id = 9
            Me.pdfZoomInBarItem1.Name = "pdfZoomInBarItem1"
            ' 
            ' pdfExactZoomListBarSubItem1
            ' 
            Me.pdfExactZoomListBarSubItem1.Id = 10
            Me.pdfExactZoomListBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom10CheckItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom25CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom50CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom75CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom100CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom125CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom150CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom200CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom400CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfZoom500CheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetActualSizeZoomModeCheckItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetPageLevelZoomModeCheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitWidthZoomModeCheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.pdfSetFitVisibleZoomModeCheckItem1) _
            })
            Me.pdfExactZoomListBarSubItem1.Name = "pdfExactZoomListBarSubItem1"
            Me.pdfExactZoomListBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu
            ' 
            ' pdfZoom10CheckItem1
            ' 
            Me.pdfZoom10CheckItem1.Id = 11
            Me.pdfZoom10CheckItem1.Name = "pdfZoom10CheckItem1"
            ' 
            ' pdfZoom25CheckItem1
            ' 
            Me.pdfZoom25CheckItem1.Id = 12
            Me.pdfZoom25CheckItem1.Name = "pdfZoom25CheckItem1"
            ' 
            ' pdfZoom50CheckItem1
            ' 
            Me.pdfZoom50CheckItem1.Id = 13
            Me.pdfZoom50CheckItem1.Name = "pdfZoom50CheckItem1"
            ' 
            ' pdfZoom75CheckItem1
            ' 
            Me.pdfZoom75CheckItem1.Id = 14
            Me.pdfZoom75CheckItem1.Name = "pdfZoom75CheckItem1"
            ' 
            ' pdfZoom100CheckItem1
            ' 
            Me.pdfZoom100CheckItem1.Id = 15
            Me.pdfZoom100CheckItem1.Name = "pdfZoom100CheckItem1"
            ' 
            ' pdfZoom125CheckItem1
            ' 
            Me.pdfZoom125CheckItem1.Id = 16
            Me.pdfZoom125CheckItem1.Name = "pdfZoom125CheckItem1"
            ' 
            ' pdfZoom150CheckItem1
            ' 
            Me.pdfZoom150CheckItem1.Id = 17
            Me.pdfZoom150CheckItem1.Name = "pdfZoom150CheckItem1"
            ' 
            ' pdfZoom200CheckItem1
            ' 
            Me.pdfZoom200CheckItem1.Id = 18
            Me.pdfZoom200CheckItem1.Name = "pdfZoom200CheckItem1"
            ' 
            ' pdfZoom400CheckItem1
            ' 
            Me.pdfZoom400CheckItem1.Id = 19
            Me.pdfZoom400CheckItem1.Name = "pdfZoom400CheckItem1"
            ' 
            ' pdfZoom500CheckItem1
            ' 
            Me.pdfZoom500CheckItem1.Id = 20
            Me.pdfZoom500CheckItem1.Name = "pdfZoom500CheckItem1"
            ' 
            ' pdfSetActualSizeZoomModeCheckItem1
            ' 
            Me.pdfSetActualSizeZoomModeCheckItem1.Id = 21
            Me.pdfSetActualSizeZoomModeCheckItem1.Name = "pdfSetActualSizeZoomModeCheckItem1"
            ' 
            ' pdfSetPageLevelZoomModeCheckItem1
            ' 
            Me.pdfSetPageLevelZoomModeCheckItem1.Id = 22
            Me.pdfSetPageLevelZoomModeCheckItem1.Name = "pdfSetPageLevelZoomModeCheckItem1"
            ' 
            ' pdfSetFitWidthZoomModeCheckItem1
            ' 
            Me.pdfSetFitWidthZoomModeCheckItem1.Id = 23
            Me.pdfSetFitWidthZoomModeCheckItem1.Name = "pdfSetFitWidthZoomModeCheckItem1"
            ' 
            ' pdfSetFitVisibleZoomModeCheckItem1
            ' 
            Me.pdfSetFitVisibleZoomModeCheckItem1.Id = 24
            Me.pdfSetFitVisibleZoomModeCheckItem1.Name = "pdfSetFitVisibleZoomModeCheckItem1"
            ' 
            ' pdfTextHighlightBarItem1
            ' 
            Me.pdfTextHighlightBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
            Me.pdfTextHighlightBarItem1.Id = 25
            Me.pdfTextHighlightBarItem1.Name = "pdfTextHighlightBarItem1"
            ' 
            ' pdfTextStrikethroughBarItem1
            ' 
            Me.pdfTextStrikethroughBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
            Me.pdfTextStrikethroughBarItem1.Id = 26
            Me.pdfTextStrikethroughBarItem1.Name = "pdfTextStrikethroughBarItem1"
            ' 
            ' pdfTextUnderlineBarItem1
            ' 
            Me.pdfTextUnderlineBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
            Me.pdfTextUnderlineBarItem1.Id = 27
            Me.pdfTextUnderlineBarItem1.Name = "pdfTextUnderlineBarItem1"
            ' 
            ' pdfExportFormDataBarItem1
            ' 
            Me.pdfExportFormDataBarItem1.Id = 28
            Me.pdfExportFormDataBarItem1.Name = "pdfExportFormDataBarItem1"
            ' 
            ' pdfImportFormDataBarItem1
            ' 
            Me.pdfImportFormDataBarItem1.Id = 29
            Me.pdfImportFormDataBarItem1.Name = "pdfImportFormDataBarItem1"
            ' 
            ' pdfRibbonPage1
            ' 
            Me.pdfRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pdfFileRibbonPageGroup1, Me.pdfFindRibbonPageGroup1, Me.pdfNavigationRibbonPageGroup1, Me.pdfZoomRibbonPageGroup1})
            Me.pdfRibbonPage1.Name = "pdfRibbonPage1"
            ' 
            ' pdfFileRibbonPageGroup1
            ' 
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFileOpenBarItem1)
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFileSaveAsBarItem1)
            Me.pdfFileRibbonPageGroup1.ItemLinks.Add(Me.pdfFilePrintBarItem1)
            Me.pdfFileRibbonPageGroup1.Name = "pdfFileRibbonPageGroup1"
            ' 
            ' pdfFindRibbonPageGroup1
            ' 
            Me.pdfFindRibbonPageGroup1.AllowTextClipping = False
            Me.pdfFindRibbonPageGroup1.ItemLinks.Add(Me.pdfFindTextBarItem1)
            Me.pdfFindRibbonPageGroup1.Name = "pdfFindRibbonPageGroup1"
            ' 
            ' pdfNavigationRibbonPageGroup1
            ' 
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfPreviousPageBarItem1)
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfNextPageBarItem1)
            Me.pdfNavigationRibbonPageGroup1.ItemLinks.Add(Me.pdfSetPageNumberBarItem1)
            Me.pdfNavigationRibbonPageGroup1.Name = "pdfNavigationRibbonPageGroup1"
            ' 
            ' pdfZoomRibbonPageGroup1
            ' 
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomOutBarItem1)
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfZoomInBarItem1)
            Me.pdfZoomRibbonPageGroup1.ItemLinks.Add(Me.pdfExactZoomListBarSubItem1)
            Me.pdfZoomRibbonPageGroup1.Name = "pdfZoomRibbonPageGroup1"
            ' 
            ' pdfCommentRibbonPage1
            ' 
            Me.pdfCommentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pdfTextCommentPageGroup1})
            Me.pdfCommentRibbonPage1.Name = "pdfCommentRibbonPage1"
            ' 
            ' pdfTextCommentPageGroup1
            ' 
            Me.pdfTextCommentPageGroup1.ItemLinks.Add(Me.pdfTextHighlightBarItem1)
            Me.pdfTextCommentPageGroup1.ItemLinks.Add(Me.pdfTextStrikethroughBarItem1)
            Me.pdfTextCommentPageGroup1.ItemLinks.Add(Me.pdfTextUnderlineBarItem1)
            Me.pdfTextCommentPageGroup1.Name = "pdfTextCommentPageGroup1"
            ' 
            ' pdfFormDataRibbonPage1
            ' 
            Me.pdfFormDataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pdfFormDataBarPageGroup1})
            Me.pdfFormDataRibbonPage1.Name = "pdfFormDataRibbonPage1"
            Me.pdfFormDataRibbonPage1.Visible = False
            ' 
            ' pdfFormDataBarPageGroup1
            ' 
            Me.pdfFormDataBarPageGroup1.ItemLinks.Add(Me.pdfExportFormDataBarItem1)
            Me.pdfFormDataBarPageGroup1.ItemLinks.Add(Me.pdfImportFormDataBarItem1)
            Me.pdfFormDataBarPageGroup1.Name = "pdfFormDataBarPageGroup1"
            ' 
            ' pdfBarController1
            ' 
            Me.pdfBarController1.BarItems.Add(Me.pdfFileOpenBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFileSaveAsBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFilePrintBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfFindTextBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfPreviousPageBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfNextPageBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetPageNumberBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoomOutBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoomInBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfExactZoomListBarSubItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom10CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom25CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom50CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom75CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom100CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom125CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom150CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom200CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom400CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfZoom500CheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetActualSizeZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetPageLevelZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetFitWidthZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfSetFitVisibleZoomModeCheckItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfTextHighlightBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfTextStrikethroughBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfTextUnderlineBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfExportFormDataBarItem1)
            Me.pdfBarController1.BarItems.Add(Me.pdfImportFormDataBarItem1)
            Me.pdfBarController1.Control = Me.pdfViewer1
            ' 
            ' pdfViewer1
            ' 
            Me.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pdfViewer1.Location = New System.Drawing.Point(0, 143)
            Me.pdfViewer1.Name = "pdfViewer1"
            Me.pdfViewer1.Size = New System.Drawing.Size(645, 458)
            Me.pdfViewer1.TabIndex = 3
            ' 
            ' accordionControl1
            ' 
            Me.accordionControl1.Appearance.Group.Pressed.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(224)))), (CInt((CByte(224)))))
            Me.accordionControl1.Appearance.Group.Pressed.Options.UseBackColor = True
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple
            Me.accordionControl1.Location = New System.Drawing.Point(645, 143)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False
            Me.accordionControl1.ShowGroupExpandButtons = False
            Me.accordionControl1.ShowItemExpandButtons = False
            Me.accordionControl1.Size = New System.Drawing.Size(338, 458)
            Me.accordionControl1.TabIndex = 4
            Me.accordionControl1.Text = "accordionControl1"
            ' 
            ' splitter1
            ' 
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(642, 143)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 458)
            Me.splitter1.TabIndex = 6
            Me.splitter1.TabStop = False
            ' 
            ' XtraForm1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(983, 601)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.pdfViewer1)
            Me.Controls.Add(Me.accordionControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "XtraForm1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "XtraForm1"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pdfBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.accordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private pdfFileOpenBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileOpenBarItem
        Private pdfFileSaveAsBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFileSaveAsBarItem
        Private pdfFilePrintBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFilePrintBarItem
        Private pdfFindTextBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfFindTextBarItem
        Private pdfPreviousPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfPreviousPageBarItem
        Private pdfNextPageBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfNextPageBarItem
        Private pdfSetPageNumberBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageNumberBarItem
        Private repositoryItemPageNumberEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit
        Private pdfZoomOutBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomOutBarItem
        Private pdfZoomInBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoomInBarItem
        Private pdfExactZoomListBarSubItem1 As DevExpress.XtraPdfViewer.Bars.PdfExactZoomListBarSubItem
        Private pdfZoom10CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom10CheckItem
        Private pdfZoom25CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom25CheckItem
        Private pdfZoom50CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom50CheckItem
        Private pdfZoom75CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom75CheckItem
        Private pdfZoom100CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom100CheckItem
        Private pdfZoom125CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom125CheckItem
        Private pdfZoom150CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom150CheckItem
        Private pdfZoom200CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom200CheckItem
        Private pdfZoom400CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom400CheckItem
        Private pdfZoom500CheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfZoom500CheckItem
        Private pdfSetActualSizeZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetActualSizeZoomModeCheckItem
        Private pdfSetPageLevelZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetPageLevelZoomModeCheckItem
        Private pdfSetFitWidthZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitWidthZoomModeCheckItem
        Private pdfSetFitVisibleZoomModeCheckItem1 As DevExpress.XtraPdfViewer.Bars.PdfSetFitVisibleZoomModeCheckItem
        Private pdfTextHighlightBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfTextHighlightBarItem
        Private pdfTextStrikethroughBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfTextStrikethroughBarItem
        Private pdfTextUnderlineBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfTextUnderlineBarItem
        Private pdfExportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfExportFormDataBarItem
        Private pdfImportFormDataBarItem1 As DevExpress.XtraPdfViewer.Bars.PdfImportFormDataBarItem
        Private pdfRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfRibbonPage
        Private pdfFileRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFileRibbonPageGroup
        Private pdfFindRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFindRibbonPageGroup
        Private pdfNavigationRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfNavigationRibbonPageGroup
        Private pdfZoomRibbonPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfZoomRibbonPageGroup
        Private pdfCommentRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfCommentRibbonPage
        Private pdfTextCommentPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfTextCommentPageGroup
        Private pdfFormDataRibbonPage1 As DevExpress.XtraPdfViewer.Bars.PdfFormDataRibbonPage
        Private pdfFormDataBarPageGroup1 As DevExpress.XtraPdfViewer.Bars.PdfFormDataBarPageGroup
        Private pdfBarController1 As DevExpress.XtraPdfViewer.Bars.PdfBarController
        Private pdfViewer1 As DevExpress.XtraPdfViewer.PdfViewer
        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
        Private splitter1 As System.Windows.Forms.Splitter
    End Class
End Namespace