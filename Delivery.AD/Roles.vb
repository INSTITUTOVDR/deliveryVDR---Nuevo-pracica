Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class Roles

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarPorID(ByVal ID_Rol As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Roles_BuscarPorID", ID_Rol)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Roles_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Roles_Agregar", Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Rol As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Roles_Modificar", ID_Rol, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Desactivar(ByVal ID_Rol As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Roles_Desactivar", ID_Rol, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarActivos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Roles_BuscarActivos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
