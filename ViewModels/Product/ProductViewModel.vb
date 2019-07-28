Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.ViewModel
Imports ProjetGestionDeStock.BD_STOCKEntities1DataModel
Imports ProjetGestionDeStock.Common
Imports ProjetGestionDeStock
Namespace Global.ProjetGestionDeStock.ViewModels
  ''' <summary>
  ''' Represents the single Product object view model.
  ''' </summary>
  Public Partial Class ProductViewModel
    Inherits SingleObjectViewModel(Of Product, Integer, IBD_STOCKEntities1UnitOfWork)    
    ''' <summary>
    ''' Creates a new instance of ProductViewModel as a POCO view model.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing) As ProductViewModel
      Return ViewModelSource.Create(Function() New ProductViewModel(unitOfWorkFactory))
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the ProductViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing)
      MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Product, Function(ByVal x) x.ProductName)
    End Sub    
    ''' <summary>
    ''' The view model that contains a look-up collection of Categoire for the corresponding navigation property in the view.
    ''' </summary>
    Public ReadOnly Property LookUpCategoire As IEntitiesViewModel(Of Categoire)
      Get
        Return GetLookUpEntitiesViewModel(propertyExpression := Function(ByVal x As ProductViewModel) x.LookUpCategoire, getRepositoryFunc := Function(ByVal x) x.Categoire)
      End Get
    End Property
  End Class
End Namespace
