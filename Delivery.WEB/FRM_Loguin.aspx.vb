Imports Delivery.AD
Imports System.Data
Public Class FRM_Loguin
    Inherits System.Web.UI.Page
    Dim oDs As New Data.DataSet
    Dim OLoguin As New Loguin
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Btn_Ingresar_Click(sender As Object, e As EventArgs) Handles Btn_Ingresar.Click
        Dim DvQuery As DataView = DirectCast(SqlDataSource1.Select(DataSourceSelectArguments.Empty), DataView)

        If Txt_Usuario.Text <> "" And txt_Contraseña.Text <> "" Then
            If DvQuery.Count > 0 Then
                Session("usuario") = DvQuery(0).Item(0)
                Response.Redirect("FRM_Paises.aspx")
            Else
                LblMensaje.Text = "Usuario y/o Contraseña incorrecto"
                LblMensaje.ForeColor = Drawing.Color.DarkRed

            End If
        Else
            LblMensaje.Text = "Rellene los campos vacios"
            LblMensaje.ForeColor = Drawing.Color.DarkRed

        End If

    End Sub
End Class