<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manage.master" AutoEventWireup="true" CodeFile="setting.aspx.cs" Inherits="Manager_setting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div class="manageplace" >
        <div class="settingdiv">
            <div style="background-color: #EEEEEE; height: 18px;">��ǰ����</div>
            <br />
            <div  class="setting" >
            <br />
                    &nbsp;��վ�������ã�<asp:TextBox ID="TextBoxsite" runat="server" BorderColor="#CCCCCC" 
                BorderStyle="Solid" BorderWidth="1px" Width="200px"></asp:TextBox>
&nbsp;<asp:Button ID="Buttonsite" runat="server" Font-Size="9pt" Height="20px" Text="�޸�" 
               BorderColor="Silver" BorderStyle="Solid"  BorderWidth="1px"   BackColor="#E8E8E8"  
               onclick="Buttonsite_Click" />
                <br />
                <br />
                &nbsp;ѧ����¼��ʽ��<asp:DropDownList ID="DDLLoginMode" runat="server" Font-Size="9pt" 
                    EnableTheming="True" AutoPostBack="True" 
            onselectedindexchanged="DDLLoginMode_SelectedIndexChanged" ToolTip="ѡ��ѧ����¼��ʽ">
                <asp:ListItem Value="0">��������</asp:ListItem>
                <asp:ListItem Value="1">�༶����</asp:ListItem>
        </asp:DropDownList>
                <br />
                <br />
                &nbsp;�˺ŵ�¼���ƣ�<asp:CheckBox ID="CheckBoxSingleLogin" runat="server" AutoPostBack="True" 
                        Font-Size="9pt" oncheckedchanged="CheckBoxSingleLogin_CheckedChanged" 
                    Text="�Ƿ�����һ���˺�ֻ����һ̨���Ե�¼ƽ̨" ToolTip="˵����ѡ����һ��ѧ���˺Ų����ڶ�̨���Ե�¼ͬ��ƽ̨��" />
                <br />
                <br />
                    &nbsp;��ǰѧ�����ã�<asp:DropDownList ID="DDLterm" runat="server" Font-Size="9pt" 
                    EnableTheming="True" AutoPostBack="True" 
            onselectedindexchanged="DDLterm_SelectedIndexChanged" ToolTip="ѡ��ǰѧ��">
                <asp:ListItem Value="1">��һѧ��</asp:ListItem>
                <asp:ListItem Value="2">�ڶ�ѧ��</asp:ListItem>
        </asp:DropDownList>
            <br />
            <br />
                &nbsp;��Դ�������ƣ�<asp:CheckBox ID="CheckBoxDownCan" runat="server" AutoPostBack="True" 
                        Font-Size="9pt" oncheckedchanged="CheckBoxDownCan_CheckedChanged" Text="�Ƿ���������" />
                <br />
                <br />
                &nbsp;��Դ����ʱ�䣺<asp:DropDownList ID="DDLDownTime" runat="server" AutoPostBack="True" Font-Size="9pt" 
                        onselectedindexchanged="DDLDownTime_SelectedIndexChanged">
                        <asp:ListItem Value="10">10����</asp:ListItem>
                        <asp:ListItem Value="20">20����</asp:ListItem>
                        <asp:ListItem Value="30">30����</asp:ListItem>
                        <asp:ListItem Value="40">40����</asp:ListItem>
                        <asp:ListItem Value="50">50����</asp:ListItem>
                        <asp:ListItem Value="60">60����</asp:ListItem>
                    </asp:DropDownList>
                ֮�������<br />
            <br />
                &nbsp;ѧ����ҳͶƱ��<asp:CheckBox ID="CheckBoxweblimit" runat="server" Text="�Ƿ�����ͶƱ" 
                    oncheckedchanged="CheckBoxweblimit_CheckedChanged" AutoPostBack="True" />
            <br />
            <br />
            &nbsp;��ҳ�������ͣ�<asp:TextBox ID="TextBoxtype" runat="server" BorderColor="#CCCCCC" 
                BorderStyle="Solid" BorderWidth="1px" Width="200px" ToolTip="�����������ҳ�������ͣ��ָ���&quot;|&quot;"></asp:TextBox>
&nbsp;<asp:Button ID="Buttontype" runat="server" Font-Size="9pt" Height="20px" Text="�޸�" 
               BorderColor="Silver" BorderStyle="Solid"  BorderWidth="1px"   BackColor="#E8E8E8" 
                    onclick="Buttontype_Click" ToolTip="ע��ǰ�󶼲��ӷָ���&quot;|&quot;" />
            <br />
            <br />
            &nbsp;��ҳĿ¼���ƣ�<asp:TextBox ID="TextBoxdir" runat="server" BorderColor="#CCCCCC" 
                BorderStyle="Solid" BorderWidth="1px" Width="200px" ToolTip="���������ϴ�����ҳĿ¼���ƣ��ָ���&quot;|&quot;"></asp:TextBox>
