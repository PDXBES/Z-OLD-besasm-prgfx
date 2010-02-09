<%@ Control Language="C#" ClassName="MstNodesAcFields" %>

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
        <td class="literal"><asp:Label ID="lbldataNode" runat="server" Text="Node:" AssociatedControlID="dataNode" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNode" Text='<%# Bind("Node") %>' MaxLength="6"></asp:TextBox><asp:RequiredFieldValidator ID="ReqVal_dataNode" runat="server" Display="Dynamic" ControlToValidate="dataNode" ErrorMessage="Required"></asp:RequiredFieldValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataXcoord" runat="server" Text="Xcoord:" AssociatedControlID="dataXcoord" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataXcoord" Text='<%# Bind("Xcoord") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataXcoord" runat="server" Display="Dynamic" ControlToValidate="dataXcoord" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataYcoord" runat="server" Text="Ycoord:" AssociatedControlID="dataYcoord" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataYcoord" Text='<%# Bind("Ycoord") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataYcoord" runat="server" Display="Dynamic" ControlToValidate="dataYcoord" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataNodeType" runat="server" Text="Node Type:" AssociatedControlID="dataNodeType" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataNodeType" Text='<%# Bind("NodeType") %>' MaxLength="4"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGrndElev" runat="server" Text="Grnd Elev:" AssociatedControlID="dataGrndElev" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGrndElev" Text='<%# Bind("GrndElev") %>'></asp:TextBox><asp:RangeValidator ID="RangeVal_dataGrndElev" runat="server" Display="Dynamic" ControlToValidate="dataGrndElev" ErrorMessage="Invalid value" MaximumValue="999999999" MinimumValue="-999999999" Type="Double"></asp:RangeValidator>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHasSpecNode" runat="server" Text="Has Spec Node:" AssociatedControlID="dataHasSpecNode" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHasSpecNode" Text='<%# Bind("HasSpecNode") %>' MaxLength="1"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataHasSpecLink" runat="server" Text="Has Spec Link:" AssociatedControlID="dataHasSpecLink" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataHasSpecLink" Text='<%# Bind("HasSpecLink") %>' MaxLength="1"></asp:TextBox>
				</td>
			</tr>
			<tr>
        <td class="literal"><asp:Label ID="lbldataGageId" runat="server" Text="Gage Id:" AssociatedControlID="dataGageId" /></td>
        <td>
					<asp:TextBox runat="server" ID="dataGageId" Text='<%# Bind("GageId") %>' MaxLength="8"></asp:TextBox>
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


