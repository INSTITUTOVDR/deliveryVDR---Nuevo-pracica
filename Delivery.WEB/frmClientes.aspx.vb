Imports Delivery.AD
Imports System.Data

Public Class frmClientes
    Inherits System.Web.UI.Page
    Dim oDs As DataSet
    Dim O_ClaseClientes As C_Clientes

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Page.IsPostBack = False Then

            'Limpiar()
            'cargar_Grilla()

        End If

    End Sub

#Region "Funciones"


#End Region
#Region "Botones"



#End Region
#Region "Procedimientos"
    Private Sub cargar_Grilla()

        O_ClaseClientes = New C_Clientes
        oDs = New DataSet
        oDs = O_ClaseClientes.BuscarTodosClientes()
        dgvGrillaClientes.DataSource = oDs.Tables(0)
        dgvGrillaClientes.DataBind()

    End Sub

    Private Sub Limpiar()

        txt_Nombre.Text = Nothing
        txt_Apellido.Text = Nothing
        txt_IdCliente.Text = Nothing
        cboTipoCliente.Enabled = False
        txtEmail.Text = Nothing
        txtDireccion.Text = Nothing

    End Sub


#End Region
    Protected Sub btn_Logo_Click(sender As Object, e As ImageClickEventArgs) Handles btn_Logo.Click
        Response.Redirect("Menu.aspx")
    End Sub

End Class