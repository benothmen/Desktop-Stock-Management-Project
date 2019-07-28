Namespace Global.ProjetGestionDeStock.Views.CategoireView
	Partial Public Class CategoireView
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
		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim WindowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim WindowsUIButtonImageOptions4 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim WindowsUIButtonImageOptions5 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim WindowsUIButtonImageOptions6 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.categoireViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ProductXtraUserControl = New DevExpress.XtraEditors.XtraUserControl()
            Me.ProductGridControl = New DevExpress.XtraGrid.GridControl()
            Me.ProductGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCreationDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModificationDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProviderId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProviderName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategorieId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoire = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.CategorieIdTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.ItemForCategorieId = New DevExpress.XtraLayout.LayoutControlItem()
            Me.CategorieNameTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.ItemForCategorieName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.DesignationTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.ItemForDesignation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForProduct = New DevExpress.XtraLayout.LayoutControlItem()
            Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.windowsUIButtonPanelCloseButton = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.windowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.labelControl = New DevExpress.XtraEditors.LabelControl()
            Me.ProductBarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bbiProductNew = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiProductEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiProductDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiProductRefresh = New DevExpress.XtraBars.BarButtonItem()
            Me.ProductBar = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.ProductPopUpMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoireViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ProductXtraUserControl.SuspendLayout()
            CType(Me.ProductGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CategorieIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCategorieId, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CategorieNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCategorieName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForDesignation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForProduct, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductPopUpMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dataLayoutControl1
            '
            Me.dataLayoutControl1.AllowCustomization = False
            Me.dataLayoutControl1.Controls.Add(Me.CategorieIdTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.CategorieNameTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.DesignationTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.ProductXtraUserControl)
            Me.dataLayoutControl1.DataSource = Me.categoireViewBindingSource
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(45, 30)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(979, 678)
            Me.dataLayoutControl1.TabIndex = 0
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(979, 678)
            Me.layoutControlGroup1.TextVisible = False
            '
            'categoireViewBindingSource
            '
            Me.categoireViewBindingSource.DataSource = GetType(ProjetGestionDeStock.Categoire)
            '
            'ProductXtraUserControl
            '
            Me.ProductXtraUserControl.Controls.Add(Me.ProductGridControl)
            Me.ProductXtraUserControl.Controls.Add(Me.barDockControlLeft)
            Me.ProductXtraUserControl.Controls.Add(Me.barDockControlRight)
            Me.ProductXtraUserControl.Controls.Add(Me.barDockControlBottom)
            Me.ProductXtraUserControl.Controls.Add(Me.barDockControlTop)
            Me.ProductXtraUserControl.Location = New System.Drawing.Point(24, 123)
            Me.ProductXtraUserControl.MinimumSize = New System.Drawing.Size(100, 100)
            Me.ProductXtraUserControl.Name = "ProductXtraUserControl"
            Me.ProductXtraUserControl.Size = New System.Drawing.Size(931, 531)
            Me.ProductXtraUserControl.TabIndex = 7
            '
            'ProductGridControl
            '
            Me.ProductGridControl.DataSource = Me.ProductBindingSource
            Me.ProductGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProductGridControl.Location = New System.Drawing.Point(0, 28)
            Me.ProductGridControl.MainView = Me.ProductGridView
            Me.ProductGridControl.Name = "ProductGridControl"
            Me.ProductGridControl.Size = New System.Drawing.Size(931, 503)
            Me.ProductGridControl.TabIndex = 0
            Me.ProductGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ProductGridView})
            '
            'ProductGridView
            '
            Me.ProductGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductId, Me.colProductName, Me.colAmount, Me.colCreationDate, Me.colModificationDate, Me.colPrice, Me.colDescription, Me.colProviderId, Me.colProviderName, Me.colCategorieId, Me.colCategoire})
            Me.ProductGridView.GridControl = Me.ProductGridControl
            Me.ProductGridView.Name = "ProductGridView"
            Me.ProductGridView.OptionsBehavior.Editable = False
            Me.ProductGridView.OptionsBehavior.ReadOnly = True
            '
            'colProductId
            '
            Me.colProductId.FieldName = "ProductId"
            Me.colProductId.Name = "colProductId"
            Me.colProductId.Visible = True
            Me.colProductId.VisibleIndex = 0
            '
            'colProductName
            '
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 1
            '
            'colAmount
            '
            Me.colAmount.FieldName = "Amount"
            Me.colAmount.Name = "colAmount"
            Me.colAmount.Visible = True
            Me.colAmount.VisibleIndex = 2
            '
            'colCreationDate
            '
            Me.colCreationDate.FieldName = "CreationDate"
            Me.colCreationDate.Name = "colCreationDate"
            Me.colCreationDate.Visible = True
            Me.colCreationDate.VisibleIndex = 3
            '
            'colModificationDate
            '
            Me.colModificationDate.FieldName = "ModificationDate"
            Me.colModificationDate.Name = "colModificationDate"
            Me.colModificationDate.Visible = True
            Me.colModificationDate.VisibleIndex = 4
            '
            'colPrice
            '
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 5
            '
            'colDescription
            '
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 6
            '
            'colProviderId
            '
            Me.colProviderId.FieldName = "ProviderId"
            Me.colProviderId.Name = "colProviderId"
            Me.colProviderId.Visible = True
            Me.colProviderId.VisibleIndex = 7
            '
            'colProviderName
            '
            Me.colProviderName.FieldName = "ProviderName"
            Me.colProviderName.Name = "colProviderName"
            Me.colProviderName.Visible = True
            Me.colProviderName.VisibleIndex = 8
            '
            'colCategorieId
            '
            Me.colCategorieId.FieldName = "CategorieId"
            Me.colCategorieId.Name = "colCategorieId"
            Me.colCategorieId.Visible = True
            Me.colCategorieId.VisibleIndex = 9
            '
            'colCategoire
            '
            Me.colCategoire.FieldName = "Categoire"
            Me.colCategoire.Name = "colCategoire"
            '
            'ProductBindingSource
            '
            Me.ProductBindingSource.DataSource = GetType(ProjetGestionDeStock.Product)
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.AllowDrawBackground = False
            Me.LayoutControlGroup2.GroupBordersVisible = False
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCategorieId, Me.ItemForCategorieName, Me.ItemForDesignation, Me.TabbedControlGroup1})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(959, 658)
            '
            'CategorieIdTextEdit
            '
            Me.CategorieIdTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoireViewBindingSource, "CategorieId", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CategorieIdTextEdit.Location = New System.Drawing.Point(92, 12)
            Me.CategorieIdTextEdit.Name = "CategorieIdTextEdit"
            Me.CategorieIdTextEdit.Properties.Appearance.Options.UseTextOptions = True
            Me.CategorieIdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.CategorieIdTextEdit.Properties.Mask.EditMask = "N0"
            Me.CategorieIdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.CategorieIdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = True
            Me.CategorieIdTextEdit.Size = New System.Drawing.Size(875, 20)
            Me.CategorieIdTextEdit.StyleController = Me.dataLayoutControl1
            Me.CategorieIdTextEdit.TabIndex = 4
            '
            'ItemForCategorieId
            '
            Me.ItemForCategorieId.Control = Me.CategorieIdTextEdit
            Me.ItemForCategorieId.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCategorieId.Name = "ItemForCategorieId"
            Me.ItemForCategorieId.Size = New System.Drawing.Size(959, 24)
            Me.ItemForCategorieId.Text = "Categorie Id"
            Me.ItemForCategorieId.TextSize = New System.Drawing.Size(77, 13)
            '
            'CategorieNameTextEdit
            '
            Me.CategorieNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoireViewBindingSource, "CategorieName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.CategorieNameTextEdit.Location = New System.Drawing.Point(92, 36)
            Me.CategorieNameTextEdit.Name = "CategorieNameTextEdit"
            Me.CategorieNameTextEdit.Size = New System.Drawing.Size(875, 20)
            Me.CategorieNameTextEdit.StyleController = Me.dataLayoutControl1
            Me.CategorieNameTextEdit.TabIndex = 5
            '
            'ItemForCategorieName
            '
            Me.ItemForCategorieName.Control = Me.CategorieNameTextEdit
            Me.ItemForCategorieName.Location = New System.Drawing.Point(0, 24)
            Me.ItemForCategorieName.Name = "ItemForCategorieName"
            Me.ItemForCategorieName.Size = New System.Drawing.Size(959, 24)
            Me.ItemForCategorieName.Text = "Categorie Name"
            Me.ItemForCategorieName.TextSize = New System.Drawing.Size(77, 13)
            '
            'DesignationTextEdit
            '
            Me.DesignationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.categoireViewBindingSource, "Designation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.DesignationTextEdit.Location = New System.Drawing.Point(92, 60)
            Me.DesignationTextEdit.Name = "DesignationTextEdit"
            Me.DesignationTextEdit.Size = New System.Drawing.Size(875, 20)
            Me.DesignationTextEdit.StyleController = Me.dataLayoutControl1
            Me.DesignationTextEdit.TabIndex = 6
            '
            'ItemForDesignation
            '
            Me.ItemForDesignation.Control = Me.DesignationTextEdit
            Me.ItemForDesignation.Location = New System.Drawing.Point(0, 48)
            Me.ItemForDesignation.Name = "ItemForDesignation"
            Me.ItemForDesignation.Size = New System.Drawing.Size(959, 24)
            Me.ItemForDesignation.Text = "Designation"
            Me.ItemForDesignation.TextSize = New System.Drawing.Size(77, 13)
            '
            'ItemForProduct
            '
            Me.ItemForProduct.Control = Me.ProductXtraUserControl
            Me.ItemForProduct.Location = New System.Drawing.Point(0, 0)
            Me.ItemForProduct.Name = "ItemForProduct"
            Me.ItemForProduct.Size = New System.Drawing.Size(935, 535)
            Me.ItemForProduct.StartNewLine = True
            Me.ItemForProduct.Text = "Product"
            Me.ItemForProduct.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForProduct.TextVisible = False
            '
            'TabbedControlGroup1
            '
            Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 72)
            Me.TabbedControlGroup1.Name = "autoGroupForTabs"
            Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
            Me.TabbedControlGroup1.Size = New System.Drawing.Size(959, 586)
            Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3})
            Me.TabbedControlGroup1.Text = "Tabs"
            '
            'LayoutControlGroup3
            '
            Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForProduct})
            Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup3.Name = "autoGroupForProduct"
            Me.LayoutControlGroup3.Size = New System.Drawing.Size(935, 535)
            Me.LayoutControlGroup3.Text = "Product"
            '
            'mvvmContext
            '
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(ProjetGestionDeStock.ViewModels.CategoireViewModel)
            '
            'windowsUIButtonPanelCloseButton
            '
            Me.windowsUIButtonPanelCloseButton.ButtonInterval = 0
            WindowsUIButtonImageOptions1.ImageUri.Uri = "Backward;Size32x32;GrayScaled"
            Me.windowsUIButtonPanelCloseButton.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
            Me.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left
            Me.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray
            Me.windowsUIButtonPanelCloseButton.Location = New System.Drawing.Point(0, 0)
            Me.windowsUIButtonPanelCloseButton.MaximumSize = New System.Drawing.Size(45, 0)
            Me.windowsUIButtonPanelCloseButton.MinimumSize = New System.Drawing.Size(45, 0)
            Me.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton"
            Me.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.windowsUIButtonPanelCloseButton.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
            Me.windowsUIButtonPanelCloseButton.Size = New System.Drawing.Size(45, 708)
            Me.windowsUIButtonPanelCloseButton.TabIndex = 2
            Me.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1"
            '
            'windowsUIButtonPanelMain
            '
            Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1
            Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = True
            Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = True
            Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = True
            Me.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1
            Me.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = True
            Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
            Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1
            Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
            Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = True
            Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = True
            Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = True
            Me.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
            WindowsUIButtonImageOptions2.ImageUri.Uri = "Save;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions3.ImageUri.Uri = "SaveAndClose;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions4.ImageUri.Uri = "SaveAndNew;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions5.ImageUri.Uri = "Reset;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions6.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
            Me.windowsUIButtonPanelMain.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.windowsUIButtonPanelMain.EnableImageTransparency = True
            Me.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White
            Me.windowsUIButtonPanelMain.Location = New System.Drawing.Point(0, 708)
            Me.windowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.windowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 60)
            Me.windowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(60, 60)
            Me.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain"
            Me.windowsUIButtonPanelMain.Size = New System.Drawing.Size(1024, 60)
            Me.windowsUIButtonPanelMain.TabIndex = 3
            Me.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
            Me.windowsUIButtonPanelMain.UseButtonBackgroundImages = False
            '
            'labelControl
            '
            Me.labelControl.AllowHtmlString = True
            Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.labelControl.Appearance.Options.UseFont = True
            Me.labelControl.Appearance.Options.UseForeColor = True
            Me.labelControl.Appearance.Options.UseTextOptions = True
            Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl.Location = New System.Drawing.Point(45, 0)
            Me.labelControl.Name = "labelControl"
            Me.labelControl.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
            Me.labelControl.Size = New System.Drawing.Size(979, 30)
            Me.labelControl.TabIndex = 1
            Me.labelControl.Text = "Categoire - Element View"
            '
            'ProductBarManager
            '
            Me.ProductBarManager.AllowCustomization = False
            Me.ProductBarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.ProductBar})
            Me.ProductBarManager.DockControls.Add(Me.barDockControlTop)
            Me.ProductBarManager.DockControls.Add(Me.barDockControlBottom)
            Me.ProductBarManager.DockControls.Add(Me.barDockControlLeft)
            Me.ProductBarManager.DockControls.Add(Me.barDockControlRight)
            Me.ProductBarManager.Form = Me.ProductXtraUserControl
            Me.ProductBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bbiProductNew, Me.bbiProductEdit, Me.bbiProductDelete, Me.bbiProductRefresh})
            Me.ProductBarManager.MainMenu = Me.ProductBar
            Me.ProductBarManager.MaxItemId = 4
            '
            'bbiProductNew
            '
            Me.bbiProductNew.Caption = "New"
            Me.bbiProductNew.Id = 0
            Me.bbiProductNew.ImageOptions.ImageUri.Uri = "New"
            Me.bbiProductNew.Name = "bbiProductNew"
            Me.bbiProductNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bbiProductEdit
            '
            Me.bbiProductEdit.Caption = "Edit"
            Me.bbiProductEdit.Id = 1
            Me.bbiProductEdit.ImageOptions.ImageUri.Uri = "Edit"
            Me.bbiProductEdit.Name = "bbiProductEdit"
            Me.bbiProductEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bbiProductDelete
            '
            Me.bbiProductDelete.Caption = "Delete"
            Me.bbiProductDelete.Id = 2
            Me.bbiProductDelete.ImageOptions.ImageUri.Uri = "Delete"
            Me.bbiProductDelete.Name = "bbiProductDelete"
            Me.bbiProductDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'bbiProductRefresh
            '
            Me.bbiProductRefresh.Caption = "Refresh"
            Me.bbiProductRefresh.Id = 3
            Me.bbiProductRefresh.ImageOptions.ImageUri.Uri = "Refresh"
            Me.bbiProductRefresh.Name = "bbiProductRefresh"
            Me.bbiProductRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            '
            'ProductBar
            '
            Me.ProductBar.BarName = "Product"
            Me.ProductBar.DockCol = 0
            Me.ProductBar.DockRow = 0
            Me.ProductBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.ProductBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductRefresh)})
            Me.ProductBar.OptionsBar.AllowQuickCustomization = False
            Me.ProductBar.OptionsBar.DrawDragBorder = False
            Me.ProductBar.Text = "Product"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.ProductBarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(931, 28)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 531)
            Me.barDockControlBottom.Manager = Me.ProductBarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(931, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
            Me.barDockControlLeft.Manager = Me.ProductBarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 503)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(931, 28)
            Me.barDockControlRight.Manager = Me.ProductBarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 503)
            '
            'ProductPopUpMenu
            '
            Me.ProductPopUpMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductNew), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.bbiProductRefresh)})
            Me.ProductPopUpMenu.Manager = Me.ProductBarManager
            Me.ProductPopUpMenu.Name = "ProductPopUpMenu"
            '
            'CategoireView
            '
            Me.Appearance.BackColor = System.Drawing.Color.White
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Controls.Add(Me.labelControl)
            Me.Controls.Add(Me.windowsUIButtonPanelCloseButton)
            Me.Controls.Add(Me.windowsUIButtonPanelMain)
            Me.Name = "CategoireView"
            Me.Size = New System.Drawing.Size(1024, 768)
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoireViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ProductXtraUserControl.ResumeLayout(False)
            Me.ProductXtraUserControl.PerformLayout()
            CType(Me.ProductGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CategorieIdTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCategorieId, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CategorieNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCategorieName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DesignationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForDesignation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForProduct, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductBarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductPopUpMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private windowsUIButtonPanelCloseButton As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private windowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private labelControl As DevExpress.XtraEditors.LabelControl
		Private categoireViewBindingSource As System.Windows.Forms.BindingSource
				Private ProductGridControl As DevExpress.XtraGrid.GridControl
		Private ProductGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private ProductBarManager As DevExpress.XtraBars.BarManager
		Private ProductBar As DevExpress.XtraBars.Bar
		Private ProductXtraUserControl As DevExpress.XtraEditors.XtraUserControl
		Private ProductPopUpMenu As DevExpress.XtraBars.PopupMenu
				Private bbiProductNew As DevExpress.XtraBars.BarButtonItem
				Private bbiProductEdit As DevExpress.XtraBars.BarButtonItem
				Private bbiProductDelete As DevExpress.XtraBars.BarButtonItem
				Private bbiProductRefresh As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents CategorieIdTextEdit As DevExpress.XtraEditors.TextEdit
        Friend WithEvents CategorieNameTextEdit As DevExpress.XtraEditors.TextEdit
        Friend WithEvents DesignationTextEdit As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ProductBindingSource As BindingSource
        Friend WithEvents colProductId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProductName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCreationDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModificationDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProviderId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProviderName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategorieId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategoire As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ItemForCategorieId As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForCategorieName As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ItemForDesignation As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
        Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ItemForProduct As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace

