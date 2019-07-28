Namespace Global.ProjetGestionDeStock.Views.ProductView
	Partial Public Class ProductView
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
			Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
			Me.windowsUIButtonPanelCloseButton = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
			Me.windowsUIButtonPanelMain = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
			Me.labelControl = New DevExpress.XtraEditors.LabelControl()
									Me.CategoireLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
			Me.CategoireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			 
			Me.SuspendLayout()
			' 
			' windowsUIButtonPanelCloseButton
			' 
			Me.windowsUIButtonPanelCloseButton.ButtonInterval = 0
			Me.windowsUIButtonPanelCloseButton.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.XtraBars.Docking2010.WindowsUIButton("", Nothing, "Backward;Size32x32;GrayScaled")})
			Me.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left
			Me.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray
			Me.windowsUIButtonPanelCloseButton.MaximumSize = New System.Drawing.Size(45, 0)
			Me.windowsUIButtonPanelCloseButton.MinimumSize = New System.Drawing.Size(45, 0)
			Me.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton"
			Me.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.windowsUIButtonPanelCloseButton.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
			Me.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1"
			' 
			' windowsUIButtonPanelMain
			' 
			Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(130)))), (CInt((CByte(130)))), (CInt((CByte(130)))))
			Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1
			Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(130)))), (CInt((CByte(130)))), (CInt((CByte(130)))))
			Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = True
			Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = True
			Me.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = True
			Me.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1
			Me.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = True
			Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(159)))), (CInt((CByte(159)))), (CInt((CByte(159)))))
			Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1
			Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(159)))), (CInt((CByte(159)))), (CInt((CByte(159)))))
			Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = True
			Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = True
			Me.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = True
			Me.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(63)))), (CInt((CByte(63)))), (CInt((CByte(63)))))
			Me.windowsUIButtonPanelMain.EnableImageTransparency = True
			Me.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White
			Me.windowsUIButtonPanelMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain"
			Me.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain"
			Me.windowsUIButtonPanelMain.MinimumSize = New System.Drawing.Size(60, 60)
			Me.windowsUIButtonPanelMain.MaximumSize = New System.Drawing.Size(0, 60)
			Me.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.windowsUIButtonPanelMain.UseButtonBackgroundImages = False
						Me.windowsUIButtonPanelMain.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", Nothing, "Save;Size32x32;GrayScaled"))
						Me.windowsUIButtonPanelMain.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", Nothing, "SaveAndClose;Size32x32;GrayScaled"))
						Me.windowsUIButtonPanelMain.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", Nothing, "SaveAndNew;Size32x32;GrayScaled"))
						Me.windowsUIButtonPanelMain.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", Nothing, "Reset;Size32x32;GrayScaled"))
						Me.windowsUIButtonPanelMain.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", Nothing, "Edit/Delete;Size32x32;GrayScaled"))
						' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' dataLayoutControl1
			' 
			Me.dataLayoutControl1.AllowCustomization = False
			Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataLayoutControl1.Root = Me.layoutControlGroup1
			Me.productViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productViewBindingSource.DataSource = GetType(Global.ProjetGestionDeStock.Product)
			Me.dataLayoutControl1.DataSource = productViewBindingSource
			'
			' Create GridControls
			'
			Dim parameters As New DevExpress.XtraDataLayout.RetrieveFieldsParameters()
			parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
          							'
			' CategoireLookUpEdit
			'
			Me.CategoireBindingSource.DataSource = GetType(Global.ProjetGestionDeStock.Categoire)
			Me.CategoireLookUpEdit.Properties.ValueMember = "CategorieId" 
			Me.CategoireLookUpEdit.Properties.DisplayMember = "CategorieName"
			Me.CategoireLookUpEdit.Properties.DataSource = Me.CategoireBindingSource
			Me.CategoireLookUpEdit.Name = "CategoireLookUpEdit"
			Me.CategoireLookUpEdit.DataBindings.Add("EditValue", productViewBindingSource, "CategorieId", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged)
			Dim CategoireLookUpEditRetrieveFieldParameters As New DevExpress.XtraDataLayout.RetrieveFieldParameters()
            CategoireLookUpEditRetrieveFieldParameters.FieldName = "CategorieId"
            CategoireLookUpEditRetrieveFieldParameters.ControlForField = Me.CategoireLookUpEdit
			parameters.CustomListParameters.Add(CategoireLookUpEditRetrieveFieldParameters)
			Dim CategoireLookUpEditRetrieveFieldParameters_NotGenerate As New DevExpress.XtraDataLayout.RetrieveFieldParameters()
		    CategoireLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Categoire"
		    CategoireLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = False
			parameters.CustomListParameters.Add(CategoireLookUpEditRetrieveFieldParameters_NotGenerate)
			 
			'
			'call RetrieveFields
			'
			Me.dataLayoutControl1.RetrieveFields(parameters)
			' 
			' mvvmContext
			' 
			Me.mvvmContext.ContainerControl = Me
			Me.mvvmContext.ViewModelType = GetType(Global.ProjetGestionDeStock.ViewModels.ProductViewModel)
			' 
			' labelControl
			' 
			Me.labelControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.labelControl.Name = "labelControl"
			Me.labelControl.Text = "Product - Element View"
			Me.labelControl.AllowHtmlString = True
			Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(140)))), (CInt((CByte(140)))), (CInt((CByte(140)))))
			Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
			'
			'ProductView
			'
			Me.Appearance.BackColor = System.Drawing.Color.White
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
			Me.Controls.Add(Me.dataLayoutControl1)
			Me.Controls.Add(Me.labelControl)
			Me.Controls.Add(Me.windowsUIButtonPanelCloseButton)
			Me.Controls.Add(Me.windowsUIButtonPanelMain)
			Me.Size = New System.Drawing.Size(1024, 768)
			Me.Name = "ProductView"
						Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private windowsUIButtonPanelCloseButton As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private windowsUIButtonPanelMain As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private labelControl As DevExpress.XtraEditors.LabelControl
		Private productViewBindingSource As System.Windows.Forms.BindingSource
						Private CategoireLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit
		Private CategoireBindingSource As System.Windows.Forms.BindingSource
		 
	End Class
End Namespace

