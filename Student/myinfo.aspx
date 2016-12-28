<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Stud.master" StylesheetTheme="Student" AutoEventWireup="true" CodeFile="myinfo.aspx.cs" Inherits="Student_myinfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cphs" Runat="Server">
    <div id="student">
<div class="left">
<div id="divscores"  class="divscoreheight">
<div class="divscore">
        <asp:GridView ID="GridViewscore" runat="server" AllowPaging="True" OnPageIndexChanging="GridViewscore_PageIndexChanging" 
                    OnRowDataBound="GridViewscore_RowDataBound" Width="100%"  
        SkinID="GridViewInfo" AutoGenerateColumns="False" Caption="����ѧ�����а�" 
            EnableModelValidation="True" >
                    <Columns>
                        <asp:BoundField HeaderText="���" />
                        <asp:TemplateField HeaderText="�༶">
                            <ItemTemplate>
                                <asp:Label ID="Labelg" runat="server" Text='<%# Bind("Sgrade") %>'></asp:Label>.
                                <asp:Label ID="Labelc" runat="server" Text='<%# Bind("Sclass") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Sname" HeaderText="����" />
                        <asp:BoundField DataField="Sscore" HeaderText="ѧ��" />
                    </Columns>
                    <PagerTemplate>
                        <div class="pagediv">
                            <asp:Label ID="lblPageIndex" runat="server" ForeColor="Black" 
                                Text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>"></asp:Label>
                            /<asp:Label ID="lblPageCount" runat="server" ForeColor="Black" 
                                Text="<%# ((GridView)Container.Parent.Parent).PageCount %>"></asp:Label>&nbsp;
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
                            &nbsp;&nbsp;
                        </div>
                    </PagerTemplate>
                </asp:GridView>
                </div>
</div>
<div id="divworks" class="divscoreheight">
<div class="divscore">
                <asp:GridView ID="GridViewwork" runat="server" AllowPaging="True" 
                    OnPageIndexChanging="GridViewwork_PageIndexChanging" 
                    OnRowDataBound="GridViewwork_RowDataBound" Width="100%" 
        SkinID="GridViewInfo" AutoGenerateColumns="False" Caption="����������Ʒ��" 
                    EnableModelValidation="True">
                    <Columns>
                        <asp:BoundField HeaderText="���" />
                        <asp:TemplateField HeaderText="�༶">
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Wgrade") %>'></asp:Label>.
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("Wclass") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Wname" HeaderText="����" />
                        <asp:HyperLinkField DataNavigateUrlFields="Wid" 
                            DataNavigateUrlFormatString="downwork.aspx?Wid={0}" HeaderText="��Ʒ" 
                            Text="�鿴" Target="_blank" />
                        <asp:BoundField DataField="Wscore" HeaderText="����" />
                    </Columns>
                    <PagerTemplate>
                        <div  class="pagediv">
                            <asp:Label ID="lblPageIndex" runat="server" ForeColor="Black" 
                                Text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1 %>"></asp:Label>
                            /<asp:Label ID="lblPageCount" runat="server" ForeColor="Black" 
                                Text="<%# ((GridView)Container.Parent.Parent).PageCount %>"></asp:Label>&nbsp;                  
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
                            &nbsp;&nbsp;
                        </div>
                    </PagerTemplate>
                </asp:GridView>
                </div>
