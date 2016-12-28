<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="soft.aspx.cs" Inherits="Teacher_soft" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
<div  class="placehold">        
            <div>
            ��Դ���ࣺ<asp:DropDownList ID="ddlcategory" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlcategory_SelectedIndexChanged">
        </asp:DropDownList>
                    <asp:Label ID="Label1" runat="server" Width="400px"></asp:Label>
                    <asp:HyperLink ID="Hlkadd" runat="server" CssClass="HyperlinkNormal" 
                    NavigateUrl="~/Teacher/softadd.aspx" Target="_self">��Դ���</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="Hlkcategory" runat="server" CssClass="HyperlinkNormal" 
                    NavigateUrl="~/Teacher/softcategory.aspx" Target="_self">��������</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="Hlkcgscore" runat="server" CssClass="HyperlinkNormal" 
                    NavigateUrl="~/Teacher/softnomic.aspx" Target="_blank">��ѧ����</asp:HyperLink>
                    </div>
            <div class="softdiv">
                <asp:GridView ID="GVSource" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False"  CellPadding="5" 
                    PageSize="20"  SkinID="GridViewInfo" Width="100%"
                    onpageindexchanging="GVSource_PageIndexChanging" 
                    onrowdatabound="GVSource_RowDataBound" EnableModelValidation="True" 
                    onrowcommand="GVSource_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="���" />
                        <asp:BoundField DataField="Fclass" HeaderText="����" />
                        <asp:HyperLinkField DataNavigateUrlFields="Fid" 
                            DataNavigateUrlFormatString="~/Teacher/softview.aspx?Fid={0}" 
                            DataTextField="Ftitle" HeaderText="����" />
                        <asp:BoundField DataField="Ffiletype" HeaderText="��ʽ" />
                        <asp:BoundField DataField="Fhit" HeaderText="����" />
                        <asp:BoundField DataField="Fopen" HeaderText="ѧ��" />
                        <asp:HyperLinkField DataNavigateUrlFields="Furl" HeaderText="����" Text="���" 
                            Target="_blank" />
                        <asp:CheckBoxField DataField="Fhide" HeaderText="����" ReadOnly="True" />
                        <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" 
                            CommandArgument='<%# Eval("Fid") %>' CommandName="Change" 
                            ImageUrl="~/Images/refresh.gif" Text="����" ToolTip="�������޻����أ���" />
                    </ItemTemplate>
                </asp:TemplateField>
                        <asp:BoundField DataField="Fdate" HeaderText="����" />
                        <asp:HyperLinkField DataNavigateUrlFields="Fid,Furl" 
                            DataNavigateUrlFormatString="~/Teacher/SoftDel.aspx?Fid={0}&amp;&amp;Furl={1}" 
                            Text="ɾ��" />
                    </Columns>
                    <pagertemplate>
                        <div  class="pagediv">
                            ��<asp:Label ID="lblPageIndex" runat="server" 
                                text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1  %>" />
                            ҳ  ��<asp:Label ID="lblPageCount" runat="server" 
                                text="<%# ((GridView)Container.Parent.Parent).PageCount  %>" />
                            ҳ 
                            <asp:LinkButton ID="btnFirst" runat="server" causesvalidation="False" 
                                commandargument="First" commandname="Page" Font-Underline="False" 
                                ForeColor="Black" text="��ҳ" />
                            <asp:LinkButton ID="btnPrev" runat="server" causesvalidation="False" 
                                commandargument="Prev" commandname="Page" Font-Underline="False" 
                                ForeColor="Black" text="��һҳ" />
                            <asp:LinkButton ID="btnNext" runat="server" causesvalidation="False" 
                                commandargument="Next" commandname="Page" Font-Underline="False" 
                                ForeColor="Black" text="��һҳ" />
                            <asp:LinkButton ID="btnLast" runat="server" causesvalidation="False" 
                                commandargument="Last" commandname="Page" Font-Underline="False" 
                                ForeColor="Black" text="βҳ" />
                        </div>
                    </pagertemplate>
                </asp:GridView>
            </div>
            <br />
    </div>
</asp:Content>

