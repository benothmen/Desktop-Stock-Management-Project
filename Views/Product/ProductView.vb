Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Namespace Global.ProjetGestionDeStock.Views.ProductView
	Partial Public Class ProductView
		Inherits XtraUserControl

		Public Sub New()
			InitializeComponent()
			If Not mvvmContext.IsDesignMode Then
				InitBindings()
			End If
		End Sub
		Private Sub InitBindings()
			Dim fluentAPI = mvvmContext.OfType(Of Global.ProjetGestionDeStock.ViewModels.ProductViewModel)()
			fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
			fluentAPI.SetObjectDataSourceBinding(productViewBindingSource,Function(x) x.Entity, Sub(x) x.Update())
									' Binding for Categoire LookUp editor
			fluentAPI.SetBinding(CategoireLookUpEdit.Properties, Function(p) p.DataSource, Function(x) x.LookUpCategoire.Entities)
									fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(0), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Save]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(1), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[SaveAndClose]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(2), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[SaveAndNew]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(3), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Reset]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(4), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Delete]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelCloseButton.Buttons(0), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Close]())
		End Sub
	End Class
End Namespace
