<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ConsultarDocente.aspx.cs" Inherits="ConsultarDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
    <h1 style="font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">Visualizar Docente</h1>
        <div  runat="server">
            <table> 
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblCodigo0" runat="server" Text="DocenteId "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDocente" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
                <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Nombre "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblNombres0" runat="server" Text="Apellido Paterno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellidosPaterno" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblApellidosMaterno" runat="server" Text="Apellido Materno"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellidoMaterno" runat="server" Height="32px" Width="276px"></asp:TextBox>
                </td>
            </tr>
                 <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="GradoId"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtGrado" runat="server" Height="32px" Width="276px"></asp:TextBox>
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
                    <asp:Button ID="btnConsultar" runat="server" Text="CONSULTAR" Width="148px" OnClick="btnConsultar_Click"   />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" Width="148px" OnClick="btnBorrar_Click"  />
                </td>
                <td>
                    <asp:Button ID="btnSalir" runat="server" Text="RETORNAR" Width="148px" OnClick="btnSalir_Click"  />
                </td>
            </tr>
        </table>



            </div>
</asp:Content>

