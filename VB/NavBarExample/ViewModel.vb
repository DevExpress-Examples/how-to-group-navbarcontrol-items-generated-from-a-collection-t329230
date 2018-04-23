Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Data

Namespace NavBarExample
    Public Class ViewModel
        Public Property Employees() As ObservableCollection(Of Employee)

        Public Sub New()
            Employees = New ObservableCollection(Of Employee)() From { _
                New Employee() With {.Name="Alex", .Department="Management"}, _
                New Employee() With {.Name="Paul", .Department="Logistics"}, _
                New Employee() With {.Name="Peter", .Department="Logistics"}, _
                New Employee() With {.Name="Mary", .Department="Management"}, _
                New Employee() With {.Name="John", .Department="Sales"}, _
                New Employee() With {.Name="Mark", .Department="Sales"}, _
                New Employee() With {.Name="Kumar", .Department="Advertisement"}, _
                New Employee() With {.Name="Janet", .Department="Logistics"}, _
                New Employee() With {.Name="Tom", .Department="Advertisement"} _
            }
        End Sub
    End Class

    Public Class Employee
        Public Property Name() As String
        Public Property Department() As String
    End Class
End Namespace
