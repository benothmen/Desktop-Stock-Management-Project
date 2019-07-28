Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.ComponentModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.ViewModel
Imports ProjetGestionDeStock.BD_STOCKEntities1DataModel
Namespace Global.ProjetGestionDeStock.ViewModels
  ''' <summary>
  ''' Represents the root POCO view model for the BD_STOCKEntities1 data model.
  ''' </summary>
  Public Partial Class BD_STOCKEntities1ViewModel
    Inherits DocumentsViewModel(Of BD_STOCKEntities1ModuleDescription, IBD_STOCKEntities1UnitOfWork)
    Private Const _TablesGroup As String = "Tables"
    Private Const _ViewsGroup As String = "Views"
    Private ReadOnly Property NavigationService As INavigationService
      Get
        Return Me.GetService(Of INavigationService)()
      End Get
    End Property    
    ''' <summary>
    ''' Creates a new instance of BD_STOCKEntities1ViewModel as a POCO view model.
    ''' </summary>
    Public Shared Function Create() As BD_STOCKEntities1ViewModel
      Return ViewModelSource.Create(Function() New BD_STOCKEntities1ViewModel())
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the BD_STOCKEntities1ViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the BD_STOCKEntities1ViewModel type without the POCO proxy factory.
    ''' </summary>
    Protected Sub New()
      MyBase.New(UnitOfWorkSource.GetUnitOfWorkFactory())
    End Sub
    Protected Overrides Function CreateModules() As BD_STOCKEntities1ModuleDescription()
      Return New BD_STOCKEntities1ModuleDescription() { New BD_STOCKEntities1ModuleDescription("Categoire", "CategoireCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Categoire)),New BD_STOCKEntities1ModuleDescription("Product", "ProductCollectionView", _TablesGroup, GetPeekCollectionViewModelFactory(Function(ByVal x) x.Product)) }
    End Function
    Protected Overrides Sub OnActiveModuleChanged(ByVal oldModule As BD_STOCKEntities1ModuleDescription)
      If ActiveModule IsNot Nothing AndAlso NavigationService IsNot Nothing Then
        NavigationService.ClearNavigationHistory()
      End If
      MyBase.OnActiveModuleChanged(oldModule)
    End Sub
  End Class
  Public Partial Class BD_STOCKEntities1ModuleDescription
    Inherits ModuleDescription(Of BD_STOCKEntities1ModuleDescription)
    Public Sub New(ByVal title As String, ByVal documentType As String, ByVal group As String, Optional ByVal peekCollectionViewModelFactory As Func(Of BD_STOCKEntities1ModuleDescription, Object) = Nothing)
      MyBase.New(title, documentType, group, peekCollectionViewModelFactory)
    End Sub
  End Class
End Namespace
