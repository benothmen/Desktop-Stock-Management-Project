'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré à partir d'un modèle.
'
'     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
'     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Categoire
    Public Property CategorieId As Integer
    Public Property CategorieName As String
    Public Property Designation As String

    Public Overridable Property Product As ICollection(Of Product) = New HashSet(Of Product)

End Class
