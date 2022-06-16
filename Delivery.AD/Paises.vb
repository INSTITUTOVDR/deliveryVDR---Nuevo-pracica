Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

'*************************************************************************************************
'Clase Generada por IDEAS SA
'*************************************************************************************************

Public Class Paises

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal sting As String)
    End Sub

    Public Function BuscarPorID(ByVal ID_Pais As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Paises_BuscarPorID", ID_Pais)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Paises_BuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal Descripcion As String, ByVal Reducida As String, ByVal Imagen As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("Paises_Agregar", Descripcion, Reducida, Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal ID_Pais As Integer, ByVal Descripcion As String, ByVal Reducida As String, ByVal Imagen As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Paises_Modificar", ID_Pais, Descripcion, Reducida, Imagen, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function Desactivar(ByVal ID_Pais As Integer, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Paises_Desactivar", ID_Pais, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarActivos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Paises_BuscarActivos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
