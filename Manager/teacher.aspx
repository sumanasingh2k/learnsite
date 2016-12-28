<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manage.master" AutoEventWireup="true" CodeFile="teacher.aspx.cs" Inherits="Manager_teacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div class="manageplace" >
        ��ʦ����<br />
        <div  class="teachermg">
                    <asp:Button ID="Btnadd" runat="server" BackColor="#E6E6E6" 
                        BorderColor="#D4D4D4" BorderWidth="1px" Font-Names="Arial" 
                Font-Size="9pt" Text="��ʦ���" Width="70px" Height="20px" onclick="Btnadd_Click" />
                    </div>
                 <div class="teacherdiv">
                <asp:GridView ID="GVTeacher" runat="server" 
                    AutoGenerateColumns="False" BorderColor="#E7E7E7" BorderStyle="Solid" 
                    BorderWidth="1px" CellPadding="3" Font-Size="9pt" GridLines="None" Width="100%" 
                    onpageindexchanging="GVTeacher_PageIndexChanging" 
                    onrowdatabound="GVTeacher_RowDataBound" EnableModelValidation="True" 
                            onrowcommand="GVTeacher_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="���" />
                        <asp:BoundField DataField="Hname" HeaderText="�˺�" />
                        <asp:BoundField DataField="Hnick" HeaderText="�ǳ�" />
                        <asp:BoundField DataField="Hpwd" HeaderText="����" />
                        <asp:TemplateField HeaderText="Ȩ��">
                            <ItemTemplate>
                                <asp:Label ID="LabelHpermiss" runat="server" Text='<%# Bind("Hpermiss") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Hnote" HeaderText="��ע" />
                        <asp:BoundField DataField="Hcount" HeaderText="ѧ����" />
                        <asp:TemplateField HeaderText="�༶">
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLinkRoom" runat="server" 
                                    NavigateUrl='<%# Eval("Hid", "roomselect.aspx?Hid={0}") %>' Text="ѡ��"></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:HyperLinkField DataNavigateUrlFields="Hid" 
                            DataNavigateUrlFormatString="teacheredit.aspx?Hid={0}" 
                            Text="�޸�" HeaderText="����" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButtonDel" runat="server" CausesValidation="false" 
                                    CommandName="D" Text="ɾ��" CommandArgument='<%# Bind("Hid") %>' ToolTip="���ɾ������ָ������ֶ������ݿ�Teacher�����˺ŵ�ɾ����־����Ϊfalse��"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <RowStyle BorderStyle="None" Font-Names="Arial" Font-Size="9pt" 
                        ForeColor="Black" Height="24px" />
                    <HeaderStyle BackColor="#939CA2" Font-Bold="False" Font-Names="Arial" 
                        Font-Size="9pt" Height="24px" />
                    <AlternatingRowStyle BackColor="#E7E7E7" />
                </asp:GridView>
                </div>
</div>
</asp:Content>

