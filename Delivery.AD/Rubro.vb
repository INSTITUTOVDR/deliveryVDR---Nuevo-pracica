Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Rubro
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarPorID(ByVal ID_Rubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarPorID", ID_Rubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Rubros_Agregar", Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Rubro As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_Modificar", ID_Rubro, Nombre, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Desactivar(ByVal ID_Rubro As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_Desactivar", ID_Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarActivos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Rubros_BuscarActivos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
