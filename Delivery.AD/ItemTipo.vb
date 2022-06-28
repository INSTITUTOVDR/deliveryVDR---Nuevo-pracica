Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ItemTipo
    Dim oDatabase As Database
    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarPorID(ByVal ID_ItemTipo As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemTipos_BuscarPorID", ID_ItemTipo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemTipos_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Clasificacion As String) As Double
        Try
            Return oDatabase.ExecuteScalar("ItemTipos_Agregar", Clasificacion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_ItemTipo As Integer, ByVal Clasificacion As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ItemTipos_Modificar", ID_ItemTipo, Clasificacion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
