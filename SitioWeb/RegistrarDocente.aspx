<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrarDocente.aspx.cs" Inherits="RegistrarDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
    
    <h1 style="font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">Registrar Docente</h1>
        <div  runat="server">
             <table>
                 <tr>
                    <td>
                        <asp:Label ID="label1" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label2" runat="server" Text="Apellido Paterno"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtApellidoPaterno" runat="server" Height="25px" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="label3" runat="server" Text="Apellido Materno"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtApellidoMaterno" runat="server" Height="25px" Width="200px"></asp:TextBox>
                    </td>
                </tr>

                  <tr>
                    <td>
                        <asp:Label ID="label4" runat="server" Text="GradoId"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtGrado" runat="server" Height="25px" Width="200px"></asp:TextBox>
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
                       <asp:Button ID="btnListar" runat="server" Text="LISTAR" OnClick="btnListar_Click"/>
                   </td>

                   <td>
                       <asp:Button ID="btnBorrar" runat="server" Text="BORRAR" OnClick="btnBorrar_Click" />
                   </td>

               </tr>
           </table>

            <table class="aut-style7">
                <tr>
                    <td>
                        <asp:GridView ID="GridLis" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />

                        </asp:GridView>
                           
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>

