Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class TipoProducto
    Dim oDatabase As Database
    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarPorID(ByVal ID_Tipo_Producto As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("TiposProductos_BuscarPorID", ID_Tipo_Producto)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("TiposProductos_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Clasificacion As String) As Double
        Try
            Return oDatabase.ExecuteScalar("TiposProductos_Agregar", Clasificacion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Tipo_Producto As Integer, ByVal Clasificacion As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("TiposProductos_Modificar", ID_Tipo_Producto, Clasificacion)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
