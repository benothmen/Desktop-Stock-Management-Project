Namespace Global.ProjetGestionDeStock.Views.ProductCollectionView
	Partial Public Class ProductCollectionView
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
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
			Me.labelControl = New DevExpress.XtraEditors.LabelControl()
			Me.windowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
			Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.itemLabel = New DevExpress.XtraLayout.LayoutControlItem()
			Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
			CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl.SuspendLayout()
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' windowsUIButtonPanel
			' 
			Me.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(130)))), (CInt((CByte(130)))), (CInt((CByte(130)))))
			Me.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1
			Me.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(130)))), (CInt((CByte(130)))), (CInt((CByte(130)))))
			Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = True
			Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = True
			Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = True
			Me.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1
			Me.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = True
			Me.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(159)))), (CInt((CByte(159)))), (CInt((CByte(159)))))
			Me.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1
			Me.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(159)))), (CInt((CByte(159)))), (CInt((CByte(159)))))
			Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = True
			Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = True
			Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = True
			Me.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(63)))), (CInt((CByte(63)))), (CInt((CByte(63)))))
			Me.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.windowsUIButtonPanel.EnableImageTransparency = True
			Me.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White
			Me.windowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
			Me.windowsUIButtonPanel.Name = "windowsUIButtonPanel"
			Me.windowsUIButtonPanel.Text = "windowsUIButtonPanel"
			Me.windowsUIButtonPanel.UseButtonBackgroundImages = False
			Me.windowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
			Me.windowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
																Me.windowsUIButtonPanel.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("New", Nothing, "New;Size32x32;GrayScaled"))
						
								Me.windowsUIButtonPanel.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", Nothing, "Edit;Size32x32;GrayScaled"))
						
								Me.windowsUIButtonPanel.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", Nothing, "Edit/Delete;Size32x32;GrayScaled"))
						
										Me.windowsUIButtonPanel.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", Nothing, "Refresh;Size32x32;GrayScaled"))
						
	
			Me.windowsUIButtonPanel.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUISeparator())
			Me.windowsUIButtonPanel.Buttons.Add(New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", Nothing, "Preview;Size32x32;GrayScaled"))
			'
			' labelControl
            ' 
            Me.labelControl.AllowHtmlString = True
			Me.labelControl.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(140)))), (CInt((CByte(140)))), (CInt((CByte(140)))))
			Me.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.labelControl.Name = "labelControl"
			Me.labelControl.Padding = New System.Windows.Forms.Padding(0, 3, 13, 6)
			Me.labelControl.Text = "Product"
			' 
			' gridControl
			' 
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.Location = New System.Drawing.Point(5, 116)
			Me.gridControl.MainView = Me.gridView
			Me.gridControl.Name = "gridControl"
			Me.gridControl.Size = New System.Drawing.Size(779, 311)
			Me.gridControl.TabIndex = 2
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
			' 
			' gridView
			' 
			Me.gridView.GridControl = Me.gridControl
			Me.gridView.Name = "gridView"
			Me.gridView.OptionsBehavior.Editable = False
			Me.gridView.OptionsCustomization.AllowColumnMoving = False
			Me.gridView.OptionsCustomization.AllowGroup = False
			Me.gridView.OptionsCustomization.AllowQuickHideColumns = False
			Me.gridView.OptionsMenu.EnableColumnMenu = False
			Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
			Me.gridView.OptionsView.ShowGroupPanel = False
			Me.gridView.OptionsView.ShowIndicator = False
			Me.productCollectionViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.productCollectionViewBindingSource.DataSource = GetType(Global.ProjetGestionDeStock.Product)
			Me.gridControl.DataSource = productCollectionViewBindingSource
			
			Dim parameters As New DevExpress.XtraGrid.Extensions.PopulateColumnsParameters()
						'
			'Categoire
			'
			Dim  CategoirePopulateColumnParameters As New DevExpress.XtraGrid.Extensions.PopulateColumnParameters()
            CategoirePopulateColumnParameters.FieldName = "Categoire"
            CategoirePopulateColumnParameters.Path = "Categoire.CategorieName"
			parameters.CustomColumnParameters.Add(CategoirePopulateColumnParameters)
						Dim CategoirePopulateColumnParameters_NotGenerate As New DevExpress.XtraGrid.Extensions.PopulateColumnParameters()
            CategoirePopulateColumnParameters_NotGenerate.FieldName = "CategorieId"
		    CategoirePopulateColumnParameters_NotGenerate.ColumnVisible = False
			parameters.CustomColumnParameters.Add(CategoirePopulateColumnParameters_NotGenerate)
										
			Dim CategoirePopulateColumnParameters_NotVisible As New DevExpress.XtraGrid.Extensions.PopulateColumnParameters()
            CategoirePopulateColumnParameters_NotVisible.FieldName = "Categoire"
		    CategoirePopulateColumnParameters_NotVisible.ColumnVisible = False
			parameters.CustomColumnParameters.Add(CategoirePopulateColumnParameters_NotVisible)
			 
			Me.gridView.PopulateColumns(GetType(Global.ProjetGestionDeStock.Product), parameters)
			' 
			' mvvmContext
			' 
			Me.mvvmContext.ContainerControl = Me
			Me.mvvmContext.ViewModelType = GetType(Global.ProjetGestionDeStock.ViewModels.ProductCollectionViewModel)
			' 
			' layoutControl
			' 
			layoutControl.Controls.AddRange(New System.Windows.Forms.Control() { Me.labelControl, Me.gridControl })
			Me.layoutControl.AllowCustomization = False
			Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl.Root = Me.layoutControlGroup
			'
			' itemLabel
			'
			Me.itemLabel.Control = Me.labelControl
			Me.itemLabel.TextVisible = False
			Me.itemLabel.Name = "itemLabel"
			Me.itemLabel.Padding = New DevExpress.XtraLayout.Utils.Padding(0)
			'
			' itemGrid
			'
			Me.itemGrid.Control = Me.gridControl
			Me.itemGrid.TextVisible = False
			Me.itemGrid.Name = "itemGrid"
			Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0)
			'
			' layoutControlGroup
			'
			Me.layoutControlGroup.GroupBordersVisible = False
			Me.layoutControlGroup.Add(itemLabel)
			Me.layoutControlGroup.Add(itemGrid)
			Me.layoutControlGroup.Name = "layoutControlGroup"
			Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup.GroupBordersVisible = False
			Me.layoutControlGroup.TextVisible = False
			Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
			'
			'ProductCollectionView
			'
			Me.Appearance.BackColor = System.Drawing.Color.White
			Me.Appearance.Options.UseBackColor = True
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl)
			Me.Controls.Add(Me.windowsUIButtonPanel)
			Me.Size = New System.Drawing.Size(1024, 768)
			Me.Name = "ProductCollectionView"
			CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl.ResumeLayout(False)
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		#End Region

		Private gridControl As DevExpress.XtraGrid.GridControl
		Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private productCollectionViewBindingSource As System.Windows.Forms.BindingSource
		Private labelControl As DevExpress.XtraEditors.LabelControl
		Private windowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private layoutControl As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
		Private itemLabel As DevExpress.XtraLayout.LayoutControlItem
		Private itemGrid As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
