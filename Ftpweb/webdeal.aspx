<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manage.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="webdeal.aspx.cs" Inherits="Manager_webdeal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div  class="placehold" >
    <div  class="webdeal">
        <div style="border: 1px solid #EEEEEE; height: 18px; background-color: #EEEEEE;  margin: auto;">
                ѧ����ҳ�����ռ�����</div>         
             <br />
        <br />
             <div  class="webdealnote">
                 &nbsp;&nbsp;&nbsp; ѧ���ռ��Ǹ�����ѧ��ȡ�ѧ�Ŷ���ֱ��ڿռ��Ŀ¼<br />
                 <br />
                 �����ɷּ�Ŀ¼��ʹ��ѧ���������ӳ�һ������������<br />
                 <br />
                 ���໥Ӱ�졣������������������һ��Ҫ����ѧ��ȡ�ѧ��<br />
                 <br />
                 �������ݡ�<br />
                 <br />
             &nbsp;&nbsp;&nbsp; ����ǰ���ر�ע���Ƿ��Ѿ�������ftp���ݿ⣬����<br />
                 <br />
                 web.config���޸���ȷ�����ַ��������ݿ����ơ��˺š���<br />
                 <br />
                 ���룬�����ú�Serv_U����<br />
             </div>

        <br />
        <div class="divcenter">
        <br />
        �ռ��С<asp:DropDownList ID="DDLspace" runat="server" Font-Size="9pt" Width="60px">
            <asp:ListItem Value="30">30MB</asp:ListItem>
            <asp:ListItem Value="50" Selected="True">50MB</asp:ListItem>
            <asp:ListItem Value="100">100MB</asp:ListItem>
            <asp:ListItem Value="300">300MB</asp:ListItem>
            <asp:ListItem Value="500">500MB</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonFtpuser" runat="server" Text="����Ftp�˺�"  SkinID="BtnLong" 
            onclick="ButtonFtpuser_Click" ToolTip="ÿ�봴��20���û����ң����Լ�����ȴ�ʱ�䣡" />
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonMakeDir" runat="server" Text="����FtpĿ¼"  SkinID="BtnLong" onclick="ButtonMakeDir_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="Buttonview" runat="server" Text="���Ftp�û�" SkinID="BtnLong" onclick="Buttonview_Click"  />
        <br />
        </div>
        <br />
        <div id="Loading" style=" display:none ;text-align: center; font-family: ����, Arial, Helvetica, sans-serif; font-size: 9pt; color: #FF0000;">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/load2.gif" />
            <input id="Textcmd" style="border-style: none" type="text" /></div>        
        <br />
        <br />
        <asp:Label ID="Labelmsg" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
       </div>
    <br />
</div>
</asp:Content>

