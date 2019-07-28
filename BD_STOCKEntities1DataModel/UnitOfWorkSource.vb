Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataModel
Imports DevExpress.Mvvm.DataModel.DesignTime
Imports DevExpress.Mvvm.DataModel.EF6
Imports ProjetGestionDeStock
Imports System
Imports System.Collections
Imports System.Linq
Namespace Global.ProjetGestionDeStock.BD_STOCKEntities1DataModel
  ''' <summary>
  ''' Provides methods to obtain the relevant IUnitOfWorkFactory.
  ''' </summary>
  Public Module UnitOfWorkSource  
    ''' <summary>
    ''' Returns the IUnitOfWorkFactory implementation.
    ''' </summary>
    Public Function GetUnitOfWorkFactory() As IUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork)
      Return New DbUnitOfWorkFactory(Of IBD_STOCKEntities1UnitOfWork)(Function() New BD_STOCKEntities1UnitOfWork(Function() New BD_STOCKEntities1()))
    End Function
  End Module
End Namespace
