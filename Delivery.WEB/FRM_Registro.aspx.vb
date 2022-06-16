Imports Delivery.AD
Imports System.Data
Public Class FRM_Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            'Limpiar()

        End If

    End Sub

    Protected Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        If txtNombre.Text <> Nothing And txtUsuario.Text <> Nothing And txtContraseña.Text <> Nothing And txtConfirmarcontraseña.Text <> Nothing And txtContraseña.Text = txtConfirmarcontraseña.Text Then
            Dim ORegistro As New Registro
            Dim ods As New DataSet

            ORegistro.Registrar(txtNombre.Text, txtUsuario.Text, txtContraseña.Text)

            ' Limpiar()

        Else
            lbl_Mensaje.ForeColor = Drawing.Color.Red
            lbl_Mensaje.Text = "Las contraseñas no coinciden"

        End If

    End Sub

    Public Function Limpiar()

        txtNombre.Text = Nothing
        txtUsuario.Text = Nothing
        txtContraseña.Text = Nothing


    End Function



End Class