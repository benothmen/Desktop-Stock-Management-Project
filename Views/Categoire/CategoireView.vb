Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.MVVM
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Namespace Global.ProjetGestionDeStock.Views.CategoireView
	Partial Public Class CategoireView
		Inherits XtraUserControl

		Public Sub New()
			InitializeComponent()
			If Not mvvmContext.IsDesignMode Then
				InitBindings()
			End If
		End Sub
		Private Sub InitBindings()
			Dim fluentAPI = mvvmContext.OfType(Of Global.ProjetGestionDeStock.ViewModels.CategoireViewModel)()
			fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
			fluentAPI.SetObjectDataSourceBinding(categoireViewBindingSource,Function(x) x.Entity, Sub(x) x.Update())
			'Region "Product Detail Collection"
			' We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
			fluentAPI.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(ProductGridView, "FocusedRowObjectChanged").SetBinding(
                Function(x) x.CategoireProductDetails.SelectedEntity,
                Function(args) TryCast(args.Row, ProjetGestionDeStock.Product),
                Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
						' We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent(Of RowClickEventArgs)(ProductGridView, "RowClick").EventToCommand(
                Sub(x) x.CategoireProductDetails.Edit(Nothing),
                Function(x) x.CategoireProductDetails.SelectedEntity,
                Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
						' We want to show PopupMenu when row clicked by right button
            AddHandler ProductGridView.RowClick, Sub(s, e)
				If e.Clicks = 1 AndAlso e.Button = System.Windows.Forms.MouseButtons.Right Then
					ProductPopUpMenu.ShowPopup(ProductGridControl.PointToScreen(e.Location), s)
				End If
			End Sub
			' We want to show the CategoireProductDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ProductGridControl, Function(g) g.DataSource, Function(x) x.CategoireProductDetails.Entities)
														fluentAPI.BindCommand(bbiProductNew, Sub(x) x.CategoireProductDetails.[New]())
																													fluentAPI.BindCommand(bbiProductEdit, Sub(x) x.CategoireProductDetails.Edit(Nothing), Function(x) x.CategoireProductDetails.SelectedEntity)
																								fluentAPI.BindCommand(bbiProductDelete, Sub(x) x.CategoireProductDetails.Delete(Nothing), Function(x) x.CategoireProductDetails.SelectedEntity)
																			fluentAPI.BindCommand(bbiProductRefresh, Sub(x) x.CategoireProductDetails.[Refresh]())
														'End Region
												fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(0), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Save]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(1), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[SaveAndClose]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(2), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[SaveAndNew]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(3), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Reset]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelMain.Buttons(4), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Delete]())
						fluentAPI.BindCommand((DirectCast(windowsUIButtonPanelCloseButton.Buttons(0), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Close]())
		End Sub
	End Class
End Namespace
