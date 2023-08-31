Imports System.Collections.Generic
Imports System.ComponentModel
Imports System

Namespace dxSample.Data

    Public Class Category

        Public Property Id As Integer

        Public Property Name As String

        Public Property Description As String
    End Class

    Public Module CategoryData

        Private _random As Random = New Random()

        Private _possibleItems As String() = New String() {"Tea", "Coffee", "Butter", "Lemon", "Apple", "Orange", "Milk", "Chocolate"}

        Private _categories As String() = New String() {"Main", "New", "Best"}

        Public Function GetCategories() As IList(Of Category)
            Dim categories As BindingList(Of Category) = New BindingList(Of Category)()
            For i As Integer = 0 To 8 - 1
                Dim index As Integer = i + 1
                Dim items As String = String.Empty
                Dim itemsCount As Integer = _random.Next(4, 14)
                For j As Integer = 0 To itemsCount - 1
                    items += _possibleItems(_random.Next(4, 8))
                    items += If(j < itemsCount - 1, ", ", "")
                Next

                categories.Add(New Category() With {.Id = i, .Name = _categories(_random.Next(0, 3)), .Description = items})
            Next

            Return categories
        End Function
    End Module
End Namespace
