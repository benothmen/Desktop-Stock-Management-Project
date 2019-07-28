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
  ''' Represents the single Categoire object view model.
  ''' </summary>
  Public Partial Class CategoireViewModel
    Inherits SingleObjectViewModel(Of Categoire, Integer, IBD_STOCKEntities1UnitOfWork)    
    ''' <summary>
    ''' Creates a new instance of CategoireViewModel as a POCO view model.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Public Shared Function Create(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing) As CategoireViewModel
      Return ViewModelSource.Create(Function() New CategoireViewModel(unitOfWorkFactory))
    End Function    
    ''' <summary>
    ''' Initializes a new instance of the CategoireViewModel class.
    ''' This constructor is declared protected to avoid undesired instantiation of the CategoireViewModel type without the POCO proxy factory.
    ''' </summary>
    ''' <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
    Protected Sub New(Optional ByVal unitOfWorkFactory As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork) = Nothing)
      MyBase.New(If(unitOfWorkFactory, UnitOfWorkSource.GetUnitOfWorkFactory()), Function(ByVal x) x.Categoire, Function(ByVal x) x.CategorieName)
    End Sub    
    ''' <summary>
    ''' The view model that contains a look-up collection of Product for the corresponding navigation property in the view.
    ''' </summary>
    Public ReadOnly Property LookUpProduct As IEntitiesViewModel(Of Product)
      Get
        Return GetLookUpEntitiesViewModel(propertyExpression := Function(ByVal x As CategoireViewModel) x.LookUpProduct, getRepositoryFunc := Function(ByVal x) x.Product)
      End Get
    End Property    
    ''' <summary>
    ''' The view model for the CategoireProduct detail collection.
    ''' </summary>
    Public ReadOnly Property CategoireProductDetails As CollectionViewModelBase(Of Product, Product, Integer, IBD_STOCKEntities1UnitOfWork)
      Get
        Return GetDetailsCollectionViewModel(propertyExpression := Function(ByVal x As CategoireViewModel) x.CategoireProductDetails, getRepositoryFunc := Function(ByVal x) x.Product, foreignKeyExpression := Function(ByVal x) x.CategorieId, navigationExpression := Function(ByVal x) x.Categoire)
      End Get
    End Property
  End Class
End Namespace
