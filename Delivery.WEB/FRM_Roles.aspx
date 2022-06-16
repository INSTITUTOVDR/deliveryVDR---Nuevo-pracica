<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FRM_Roles.aspx.vb" Inherits="Delivery.WEB.FRM_Roles" %>

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
        .auto-style1 {
            height: 26px;
        }
        .auto-style8 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: medium;
        }
        .auto-style11 {
            height: 24px;
        }
        .auto-style2 {
            height: 26px;
            width: 154px;
        }
        .auto-style3 {
            width: 154px;
        }
        .auto-style15 {
            height: 30px;
        }
        .auto-style6 {
            height: 156px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td colspan="3">
                        <asp:ImageButton ID="btn_Logo" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Imagenes/Logo.png" Width="250px" />
&nbsp;<span class="auto-style7"><strong>Delivery - Roles</strong></span></td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="3">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="3">
                        <asp:Button ID="Btn_Paises" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Paises" Width="200px" />
&nbsp;<asp:Button ID="Btn_Roles" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Roles" Width="200px" />
&nbsp;<asp:Button ID="Btn_Paises1" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Paises" Width="200px" />
&nbsp;<asp:Button ID="Btn_Paises2" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Paises" Width="200px" />
&nbsp;<asp:Button ID="Btn_Paises3" runat="server" BackColor="#E51727" CssClass="auto-style8" ForeColor="White" Height="50px" Text="Paises" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1" colspan="3">
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
                    <td class="auto-style11" colspan="3">
                        <asp:Button ID="btn_Cargar" runat="server" Text="Guardar" Width="200px" />
                        &nbsp;<asp:Button ID="btn_Modificar" runat="server" Text="Modificar" Width="200px" />
                        &nbsp;<asp:Button ID="btn_Limpiar" runat="server" Text="Limpiar" Width="200px" />
                        &nbsp;<asp:Button ID="btn_ConsultarID" runat="server" Text="Consultar x ID" Width="200px" />
                    &nbsp;<asp:Button ID="btn_ConsultarTodo" runat="server" Text="Consultar Todo" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">ID</td>
                    <td class="auto-style1" colspan="2">
                        <asp:TextBox ID="txt_Id" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Nombre</td>
                    <td colspan="2">
                        <asp:TextBox ID="txt_Nombre" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Activo</td>
                    <td class="auto-style1" colspan="2">
                        <asp:CheckBox ID="chk_Activo" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
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
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1" colspan="2">
                        &nbsp;<asp:Button ID="btn_Cargar0" runat="server" Text="Aceptar" Width="200px" />
                        &nbsp;<asp:Button ID="btn_Cargar1" runat="server" Text="Cancelar" Width="200px" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style6">
                        &nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
    <%--<script>
        function test(input) {
            var imagen = input.
            console.log(imagen)
            document.getElementById("img_Pais").src = imagen
            //var reader = new FileReader();

            //reader.onload = function (e) {
            //    console.log(e.target.result)
            //    document.getElementById("img_Pais").src = e.target.result
            //     };
        }
    </script>--%>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
