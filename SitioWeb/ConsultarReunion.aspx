<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ConsultarReunion.aspx.cs" Inherits="ConsultarReunion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    <h1 style="font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">Visualizar Reunion</h1>
        <div  runat="server">
            <table> 
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblCodigo0" runat="server" Text="Codigo Reunion "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCodigoReunion" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Fecha Reunion "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFecha" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblNombres0" runat="server" Text="DHENT"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDHENT" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblApellidosMaterno" runat="server" Text="DHSAL"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDHSAL" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Lugar"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLugar" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>

                 <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Codigo Docente"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtcodDocente" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
            
        </table>
            <table class="auto-style2">
                <tr>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>

            <table class="auto-style2">
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="btnConsultar" runat="server" Text="CONSULTAR" Width="148px" OnClick="btnConsultar_Click"  />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" Width="148px" OnClick="btnBorrar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnSalir" runat="server" Text="RETORNAR" Width="148px" OnClick="btnSalir_Click" />
                </td>
            </tr>
        </table>



            </div>
</asp:Content>

