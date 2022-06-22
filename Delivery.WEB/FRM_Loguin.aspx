<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FRM_Loguin.aspx.vb" Inherits="Delivery.WEB.FRM_Loguin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 116px;
        }
        .auto-style2 {
            width: 126px;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            width: 116px;
            height: 29px;
        }
        .auto-style6 {
            width: 126px;
            height: 29px;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style8 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <div class="auto-style8">
                        <asp:ImageButton ID="btn_Logo" runat="server" Height="200px" ImageAlign="Middle" ImageUrl="~/Imagenes/Logo.png" Width="250px" />
&nbsp;<span class="auto-style7"><strong>Delivery - Roles</strong></span></div>
        <table class="auto-style4">
            <tr>
                <td class="auto-style1">Usuario</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Txt_Usuario" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Contraseña</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txt_Contraseña" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style8" colspan="2">
                    <asp:Label ID="LblMensaje" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Btn_Ingresar" runat="server" BackColor="#E51727" ForeColor="White" Text="Ingresar" Height="46px" Width="123px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Conn %>" SelectCommand="ConsultaLoguin" SelectCommandType="StoredProcedure">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="Txt_Usuario" Name="nomUsuerio" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="txt_Contraseña" Name="clave" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
