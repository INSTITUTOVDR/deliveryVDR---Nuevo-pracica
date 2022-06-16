<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FRM_Registro.aspx.vb" Inherits="Delivery.WEB.FRM_Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style1 {
        }
        #Button1 {
            width: 13px;
        }
    </style>
</head>
<body>
    <form id="FRM_Registro" runat="server">   
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">
                        <asp:ImageButton ID="btn_Logo" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Imagenes/Logo.png" Width="250px" />
                        Registro</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="3">
                    <hr style="color: #E51727" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nombre</td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Usuario</td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña</td>
                <td>
                    <asp:TextBox ID="txtContraseña" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Confirmar contraseña</td>
                <td>
                    <asp:TextBox ID="txtConfirmarcontraseña" runat="server" TextMode="Password"></asp:TextBox>
                    <%--<asp:Button ID="Button1" runat="server" Text="Button" />--%>
                    <a href="#" onclick="MostrarContraseña()"> <img src="Imagenes/mostrar%20contraseña.png" style="height: 25px; width: 25px" /></a></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td id="lblAviso">
                    <asp:Label ID="lbl_Mensaje" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnRegistro" runat="server" Text="Registar" OnClick="btnRegistro_Click" BackColor="#E51727" ForeColor="White" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" BackColor="#E51727" ForeColor="White" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <script>    function MostrarContraseña() {
        var tipo = document.getElementById("txtConfirmarcontraseña");

        if (tipo.type == "password") {
            tipo.type = "text";
        }
        else {
            tipo.type = "password";
        } 

    }    </script>
  
</body>
</html>
