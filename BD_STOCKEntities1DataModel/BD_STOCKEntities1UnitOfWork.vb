Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.DataModel.EF6
Imports ProjetGestionDeStock
Imports System
Imports System.Collections.Generic
Imports System.Linq
Namespace Global.ProjetGestionDeStock.BD_STOCKEntities1DataModel
  ''' <summary>
  ''' A BD_STOCKEntities1UnitOfWork instance that represents the run-time implementation of the IBD_STOCKEntities1UnitOfWork interface.
  ''' </summary>
  Public Class BD_STOCKEntities1UnitOfWork
    Inherits DbUnitOfWork(Of BD_STOCKEntities1)
    Implements IBD_STOCKEntities1UnitOfWork
    Public Sub New(ByVal contextFactory As Func(Of BD_STOCKEntities1))
      MyBase.New(contextFactory)
    End Sub
    Private ReadOnly Property Categoire As IRepository(Of Categoire, Integer) Implements IBD_STOCKEntities1UnitOfWork.Categoire
      Get
        Return GetRepository(Function(ByVal x) x.[Set](Of Categoire)(), Function(ByVal x As Categoire) x.CategorieId)
      End Get
    End Property
    Private ReadOnly Property Product As IRepository(Of Product, Integer) Implements IBD_STOCKEntities1UnitOfWork.Product
      Get
        Return GetRepository(Function(ByVal x) x.[Set](Of Product)(), Function(ByVal x As Product) x.ProductId)
      End Get
    End Property
  End Class
End Namespace
