<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Stud.master" StylesheetTheme="Student" AutoEventWireup="true" CodeFile="mywork.aspx.cs" Inherits="Student_mywork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cphs" Runat="Server">
<div id="student">
<div class="left">
<div class="ccontent">
    <asp:GridView ID="GridViewworks" runat="server" AllowPaging="True" OnPageIndexChanging="GridViewworks_PageIndexChanging" 
        PageSize="15" Width="100%" SkinID="GridViewInfo" 
        onrowdatabound="GridViewworks_RowDataBound" AutoGenerateColumns="False" 
        Caption="�ҵ���Ʒ" CaptionAlign="Left" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="Cobj" HeaderText="�꼶" >
            <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField DataField="Cterm" HeaderText="ѧ��" >
            <ItemStyle Width="50px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="ѧ��">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" 
                        NavigateUrl='<%# Eval("Wcid", "~/Student/showcourse.aspx?Cid={0}") %>' 
                        Text='<%# Eval("Ctitle") %>' ></asp:HyperLink>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" Width="220px" />
            </asp:TemplateField>
            <asp:BoundField DataField="Mtitle" HeaderText="�" >
            <HeaderStyle HorizontalAlign="Left" />
            <ItemStyle Width="180px" HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="Wid" 
                DataNavigateUrlFormatString="downwork.aspx?Wid={0}" HeaderText="��Ʒ" 
                Text="����" Target="_blank">
            <ControlStyle Font-Underline="True" />
            <ItemStyle Width="30px" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="Wscore" HeaderText="ѧ��">
            <ItemStyle Width="30px" />
            </asp:BoundField>
            <asp:BoundField DataField="Wdscore" HeaderText="�ӷ�">
            <ItemStyle Width="30px" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="Wmid,Wcid" 
                DataNavigateUrlFormatString="~/Student/myevaluate.aspx?Mid={0}&amp;Cid={1}" 
                HeaderText="����" Target="_blank" Text="����">
            <ItemStyle Width="30px" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="Wvote" HeaderText="�ʻ�">
            <ItemStyle Width="30px" />
            </asp:BoundField>
            <asp:CheckBoxField DataField="Wcheck" HeaderText="����" ReadOnly="True" >
            <ItemStyle Width="30px"  Height="24px"  />
            </asp:CheckBoxField >
        </Columns>
        <PagerTemplate>
            <div  class="pagediv">
                ��<asp:Label ID="lblPageIndex" runat="server" ForeColor="Black" 
                    Text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>"></asp:Label>
                ҳ ��/<asp:Label ID="lblPageCount" runat="server" ForeColor="Black" 
                    Text="<%# ((GridView)Container.Parent.Parent).PageCount %>"></asp:Label>
                ҳ 
                <asp:LinkButton ID="btnFirst" runat="server" CausesValidation="False" 
                    CommandArgument="First" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="��ҳ"></asp:LinkButton>
                <asp:LinkButton ID="btnPrev" runat="server" CausesValidation="False" 
                    CommandArgument="Prev" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="��һҳ"></asp:LinkButton>
                <asp:LinkButton ID="btnNext" runat="server" CausesValidation="False" 
                    CommandArgument="Next" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="��һҳ"></asp:LinkButton>
                <asp:LinkButton ID="btnLast" runat="server" CausesValidation="False" 
                    CommandArgument="Last" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="βҳ"></asp:LinkButton>
                &nbsp;&nbsp;
            </div>
        </PagerTemplate>
    </asp:GridView>
    <br />
    </div>  
</div>
<div class="right">
<div>
    <asp:GridView ID="GVScore" runat="server" AllowPaging="True"  
        Caption="����������а�" CellPadding="2"         
        onpageindexchanging="GVScore_PageIndexChanging"
        OnRowDataBound="GVScore_RowDataBound" Width="90%" SkinID="GridViewInfo" 
        AutoGenerateColumns="False" PageSize="20">
        <Columns>
<asp:BoundField HeaderText="����"></asp:BoundField>
            <asp:BoundField HeaderText="����" DataField="Sname" >
            <HeaderStyle HorizontalAlign="Left" />
            <ItemStyle HorizontalAlign="Left" />
            </asp:BoundField>
            <asp:BoundField DataField="Sscore" HeaderText="ѧ��">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
        <PagerTemplate>
            <div style="color: black;  text-align:center">
            <asp:LinkButton ID="btnFirst" runat="server" CausesValidation="False" 
                    CommandArgument="First" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="��ҳ"></asp:LinkButton>
                <asp:LinkButton ID="btnPrev" runat="server" CausesValidation="False" 
                    CommandArgument="Prev" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="��ҳ"></asp:LinkButton>
                <asp:LinkButton ID="btnNext" runat="server" CausesValidation="False" 
                    CommandArgument="Next" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="��ҳ"></asp:LinkButton>
                <asp:LinkButton ID="btnLast" runat="server" CausesValidation="False" 
                    CommandArgument="Last" CommandName="Page" Font-Underline="False" 
                    ForeColor="Black" Text="βҳ"></asp:LinkButton>               
            </div>
        </PagerTemplate>
        <PagerStyle Font-Size="9pt" />
    </asp:GridView>
    </div>
    <br />
    </div>
<br />
</div>
</asp:Content>

