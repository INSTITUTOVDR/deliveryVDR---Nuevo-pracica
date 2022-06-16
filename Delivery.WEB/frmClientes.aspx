<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmClientes.aspx.vb" Inherits="Delivery.WEB.frmClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style7 {
            width: 197px;
        }
        .auto-style8 {
            width: 63px;
        }
        .auto-style12 {
            height: 21px;
            width: 248px;
        }
        .auto-style13 {
            height: 21px;
        }
        .auto-style15 {
            height: 30px;
        }
        .auto-style16 {
            width: 135px;
        }
        .auto-style17 {
            height: 23px;
            width: 135px;
        }
        .auto-style18 {
            height: 23px;
            width: 191px;
        }
        .auto-style19 {
            width: 191px;
        }
        .auto-style20 {
            margin-left: 31px;
        }
        .auto-style21 {
            height: 23px;
            width: 248px;
        }
        .auto-style22 {
            width: 248px;
        }
        .auto-style25 {
            height: 23px;
            width: 199px;
        }
        .auto-style26 {
            width: 199px;
        }
        .auto-style27 {
            margin-bottom: 2px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style26">
                        <asp:ImageButton ID="btn_Logo" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Imagenes/Logo.png" Width="250px" />
                    </td>
                    <td class="auto-style7"><strong>Delivery - Clientes</strong></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style25">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style25">
                        <asp:HiddenField ID="HF" runat="server" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style1"></td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="dgvGrillaClientes" runat="server" Height="195px" Width="856px">
        </asp:GridView>
        <table style="width:100%;">
            <tr>
                <td class="auto-style22">
                        <asp:Button ID="btn_Guardar" runat="server" Text="Agregar" Width="200px" />
                        </td>
                <td class="auto-style16">
                        <asp:Button ID="btn_Modificar" runat="server" Text="Modificar" Width="200px" />
                        </td>
                <td class="auto-style19">
                        <asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" Width="200px" />
                        </td>
                <td class="auto-style7">
                        <asp:Button ID="btn_ConsultarXID" runat="server" Text="Consultar por ID" Width="200px" />
                        </td>
                <td class="auto-style8">
                        <asp:Button ID="btn_ConsultarTodo" runat="server" Text="Consultar Todo" Width="200px" CssClass="auto-style20" />
                        </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style17">
                        &nbsp;</td>
                    <td class="auto-style18">
                        &nbsp;</td>
                </tr>
            <tr>
                    <td class="auto-style22">ID</td>
                    <td class="auto-style1" colspan="2">
                        <asp:TextBox ID="txt_IdCliente" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                    <td class="auto-style21">Nombre</td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_Nombre" runat="server" Width="200px" CssClass="auto-style27"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                    <td class="auto-style21">Apellido</td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_Apellido" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                    <td class="auto-style21">Tipo de cliente</td>
                    <td colspan="2">
                        <asp:DropDownList ID="cboTipoCliente" runat="server" Height="21px" Width="207px">
                        </asp:DropDownList>
                    </td>
                </tr>
            <tr>
                    <td class="auto-style21">Email</td>
                    <td colspan="2">
                        <asp:TextBox ID="txtEmail" runat="server" Width="194px"></asp:TextBox>
                    </td>
                </tr>
            <tr>
                    <td class="auto-style12">Dirección</td>
                    <td colspan="2" class="auto-style13">
                        
                        <asp:TextBox ID="txtDireccion" runat="server" Width="194px"></asp:TextBox>

                    </td>
                </tr>
            <tr>
                    <td class="auto-style12">Telefono</td>
                    <td colspan="2" class="auto-style13">
                        
                        <asp:TextBox ID="TextBox2" runat="server" Width="193px"></asp:TextBox>

                    </td>
                </tr>
            <tr>
                    <td class="auto-style22">Activo</td>
                    <td class="auto-style1" colspan="2">
                        <asp:CheckBox ID="chk_Activo" runat="server" />
                    </td>
                </tr>
            <tr>
                    <td class="auto-style22"></td>
                    <td class="auto-style1" colspan="2">
                        <asp:Label ID="lbl_Mensaje" runat="server" Text="Error"></asp:Label>
                        &nbsp;&nbsp;</td>
                </tr>
            <tr>
                    <td class="auto-style15" colspan="3">
                        <hr />
                    </td>
                </tr>
            <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style1" colspan="2">
                        &nbsp;<asp:Button ID="btn_Aceptar" runat="server" Text="Aceptar" Width="200px" />
                        &nbsp;<asp:Button ID="btn_Cancelar" runat="server" Text="Cancelar" Width="200px" />
                        &nbsp;</td>
                </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>
