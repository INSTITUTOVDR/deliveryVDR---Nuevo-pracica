Imports Delivery.AD
Imports System.Data
Public Class FRM_Proveedores
    Inherits System.Web.UI.Page

#Region "Formulario"
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
            Cargar_Grilla()
            DesHabilitarComandos()
            btn_Agregar.Enabled = True
            btn_Limpiar.Enabled = True
            txt_ID_Proveedor.Enabled = True

        End If
    End Sub
#End Region

#Region "Grilla"

    Private Sub Grilla_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Grilla.PageIndexChanging


        Dim OProveedor As New Proveedor
        Dim oDs As New DataSet

        oDs = OProveedor.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)
        Grilla.PageIndex = e.NewPageIndex
        Grilla.DataBind()

        If txt_ID_Proveedor.Text <> "" Then

            btn_Modificar.Enabled = True

        End If


        OProveedor = Nothing
        oDs = Nothing

    End Sub
    'ESTE ES EL SELECIONAR DE LA GRILLA
    Protected Sub Grilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grilla.SelectedIndexChanged

        Dim row As GridViewRow = Grilla.SelectedRow

        BuscarPorID(row.Cells(1).Text)


        If txt_Nombre.Text <> "" And txt_Cargo.Text <> "" Then

            btn_Modificar.Enabled = True

        End If

        btn_Agregar.Enabled = True

    End Sub

#End Region

#Region "Procedimientos"

    Private Sub BuscarPorID(ByVal ID As Integer)

        lbl_Mensaje.Text = ""

        Dim oProveedor As New Proveedor
        Dim oDs As New DataSet
        oDs = oProveedor.BuscarPorID(ID)
        '' CORROBORAR CON LOS NOMBRE EN LA BASE DE DATOS Y SI EL ES .AllowMultiple
        If oDs.Tables(0).Rows.Count > 0 Then

            txt_ID_Proveedor.Text = oDs.Tables(0).Rows(0).Item("ID_Proveedor")
            txt_Nombre.Text = oDs.Tables(0).Rows(0).Item("NombreCompañia")
            txt_Cargo.Text = oDs.Tables(0).Rows(0).Item("CargoContacto")
            ddl_ID_Localidad.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_Localidad")
            ddl_ID_ContactoTipo.SelectedValue = oDs.Tables(0).Rows(0).Item("ID_ContactoTipo")
            chk_Activo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

            btn_Modificar.Enabled = True

        Else

            lbl_Mensaje.Text = "No se encontró el proveedor con el código ingresado"
            Limpiar()

        End If

    End Sub

    Private Sub Limpiar()

        HF.Value = 0
        txt_ID_Proveedor.Text = ""
        txt_Nombre.Text = ""
        txt_Cargo.Text = ""
        chk_Activo.Checked = False

    End Sub

    Private Sub Cargar_Grilla()
        Dim oProveedor As New Proveedor
        Dim oDs As New DataSet

        oDs = oProveedor.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)
        Grilla.DataBind()

        btn_Modificar.Enabled = True


        oProveedor = Nothing
        oDs = Nothing

    End Sub
    '' CORROBORAR QUE NO FALTEN BOTONES

    Private Sub DesHabilitarComandos()

        btn_Agregar.Enabled = False
        btn_Modificar.Enabled = False
        btn_Limpiar.Enabled = False
        btn_Aceptar.Enabled = False
        btn_Cancelar.Enabled = False

    End Sub

    Private Sub DesHabilitarCampos()

        txt_ID_Proveedor.Enabled = False
        txt_Nombre.Enabled = False
        txt_Cargo.Enabled = False
        chk_Activo.Enabled = False

    End Sub

    Private Function Validar() As Boolean

        Dim oProveedor As New Proveedor
        Dim oDs As New DataSet

        oDs = oProveedor.BuscarPorID(txt_ID_Proveedor.Text)

        If oDs.Tables(0).Rows.Count > 0 Then

            Return False

        End If

        Return True

    End Function

#End Region

#Region "Botones de Comando"
    Protected Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Select Case HF.Value
            Case 1
                If Validar() = True Then
                    If txt_Nombre.Text <> Nothing And txt_Cargo.Text <> Nothing Then
                        Dim oProveedor As New Proveedor
                        Dim oDs As New Data.DataSet

                        oProveedor = New Proveedor
                        oProveedor.Agregar(ddl_ID_Localidad.SelectedValue, ddl_ID_ContactoTipo.SelectedValue, txt_Nombre.Text, txt_Cargo.Text, 1)
                        Cargar_Grilla()
                        Limpiar()
                        lbl_Mensaje.ForeColor = Drawing.Color.Green
                        lbl_Mensaje.Text = "Cargado Correctamente :)"
                        oProveedor = Nothing
                    Else
                        lbl_Mensaje.ForeColor = Drawing.Color.Red
                        lbl_Mensaje.Text = "Complete los campos vacios :("

                    End If
                End If
            Case 2
                If txt_ID_Proveedor.Text <> Nothing And txt_Nombre.Text <> Nothing And txt_Cargo.Text <> Nothing Then
                    Dim OProveedor As New Proveedor
                    Dim oDs As New Data.DataSet

                    OProveedor = New Proveedor
                    oDs = New Data.DataSet
                    oDs = OProveedor.BuscarPorID(txt_ID_Proveedor.Text)
                    If oDs.Tables(0).Rows.Count > 0 Then
                        oDs = New Data.DataSet
                        OProveedor = New Proveedor
                        OProveedor.Modificar(txt_ID_Proveedor.Text, ddl_ID_Localidad.SelectedValue, ddl_ID_ContactoTipo.SelectedValue, txt_Nombre.Text, txt_Cargo.Text, 1)
                        Cargar_Grilla()
                        Limpiar()
                        lbl_Mensaje.ForeColor = Drawing.Color.Green
                        lbl_Mensaje.Text = "Modificado Correctamente :)"
                        OProveedor = Nothing
                    Else
                        lbl_Mensaje.ForeColor = Drawing.Color.Red
                        lbl_Mensaje.Text = "Error ID Incorrecto :("
                        OProveedor = Nothing
                    End If
                Else
                    lbl_Mensaje.ForeColor = Drawing.Color.Red
                    lbl_Mensaje.Text = "Complete los campos vacios :("
                End If

        End Select
        Limpiar()
        DesHabilitarCampos()
        DesHabilitarComandos()
        Cargar_Grilla()
    End Sub

    Protected Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        DesHabilitarComandos()
        Limpiar()

        btn_Aceptar.Enabled = True
        btn_Cancelar.Enabled = True
        txt_Nombre.Enabled = True
        txt_Cargo.Enabled = True
        chk_Activo.Enabled = True

        'EL VALOR 1 ES PARA AGREGAR
        HF.Value = 1

    End Sub

    Protected Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        DesHabilitarComandos()
        btn_Aceptar.Enabled = True
        btn_Cancelar.Enabled = True
        txt_Descripcion.Enabled = True
        txt_Reducida.Enabled = True
        btn_SubirImagen.Enabled = True
        chk_Activo.Enabled = True
        txt_ID_Proveedor.Enabled = False

        'EL VALOR 2 ES PARA MODIFICAR
        HF.Value = 2
    End Sub
    Protected Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
            Limpiar()
            Cargar_Grilla()
            DesHabilitarComandos()
            btn_Agregar.Enabled = True
            btn_Limpiar.Enabled = True
            txt_Id.Enabled = True
        End Sub
#End Region

End Class