﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Vista.Master" AutoEventWireup="true" CodeBehind="Vista.aspx.cs" Inherits="WSconsumir.Vista1" %>
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
				<li class="active">Bienvenido!</li>
			</ol>

			<div class="panel-body articles-container" >
			<div class="panel panel-default articles">
               
                     </div>
                </div>
            </div>
                </div>
            </ContentTemplate>
    </asp:UpdatePanel>
        </form>
</asp:Content>
