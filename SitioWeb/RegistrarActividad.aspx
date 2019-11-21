<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrarActividad.aspx.cs" Inherits="RegistrarActividad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    
    <h1 style="font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">Registrar Actividad</h1>
        <div  runat="server">
             <table>
                 <tr>
                    <td>
                        <asp:Label ID="label1" runat="server" Text="Descripcion De Actividad"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtVDESC_ACTIVIDAD" runat="server" Height="58px" Width="305px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Fecha De Actividad"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDFEC_ACTIVIDAD" runat="server" Height="43px" Width="299px"></asp:TextBox>
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
           <table class="auto-style4">
               <tr>
                   <td>
                       <asp:Button ID="btnRegistrar" runat="server" Text="REGISTRAR" OnClick="btnRegistrar_Click"  />
                   </td>

                   <td>
                       <asp:Button ID="btnListar" runat="server" Text="LISTAR" OnClick="btnListar_Click"  />
                   </td>

                   <td>
                       <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" OnClick="btnBorrar_Click" />
                   </td>

               </tr>
           </table>
             <table class="aut-style7">
                <tr>
                    <td>
                        <asp:GridView ID="GridLis" runat="server" HorizontalAlign="Center">
                           
                        </asp:GridView>
                           
                    </td>
                </tr>
            </table>

            </div>
</asp:Content>

