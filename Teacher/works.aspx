<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="works.aspx.cs" Inherits="Teacher_works" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div  class="placehold">
        <div class="chead" >
            &nbsp;��Ʒѡ��<asp:DropDownList ID="DDLgrade" runat="server" Font-Size="9pt" 
                EnableTheming="True" AutoPostBack="True" 
                onselectedindexchanged="DDLgrade_SelectedIndexChanged" Width="60px">
        </asp:DropDownList>
            �꼶&nbsp;
                    <asp:Label ID="Labelmsg" runat="server" Width="350px" Height="16px"></asp:Label>

                 <span id="pg" onclick="package()">��Ʒ���&nbsp;&nbsp;</span>
        <link href="../Js/tinybox.css" rel="stylesheet" type="text/css" />
        <script src="../Js/tinybox.js" type="text/javascript"></script>
        <script type ="text/javascript" >
            function package() {
                var urlpg = "../Teacher/workpackage.aspx" ;
                TINY.box.show({ iframe: urlpg, boxid: 'frameless', width: 360, height: 240, fixed: false, maskopacity: 40, closejs: function () { closeJS() } })
            }
        </script>
                    <asp:Button ID="Btnterm" runat="server" Text="ѧ������"  SkinID="BtnNormal" 
                onclick="Btnterm_Click" ToolTip="��ת��ѧ������ҳ��" />
        </div>
        <div>
        <div class="centerdiv">
            <asp:GridView ID="GVCourse" runat="server" AllowPaging="True" 
                AutoGenerateColumns="False"  CellPadding="6" DataKeyNames="Cid"  SkinID="GridViewInfo"
                PageSize="20" Width="100%" 
                onpageindexchanging="GVCourse_PageIndexChanging" 
                onrowdatabound="GVCourse_RowDataBound" EnableModelValidation="True">
                <Columns>
                    <asp:BoundField DataField="Cid" HeaderText="���" InsertVisible="False" 
                        ReadOnly="True" SortExpression="Cid" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle Width="50px" HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:HyperLinkField 
                        DataTextField="Ctitle" HeaderText="ѧ��" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                    </asp:HyperLinkField>
                    <asp:BoundField DataField="Cclass" HeaderText="����" SortExpression="Cclass" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" />
                    <ItemStyle Width="60px" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="δ����">
                        <ItemTemplate>
                            <asp:HyperLink ID="HlNoCheck" runat="server" ></asp:HyperLink>
                        </ItemTemplate>
                        <ItemStyle Font-Bold="True" Width="60px" />
                    </asp:TemplateField>
                    <asp:HyperLinkField DataNavigateUrlFields="Cid,Cobj" 
                        DataNavigateUrlFormatString="workcheck.aspx?Cid={0}&amp;Grade={1}" 
                        Text="�鿴" HeaderText="����" Target="_blank">
                    <ItemStyle Width="60px" />
                    </asp:HyperLinkField>
                    <asp:BoundField DataField="Cdate" HeaderText="����" SortExpression="Cdate" >
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle HorizontalAlign="Left" Width="120px" />
                    </asp:BoundField>
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
        </div>
        <br />
        <br />
    </div>
</asp:Content>

