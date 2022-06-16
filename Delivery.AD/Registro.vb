Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data


Public Class Registro

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub


    Public Function Registrar(ByVal Nombre As String, ByVal Usuario As String, ByVal Contraseña As String) As Double
        Try
            Return oDatabase.ExecuteScalar("usuario_Registrar", Nombre, Usuario, Contraseña)
        Catch ex As System.Exception
            Throw ex

        End Try
    End Function

End Class
