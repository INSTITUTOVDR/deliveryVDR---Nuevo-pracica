Imports Delivery.AD
Imports System.Data
Public Class FRM_Paieses
    Inherits System.Web.UI.Page

#Region "Formulario"
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Page.IsPostBack = False Then
            Limpiar()
            Cargar_Grilla()
            DesHabilitarComandos()
            btn_Agregar.Enabled = True
            btn_Limpiar.Enabled = True
            txt_Id.Enabled = True

        End If
    End Sub
#End Region

#Region "Grilla"

    Private Sub Grilla_PageIndexChanging(sender As Object, e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles Grilla.PageIndexChanging


        Dim OPaises As New Paises
        Dim oDs As New DataSet

        oDs = OPaises.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)
        Grilla.PageIndex = e.NewPageIndex
        Grilla.DataBind()

        If txt_Id.Text <> "" Then

            btn_Modificar.Enabled = True

        End If


        OPaises = Nothing
        oDs = Nothing

    End Sub
    'ESTE ES EL SELECIONAR DE LA GRILLA
    Protected Sub Grilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Grilla.SelectedIndexChanged

        Dim row As GridViewRow = Grilla.SelectedRow

        BuscarPorID(row.Cells(1).Text)


        If txt_Descripcion.Text <> "" And txt_Reducida.Text <> "" Then

            btn_Modificar.Enabled = True

        End If

        btn_Agregar.Enabled = True

    End Sub

#End Region

#Region "Procedimientos"

    Private Sub BuscarPorID(ByVal ID As Integer)

        lbl_Mensaje.Text = ""

        Dim oObjeto As New Paises
        Dim oDs As New DataSet
        oDs = oObjeto.BuscarPorID(ID)
        '' CORROBORAR CON LOS NOMBRE EN LA BASE DE DATOS Y SI EL ES .AllowMultiple
        If oDs.Tables(0).Rows.Count > 0 Then

            txt_Id.Text = oDs.Tables(0).Rows(0).Item("ID_Pais")
            txt_Descripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
            txt_Reducida.Text = oDs.Tables(0).Rows(0).Item("Reducida")
            img_Imagen.ImageUrl = oDs.Tables(0).Rows(0).Item("Imagen")
            chk_Activo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

            btn_Modificar.Enabled = True


        Else

            lbl_Mensaje.Text = "No se encontró el pais con el código ingresado"
            Limpiar()

        End If

    End Sub

    Private Sub Limpiar()

        HF.Value = 0
        txt_Id.Text = ""
        txt_Descripcion.Text = ""
        txt_Reducida.Text = ""
        img_Imagen.ImageUrl = ""
        chk_Activo.Checked = False

    End Sub

    Private Sub Cargar_Grilla()
        Dim oPaises As New Paises
        Dim oDs As New DataSet

        oDs = oPaises.BuscarTodos

        Grilla.DataSource = oDs.Tables(0)
        Grilla.DataBind()

        btn_Modificar.Enabled = True


        oPaises = Nothing
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

        txt_Id.Enabled = False
        txt_Descripcion.Enabled = False
        txt_Reducida.Enabled = False
        btn_SubirImagen.Enabled = False
        chk_Activo.Enabled = False

    End Sub

    Private Function Validar() As Boolean

        Dim oPaises As New Paises
        Dim oDs As New DataSet

        oDs = oPaises.BuscarPorID(txt_Id.Text)

        If oDs.Tables(0).Rows.Count > 0 Then

            Return False

        End If


        Return True

    End Function

#End Region

#Region "Botones de Comando"
    ''
    Protected Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click

        Select Case HF.Value
            Case 1
                If Validar() = True Then
                    If txt_Descripcion.Text <> Nothing And txt_Reducida.Text <> Nothing And btn_SubirImagen.HasFile = True Then
                        Dim oPaises As New Paises
                        Dim oDs As New Data.DataSet
                        Dim urlImagen As String
                        urlImagen = "/Imagenes/"

                        Dim nombre As String = btn_SubirImagen.FileName

                        btn_SubirImagen.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/") & nombre)


                        urlImagen = urlImagen & nombre

                        oPaises = New Paises
                        oPaises.Agregar(txt_Descripcion.Text, txt_Reducida.Text, urlImagen, 1)
                        Cargar_Grilla()
                        Limpiar()
                        lbl_Mensaje.ForeColor = Drawing.Color.Green
                        lbl_Mensaje.Text = "Cargado Correctamente :)"
                        oPaises = Nothing
                    Else
                        lbl_Mensaje.ForeColor = Drawing.Color.Red
                        lbl_Mensaje.Text = "Complete los campos vacios :("

                    End If
                End If


            Case 2
                If txt_Id.Text <> Nothing And txt_Descripcion.Text <> Nothing And txt_Reducida.Text <> Nothing And btn_SubirImagen.HasFile = True Then
                    Dim OPaises As New Paises
                    Dim oDs As New Data.DataSet
                    Dim urlImagen As String
                    urlImagen = "/Imagenes/"

                    Dim nombre As String = btn_SubirImagen.FileName

                    btn_SubirImagen.SaveAs(HttpContext.Current.Server.MapPath("./Imagenes/") & nombre)


                    urlImagen = urlImagen & nombre

                    OPaises = New Paises
                    oDs = New Data.DataSet
                    oDs = OPaises.BuscarPorID(txt_Id.Text)
                    If oDs.Tables(0).Rows.Count > 0 Then
                        oDs = New Data.DataSet
                        OPaises = New Paises
                        OPaises.Modificar(txt_Id.Text, txt_Descripcion.Text, txt_Reducida.Text, urlImagen, 1)
                        Cargar_Grilla()
                        Limpiar()
                        lbl_Mensaje.ForeColor = Drawing.Color.Green
                        lbl_Mensaje.Text = "Modificado Correctamente :)"
                        OPaises = Nothing
                    Else
                        lbl_Mensaje.ForeColor = Drawing.Color.Red
                        lbl_Mensaje.Text = "Error ID Incorrecto :("
                        OPaises = Nothing
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
        txt_Descripcion.Enabled = True
        txt_Reducida.Enabled = True
        btn_SubirImagen.Enabled = True
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
        txt_Id.Enabled = False

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