&nbsp;<asp:Button ID="Buttondir" runat="server" Font-Size="9pt" Height="20px" Text="�޸�" 
               BorderColor="Silver" BorderStyle="Solid"  BorderWidth="1px"   BackColor="#E8E8E8" 
                    onclick="Buttondir_Click" ToolTip="ע��ǰ�󶼲��ӷָ���&quot;|&quot;" />
            <br />
            <br />
                &nbsp;��Ʒ�鿴ʱ�䣺<asp:DropDownList ID="DDLworkdowntime" runat="server" Font-Size="9pt" 
                    EnableTheming="True" AutoPostBack="True" 
            onselectedindexchanged="DDLworkdowntime_SelectedIndexChanged" ToolTip="ѡ��鿴����">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
                �����Բ鿴<br />
                <br />
                &nbsp;��Ʒ�ύ���ƣ�<asp:CheckBox ID="CheckBoxWorkIp" runat="server" AutoPostBack="True" 
                        Font-Size="9pt" oncheckedchanged="CheckBoxWorkIp_CheckedChanged" 
                    Text="�Ƿ��ͬ����Ʒ�ύ����Ip����" ToolTip="ͬ��һ��Ip�����ύһ����Ʒ" />
                <br />
                <br />
                &nbsp;CookiesʧЧ���ã�<asp:DropDownList ID="DDLCookiesPeriod" runat="server" 
                    AutoPostBack="True" Font-Size="9pt" 
                        onselectedindexchanged="DDLCookiesPeriod_SelectedIndexChanged">
                        <asp:ListItem Value="0">�ر�ʧЧ</asp:ListItem>
                        <asp:ListItem Value="1">45����</asp:ListItem>
                        <asp:ListItem Value="2">1Сʱ</asp:ListItem>
                        <asp:ListItem Value="3">3Сʱ</asp:ListItem>
                        <asp:ListItem Value="4">5Сʱ</asp:ListItem>
                        <asp:ListItem Value="5">����</asp:ListItem>
                    </asp:DropDownList>
                <br />
                <br />
                <div>
&nbsp;Cookiesǰ׺���ã�<asp:Label ID="LabelCookiesFix" runat="server" Width="160px" 
                    BorderColor="#E1E1E1" BorderWidth="1px"></asp:Label>
                &nbsp;<asp:Button ID="ButtonFix" runat="server" Font-Size="9pt" Height="20px" Text="����" 
               BorderColor="Silver" BorderStyle="Solid"  BorderWidth="1px"   
                    BackColor="#E8E8E8" onclick="ButtonFix_Click"  />
                <br />
                </div>
                <br />
                &nbsp;&nbsp;ȫ��ѧ���ջ����أ�<asp:Button ID="Btnpublish" runat="server" Font-Size="9pt" 
                    Height="20px" Text="һ���ջ�" 
               BorderColor="Silver" BorderStyle="Solid"  BorderWidth="1px"   BackColor="#E8E8E8" 
                    onclick="Btnpublish_Click" ToolTip="�ջص�ѧ��ֻ����ѧ�����治��ʾ����ʦ��������ʾ���������óɷ���״̬" 
                    Width="80px" />
                <br />
                <br />
                &nbsp;��Ʒ�ϴ��ؼ�ѡ��<asp:DropDownList ID="DDLUploadMode" runat="server" 
                    AutoPostBack="True" Font-Size="9pt" 
                    onselectedindexchanged="DDLUploadMode_SelectedIndexChanged">
                    <asp:ListItem Value="0">Swfupload�ϴ��ؼ�</asp:ListItem>
                    <asp:ListItem Value="1">��ͨ��ˢ�·�ʽ�ϴ�</asp:ListItem>
                    </asp:DropDownList>
                <br />
                <br />
&nbsp;ftp����˿ں����ã�<asp:DropDownList ID="DDLftpport" runat="server" Font-Size="9pt" 
                    EnableTheming="True" AutoPostBack="True" 
            onselectedindexchanged="DDLftpport_SelectedIndexChanged" Width="50px">
                <asp:ListItem Selected="True">21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
        </asp:DropDownList>
                <br />
                <br />
&nbsp;��ʦƽ̨��¼���ƣ�<asp:CheckBox ID="CheckBoxLogin" runat="server" 
                    oncheckedchanged="CheckBoxLogin_CheckedChanged" Text="����Ϊ��������ͬ���β��ܵ�¼" 
                    AutoPostBack="True" />
                <asp:Image ID="ImageLogin" runat="server" ImageUrl="~/Images/green.gif" />
                <br />
                <br />
                </div>
            <br />
            <asp:Label ID="Labelmsg" runat="server" ForeColor="Red" ></asp:Label>
            <br />
            <br />
         </div>
        <br />

</div>
</asp:Content>

