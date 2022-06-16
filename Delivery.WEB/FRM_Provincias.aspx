<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FRM_Provincias.aspx.vb" Inherits="Delivery.WEB.FRM_Provincias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style7 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
        }
        .auto-style8 {
            height: 12px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="3">
                        <asp:ImageButton ID="btn_Logo" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Imagenes/Logo.png" Width="250px" />
&nbsp;<span class="auto-style7"><strong>Delivery - Provincias</strong></span></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Btn_Provincias" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Provincias" Width="200px" />
&nbsp;<asp:Button ID="Btn_Paises0" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Provincias" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="3"></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="grd_Lista" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="1020px">
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <SortedAscendingCellStyle BackColor="#FEFCEB" />
                            <SortedAscendingHeaderStyle BackColor="#AF0101" />
                            <SortedDescendingCellStyle BackColor="#F6F0C0" />
                            <SortedDescendingHeaderStyle BackColor="#7E0000" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="btn_Cargar" runat="server" Text="Guardar" Width="200px" />
                        &nbsp;&nbsp;
                        <asp:Button ID="btn_Modificar" runat="server" Text="Modificar" Width="200px" />
                        &nbsp;
                        <asp:Button ID="btn_ConsultarTodo" runat="server" Text="Consultar Todo" Width="200px" />
                        &nbsp;
                        <asp:Button ID="btn_Cargar3" runat="server" Text="Consultar  por ID" Width="200px" />
                        &nbsp;
                        <asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" Width="200px" />
                        </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>ID</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Descripción:</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
