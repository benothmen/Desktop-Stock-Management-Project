Imports DevExpress.Mvvm.DataModel
Imports ProjetGestionDeStock
Imports System
Imports System.Collections.Generic
Imports System.Linq
Namespace Global.ProjetGestionDeStock.BD_STOCKEntities1DataModel
  ''' <summary>
  ''' IBD_STOCKEntities1UnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
  ''' </summary>
  Public Interface IBD_STOCKEntities1UnitOfWork
    Inherits IUnitOfWork    
    ''' <summary>
    ''' The Categoire entities repository.
    ''' </summary>
    ReadOnly Property Categoire As IRepository(Of Categoire, Integer)    
    ''' <summary>
    ''' The Product entities repository.
    ''' </summary>
    ReadOnly Property Product As IRepository(Of Product, Integer)
  End Interface
End Namespace
