<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/Manage.master" AutoEventWireup="true" CodeFile="upgrade.aspx.cs" Inherits="Manager_upgrade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div class="manageplace" >
        <div style="border: 1px solid #CCCCCC; width: 368px;  margin: auto; ">
            <div style="border: 1px solid #EEEEEE; height: 18px; background-color: #EEEEEE;  margin: auto;">
                ѧ������</div>
            <br />
            <div style="border: 1px solid #E7E7E7; width: 220px; text-align: left; background-color: #EAEAEA;  margin: auto;">
                <br />
&nbsp;&nbsp;&nbsp; <b>ע������</b>���༶�����еİ༶�б�<br />
                <br />
&nbsp;����ΪȫУ�����༶�б��Է�ȱ���<br />
                <br />
&nbsp;��ɾ�������İ༶��лл����<br />
                &nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp; <b>����Ч��</b>��ѧ���������꼶����һ<br />
                <br />
&nbsp;�꣬Ȼ����ѧ������ɾ���༶���в���&nbsp; 
                <br />
                <br />
&nbsp;�ڰ༶��ѧ��������༶δ���ã���ѧ 
                <br />
                <br />
&nbsp;�����ఴťʧЧ��<br />
                <br />
&nbsp;&nbsp;&nbsp; ѧ�����಻Ӱ����ҳ�����е�ѧ��<br />
                <br />
                &nbsp;Ftp��ַ��<br />
                <br />
&nbsp; <strong>&nbsp;���⴦��</strong>������ǰ�Ƚ����ݱ��ݲ˵���<br />
                <br />
                �������ݿ⣬������꼶�İ༶��ȱ�٣�<br />
                <br />
                ������ڰ༶�б����ֶ����ȱ�ٵİ�<br />
                <br />
                ������Ӱ�����ݡ�<br />
                <br />
               <div style="font-family: ����, Arial, Helvetica, sans-serif; font-size: 9pt; font-weight: bold; text-align: center">
                    ע�⣺��ѧ����������������룡</div>
                <br />
            </div>
            <br />
            <asp:TextBox ID="Textthisyear" runat="server" 
                BorderStyle="None" Width="90px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
                    <asp:Button ID="Btnupgrade" runat="server" BackColor="#E6E6E6" 
                        BorderColor="#D4D4D4" BorderWidth="1px" Font-Names="Arial" 
                Font-Size="9pt" Text="ѧ������" Width="80px" Height="20px" 
                onclick="Btnupgrade_Click" />
                    <br />
            <br />
            <div id="Loading" style=" display:none ;text-align: center; font-family: ����, Arial, Helvetica, sans-serif; font-size: 9pt; color: #FF0000;">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/load2.gif" />
            <input id="Textcmd" style="border-style: none" type="text" /></div>
            <br />
        </div>
        <br />
        <br />
        <asp:Label ID="Labelmsg" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <br />
        <br />
</div>
</asp:Content>

