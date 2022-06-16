Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_Clientes

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarTodosClientes() As DataSet
        Return oDatabase.ExecuteDataSet("BuscarTodosClientes")
    End Function

End Class
