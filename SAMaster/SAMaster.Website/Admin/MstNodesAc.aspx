
<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="MstNodesAc.aspx.cs" Inherits="MstNodesAc" Title="MstNodesAc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Mst Nodes Ac List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="MstNodesAcDataSource"
				DataKeyNames="MapinfoId"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_MstNodesAc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MapinfoId" HeaderText="Mapinfo Id" SortExpression="[MAPINFO_ID]" ReadOnly="True" />
				<asp:BoundField DataField="Node" HeaderText="Node" SortExpression="[Node]"  />
				<asp:BoundField DataField="Xcoord" HeaderText="Xcoord" SortExpression="[XCoord]"  />
				<asp:BoundField DataField="Ycoord" HeaderText="Ycoord" SortExpression="[YCoord]"  />
				<asp:BoundField DataField="NodeType" HeaderText="Node Type" SortExpression="[NodeType]"  />
				<asp:BoundField DataField="GrndElev" HeaderText="Grnd Elev" SortExpression="[GrndElev]"  />
				<asp:BoundField DataField="HasSpecNode" HeaderText="Has Spec Node" SortExpression="[HasSpecNode]"  />
				<asp:BoundField DataField="HasSpecLink" HeaderText="Has Spec Link" SortExpression="[HasSpecLink]"  />
				<asp:BoundField DataField="GageId" HeaderText="Gage Id" SortExpression="[GageID]"  />
				<asp:BoundField DataField="DmeGlobalId" HeaderText="Dme Global Id" SortExpression="[DME_GlobalID]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No MstNodesAc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnMstNodesAc" OnClientClick="javascript:location.href='MstNodesAcEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:MstNodesAcDataSource ID="MstNodesAcDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
		>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:MstNodesAcDataSource>
	    		
</asp:Content>



