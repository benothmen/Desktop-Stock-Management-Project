Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports ProjetGestionDeStock.BD_STOCKEntities1DataModel
Imports ProjetGestionDeStock.Common
Imports ProjetGestionDeStock
Namespace Global.ProjetGestionDeStock.ViewModels
  ''' <summary>
  ''' Represents the Categoire collection view model.
  ''' </summary>
  Public Partial Class CategoireCollectionViewModel
    Inherits CollectionViewModel(Of Categoire, Integer, IBD_STOCKEntities1UnitOfWork)    
    ''' <summary>
    ''' Creates a new instance of CategoireCollectionViewModel as a POCO view model.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing) As CategoireCollectionViewModel
      Return ViewModelSource.Create(Function() New CategoireCollectionViewModel(unitOfWorkFactory))
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the CategoireCollectionViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the CategoireCollectionViewModel type without the POCO proxy factory.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing)
      MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Categoire)
    End Sub
  End Class
End Namespace
