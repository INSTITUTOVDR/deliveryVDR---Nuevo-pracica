Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class SubRubro
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarPorID(ByVal ID_SubRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_BuscarPorID", ID_SubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal ID_Rubro As Integer, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("SubRubros_Agregar", Nombre, ID_Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_SubRubro As Integer, ByVal Nombre As String, ByVal ID_Rubro As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_Modificar", ID_SubRubro, Nombre, ID_Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Desactivar(ByVal ID_SubRubro As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_Desactivar", ID_SubRubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarActivos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubros_BuscarActivos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
