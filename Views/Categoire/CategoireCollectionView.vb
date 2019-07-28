Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.MVVM.Services
Imports DevExpress.XtraBars

Namespace Global.ProjetGestionDeStock.Views.CategoireCollectionView
	Partial Public Class CategoireCollectionView
		Inherits XtraUserControl

		Public Sub New()
			InitializeComponent()
			If Not mvvmContext.IsDesignMode Then
				InitBindings()
			End If
		End Sub
		Private Sub InitBindings()
			Dim fluentAPI = mvvmContext.OfType(Of Global.ProjetGestionDeStock.ViewModels.CategoireCollectionViewModel)()
			fluentAPI.WithEvent(Me, "Load").EventToCommand(Sub(x) x.OnLoaded())
			' We want to show the Entities collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(gridControl, Function(gControl) gControl.DataSource, Function(x) x.Entities)
			' We want to show loading-indicator when data is loading asynchronously
            fluentAPI.SetBinding(gridView, Function(gView) gView.LoadingPanelVisible, Function(x) x.IsLoading)
						' We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent(Of RowClickEventArgs)(gridView, "RowClick").EventToCommand(
                Sub(x) x.Edit(Nothing),
                Function(x) x.SelectedEntity,
                Function(args) (args.Clicks = 2) AndAlso (args.Button = System.Windows.Forms.MouseButtons.Left))
						' We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent(Of GridView, FocusedRowObjectChangedEventArgs)(gridView, "FocusedRowObjectChanged").SetBinding(
                Function(x) x.SelectedEntity,
                Function(args) TryCast(args.Row, ProjetGestionDeStock.Categoire),
                Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
			
									fluentAPI.BindCommand((DirectCast(windowsUIButtonPanel.Buttons(0), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[New]())
																		fluentAPI.BindCommand((DirectCast(windowsUIButtonPanel.Buttons(1), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x, p) x.[Edit](p), Function(x) x.SelectedEntity)
															fluentAPI.BindCommand((DirectCast(windowsUIButtonPanel.Buttons(2), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x, p) x.[Delete](p), Function(x) x.SelectedEntity)
												fluentAPI.BindCommand((DirectCast(windowsUIButtonPanel.Buttons(3), DevExpress.Utils.MVVM.ISupportCommandBinding)), Sub(x) x.[Refresh]())
												'We want to show ribbon print preview when windowsUIButton clicked
			AddHandler CType(windowsUIButtonPanel.Buttons(5), DevExpress.XtraBars.Docking2010.WindowsUIButton).Click, Sub(s, e) gridControl.ShowRibbonPrintPreview()
		End Sub

    End Class
End Namespace
