<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manage.master" AutoEventWireup="true" CodeFile="studentimport.aspx.cs" Inherits="Manager_studentimport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
       <div class="manageplace" >        
        <div style="border: 1px solid #D8D8D8; width: 283px;  margin: auto; ">
        <div style="font-size: 9pt; background-color: #EEEEEE; height: 18px;  margin: auto;">
        ѧ����Ϣ����</div>
            <br />
            <br />
            <asp:FileUpload ID="FileUpExcel" runat="server" BorderColor="Gainsboro" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Arial" Font-Size="9pt" Height="20px" 
                Width="160px" BackColor="White" />
            <br />
           <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Text="����ת��Ϊ����ƴ����д" 
                ToolTip="�Ƿ��ڻ�ȡ����ʱ�Զ�������ת��Ϊѧ������ƴ����д" />
            <br />
            <br />
            <asp:Button ID="ButtonInsert" runat="server" BorderColor="Silver" BorderStyle="None"
                BorderWidth="1px" Font-Names="Arial" Font-Size="9pt" Height="20px" OnClick="ButtonInsert_Click"
                TabIndex="1" Text="1 �ϴ�Excel" Width="100px" ToolTip="�ϴ���������ʱѧ����" />            
            <br />
            <br />
            <br />
            <asp:Button ID="ButtonAppend" runat="server" BorderColor="Silver"
                BorderStyle="None" BorderWidth="1px" Font-Names="Arial" Font-Size="9pt" Height="20px"
                OnClick="ButtonAppend_Click" TabIndex="1" Text="2 ��������" Width="100px" 
                ToolTip="���ϴ���ѧ����ʱ�����ݵ���ƽ̨ѧ������" Enabled="False" />
            <br />
            <br />
            <div id="Loading" style=" display:none ;text-align: center; font-family: ����, Arial, Helvetica, sans-serif; font-size: 9pt; color: #FF0000;">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/load2.gif" />
            <input id="Textcmd" style="border-style: none" type="text" /></div>  
            <br />
            <br />
        </div>
        <br />
        <asp:Label ID="Labelmsg" runat="server" Font-Names="Arial" Font-Size="9pt" 
               ForeColor="Red">**����Excel�����б���Ҫ��ѧ�š���ѧ��ȡ��꼶���༶�����������롢�Ա�**<br />**��ѧ��ȡ��꼶���༶����Ϊ���֣�ѧ�ű���Ϊ�����Ҿ���������12λ**</asp:Label>
           <br />
           <br />
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/˵���ض�/ѧ������ģ��.xls" 
               Target="_blank">��ο���վĿ¼�µ�˵���ض�Ŀ¼�е�ѧ����ϢExcelģ��</asp:HyperLink>
           <br />
        <br />
            <asp:Button ID="ButtonClear" runat="server" BorderColor="#CCCCCC"
                BorderStyle="Solid" BorderWidth="1px" Font-Names="Arial" 
            Font-Size="9pt" Height="20px"
                OnClick="ButtonClear_Click" TabIndex="1" Text="��������������" Width="120px" 
            BackColor="#DDDDDD" ToolTip="ֻɾ���ղŵ�������ݣ��Է������µ��룡" Font-Bold="False" 
               ForeColor="Red" />
           <br />
        <br />
           <asp:GridView ID="GVrepeat" runat="server" BorderColor="#E1E1E1"
            BorderStyle="Solid" BorderWidth="1px" Font-Size="9pt"
            Width="280px" GridLines="None" CellPadding="2" PageSize="25" 
               Caption="�������ݼ����ظ��б�" HorizontalAlign="Center" 
               EnableTheming="False" EnableViewState="False">
                            <RowStyle Font-Size="9pt" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#EFEFEF" Font-Size="9pt" ForeColor="Black" 
                                HorizontalAlign="Center" />
                            <HeaderStyle BackColor="#EFEFEF" Font-Bold="False" Font-Size="9pt" 
                                ForeColor="#222222" />
                            <AlternatingRowStyle BackColor="#EFEFEF" BorderStyle="None" />
        </asp:GridView>

           <br />
        <br />
        </div>
</asp:Content>

