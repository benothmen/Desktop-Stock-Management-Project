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
  ''' Represents the Product collection view model.
  ''' </summary>
  Public Partial Class ProductCollectionViewModel
    Inherits CollectionViewModel(Of Product, Integer, IBD_STOCKEntities1UnitOfWork)    
    ''' <summary>
    ''' Creates a new instance of ProductCollectionViewModel as a POCO view model.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing) As ProductCollectionViewModel
      Return ViewModelSource.Create(Function() New ProductCollectionViewModel(unitOfWorkFactory))
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the ProductCollectionViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the ProductCollectionViewModel type without the POCO proxy factory.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing)
      MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Product)
    End Sub
  End Class
End Namespace
