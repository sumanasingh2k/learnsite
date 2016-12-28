<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Stud.master"  StylesheetTheme="Student" AutoEventWireup="true" CodeFile="mysite.aspx.cs" Inherits="Student_mysite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cphs" Runat="Server">
    <div id="student">
<div class="left">
<div class="divcenter">
     <br />
     <asp:Image ID="ImageHome" runat="server" ImageUrl="~/Images/home.png" 
         BorderStyle="None" />
    <asp:HyperLink ID="HyperLinksite" runat="server"  ToolTip="^p^ȥ�ҵ���վ�ռ�Ȳȣ�"
         Target="_blank" Height="18px" BorderStyle="None" BorderWidth="1px" 
         CssClass="txtszcenter" Width="70px" BackColor="#E1EDFF">hls</asp:HyperLink>
           &nbsp;�ռ����ã�<asp:Label ID="LabelWquota" runat="server"  ></asp:Label>
                &nbsp;�ҵ���վ��Ʊ��<asp:Label ID="LabelWvote" runat="server" 
         Font-Bold="False" Font-Names="Arial"  ></asp:Label>
     <asp:Image ID="Imagegift" runat="server" ImageUrl="~/Images/gift.png" />
                &nbsp; ��Ͷ������<asp:Label ID="LabelWegg"  runat="server"  ></asp:Label>
                &nbsp;<asp:Label ID="Lbc" runat="server" BackColor="#C6E3B3" 
         Height="14px" ToolTip="��վ����ָʾ��ɫ" Width="14px"></asp:Label>
                <br />
<asp:Label ID="Labelmsg" runat="server"  Height="16px" ForeColor="Red"></asp:Label>
     <br />
     <asp:DataList ID="DataListvote" runat="server" RepeatDirection="Horizontal" 
                    RepeatColumns="8" DataKeyField="Wid" 
                    OnItemCommand="DataListvote_ItemCommand" CellPadding="2" 
                     onitemdatabound="DataListvote_ItemDataBound" Width="98%">
                    <ItemTemplate>
                        <div  class="divvote"> 
                        <div class="divvotebg"><asp:HyperLink ID="Hypername" runat="server"  Text='<%# Eval("Sname") %>'  
                                Font-Underline="False" Height="18px"  ForeColor="Black"  ToolTip="�����ҵ���վ��"   Target="_blank" 
                                NavigateUrl='<%# Eval("Wurl") %>' ></asp:HyperLink>
                                </div>
                            <asp:Label ID="WvoteLabel" runat="server" Text='<%# Eval("Wvote") %>' 
                                Height="16px" ></asp:Label>
                            <br />
                            <asp:LinkButton ID="Linkvote" runat="server" BackColor="#C4DBFF" BorderColor="#E0E0E0"
                                CommandArgument="uid" CommandName="vote" Font-Size="9pt" Font-Underline="False"
                                ForeColor="Black" Height="18px" Width="50px" ToolTip="��Ͷ��һƱ��лл��" 
                                CssClass="txtszcenter">ͶƱ</asp:LinkButton>
                            <br />
                            <asp:Label ID="LabelWscore" runat="server" Text='<%# Eval("Wscore") %>' Visible="false"></asp:Label>
                            <asp:Label ID="LabelWupdate" runat="server" Text='<%# Eval("Wupdate") %>' Visible="false"></asp:Label>
                                </div>
                                <br />
                    </ItemTemplate>
      </asp:DataList>
     <br />
</div>
<br />        
</div>
<div class="right">
<div>    
    <asp:Image ID="Imageface" runat="server" Height="80px" Width="80px" />
    <div id="DivRank" class="divinfo" >
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
            NavigateUrl="~/Student/attituderank.aspx" Target="_blank" ToolTip="�����ʾ��������">[sattitude]</asp:HyperLink>
        </div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">ѧ��:</div>
    <div class="divinfo2"><asp:Label ID="sscore" runat="server" ></asp:Label></div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">�鳤:</div>
    <div class="divinfo2"><asp:Label ID="sleadername" runat="server" ></asp:Label></div>
    </div>
    <div class="divinfo">
    <div class="divinfo1">MyIP:</div>
    <div class="divinfo2"><asp:Label ID="Labelip" runat="server"  SkinID="LabelSize8" ></asp:Label></div>
    </div> 
    <br />
    <br /> 
    <div>
    
    <asp:HyperLink ID="HyperLink1" runat="server"  Width="120px" SkinID="HyperLink" 
        Height="18px" NavigateUrl="~/Student/allsite.aspx" CssClass="txtszcenter" 
            Target="_self">ȫУͬѧ��վ���</asp:HyperLink>   
    </div>
    <br />
    <br />
    </div>
<br />
</div>
</asp:Content>

