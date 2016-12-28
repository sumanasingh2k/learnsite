<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master"   StylesheetTheme="Teacher" AutoEventWireup="true"  CodeFile="course.aspx.cs" Inherits="Teacher_course" %>
<%@ Register assembly="Anthem" namespace="Anthem" tagprefix="anthem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div  >
        <div  class="chead">
            &nbsp;ѧ��ѡ��<asp:DropDownList ID="DDLgrade" runat="server" Font-Size="9pt" 
            Width="60px" EnableTheming="True" AutoPostBack="True" 
                onselectedindexchanged="DDLgrade_SelectedIndexChanged">
        </asp:DropDownList>
            �꼶&nbsp;
                    <asp:Label ID="Labelmsg" runat="server" Width="220px" Height="16px"></asp:Label>
                    &nbsp;<asp:DropDownList ID="DDLterm" runat="server" Font-Size="9pt" 
                    EnableTheming="True" AutoPostBack="True" 
            onselectedindexchanged="DDLterm_SelectedIndexChanged" 
                ToolTip="ѡ��Ҫ��ʾѧ����ѧ�ڣ����ı��̨Ĭ��ѧ������">
                <asp:ListItem Value="1">��һѧ��</asp:ListItem>
                <asp:ListItem Value="2">�ڶ�ѧ��</asp:ListItem>
        </asp:DropDownList>
            &nbsp;
                    <asp:Label ID="Labelspace" runat="server" Width="120px" Height="16px"></asp:Label>
                    <asp:Button ID="Btnadd" runat="server"  Text="���ѧ��"  onclick="Btnadd_Click" SkinID="BtnNormal" />                    
                    </div>
                    <div >
                    <div class="centerdiv">
                    <anthem:GridView ID="GVCourse" runat="server" AllowPaging="True"
                            AutoGenerateColumns="False"  DataKeyNames="Cid"  
                            PageSize="20" Width="100%"
                            onpageindexchanging="GVCourse_PageIndexChanging" 
                            onrowdatabound="GVCourse_RowDataBound" CellPadding="6" 
                            EnableModelValidation="True" Font-Size="9pt" 
                            onrowcommand="GVCourse_RowCommand" ForeColor="#111111" GridLines="None" >
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>                                
                                <asp:BoundField DataField="Cks" HeaderText="�ν�">
                                <ControlStyle Width="20px" />
                                </asp:BoundField>
                                <asp:HyperLinkField DataNavigateUrlFields="Cid" 
                                    DataNavigateUrlFormatString="~/Teacher/CourseShow.aspx?Cid={0}" 
                                    DataTextField="Ctitle" HeaderText="ѧ��" >
                                <HeaderStyle HorizontalAlign="Left" />
                                <ItemStyle HorizontalAlign="Left" />
                                </asp:HyperLinkField>
                                <asp:BoundField DataField="Cclass" HeaderText="����" SortExpression="Cclass" >
                                <HeaderStyle HorizontalAlign="Left" />
                                <ItemStyle HorizontalAlign="Left" />
                                </asp:BoundField>
                                <asp:HyperLinkField DataNavigateUrlFields="Cid"                                     
                                    DataNavigateUrlFormatString="~/Teacher/Package.aspx?Cid={0}" HeaderText="���" 
                                    Text="����" />
                                <asp:TemplateField HeaderText="����" ShowHeader="False">
                                    <ItemTemplate>
                                        <anthem:LinkButton ID="LbtnCpublish" runat="server" CausesValidation="false" 
                                   CommandArgument='<%# Bind("Cid") %>'  CommandName="Cp" Text='<%# Eval("Cpublish") %>'></anthem:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:HyperLinkField DataNavigateUrlFields="Cid" 
                                    DataNavigateUrlFormatString="~/Teacher/courseanalyse.aspx?Cid={0}" Text="����" />
                                <asp:TemplateField HeaderText="̽��">
                                    <ItemTemplate>                                    
                                        <asp:HyperLink ID="Hl" runat="server" Text="��˼" ForeColor="Blue"></asp:HyperLink>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="�Ƽ�" ShowHeader="False">
                                    <ItemTemplate>
                                        <anthem:LinkButton ID="LbtnCgood" runat="server" CausesValidation="false" 
                                   CommandArgument='<%# Bind("Cid") %>'  CommandName="Cg" ToolTip="Ĭ��ΪTrue��ѧ��ƽ̨��Ʒ�ղ�ѧ���б�����ʾ��False����ʾ!" Text='<%# Eval("Cgood") %>'></anthem:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:HyperLinkField DataNavigateUrlFields="Cid" 
                                    DataNavigateUrlFormatString="~/Teacher/CourseEdit.aspx?Cid={0}" Text="�༭">
                                <ItemStyle Width="30px" />
                                </asp:HyperLinkField>
                                <asp:TemplateField HeaderText="����" SortExpression="Cdate">
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" 
                                            Text='<%# DataBinder.Eval(Container.DataItem,"Cdate","{0:d}")%>'></asp:Label>
                                    </ItemTemplate>
                                    <ControlStyle Width="70px" />
                                    <ItemStyle HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="���" ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LbtnCold" runat="server" CausesValidation="false" 
                                          CommandArgument='<%# Bind("Cid") %>'  ToolTip="ת�Ƶ�ѧ���ֿ��б���" CommandName="Cu" Text="ת��"></asp:LinkButton>
                                    </ItemTemplate>
                                    <ControlStyle Width="30px" />
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#E7E7E7" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#9EA9B1" Font-Bold="True" ForeColor="#111111" />
                            <PagerStyle BackColor="#EFEFEF" ForeColor="#111111" HorizontalAlign="Center" />
                            <pagertemplate>
                                <div style="width:100%; height:13px; text-align:right">
                                    ��<asp:Label ID="lblPageIndex" runat="server" 
                                        text="<%# ((Anthem.GridView)Container.Parent.Parent).PageIndex + 1  %>" />
                                    ҳ ��<asp:Label ID="lblPageCount" runat="server" 
                                        text="<%# ((Anthem.GridView)Container.Parent.Parent).PageCount  %>" />
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
                            <RowStyle BackColor="#E7E7E7" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        </anthem:GridView>
                        </div>
                    </div>
                    <div style="height: 10px" ></div>
                    <div style="text-align: right; ">
                    <asp:Button ID="Btnimport"  runat="server"  Text="����ѧ��"  onclick="Btnimport_Click" SkinID="BtnNormal" />                    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btnold"  runat="server"  Text="ѧ���ֿ�"  onclick="Btnold_Click" 
                            SkinID="BtnNormal" />                    
                    &nbsp;                    
                    &nbsp;                    
        <link href="../Js/tinybox.css" rel="stylesheet" type="text/css" />
        <script src="../Js/tinybox.js" type="text/javascript"></script>
        <script type ="text/javascript" >
            function tshow(c) {
                var urlat = "../Lessons/ThinkShow.aspx?Cid=" + c;
                TINY.box.show({ iframe: urlat, boxid: 'frameless', width: 800, height: 500, fixed: false, maskopacity: 40, closejs: function () { closeJS() } })
            }
        </script>               
                    </div>
    </div>
</asp:Content>

