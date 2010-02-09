<%@ Control Language="C#" ClassName="MstLinksAcFields" %>

<asp:FormView ID="FormView1" runat="server">
	<ItemTemplate>
		<table border="0" cellpadding="3" cellspacing="1">
			<tr>
        <td class="literal"><asp:Label ID="lbldataMapinfoId" runat="server" Text="Mapinfo Id:" AssociatedControlID="dataMapinfoId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMapinfoId" Text='<%# Bind("MapinfoId") %>'></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataMapinfoId" runat="server" Display="Dynamic" ControlToValidate="dataMapinfoId" ErrorMessage="Required"></asp:RequiredFieldValidator><asp:RangeValidator ID="RangeVal_dataMapinfoId" runat="server" Display="Dynamic" ControlToValidate="dataMapinfoId" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMlinkId" runat="server" Text="Mlink Id:" AssociatedControlID="dataMlinkId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMlinkId" Text='<%# Bind("MlinkId") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataMlinkId" runat="server" Display="Dynamic" ControlToValidate="dataMlinkId" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCompKey" runat="server" Text="Comp Key:" AssociatedControlID="dataCompKey" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCompKey" Text='<%# Bind("CompKey") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataCompKey" runat="server" Display="Dynamic" ControlToValidate="dataCompKey" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUsNode" runat="server" Text="Us Node:" AssociatedControlID="dataUsNode" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataUsNode" DataSourceID="UsNodeMstNodesAcDataSource" DataTextField="Node" DataValueField="Node" SelectedValue='<%# Bind("UsNode") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:MstNodesAcDataSource ID="UsNodeMstNodesAcDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDsNode" runat="server" Text="Ds Node:" AssociatedControlID="dataDsNode" /></td>
        <td>
					<data:EntityDropDownList runat="server" ID="dataDsNode" DataSourceID="DsNodeMstNodesAcDataSource" DataTextField="Node" DataValueField="Node" SelectedValue='<%# Bind("DsNode") %>' AppendNullItem="true" Required="false" NullItemText="< Please Choose ...>" />
					<data:MstNodesAcDataSource ID="DsNodeMstNodesAcDataSource" runat="server" SelectMethod="GetAll"  />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPipeShape" runat="server" Text="Pipe Shape:" AssociatedControlID="dataPipeShape" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPipeShape" Text='<%# Bind("PipeShape") %>' MaxLength="4"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLinkType" runat="server" Text="Link Type:" AssociatedControlID="dataLinkType" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLinkType" Text='<%# Bind("LinkType") %>' MaxLength="2"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataPipeFlowType" runat="server" Text="Pipe Flow Type:" AssociatedControlID="dataPipeFlowType" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataPipeFlowType" Text='<%# Bind("PipeFlowType") %>' MaxLength="1"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataLength" runat="server" Text="Length:" AssociatedControlID="dataLength" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataLength" Text='<%# Bind("Length") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataLength" runat="server" Display="Dynamic" ControlToValidate="dataLength" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDiamWidth" runat="server" Text="Diam Width:" AssociatedControlID="dataDiamWidth" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDiamWidth" Text='<%# Bind("DiamWidth") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDiamWidth" runat="server" Display="Dynamic" ControlToValidate="dataDiamWidth" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHeight" runat="server" Text="Height:" AssociatedControlID="dataHeight" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHeight" Text='<%# Bind("Height") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataHeight" runat="server" Display="Dynamic" ControlToValidate="dataHeight" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataMaterial" runat="server" Text="Material:" AssociatedControlID="dataMaterial" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataMaterial" Text='<%# Bind("Material") %>' MaxLength="6"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUpsdpth" runat="server" Text="Upsdpth:" AssociatedControlID="dataUpsdpth" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUpsdpth" Text='<%# Bind("Upsdpth") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataUpsdpth" runat="server" Display="Dynamic" ControlToValidate="dataUpsdpth" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDwndpth" runat="server" Text="Dwndpth:" AssociatedControlID="dataDwndpth" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDwndpth" Text='<%# Bind("Dwndpth") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDwndpth" runat="server" Display="Dynamic" ControlToValidate="dataDwndpth" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataUsie" runat="server" Text="Usie:" AssociatedControlID="dataUsie" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataUsie" Text='<%# Bind("Usie") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataUsie" runat="server" Display="Dynamic" ControlToValidate="dataUsie" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDsie" runat="server" Text="Dsie:" AssociatedControlID="dataDsie" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDsie" Text='<%# Bind("Dsie") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDsie" runat="server" Display="Dynamic" ControlToValidate="dataDsie" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataAsBuilt" runat="server" Text="As Built:" AssociatedControlID="dataAsBuilt" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataAsBuilt" Text='<%# Bind("AsBuilt") %>' MaxLength="14"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataInstdate" runat="server" Text="Instdate:" AssociatedControlID="dataInstdate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataInstdate" Text='<%# Bind("Instdate", "{0:d}") %>' MaxLength="10"></asp:TextBox><asp:ImageButton ID="cal_dataInstdate" runat="server" SkinID="CalendarImageButton" OnClientClick="javascript:showCalendarControl(this.previousSibling);return false;" />
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataFromx" runat="server" Text="Fromx:" AssociatedControlID="dataFromx" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataFromx" Text='<%# Bind("Fromx") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataFromx" runat="server" Display="Dynamic" ControlToValidate="dataFromx" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataFromy" runat="server" Text="Fromy:" AssociatedControlID="dataFromy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataFromy" Text='<%# Bind("Fromy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataFromy" runat="server" Display="Dynamic" ControlToValidate="dataFromy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTox" runat="server" Text="Tox:" AssociatedControlID="dataTox" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTox" Text='<%# Bind("Tox") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataTox" runat="server" Display="Dynamic" ControlToValidate="dataTox" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataToy" runat="server" Text="Toy:" AssociatedControlID="dataToy" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataToy" Text='<%# Bind("Toy") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataToy" runat="server" Display="Dynamic" ControlToValidate="dataToy" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataRoughness" runat="server" Text="Roughness:" AssociatedControlID="dataRoughness" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataRoughness" Text='<%# Bind("Roughness") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataRoughness" runat="server" Display="Dynamic" ControlToValidate="dataRoughness" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataTimeFrame" runat="server" Text="Time Frame:" AssociatedControlID="dataTimeFrame" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataTimeFrame" Text='<%# Bind("TimeFrame") %>' MaxLength="2"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDataFlagSynth" runat="server" Text="Data Flag Synth:" AssociatedControlID="dataDataFlagSynth" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDataFlagSynth" Text='<%# Bind("DataFlagSynth") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDataFlagSynth" runat="server" Display="Dynamic" ControlToValidate="dataDataFlagSynth" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDataQual" runat="server" Text="Data Qual:" AssociatedControlID="dataDataQual" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDataQual" Text='<%# Bind("DataQual") %>' MaxLength="15"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHservstat" runat="server" Text="Hservstat:" AssociatedControlID="dataHservstat" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHservstat" Text='<%# Bind("Hservstat") %>' MaxLength="4"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataValidFromDate" runat="server" Text="Valid From Date:" AssociatedControlID="dataValidFromDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataValidFromDate" Text='<%# Bind("ValidFromDate") %>' MaxLength="8"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataValidToDate" runat="server" Text="Valid To Date:" AssociatedControlID="dataValidToDate" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataValidToDate" Text='<%# Bind("ValidToDate") %>' MaxLength="8"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataCadKey" runat="server" Text="Cad Key:" AssociatedControlID="dataCadKey" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataCadKey" Text='<%# Bind("CadKey") %>' MaxLength="14"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataAuditNodeId" runat="server" Text="Audit Node Id:" AssociatedControlID="dataAuditNodeId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataAuditNodeId" Text='<%# Bind("AuditNodeId") %>' MaxLength="20"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataAuditDups" runat="server" Text="Audit Dups:" AssociatedControlID="dataAuditDups" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataAuditDups" Text='<%# Bind("AuditDups") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataAuditSpatial" runat="server" Text="Audit Spatial:" AssociatedControlID="dataAuditSpatial" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataAuditSpatial" Text='<%# Bind("AuditSpatial") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataAuditOk2Go" runat="server" Text="Audit Ok2 Go:" AssociatedControlID="dataAuditOk2Go" /></td>
        <td>
					<asp:RadioButtonList runat="server" ID="dataAuditOk2Go" SelectedValue='<%# Bind("AuditOk2Go") %>' RepeatDirection="Horizontal"><asp:ListItem Value="True" Text="Yes" Selected="True"></asp:ListItem><asp:ListItem Value="False" Text="No"></asp:ListItem></asp:RadioButtonList>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataAuditProcTimestamp" runat="server" Text="Audit Proc Timestamp:" AssociatedControlID="dataAuditProcTimestamp" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataAuditProcTimestamp" Text='<%# Bind("AuditProcTimestamp") %>' MaxLength="30"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataQdes" runat="server" Text="Qdes:" AssociatedControlID="dataQdes" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataQdes" Text='<%# Bind("Qdes") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataQdes" runat="server" Display="Dynamic" ControlToValidate="dataQdes" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataDmeGlobalId" runat="server" Text="Dme Global Id:" AssociatedControlID="dataDmeGlobalId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataDmeGlobalId" Text='<%# Bind("DmeGlobalId") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataDmeGlobalId" runat="server" Display="Dynamic" ControlToValidate="dataDmeGlobalId" ErrorMessage="Invalid value" MaximumValue="2147483647" MinimumValue="-2147483648" Type="Integer"></asp:RangeValidator>
				</td>
			</tr>
			
		</table>

	</ItemTemplate>
</asp:FormView>


