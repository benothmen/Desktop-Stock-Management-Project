Namespace Global.ProjetGestionDeStock.Views.BD_STOCKEntities1View
	Partial Public Class BD_STOCKEntities1View
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
            Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
            Me.tileBar = New DevExpress.XtraBars.Navigation.TileBar()
            Me.tileBarGroupTables = New DevExpress.XtraBars.Navigation.TileBarGroup()
            Me.tileBarItemCategoireCollectionView = New DevExpress.XtraBars.Navigation.TileBarItem()
            Me.tileBarItemProductCollectionView = New DevExpress.XtraBars.Navigation.TileBarItem()
            Me.tileBarGroupViews = New DevExpress.XtraBars.Navigation.TileBarGroup()
            Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'tileBar
            '
            Me.tileBar.AllowGlyphSkinning = True
            Me.tileBar.AllowSelectedItem = True
            Me.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
            Me.tileBar.AppearanceGroupText.Options.UseForeColor = True
            Me.tileBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.tileBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.tileBar.DropDownButtonWidth = 30
            Me.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            Me.tileBar.Groups.Add(Me.tileBarGroupTables)
            Me.tileBar.Groups.Add(Me.tileBarGroupViews)
            Me.tileBar.IndentBetweenGroups = 10
            Me.tileBar.IndentBetweenItems = 10
            Me.tileBar.ItemPadding = New System.Windows.Forms.Padding(8, 6, 12, 6)
            Me.tileBar.Location = New System.Drawing.Point(0, 0)
            Me.tileBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.tileBar.MaximumSize = New System.Drawing.Size(0, 110)
            Me.tileBar.MinimumSize = New System.Drawing.Size(100, 110)
            Me.tileBar.Name = "tileBar"
            Me.tileBar.Padding = New System.Windows.Forms.Padding(29, 11, 29, 11)
            Me.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
            Me.tileBar.SelectionBorderWidth = 2
            Me.tileBar.Size = New System.Drawing.Size(1024, 110)
            Me.tileBar.TabIndex = 1
            Me.tileBar.Text = "tileBar"
            Me.tileBar.WideTileWidth = 150
            '
            'tileBarGroupTables
            '
            Me.tileBarGroupTables.Items.Add(Me.tileBarItemCategoireCollectionView)
            Me.tileBarGroupTables.Items.Add(Me.tileBarItemProductCollectionView)
            Me.tileBarGroupTables.Name = "tileBarGroupTables"
            Me.tileBarGroupTables.Text = "TABLES"
            '
            'tileBarItemCategoireCollectionView
            '
            Me.tileBarItemCategoireCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(156, Byte), Integer))
            Me.tileBarItemCategoireCollectionView.AppearanceItem.Normal.Options.UseBackColor = True
            Me.tileBarItemCategoireCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            TileItemElement3.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled"
            TileItemElement3.Text = "Categoire"
            Me.tileBarItemCategoireCollectionView.Elements.Add(TileItemElement3)
            Me.tileBarItemCategoireCollectionView.Name = "tileBarItemCategoireCollectionView"
            '
            'tileBarItemProductCollectionView
            '
            Me.tileBarItemProductCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.tileBarItemProductCollectionView.AppearanceItem.Normal.Options.UseBackColor = True
            Me.tileBarItemProductCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty
            TileItemElement4.ImageOptions.ImageUri.Uri = "Cube;Size32x32;GrayScaled"
            TileItemElement4.Text = "Product"
            Me.tileBarItemProductCollectionView.Elements.Add(TileItemElement4)
            Me.tileBarItemProductCollectionView.Name = "tileBarItemProductCollectionView"
            '
            'tileBarGroupViews
            '
            Me.tileBarGroupViews.Name = "tileBarGroupViews"
            Me.tileBarGroupViews.Text = "VIEWS"
            '
            'navigationFrame
            '
            Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationFrame.Location = New System.Drawing.Point(0, 110)
            Me.navigationFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.navigationFrame.Name = "navigationFrame"
            Me.navigationFrame.SelectedPage = Nothing
            Me.navigationFrame.Size = New System.Drawing.Size(1024, 658)
            Me.navigationFrame.TabIndex = 0
            Me.navigationFrame.Text = "navigationFrame"
            '
            'mvvmContext
            '
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(ProjetGestionDeStock.ViewModels.BD_STOCKEntities1ViewModel)
            '
            'BD_STOCKEntities1View
            '
            Me.Appearance.BackColor = System.Drawing.Color.White
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.navigationFrame)
            Me.Controls.Add(Me.tileBar)
            Me.Name = "BD_STOCKEntities1View"
            Me.Size = New System.Drawing.Size(1024, 768)
            CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tileBar As DevExpress.XtraBars.Navigation.TileBar
		Private navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
		Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext
		Private tileBarGroupTables As DevExpress.XtraBars.Navigation.TileBarGroup
		Private tileBarGroupViews As DevExpress.XtraBars.Navigation.TileBarGroup
				Private tileBarItemCategoireCollectionView As DevExpress.XtraBars.Navigation.TileBarItem
				Private tileBarItemProductCollectionView As DevExpress.XtraBars.Navigation.TileBarItem
					End Class
End Namespace
