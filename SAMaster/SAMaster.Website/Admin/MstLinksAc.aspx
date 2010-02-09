
<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="MstLinksAc.aspx.cs" Inherits="MstLinksAc" Title="MstLinksAc List" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Mst Links Ac List</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:GridViewSearchPanel ID="GridViewSearchPanel1" runat="server" GridViewControlID="GridView1" PersistenceMethod="Session" />
		<br />
		<data:EntityGridView ID="GridView1" runat="server"			
				AutoGenerateColumns="False"					
				OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
				DataSourceID="MstLinksAcDataSource"
				DataKeyNames="MapinfoId"
				AllowMultiColumnSorting="false"
				DefaultSortColumnName="" 
				DefaultSortDirection="Ascending"	
				ExcelExportFileName="Export_MstLinksAc.xls"  		
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" ShowEditButton="True" />				
				<asp:BoundField DataField="MapinfoId" HeaderText="Mapinfo Id" SortExpression="[MAPINFO_ID]" ReadOnly="True" />
				<asp:BoundField DataField="MlinkId" HeaderText="Mlink Id" SortExpression="[MLinkID]"  />
				<asp:BoundField DataField="CompKey" HeaderText="Comp Key" SortExpression="[CompKey]"  />
				<data:HyperLinkField HeaderText="Us Node" DataNavigateUrlFormatString="MstNodesAcEdit.aspx?Node={0}" DataNavigateUrlFields="Node" DataContainer="UsNodeSource" DataTextField="Node" />
				<data:HyperLinkField HeaderText="Ds Node" DataNavigateUrlFormatString="MstNodesAcEdit.aspx?Node={0}" DataNavigateUrlFields="Node" DataContainer="DsNodeSource" DataTextField="Node" />
				<asp:BoundField DataField="PipeShape" HeaderText="Pipe Shape" SortExpression="[PipeShape]"  />
				<asp:BoundField DataField="LinkType" HeaderText="Link Type" SortExpression="[LinkType]"  />
				<asp:BoundField DataField="PipeFlowType" HeaderText="Pipe Flow Type" SortExpression="[PipeFlowType]"  />
				<asp:BoundField DataField="Length" HeaderText="Length" SortExpression="[Length]"  />
				<asp:BoundField DataField="DiamWidth" HeaderText="Diam Width" SortExpression="[DiamWidth]"  />
				<asp:BoundField DataField="Height" HeaderText="Height" SortExpression="[Height]"  />
				<asp:BoundField DataField="Material" HeaderText="Material" SortExpression="[Material]"  />
				<asp:BoundField DataField="Upsdpth" HeaderText="Upsdpth" SortExpression="[upsdpth]"  />
				<asp:BoundField DataField="Dwndpth" HeaderText="Dwndpth" SortExpression="[dwndpth]"  />
				<asp:BoundField DataField="Usie" HeaderText="Usie" SortExpression="[USIE]"  />
				<asp:BoundField DataField="Dsie" HeaderText="Dsie" SortExpression="[DSIE]"  />
				<asp:BoundField DataField="AsBuilt" HeaderText="As Built" SortExpression="[AsBuilt]"  />
				<asp:BoundField DataField="Instdate" DataFormatString="{0:d}" HtmlEncode="False" HeaderText="Instdate" SortExpression="[Instdate]"  />
				<asp:BoundField DataField="Fromx" HeaderText="Fromx" SortExpression="[FromX]"  />
				<asp:BoundField DataField="Fromy" HeaderText="Fromy" SortExpression="[FromY]"  />
				<asp:BoundField DataField="Tox" HeaderText="Tox" SortExpression="[ToX]"  />
				<asp:BoundField DataField="Toy" HeaderText="Toy" SortExpression="[ToY]"  />
				<asp:BoundField DataField="Roughness" HeaderText="Roughness" SortExpression="[Roughness]"  />
				<asp:BoundField DataField="TimeFrame" HeaderText="Time Frame" SortExpression="[TimeFrame]"  />
				<asp:BoundField DataField="DataFlagSynth" HeaderText="Data Flag Synth" SortExpression="[DataFlagSynth]"  />
				<asp:BoundField DataField="DataQual" HeaderText="Data Qual" SortExpression="[DataQual]"  />
				<asp:BoundField DataField="Hservstat" HeaderText="Hservstat" SortExpression="[Hservstat]"  />
				<asp:BoundField DataField="ValidFromDate" HeaderText="Valid From Date" SortExpression="[ValidFromDate]"  />
				<asp:BoundField DataField="ValidToDate" HeaderText="Valid To Date" SortExpression="[ValidToDate]"  />
				<asp:BoundField DataField="CadKey" HeaderText="Cad Key" SortExpression="[CADKey]"  />
				<asp:BoundField DataField="AuditNodeId" HeaderText="Audit Node Id" SortExpression="[AuditNodeID]"  />
				<asp:BoundField DataField="AuditDups" HeaderText="Audit Dups" SortExpression="[AuditDups]"  />
				<asp:BoundField DataField="AuditSpatial" HeaderText="Audit Spatial" SortExpression="[AuditSpatial]"  />
				<data:BoundRadioButtonField DataField="AuditOk2Go" HeaderText="Audit Ok2 Go" SortExpression="[AuditOK2Go]"  />
				<asp:BoundField DataField="AuditProcTimestamp" HeaderText="Audit Proc Timestamp" SortExpression="[AuditProcTimestamp]"  />
				<asp:BoundField DataField="Qdes" HeaderText="Qdes" SortExpression="[Qdes]"  />
				<asp:BoundField DataField="DmeGlobalId" HeaderText="Dme Global Id" SortExpression="[DME_GlobalID]"  />
			</Columns>
			<EmptyDataTemplate>
				<b>No MstLinksAc Found!</b>
			</EmptyDataTemplate>
		</data:EntityGridView>
		<br />
		<asp:Button runat="server" ID="btnMstLinksAc" OnClientClick="javascript:location.href='MstLinksAcEdit.aspx'; return false;" Text="Add New"></asp:Button>
		<data:MstLinksAcDataSource ID="MstLinksAcDataSource" runat="server"
			SelectMethod="GetPaged"
			EnablePaging="True"
			EnableSorting="True"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:MstLinksAcProperty Name="MstNodesAc"/> 
				</Types>
			</DeepLoadProperties>
			<Parameters>
				<data:CustomParameter Name="WhereClause" Value="" ConvertEmptyStringToNull="false" />
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" />
				<asp:ControlParameter Name="PageIndex" ControlID="GridView1" PropertyName="PageIndex" Type="Int32" />
				<asp:ControlParameter Name="PageSize" ControlID="GridView1" PropertyName="PageSize" Type="Int32" />
				<data:CustomParameter Name="RecordCount" Value="0" Type="Int32" />
			</Parameters>
		</data:MstLinksAcDataSource>
	    		
</asp:Content>



