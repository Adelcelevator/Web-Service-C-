<%@ Page Title="" Language="C#" MasterPageFile="~/Vista.Master" AutoEventWireup="true" CodeBehind="cargo.aspx.cs" Inherits="WSconsumir.cargo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"> 
        <ContentTemplate>
        <asp:HiddenField ID="hdf_car" runat="server"></asp:HiddenField>
            <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
		<div class="row">
		<ol class="breadcrumb">
				<li><a href="#">
					<em class="fa fa-home"></em>
				</a></li>
				<li class="active">Listar Cargos</li>
			</ol>

			<div class="panel-body articles-container" >
			<div class="panel panel-default articles">
                <table class="table table-striped table-bordered table-hover dataTable no-footer dtr-inline collapsed">
                <tr>
                                                <td>
                                                Descripcion:
                                                </td>
                                                <td align="center">
                                                    <asp:TextBox ID="Txt_des" runat="server" CssClass="form-control"></asp:TextBox>
                                                </td>
                                            </tr>
               
                                            </tr>
                                            
                                               <tr>
                                                <td>
                                                Empleado:
                                                </td>
                                                <td align="center">
                                                    <asp:DropDownList ID="Dr_emp" runat="server" CssClass="form-control"></asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>

                                                </td>
                                                <td align="center">
                                                    <asp:Button ID="btn_guardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="btn_guardar_Click"  />&nbsp;&nbsp;<asp:Button ID="btn_actulizar"  CssClass="btn btn-warning"  runat="server" Text="Actulizar" OnClick="btn_actulizar_Click"  />&nbsp;&nbsp;<asp:Button ID="btn_eliminar"  runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClientClick="return confirm('esta seguro de eliminar?')" OnClick="btn_eliminar_Click"  />
                                                </td>
                                            </tr>
              <tr>
                                        <td colspan="4">
                                            <div>
                                            <asp:GridView ID="Grv_car"  AutoGenerateColumns="false" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline collapsed"  ViewStateMode="Enabled" >
                                                    <AlternatingRowStyle BackColor="White" />
                                                    <Columns>
                                                            
                                                            <asp:BoundField DataField="idCargos" HeaderText="Codigo" />
                                                            <asp:BoundField DataField="descripcionCar" HeaderText="Descripcion" />
                                                            <asp:BoundField DataField="estadoCar" HeaderText="Estado" />
                                                            <asp:BoundField DataField="nombreEmpl" HeaderText="Empleado" />
                                                            <asp:TemplateField>
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="Lnk_Seleccionar" CommandArgument='<%#Eval("idCargos") %>'  runat="server" OnClick="Lnk_Seleccionar_Click">Seleccionar</asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                  
                                                </asp:GridView>
                                            </div>
                                        </td>
                                    </tr>
                                   
                                </table>
                            </td>
                        </tr>
                           
                </td>
            </tr>
                   
			</table>
                     </div>
                </div>
            </div>
                </div>
            </ContentTemplate>
    </asp:UpdatePanel>
        </form>
</asp:Content>
