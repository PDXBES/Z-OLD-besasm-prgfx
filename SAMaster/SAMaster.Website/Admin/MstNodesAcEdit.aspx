<%@ Page Language="C#" Theme="Default" MasterPageFile="~/MasterPages/admin.master" AutoEventWireup="true"  CodeFile="MstNodesAcEdit.aspx.cs" Inherits="MstNodesAcEdit" Title="MstNodesAc Edit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">Mst Nodes Ac - Add/Edit</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
		<data:MultiFormView ID="FormView1" DataKeyNames="MapinfoId" runat="server" DataSourceID="MstNodesAcDataSource">
		
			<EditItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/MstNodesAcFields.ascx" />
			</EditItemTemplatePaths>
		
			<InsertItemTemplatePaths>
				<data:TemplatePath Path="~/Admin/UserControls/MstNodesAcFields.ascx" />
			</InsertItemTemplatePaths>
		
			<EmptyDataTemplate>
				<b>MstNodesAc not found!</b>
			</EmptyDataTemplate>
			
			<FooterTemplate>
				<asp:Button ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
				<asp:Button ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
				<asp:Button ID="CancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
			</FooterTemplate>

		</data:MultiFormView>
		
		<data:MstNodesAcDataSource ID="MstNodesAcDataSource" runat="server"
			SelectMethod="GetByMapinfoId"
		>
			<Parameters>
				<asp:QueryStringParameter Name="MapinfoId" QueryStringField="MapinfoId" Type="String" />

			</Parameters>
		</data:MstNodesAcDataSource>
		
		<br />

		<data:EntityGridView ID="GridViewMstLinksAc1" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewMstLinksAc1_SelectedIndexChanged"			 			 
			DataSourceID="MstLinksAcDataSource1"
			DataKeyNames="MapinfoId"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_MstLinksAc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MlinkId" HeaderText="Mlink Id" SortExpression="[MLinkID]" />				
				<asp:BoundField DataField="CompKey" HeaderText="Comp Key" SortExpression="[CompKey]" />				
				<data:HyperLinkField HeaderText="Us Node" DataNavigateUrlFormatString="MstNodesAcEdit.aspx?Node={0}" DataNavigateUrlFields="Node" DataContainer="UsNodeSource" DataTextField="Node" />
				<data:HyperLinkField HeaderText="Ds Node" DataNavigateUrlFormatString="MstNodesAcEdit.aspx?Node={0}" DataNavigateUrlFields="Node" DataContainer="DsNodeSource" DataTextField="Node" />
				<asp:BoundField DataField="PipeShape" HeaderText="Pipe Shape" SortExpression="[PipeShape]" />				
				<asp:BoundField DataField="LinkType" HeaderText="Link Type" SortExpression="[LinkType]" />				
				<asp:BoundField DataField="PipeFlowType" HeaderText="Pipe Flow Type" SortExpression="[PipeFlowType]" />				
				<asp:BoundField DataField="Length" HeaderText="Length" SortExpression="[Length]" />				
				<asp:BoundField DataField="DiamWidth" HeaderText="Diam Width" SortExpression="[DiamWidth]" />				
				<asp:BoundField DataField="Height" HeaderText="Height" SortExpression="[Height]" />				
				<asp:BoundField DataField="Material" HeaderText="Material" SortExpression="[Material]" />				
				<asp:BoundField DataField="Upsdpth" HeaderText="Upsdpth" SortExpression="[upsdpth]" />				
				<asp:BoundField DataField="Dwndpth" HeaderText="Dwndpth" SortExpression="[dwndpth]" />				
				<asp:BoundField DataField="Usie" HeaderText="Usie" SortExpression="[USIE]" />				
				<asp:BoundField DataField="Dsie" HeaderText="Dsie" SortExpression="[DSIE]" />				
				<asp:BoundField DataField="AsBuilt" HeaderText="As Built" SortExpression="[AsBuilt]" />				
				<asp:BoundField DataField="Instdate" HeaderText="Instdate" SortExpression="[Instdate]" />				
				<asp:BoundField DataField="Fromx" HeaderText="Fromx" SortExpression="[FromX]" />				
				<asp:BoundField DataField="Fromy" HeaderText="Fromy" SortExpression="[FromY]" />				
				<asp:BoundField DataField="Tox" HeaderText="Tox" SortExpression="[ToX]" />				
				<asp:BoundField DataField="Toy" HeaderText="Toy" SortExpression="[ToY]" />				
				<asp:BoundField DataField="Roughness" HeaderText="Roughness" SortExpression="[Roughness]" />				
				<asp:BoundField DataField="TimeFrame" HeaderText="Time Frame" SortExpression="[TimeFrame]" />				
				<asp:BoundField DataField="DataFlagSynth" HeaderText="Data Flag Synth" SortExpression="[DataFlagSynth]" />				
				<asp:BoundField DataField="DataQual" HeaderText="Data Qual" SortExpression="[DataQual]" />				
				<asp:BoundField DataField="Hservstat" HeaderText="Hservstat" SortExpression="[Hservstat]" />				
				<asp:BoundField DataField="ValidFromDate" HeaderText="Valid From Date" SortExpression="[ValidFromDate]" />				
				<asp:BoundField DataField="ValidToDate" HeaderText="Valid To Date" SortExpression="[ValidToDate]" />				
				<asp:BoundField DataField="CadKey" HeaderText="Cad Key" SortExpression="[CADKey]" />				
				<asp:BoundField DataField="AuditNodeId" HeaderText="Audit Node Id" SortExpression="[AuditNodeID]" />				
				<asp:BoundField DataField="AuditDups" HeaderText="Audit Dups" SortExpression="[AuditDups]" />				
				<asp:BoundField DataField="AuditSpatial" HeaderText="Audit Spatial" SortExpression="[AuditSpatial]" />				
				<asp:BoundField DataField="AuditOk2Go" HeaderText="Audit Ok2 Go" SortExpression="[AuditOK2Go]" />				
				<asp:BoundField DataField="AuditProcTimestamp" HeaderText="Audit Proc Timestamp" SortExpression="[AuditProcTimestamp]" />				
				<asp:BoundField DataField="Qdes" HeaderText="Qdes" SortExpression="[Qdes]" />				
				<asp:BoundField DataField="DmeGlobalId" HeaderText="Dme Global Id" SortExpression="[DME_GlobalID]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Mst Links Ac Found! </b>
				<asp:HyperLink runat="server" ID="hypMstLinksAc" NavigateUrl="~/admin/MstLinksAcEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:MstLinksAcDataSource ID="MstLinksAcDataSource1" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:MstLinksAcProperty Name="MstNodesAc"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:MstLinksAcFilter  Column="DsNode" QueryStringField="MapinfoId" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:MstLinksAcDataSource>		
		
		<br />
		<data:EntityGridView ID="GridViewMstLinksAc2" runat="server"
			AutoGenerateColumns="False"	
			OnSelectedIndexChanged="GridViewMstLinksAc2_SelectedIndexChanged"			 			 
			DataSourceID="MstLinksAcDataSource2"
			DataKeyNames="MapinfoId"
			AllowMultiColumnSorting="false"
			DefaultSortColumnName="" 
			DefaultSortDirection="Ascending"	
			ExcelExportFileName="Export_MstLinksAc.xls"  		
			Visible='<%# (FormView1.DefaultMode == FormViewMode.Insert) ? false : true %>'	
			>
			<Columns>
				<asp:CommandField ShowSelectButton="True" />
				<asp:BoundField DataField="MlinkId" HeaderText="Mlink Id" SortExpression="[MLinkID]" />				
				<asp:BoundField DataField="CompKey" HeaderText="Comp Key" SortExpression="[CompKey]" />				
				<data:HyperLinkField HeaderText="Us Node" DataNavigateUrlFormatString="MstNodesAcEdit.aspx?Node={0}" DataNavigateUrlFields="Node" DataContainer="UsNodeSource" DataTextField="Node" />
				<data:HyperLinkField HeaderText="Ds Node" DataNavigateUrlFormatString="MstNodesAcEdit.aspx?Node={0}" DataNavigateUrlFields="Node" DataContainer="DsNodeSource" DataTextField="Node" />
				<asp:BoundField DataField="PipeShape" HeaderText="Pipe Shape" SortExpression="[PipeShape]" />				
				<asp:BoundField DataField="LinkType" HeaderText="Link Type" SortExpression="[LinkType]" />				
				<asp:BoundField DataField="PipeFlowType" HeaderText="Pipe Flow Type" SortExpression="[PipeFlowType]" />				
				<asp:BoundField DataField="Length" HeaderText="Length" SortExpression="[Length]" />				
				<asp:BoundField DataField="DiamWidth" HeaderText="Diam Width" SortExpression="[DiamWidth]" />				
				<asp:BoundField DataField="Height" HeaderText="Height" SortExpression="[Height]" />				
				<asp:BoundField DataField="Material" HeaderText="Material" SortExpression="[Material]" />				
				<asp:BoundField DataField="Upsdpth" HeaderText="Upsdpth" SortExpression="[upsdpth]" />				
				<asp:BoundField DataField="Dwndpth" HeaderText="Dwndpth" SortExpression="[dwndpth]" />				
				<asp:BoundField DataField="Usie" HeaderText="Usie" SortExpression="[USIE]" />				
				<asp:BoundField DataField="Dsie" HeaderText="Dsie" SortExpression="[DSIE]" />				
				<asp:BoundField DataField="AsBuilt" HeaderText="As Built" SortExpression="[AsBuilt]" />				
				<asp:BoundField DataField="Instdate" HeaderText="Instdate" SortExpression="[Instdate]" />				
				<asp:BoundField DataField="Fromx" HeaderText="Fromx" SortExpression="[FromX]" />				
				<asp:BoundField DataField="Fromy" HeaderText="Fromy" SortExpression="[FromY]" />				
				<asp:BoundField DataField="Tox" HeaderText="Tox" SortExpression="[ToX]" />				
				<asp:BoundField DataField="Toy" HeaderText="Toy" SortExpression="[ToY]" />				
				<asp:BoundField DataField="Roughness" HeaderText="Roughness" SortExpression="[Roughness]" />				
				<asp:BoundField DataField="TimeFrame" HeaderText="Time Frame" SortExpression="[TimeFrame]" />				
				<asp:BoundField DataField="DataFlagSynth" HeaderText="Data Flag Synth" SortExpression="[DataFlagSynth]" />				
				<asp:BoundField DataField="DataQual" HeaderText="Data Qual" SortExpression="[DataQual]" />				
				<asp:BoundField DataField="Hservstat" HeaderText="Hservstat" SortExpression="[Hservstat]" />				
				<asp:BoundField DataField="ValidFromDate" HeaderText="Valid From Date" SortExpression="[ValidFromDate]" />				
				<asp:BoundField DataField="ValidToDate" HeaderText="Valid To Date" SortExpression="[ValidToDate]" />				
				<asp:BoundField DataField="CadKey" HeaderText="Cad Key" SortExpression="[CADKey]" />				
				<asp:BoundField DataField="AuditNodeId" HeaderText="Audit Node Id" SortExpression="[AuditNodeID]" />				
				<asp:BoundField DataField="AuditDups" HeaderText="Audit Dups" SortExpression="[AuditDups]" />				
				<asp:BoundField DataField="AuditSpatial" HeaderText="Audit Spatial" SortExpression="[AuditSpatial]" />				
				<asp:BoundField DataField="AuditOk2Go" HeaderText="Audit Ok2 Go" SortExpression="[AuditOK2Go]" />				
				<asp:BoundField DataField="AuditProcTimestamp" HeaderText="Audit Proc Timestamp" SortExpression="[AuditProcTimestamp]" />				
				<asp:BoundField DataField="Qdes" HeaderText="Qdes" SortExpression="[Qdes]" />				
				<asp:BoundField DataField="DmeGlobalId" HeaderText="Dme Global Id" SortExpression="[DME_GlobalID]" />				
			</Columns>
			<EmptyDataTemplate>
				<b>No Mst Links Ac Found! </b>
				<asp:HyperLink runat="server" ID="hypMstLinksAc" NavigateUrl="~/admin/MstLinksAcEdit.aspx">Add New</asp:HyperLink>
			</EmptyDataTemplate>
		</data:EntityGridView>					
		
		<data:MstLinksAcDataSource ID="MstLinksAcDataSource2" runat="server" SelectMethod="Find"
			EnableDeepLoad="True"
			>
			<DeepLoadProperties Method="IncludeChildren" Recursive="False">
	            <Types>
					<data:MstLinksAcProperty Name="MstNodesAc"/> 
				</Types>
			</DeepLoadProperties>
			
		    <Parameters>
				<data:SqlParameter Name="Parameters">
					<Filters>
						<data:MstLinksAcFilter  Column="UsNode" QueryStringField="MapinfoId" /> 
					</Filters>
				</data:SqlParameter>
				<data:CustomParameter Name="OrderByClause" Value="" ConvertEmptyStringToNull="false" /> 
		    </Parameters>
		</data:MstLinksAcDataSource>		
		
		<br />
		

</asp:Content>

