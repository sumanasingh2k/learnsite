<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="website.aspx.cs" Inherits="Ftpweb_website" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div  class="placehold"> 
        <br />       
        <div  class="website">
        <div  class="phead"> ѧ����վ����</div>
            <div  class="websitediv">
                <br />
                <asp:Button ID="Buttonspace" runat="server"    Text="��ȡFtpѧ���ռ�ռ��"  
                    SkinID="BtnLong" onclick="Buttonspace_Click" ToolTip="��Ftp���ݿ��ȡ��ǰ�ռ�ռ�����" />
                <br />
                <br />
            </div>
             <div class="websitediv">
                 <br />
                 ���볤��<asp:DropDownList ID="DDLlen" runat="server" Font-Size="9pt">
                     <asp:ListItem>2</asp:ListItem>
                     <asp:ListItem>3</asp:ListItem>
                     <asp:ListItem>5</asp:ListItem>
                     <asp:ListItem>6</asp:ListItem>
                     <asp:ListItem>8</asp:ListItem>
                     <asp:ListItem>12</asp:ListItem>
                     <asp:ListItem Selected="True">16</asp:ListItem>
                 </asp:DropDownList>
                 ��������<asp:DropDownList ID="DDLmethod" runat="server" Font-Size="9pt">
                     <asp:ListItem Value="0">��������</asp:ListItem>
                     <asp:ListItem Value="1">������ĸ</asp:ListItem>
                     <asp:ListItem Selected="True" Value="2">������ĸ</asp:ListItem>
                 </asp:DropDownList>
                 &nbsp;
                 <asp:Button ID="ButtonRadom" runat="server" Text="����Ftp���������"   
                     SkinID="BtnLong"  onclick="ButtonRadom_Click" 
                     ToolTip="����ȫУ����ftp�û���������룡" />
                 <br />
                 <br />
                 <asp:Button ID="ButtonStuPwd" runat="server" Text="����Ftp������ѧ�����˵�¼����һ��"   
                     SkinID="BtnLong"  onclick="ButtonStuPwd_Click" 
                     ToolTip="����ȫУ����ftp�û����¼����ͬ��" Width="300px" />
                 <br />
            </div>
             <div class="websitediv">
                 <br />
                 ѡ���ͶƱ����<asp:DropDownList ID="DDLWvote" runat="server" 
                     Font-Size="9pt" Width="50px">
                     <asp:ListItem>0</asp:ListItem>
                     <asp:ListItem>3</asp:ListItem>
                     <asp:ListItem>5</asp:ListItem>
                     <asp:ListItem>8</asp:ListItem>
                     <asp:ListItem Selected="True">12</asp:ListItem>
                     <asp:ListItem>16</asp:ListItem>
                 </asp:DropDownList>
                 &nbsp;
                <asp:Button ID="ButtonVote" runat="server"  Text="�Ͽΰ༶��վͶƱ����"  SkinID="BtnLong"  onclick="ButtonVote_Click" 
                     ToolTip="ÿ������ҳ�����ζ���һ��ͶƱ���ᣬֻ�����������̵ĵ�ǰ�Ͽΰ༶����Ӱ��������ʦ�༶" 
                     style="margin-bottom: 0px" />
                 <br />
                 <br />
                <br />
            </div>
           <div class="websitediv">
                 <br />
                 �����ҳ��<asp:DropDownList ID="DDLhtmlname" runat="server" Font-Size="9pt">
                     <asp:ListItem>index.htm</asp:ListItem>
                     <asp:ListItem>1.htm</asp:ListItem>
                     <asp:ListItem>2.htm</asp:ListItem>
                     <asp:ListItem>3.htm</asp:ListItem>
                     <asp:ListItem>4.htm</asp:ListItem>
                     <asp:ListItem>5.htm</asp:ListItem>
                     <asp:ListItem>6.htm</asp:ListItem>
                     <asp:ListItem>7.htm</asp:ListItem>
                     <asp:ListItem>8.htm</asp:ListItem>
                 </asp:DropDownList>
                 &nbsp;
                <asp:Button ID="ButtonCheck" runat="server"  Text="���ѧ����վ����"  SkinID="BtnLong"  onclick="ButtonCheck_Click" 
                     ToolTip="�����̵ĵ�ǰ�༶����ѧ����վ���������⣬�����������ڼ�¼�����ݿ���Ϊ����ʱ�ο�����" />
                 <br />
                 <br />
                <br />
            </div>
            <div  class="websitediv" >
                <br />
                <asp:Button ID="Btnsite" runat="server"   Text="ѧ����վ���������"   SkinID="BtnLong"  onclick="Btnsite_Click" />
                &nbsp;
                <asp:Button ID="BtnReBuild" runat="server"   SkinID="BtnLong"  
            onclick="BtnReBuild_Click" ToolTip="���ã�����ѧ���䶯ʱʹ�ã����¸������̰༶ѧ����վ��ַ" 
            Text="����ѧ����վ��ַ" />
                <br />
                <br />
            </div>   
            <div  class="websitediv" >
        <br />
                <asp:Button ID="BtnTeacher" runat="server"   SkinID="BtnLong"  
            onclick="BtnTeacher_Click" ToolTip="�������̰༶ģ��ѧ����ɫʱ������ҳ�ĸ���Ftp�ռ��˺�" 
            Text="����ģ��ѧ��Ftp�ռ�" />
                <br />
        <br />
            </div>  
        <div  class="websitediv" >
                <br />
                �趨ѧ���ռ䵱ǰ��ҳλ����<asp:TextBox ID="TextBoxHome" runat="server" Width="80px"></asp:TextBox>
                Ŀ¼��
&nbsp;<asp:Button ID="BtnEditHome" runat="server"   SkinID="BtnSmall"  
            onclick="BtnEditHome_Click" 
            Text="�޸�" />
                <br />
&nbsp;<br />
                <span style="color: #008080">˵�������� ��ʾ�ڸ�Ŀ¼�������趨Ϊѧ���ռ䵱ǰ��ҳλ�ã�����web<br />
                <br />
                ���ܣ����ô�λ�����ƺ�ѧ����վ�������ʦ����ʱ����ַ��Ϊ��ǰλ��<br />
                </span><br />
                </div>          
        </div>

           <div id="Loading" style=" display:none ;text-align: center; font-family: ����, Arial, Helvetica, sans-serif; font-size: 9pt; color: #FF0000;">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/load2.gif" />
            <input id="Textcmd" style="border-style: none" type="text" /></div>
                <br />
            <asp:Label ID="Labelmsg" runat="server" Font-Names="Arial" Font-Size="9pt" 
                ForeColor="Red" Height="18px"></asp:Label>
            <br />
            <br />
    </div>
</asp:Content>

