Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars.Navigation
Namespace Global.ProjetGestionDeStock.Views.BD_STOCKEntities1View
	Partial Public Class BD_STOCKEntities1View
		Inherits XtraUserControl

		Public Sub New()
			InitializeComponent()
			If Not mvvmContext.IsDesignMode Then
				InitializeNavigation()
			End If
		End Sub
		Private Sub InitializeNavigation()
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
			DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins()
			DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
			DevExpress.XtraEditors.WindowsFormsSettings.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
			DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013")
			Dim fontSize As Single = 10F
			DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = New System.Drawing.Font("Segoe UI", fontSize)
			DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = New System.Drawing.Font("Segoe UI", fontSize)

			tileBar.SelectionColorMode = SelectionColorMode.UseItemBackColor
            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame))
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService()
            ' We want to use buttons in Ribbon to show the specific modules
            Dim fluentAPI = mvvmContext.OfType(Of Global.ProjetGestionDeStock.ViewModels.BD_STOCKEntities1ViewModel)()
						tileBar.SelectedItem = tileBarItemCategoireCollectionView
			            fluentAPI.BindCommand(tileBarItemCategoireCollectionView, Sub(x, m) x.Show(m), Function(x) x.Modules(0))
			            fluentAPI.BindCommand(tileBarItemProductCollectionView, Sub(x, m) x.Show(m), Function(x) x.Modules(1))
						            ' We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent(Of EventArgs)(Me, "Load").EventToCommand(
                Sub(x) x.OnLoaded(Nothing), Function(x) x.DefaultModule)
		End Sub
	End Class
End Namespace

