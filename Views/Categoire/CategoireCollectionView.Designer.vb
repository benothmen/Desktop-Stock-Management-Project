﻿Namespace Global.ProjetGestionDeStock.Views.CategoireCollectionView
	Partial Public Class CategoireCollectionView
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
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.categoireCollectionViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.labelControl = New DevExpress.XtraEditors.LabelControl()
            Me.windowsUIButtonPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.itemLabel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemGrid = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoireCollectionViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.itemLabel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.DataSource = Me.categoireCollectionViewBindingSource
            Me.gridControl.Location = New System.Drawing.Point(40, 34)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(944, 674)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
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
            '
            'GridColumn1
            '
            Me.GridColumn1.FieldName = "CategorieId"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 0
            '
            'GridColumn2
            '
            Me.GridColumn2.FieldName = "CategorieName"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 1
            '
            'GridColumn3
            '
            Me.GridColumn3.FieldName = "Designation"
            Me.GridColumn3.Name = "GridColumn3"
            Me.GridColumn3.Visible = True
            Me.GridColumn3.VisibleIndex = 2
            '
            'GridColumn4
            '
            Me.GridColumn4.FieldName = "Product"
            Me.GridColumn4.Name = "GridColumn4"
            '
            'categoireCollectionViewBindingSource
            '
            Me.categoireCollectionViewBindingSource.DataSource = GetType(ProjetGestionDeStock.Categoire)
            '
            'mvvmContext
            '
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(ProjetGestionDeStock.ViewModels.CategoireCollectionViewModel)
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
            Me.labelControl.Location = New System.Drawing.Point(40, 0)
            Me.labelControl.Name = "labelControl"
            Me.labelControl.Padding = New System.Windows.Forms.Padding(0, 3, 13, 6)
            Me.labelControl.Size = New System.Drawing.Size(944, 34)
            Me.labelControl.StyleController = Me.layoutControl
            Me.labelControl.TabIndex = 4
            Me.labelControl.Text = "Categoire"
            '
            'windowsUIButtonPanel
            '
            Me.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1
            Me.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = True
            Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = True
            Me.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = True
            Me.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1
            Me.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = True
            Me.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
            Me.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1
            Me.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
            Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = True
            Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = True
            Me.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = True
            Me.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
            WindowsUIButtonImageOptions1.ImageUri.Uri = "New;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions2.ImageUri.Uri = "Edit;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions3.ImageUri.Uri = "Edit/Delete;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions4.ImageUri.Uri = "Refresh;Size32x32;GrayScaled"
            WindowsUIButtonImageOptions5.ImageUri.Uri = "Preview;Size32x32;GrayScaled"
            Me.windowsUIButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("New", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Edit", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", True, WindowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Refresh", True, WindowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUISeparator(), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", True, WindowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.windowsUIButtonPanel.EnableImageTransparency = True
            Me.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White
            Me.windowsUIButtonPanel.Location = New System.Drawing.Point(0, 708)
            Me.windowsUIButtonPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.windowsUIButtonPanel.MaximumSize = New System.Drawing.Size(0, 60)
            Me.windowsUIButtonPanel.MinimumSize = New System.Drawing.Size(60, 60)
            Me.windowsUIButtonPanel.Name = "windowsUIButtonPanel"
            Me.windowsUIButtonPanel.Size = New System.Drawing.Size(1024, 60)
            Me.windowsUIButtonPanel.TabIndex = 1
            Me.windowsUIButtonPanel.Text = "windowsUIButtonPanel"
            Me.windowsUIButtonPanel.UseButtonBackgroundImages = False
            '
            'layoutControl
            '
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.labelControl)
            Me.layoutControl.Controls.Add(Me.gridControl)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroup
            Me.layoutControl.Size = New System.Drawing.Size(1024, 708)
            Me.layoutControl.TabIndex = 0
            '
            'layoutControlGroup
            '
            Me.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup.GroupBordersVisible = False
            Me.layoutControlGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.itemLabel, Me.itemGrid})
            Me.layoutControlGroup.Name = "layoutControlGroup"
            Me.layoutControlGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0)
            Me.layoutControlGroup.Size = New System.Drawing.Size(1024, 708)
            Me.layoutControlGroup.TextVisible = False
            '
            'itemLabel
            '
            Me.itemLabel.Control = Me.labelControl
            Me.itemLabel.Location = New System.Drawing.Point(0, 0)
            Me.itemLabel.Name = "itemLabel"
            Me.itemLabel.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.itemLabel.Size = New System.Drawing.Size(944, 34)
            Me.itemLabel.TextSize = New System.Drawing.Size(0, 0)
            Me.itemLabel.TextVisible = False
            '
            'itemGrid
            '
            Me.itemGrid.Control = Me.gridControl
            Me.itemGrid.Location = New System.Drawing.Point(0, 34)
            Me.itemGrid.Name = "itemGrid"
            Me.itemGrid.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.itemGrid.Size = New System.Drawing.Size(944, 674)
            Me.itemGrid.TextSize = New System.Drawing.Size(0, 0)
            Me.itemGrid.TextVisible = False
            '
            'CategoireCollectionView
            '
            Me.Appearance.BackColor = System.Drawing.Color.White
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Controls.Add(Me.windowsUIButtonPanel)
            Me.Name = "CategoireCollectionView"
            Me.Size = New System.Drawing.Size(1024, 768)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoireCollectionViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.layoutControlGroup, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.itemLabel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.itemGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private gridControl As DevExpress.XtraGrid.GridControl
		Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private categoireCollectionViewBindingSource As System.Windows.Forms.BindingSource
		Private labelControl As DevExpress.XtraEditors.LabelControl
		Private windowsUIButtonPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
		Private layoutControl As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup As DevExpress.XtraLayout.LayoutControlGroup
		Private itemLabel As DevExpress.XtraLayout.LayoutControlItem
		Private itemGrid As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
