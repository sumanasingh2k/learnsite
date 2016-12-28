<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" Validaterequest="false"  AutoEventWireup="true" CodeFile="courseshow.aspx.cs" Inherits="Teacher_courseshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
<div  class="courseshow">
    <br />  	
    <asp:Label ID="LabelCtitle" runat="server"  CssClass="coursetitle"></asp:Label><br /><br />
    <div class="courseother">
                 ���ڣ�[<asp:Label ID="LabelCdate"  runat="server" ></asp:Label>]
			     ���ͣ�[<asp:Label ID="LabelCclass"  runat="server" ></asp:Label>]&nbsp;   
                 �꼶��[<asp:Label ID="LabelCobj"  runat="server" ></asp:Label>]&nbsp;
                 ��[<asp:Label ID="LabelCterm"  runat="server" ></asp:Label>]ѧ��&nbsp;
                 [�νڣ�<asp:Label ID="LabelCks"  runat="server" ></asp:Label>]	&nbsp;	
                 <asp:ImageButton ID="BtnEdit" runat="server" ToolTip="����޸�" 
                     ImageUrl="~/Images/edit.gif" onclick="BtnEdit_Click" />
    </div>    
    <br />
    <br /> 
<div class="courseother" style="width: 700px">
<div style="margin: auto; width: 700px;">
         <asp:LinkButton ID="LinkBtnAdd" runat="server"  SkinID="LinkBtn"
          OnClick="LinkBtnAdd_Click" BackColor="#9BCBFF" >��ӻ</asp:LinkButton>
             &nbsp;&nbsp;&nbsp; &nbsp;
         <asp:LinkButton ID="LinkBtnAddTopic" runat="server"  SkinID="LinkBtn"
          OnClick="LinkBtnAddTopic_Click" BackColor="#9BCBFF" >�������</asp:LinkButton>
             &nbsp;&nbsp; &nbsp;&nbsp;
         <asp:LinkButton ID="LinkBtnAddSurvey" runat="server"  SkinID="LinkBtn"
          OnClick="LinkBtnAddSurvey_Click" BackColor="#9BCBFF" >��ӵ���</asp:LinkButton>
             &nbsp;
             &nbsp; &nbsp;
         <asp:LinkButton ID="LinkBtnAddTxtForm" runat="server"  SkinID="LinkBtn"
          OnClick="LinkBtnAddTxtForm_Click" BackColor="#9BCBFF" >��ӱ�</asp:LinkButton>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:LinkButton ID="LinkBtnProgram" runat="server"  SkinID="LinkBtn"
          OnClick="LinkBtnProgram_Click" BackColor="#9BCBFF" >��ӱ��</asp:LinkButton>
             &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
         <asp:LinkButton ID="LinkBtnReturn" runat="server" SkinID="LinkBtn"  
             OnClick="LinkBtnReturn_Click" BackColor="#9BCBFF" >����</asp:LinkButton>
         </div>

             <br />

         <asp:GridView ID="GVlistmenu" runat="server"  Width="600px"  SkinID="GVmission" 
             CellPadding="6" AutoGenerateColumns="False" 
             EnableModelValidation="True" HorizontalAlign="Center" 
        onrowcommand="GVlistmenu_RowCommand" 
        onrowdatabound="GVlistmenu_RowDataBound" >
             <Columns>             
                 <asp:TemplateField Visible="False">
                     <ItemTemplate>
                         <asp:Label ID="LabelLid" runat="server" Text='<%# Bind("Lid") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField Visible="False">
                     <ItemTemplate>
                         <asp:Label ID="LabelLxid" runat="server" Text='<%# Bind("Lxid") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField Visible="False">
                     <ItemTemplate>
                         <asp:Label ID="LabelLtype" runat="server" Text='<%# Bind("Ltype") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="���">
                     <ItemTemplate>
                         <asp:Label ID="LabelLsort" runat="server" Text='<%# Bind("Lsort") %>'></asp:Label>
                     </ItemTemplate>
                     <ItemStyle Width="50px" />
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="����">
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server"></asp:Label>
                     </ItemTemplate>
                     <ItemStyle Width="50px" />
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="������Ŀ">
                     <ItemTemplate>
                         <asp:HyperLink ID="HlLtitle" runat="server" NavigateUrl="" 
                             Text='<%# Eval("Ltitle") %>'></asp:HyperLink>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="ImageBtnTop" runat="server" CausesValidation="False" 
                            CommandName="Top"  CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'
                            Text="��" ToolTip="������" Font-Underline="False"></asp:LinkButton>
                    </ItemTemplate>
                     <ItemStyle Width="16px" />
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="ImageBtnBottom" runat="server" CausesValidation="False" 
                            CommandName="Bottom"  CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'
                            Text="��" ToolTip="������" Font-Underline="False"></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle Width="16px" />
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="����" ShowHeader="False">
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkBtnShow" runat="server" CausesValidation="false" 
                             CommandName="P" CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'
                             Text='<%# Eval("lshow") %>' ToolTip="True��ʾ��False����"></asp:LinkButton>
                     </ItemTemplate>
                     <ItemStyle Width="50px" />
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="����" ShowHeader="False">
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkBtnDel" runat="server" CausesValidation="false" 
                             CommandName="D"  CommandArgument='<%# ((GridViewRow) Container).RowIndex %>'
                             Text="ɾ��"  ToolTip="������ȷ���Ƿ�ɾ�������ɻָ���"></asp:LinkButton>
                     </ItemTemplate>
                     <ItemStyle Width="50px" />
                 </asp:TemplateField>
             </Columns>
             <RowStyle Height="32px" />
         </asp:GridView>
         <div>
            <asp:ImageButton ID="ImageButton1" runat="server" 
                 ImageUrl="~/Images/refresh.gif" onclick="ImageButton1_Click" 
                 ToolTip="������Ŀ������ȡ�ʵ����ȣ�����ѧ�������˵����Σ�" />
         </div>       
         </div>
         <div  id="Ccontent" class="coursecontent" runat ="server">   
    </div>
         <br />
    </div>
</asp:Content>

