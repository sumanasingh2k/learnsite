<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manage.master"  StylesheetTheme="Teacher"  AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Manager_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
<div class="manageplace" >
    <div style=" margin: auto; border: 1px solid #E0E0E0; width: 480px; ">
        <div style="background-color: #EEEEEE; height: 18px;">
        ϵͳ˵��</div>
        <br />
        <div style="padding: 6px; margin: auto; width: 431px; text-align: left; background-color: #FAFAFA; ">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ��ϵͳ����ԭ��ITMS1.0�Ļ��������±�д���ɡ����ݿ�ṹ�Ż����������<br />
            <br />
            ����ܹ�ԭ���д������չ��ǿ��ϵͳ�����ֽ�ɫ��¼��ѧ������ʦ������Ա��<br />
            &nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ��ʦƽ̨���ܣ�ѧ������ѧ��������Ʒ����ǩ��������ҳ������<br />
            <br />
            �ֹ�����Դ�����ߴ��ܡ�<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; �����̨���ܣ�ϵͳ���á���ʦ�����༶���á��������롢�ռ����ɡ�ѧ��<br />
            <br />
            �������<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ��ʷ�汾��ITMS1.0��&gt;Magnet2.2��&gt;LearnSite1.100��&gt;LearnSite1.2.1.8<br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            2009��8��&nbsp;&nbsp; ����ˮ��<br />
        </div>
        <br />
        </div>
    <br />
    <br />
                    <asp:Button ID="Btnlogout" runat="server" BackColor="#E6E6E6" 
                        BorderColor="#D4D4D4" BorderWidth="1px" Font-Names="Arial" 
                        Font-Size="9pt" Text="ϵͳ�˳�" Width="80px" 
            onclick="Btnlogout_Click" />
       
    <br />
       
    <br />
       
    <br />
    <asp:TextBox ID="TextBox1" runat="server"  SkinID="TextBoxindex" ReadOnly="true" Width="80px">��������ͼ��</asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server"  SkinId="TextBoxaa"
        ReadOnly="True" Width="56px">�༶����</asp:TextBox>
    <asp:TextBox ID="TextBox7" runat="server"  SkinId="TextBoxbb"  ReadOnly="True" Width="22px">��</asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"  SkinId="TextBoxaa" ReadOnly="True" Width="56px">��ʦ����</asp:TextBox>
    <asp:TextBox ID="TextBox8" runat="server"  SkinId="TextBoxbb"  ReadOnly="True" Width="22px">��</asp:TextBox>
    <asp:TextBox ID="TextBox4" runat="server"  SkinId="TextBoxaa" ReadOnly="True" Width="56px">��������</asp:TextBox>
    <asp:TextBox ID="TextBox9" runat="server" SkinId="TextBoxbb"  ReadOnly="True" Width="22px">��</asp:TextBox>
    <asp:TextBox ID="TextBox5" runat="server"  SkinId="TextBoxaa"  ReadOnly="True" Width="56px">�ռ�����</asp:TextBox>
    <br />
    <br />
    <b>����Ա</b>������ȫУ�����༶�б�-&gt;��ӽ�ʦ������ʦѡ��ָ���İ༶-&gt;ʹ��ѧ��excelģ�嵼������<br />
    <br />
    <b>��ʦ</b>����ʦƽ̨��¼-&gt;����(ʹ�û�����顢�������ѧ�����)-&gt;�Ͽ�(�鿴ǩ�����鿴��Ʒ�����)-&gt;����-&gt;��˼<br />
    <br />
    <b>ѧ��</b>��ѧ��ƽ̨��¼-&gt;�����ǰѧ��-&gt;��ɵ�ѧ��׼������-&gt;��ɿ��û�����顢���۵�-&gt;��Ʒչʾ-&gt;ʦ������С��<br />
    <br />
       
</div>

</asp:Content>

