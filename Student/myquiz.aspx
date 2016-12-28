<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Stud.master"  StylesheetTheme="Student" AutoEventWireup="true" CodeFile="myquiz.aspx.cs" Inherits="Student_myquiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cphs" Runat="Server">
    <div id="student">
<div class="left">
<div id="divscore"  class="quizscoreheight">
<div class="divquizscore">
        <asp:GridView ID="GridViewgrade" runat="server" AllowPaging="True" Width="100%"  
        SkinID="GridViewInfo" AutoGenerateColumns="False" PageSize="20" 
        onpageindexchanging="GridViewgrade_PageIndexChanging" 
        onrowdatabound="GridViewgrade_RowDataBound" Caption="�꼶�ɼ���">
                    <Columns>
                        <asp:BoundField HeaderText="���" />
                        <asp:BoundField DataField="Sgradeclass" HeaderText="�༶" />
                        <asp:BoundField DataField="Sname" HeaderText="����" />
                        <asp:BoundField DataField="Squiz" HeaderText="ѧ��" />
                    </Columns>
                    <PagerTemplate>
                        <div class="pagediv">
                            ��<asp:Label ID="lblPageIndex" runat="server" ForeColor="Black" 
                                Text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>"></asp:Label>
                            ҳ ��<asp:Label ID="lblPageCount" runat="server" ForeColor="Black" 
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
                </div>
                <br />
</div>
<div id="divwork" class="quizscoreheight">
<div class="divquizscore">
        <asp:GridView ID="GridViewclass" runat="server" AllowPaging="True" Width="100%"  
        SkinID="GridViewInfo" AutoGenerateColumns="False" PageSize="20" 
        onpageindexchanging="GridViewclass_PageIndexChanging" 
        onrowdatabound="GridViewclass_RowDataBound" Caption="�༶�ɼ���">
                    <Columns>
                        <asp:BoundField HeaderText="���" />
                        <asp:BoundField DataField="Sgradeclass" HeaderText="�༶" />
                        <asp:BoundField DataField="Sname" HeaderText="����" />
                        <asp:BoundField DataField="Squiz" HeaderText="ѧ��" />
                    </Columns>
                    <PagerTemplate>
                        <div class="pagediv">
                            ��<asp:Label ID="lblPageIndex" runat="server" ForeColor="Black" 
                                Text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>"></asp:Label>
                            ҳ ��<asp:Label ID="lblPageCount" runat="server" ForeColor="Black" 
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
                </div>
                <br />
</div>
 <br /> 
</div>
<div class="right">
<div>
    
    <asp:GridView ID="GVmyScore" runat="server" AllowPaging="True"  
        Caption="�ҵĲ����¼" CellPadding="2"         
        onpageindexchanging="GVmyScore_PageIndexChanging"
        OnRowDataBound="GVmyScore_RowDataBound" Width="90%" SkinID="GridViewInfo" 
        AutoGenerateColumns="False" EnableModelValidation="True">
        <Columns>
            <asp:BoundField HeaderText="����" DataField="Rdate" />
            <asp:HyperLinkField DataNavigateUrlFields="Rid" 
                DataNavigateUrlFormatString="quizview.aspx?Rid={0}" Target="_blank" 
                DataTextField="Rscore" HeaderText="�ɼ�"  />
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

    <div class="quizresult">
        <br /> 
        <div class="quizinfo">
            <div  class="quizhead">�ҵĲ���ƽ���ɼ�</div>
                <br />
                <asp:Label ID="LabelSquiz" runat="server" ></asp:Label>
                <br />
                <br />  
                </div>      
        <br />
                <asp:Button ID="Btnquiz" runat="server" OnClick="Btnquiz_Click"
                    Text="��ʼ����" Width="80px" CausesValidation="False" 
            CssClass="buttonimg" Font-Bold="False" BorderStyle="None"/>
                <br />
        <br />
        <asp:Label ID="Labelmsg" runat="server" Font-Size="9pt"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Student/quizrank.aspx" Target="_blank" SkinID="HyperLink" 
            Width="120px" CssClass="txtszcenter" Height="18px">����������а�</asp:HyperLink>
        <br />
        <br />
        <br />
    </div>   
    <br />
    <br />
    </div>
<br />
</div>
</asp:Content>

