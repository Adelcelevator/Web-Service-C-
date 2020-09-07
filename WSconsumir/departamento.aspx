<%@ Page Title="" Language="C#" MasterPageFile="~/Vista.Master" AutoEventWireup="true" CodeBehind="departamento.aspx.cs" Inherits="WSconsumir.departamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server"> 
        <ContentTemplate>
        <asp:HiddenField ID="hdf_dep" runat="server"></asp:HiddenField>
            <div class="col-sm-9 col-sm-offset-3 col-lg-10 col-lg-offset-2 main">
		<div class="row">
		<ol class="breadcrumb">
				<li><a href="#">
					<em class="fa fa-home"></em>
				</a></li>
				<li class="active">Listar Departamentos</li>
			</ol>

			<div class="panel-body articles-container" >
			<div class="panel panel-default articles">
			
			<table class="table table-striped table-bordered table-hover dataTable no-footer dtr-inline collapsed">
                <tr>
                                              
                                            <td>Descripcion: </td>
                                            <td align="center">
                                                <asp:TextBox ID="Txt_des" runat="server" CssClass="form-control"></asp:TextBox>
                                            </td>
                <tr>
                    <td>Empresa: </td>
                    <td align="center">
                        <asp:DropDownList ID="Dr_emp" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td align="center">
                        <asp:Button ID="btn_guardar" runat="server" CssClass="btn btn-success" OnClick="btn_guardar_Click" Text="Guardar"  />
                        &nbsp;&nbsp;<asp:Button ID="btn_actulizar" runat="server" CssClass="btn btn-warning" OnClick="btn_actulizar_Click" Text="Actulizar" />
                        &nbsp;&nbsp;<asp:Button ID="btn_eliminar" runat="server" CssClass="btn btn-danger" OnClick="btn_eliminar_Click" OnClientClick="return confirm('esta seguro de eliminar?')" Text="Eliminar" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <div>
                            <asp:GridView ID="Grv_dep" runat="server" AutoGenerateColumns="false" CellPadding="4" CssClass="table table-striped table-bordered table-hover dataTable no-footer dtr-inline collapsed" ForeColor="#333333" GridLines="None" ViewStateMode="Enabled">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="idDepartamento" HeaderText="id" />
                                    <asp:BoundField DataField="descripcionDep" HeaderText="Descripcion" />
                                    <asp:BoundField DataField="estadoDep" HeaderText="Estado" />
                                    <asp:BoundField DataField="nombreEmp" HeaderText="Empresa" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="Lnk_Seleccionar" runat="server" CommandArgument='<%#Eval("idDepartamento") %>' OnClick="Lnk_Seleccionar_Click">Seleccionar</asp:LinkButton>
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