</div><br />&nbsp;<br />  
    <div  class="ccontent" > 
    <br />&nbsp;<br />        
        <asp:DataList ID="DataListonline" runat="server" DataKeyField="Qid"
                    RepeatColumns="8" RepeatDirection="Horizontal" Caption="����ǩ����ͬѧ" 
            CaptionAlign="Left" onitemdatabound="DataListonline_ItemDataBound">
                    <ItemTemplate>
                        <div  class="onlinediv">
                        <div class="onlinebg">
                            <asp:HyperLink ID="HyperQname" runat="server" Font-Size="9pt" Font-Underline="False"
                                Height="18px" Text='<%# Eval("Sname") %>'   
                                ToolTip='<%# Eval("Qip") %>' ></asp:HyperLink>
                        </div>
                            <asp:Image ID="Imageflag" runat="server" BorderStyle="None"  BorderWidth="0" />
                            <asp:Label ID="Labeltime" runat="server" Text='<%# Eval("Qdate") %>' Font-Names="Arial" Font-Size="8pt" Width="40px"></asp:Label></div>
                            <asp:Label ID="LabelSleader" runat="server" Text='<%# Eval("Sleader") %>' Visible="false" ></asp:Label>
                            <asp:Label ID="LabelSgroup" runat="server" Text='<%# Eval("Sgroup") %>' Visible="false" ></asp:Label>
                            <asp:Label ID="LabelQnum" runat="server" Text='<%# Eval("Qnum") %>' Visible="false" ></asp:Label>
                    </ItemTemplate>
                </asp:DataList>
                <br />
        </div>        
        <br />
</div>
<div class="right">
<div>    
    <asp:Image ID="Imageface" runat="server" Height="80px" Width="80px"  />    
    <div id="DivRank" class="divrank" >
    <asp:Label ID="LabelRank" runat="server"></asp:Label>
    </div>
    </div> 
    <div class="divinfo">
    <div class="divinfo1">ѧ��:</div>
    <div class="divinfo2"><asp:Label ID="snum" runat="server" ></asp:Label></div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">�༶:</div>
    <div class="divinfo2"><asp:Label ID="sclass" runat="server" ></asp:Label></div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">����:</div>
    <div class="divinfo2"><asp:Label ID="sname" runat="server" ></asp:Label></div>
    </div>    
    <div class="divinfo">
    <div class="divinfo1">����:</div>
    <div class="divinfo2">
        <asp:HyperLink ID="sattitude" runat="server" 
            NavigateUrl="~/Student/attiduderank.aspx" Target="_blank" ToolTip="�����ʾ��������">[sattitude]</asp:HyperLink>
        </div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">ѧ��:</div>
    <div class="divinfo2"><asp:Label ID="sscore" runat="server" ></asp:Label></div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">�鳤:</div>
    <div class="divinfo2"><asp:HyperLink ID="HLgroup" runat="server">[HLgroup]</asp:HyperLink></div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">MyIP:</div>
    <div class="divinfo2"><asp:Label ID="Labelip" runat="server"  SkinID="LabelSize8" ></asp:Label></div>
    </div> 
    <div class="divnull">
        ������Ʒ���<br />
        <br />
        <div style="padding: 2px; width: 150px; border: 1px dashed #ABC1EB">
        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LabelWself" runat="server" ></asp:Label>&nbsp;&nbsp;
        <asp:HyperLink ID="Hlwork" runat="server" ForeColor="#3399FF" Target="_blank" >�鿴</asp:HyperLink>
        </div>
        <br />
        <br />
                <asp:Button ID="BtnProfile" runat="server" OnClick="BtnProfile_Click"
                    Text="�ҵ�����" Width="80px" CausesValidation="False" 
            CssClass="buttonimg" BorderStyle="None"/>
        <br />
        <br />
        <asp:Button ID="BtnExit" runat="server" 
            BorderStyle="None" onclick="BtnExit_Click" 
            Width="80px" Enabled="False"  Text="" CssClass="buttonnone"  />
        <br />
        <script type="text/javascript">
            var i = 10;//�趨�˳���ť�����Ӻ���Ч
            function setbar() {
                i--;
                var btnid = "<%= BtnExit.ClientID %>";
                if (document.getElementById(btnid).value != "") {
                    document.getElementById(btnid).value = "ƽ̨�˳�" + i;
                }
                if (i <0) {
                    document.getElementById(btnid).disabled = false;
                    if (document.getElementById(btnid).value != "") {
                        document.getElementById(btnid).value = "ƽ̨�˳�";
                    }
                    return;
                }
                else {
                    document.getElementById(btnid).disabled = true;
                }
                
                setTimeout("setbar()", 1000);
            }
            setbar(); 
          </script>
        <br />
        <br />
    </div>   
    </div>
</div>
</asp:Content>

