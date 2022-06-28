Imports Delivery.AD
Imports System.Data
Public Class FRM_TipoProducto
    Inherits System.Web.UI.Page

#Region "Formulario"
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
            Cargar_Grilla()
            DesHabilitarComandos()
            btn_Agregar.Enabled = True
            btn_Limpiar.Enabled = True
            txt_ID_TipoProducto.Enabled = True

        End If
    End Sub
#End Region

#Region "Grilla"

    Private Sub Grilla_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Grilla.PageIndexChanging


        Dim OTipoProducto As New TipoProducto
        Dim oDs As New DataSet

        oDs = OTipoProducto.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)
        Grilla.PageIndex = e.NewPageIndex
        Grilla.DataBind()

        If txt_ID_TipoProducto.Text <> "" Then

            btn_Modificar.Enabled = True

        End If


        OTipoProducto = Nothing
        oDs = Nothing

    End Sub
    'ESTE ES EL SELECIONAR DE LA GRILLA
    Protected Sub Grilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grilla.SelectedIndexChanged

        Dim row As GridViewRow = Grilla.SelectedRow

        BuscarPorID(row.Cells(1).Text)


        If txt_Clasificacion.Text <> "" Then

            btn_Modificar.Enabled = True

        End If

        btn_Agregar.Enabled = True

    End Sub

#End Region

#Region "Procedimientos"

    Private Sub BuscarPorID(ByVal ID_Tipo_Producto As Integer)

        lbl_Mensaje.Text = ""

        Dim oTipoProducto As New TipoProducto
        Dim oDs As New DataSet
        oDs = oTipoProducto.BuscarPorID(ID_Tipo_Producto)
        '' CORROBORAR CON LOS NOMBRE EN LA BASE DE DATOS Y SI EL ES .AllowMultiple
        If oDs.Tables(0).Rows.Count > 0 Then

            txt_ID_TipoProducto.Text = oDs.Tables(0).Rows(0).Item("ID_Tipo_Producto")
            txt_Clasificacion.Text = oDs.Tables(0).Rows(0).Item("Clasificacion")

            btn_Modificar.Enabled = True

        Else

            lbl_Mensaje.Text = "No se encontró el tipo de producto con el código ingresado"
            Limpiar()

        End If

    End Sub

    Private Sub Limpiar()

        HF.Value = 0
        txt_ID_TipoProducto.Text = ""
        txt_Clasificacion.Text = ""


    End Sub

    Private Sub Cargar_Grilla()
        Dim oTipoProducto As New TipoProducto
        Dim oDs As New DataSet

        oDs = oTipoProducto.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)
        Grilla.DataBind()

        btn_Modificar.Enabled = True


        oTipoProducto = Nothing
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

        txt_ID_TipoProducto.Enabled = False
        txt_Clasificacion.Enabled = False


    End Sub

    Private Function Validar() As Boolean

        Dim oTipoProducto As New TipoProducto
        Dim oDs As New DataSet

        oDs = oTipoProducto.BuscarPorID(txt_ID_TipoProducto.Text)

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
                    If txt_Clasificacion.Text <> Nothing Then
                        Dim oTipoProducto As New TipoProducto
                        Dim oDs As New Data.DataSet

                        oTipoProducto = New TipoProducto
                        oTipoProducto.Agregar(txt_Clasificacion.Text)
                        Cargar_Grilla()
                        Limpiar()
                        lbl_Mensaje.ForeColor = Drawing.Color.Green
                        lbl_Mensaje.Text = "Cargado Correctamente :)"
                        oTipoProducto = Nothing
                    Else
                        lbl_Mensaje.ForeColor = Drawing.Color.Red
                        lbl_Mensaje.Text = "Complete los campos vacios :("

                    End If
                End If
            Case 2
                If txt_ID_TipoProducto.Text <> Nothing And txt_Clasificacion.Text <> Nothing Then
                    Dim OTipoProducto As New TipoProducto
                    Dim oDs As New Data.DataSet

                    OTipoProducto = New TipoProducto
                    oDs = New Data.DataSet
                    oDs = OTipoProducto.BuscarPorID(txt_ID_TipoProducto.Text)
                    If oDs.Tables(0).Rows.Count > 0 Then
                        oDs = New Data.DataSet
                        OTipoProducto = New TipoProducto
                        OTipoProducto.Modificar(txt_ID_TipoProducto.Text, txt_Clasificacion.Text)
                        Cargar_Grilla()
                        Limpiar()
                        lbl_Mensaje.ForeColor = Drawing.Color.Green
                        lbl_Mensaje.Text = "Modificado Correctamente :)"
                        OTipoProducto = Nothing
                    Else
                        lbl_Mensaje.ForeColor = Drawing.Color.Red
                        lbl_Mensaje.Text = "Error ID Incorrecto :("
                        OTipoProducto = Nothing
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
        txt_Clasificacion.Enabled = True

        'EL VALOR 1 ES PARA AGREGAR
        HF.Value = 1

    End Sub

    Protected Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        DesHabilitarComandos()
        btn_Aceptar.Enabled = True
        btn_Cancelar.Enabled = True
        txt_Clasificacion.Enabled = True
        txt_ID_TipoProducto.Enabled = False

        'EL VALOR 2 ES PARA MODIFICAR
        HF.Value = 2
    End Sub
    Protected Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        Limpiar()
        Cargar_Grilla()
        DesHabilitarComandos()
        btn_Agregar.Enabled = True
        btn_Limpiar.Enabled = True
        txt_ID_TipoProducto.Enabled = True
    End Sub
#End Region

End Class