Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class Proveedor
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Function BuscarPorID(ByVal ID_Proveedor As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Proveedores_BuscarPorID", ID_Proveedor)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Proveedores_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal NombreCompañia As String, ByVal CargoContacto As String, ByVal ID_Localidad As Integer, ByVal ID_ContactoTipo As Integer, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Proveedores_Agregar", NombreCompañia, CargoContacto, ID_Localidad, ID_ContactoTipo, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Proveedor As Integer, ByVal NombreCompañia As String, ByVal CargoContacto As String, ByVal ID_Localidad As Integer, ByVal ID_ContactoTipo As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Proveedores_Modificar", ID_Proveedor, NombreCompañia, CargoContacto, ID_Localidad, ID_ContactoTipo, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Desactivar(ByVal ID_Proveedor As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Proveedores_Desactivar", ID_Proveedor, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarActivos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Proveedores_BuscarActivos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
