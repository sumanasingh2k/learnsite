<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" enableViewStateMac="false" CodeFile="systeminfo.aspx.cs" Inherits="Teacher_systeminfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div  class="placehold">
    <center>
        <br />
        <table style="border: 1px solid #D8D8D8; width: 300px; font-size: 9pt;font-family: ����, Arial, Helvetica, sans-serif;" 
            cellpadding="5" cellspacing="0">
            <tr>
                <td style="background-color: #E6E6E6; font-weight: bold;" colspan="2" 
                    align="center">
                    <asp:HyperLink ID="HlSearching" runat="server" 
                        ImageUrl="~/Workshow/image/zoom.gif" NavigateUrl="~/Workshow/search.aspx" 
                        Target="_blank"></asp:HyperLink>
                    ��վ����ͳ��</td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ѧ��������</td>
                <td>
                    <asp:Label ID="Label15" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ��Ʒ������</td>
                <td>
                    <asp:Label ID="Label16" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ѧ��������</td>
                <td>
                    <asp:Label ID="Label17" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ǩ��������</td>
                <td>
                    <asp:Label ID="Label18" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ���ִ�����</td>
                <td>
                    <asp:Label ID="Label19" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 120px">
                    ��Դ������</td>
                <td>
                    <asp:Label ID="Label20" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
       &nbsp;<asp:HyperLink ID="HLcomputer" runat="server" 
            NavigateUrl="~/Teacher/computers.aspx" CssClass="HyperlinkLong" 
            EnableTheming="False" EnableViewState="False">������IP��Ӧ��</asp:HyperLink>
        &nbsp;&nbsp;
        <asp:HyperLink ID="HLmythware" runat="server" 
            NavigateUrl="~/Teacher/mythware.aspx" CssClass="HyperlinkLong" 
            EnableTheming="False" EnableViewState="False">����༶ģ��</asp:HyperLink>
        <br />
        <br />
<table style="border: 1px solid #D8D8D8; font-size: 9pt; width: 600px;  text-align: left; font-family: ����, Arial, Helvetica, sans-serif; " 
            cellpadding="4" cellspacing="0">
            <tr>
                <td style="font-weight: bold; color: black; height: 16px; background-color: #E6E6E6; text-align: center;" 
                    colspan="4">
                    ������״̬</td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ������IP��</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                <asp:Image ID="ImageLogin" runat="server" ImageUrl="~/Images/green.gif" />
                </td>
                <td style="width: 116px" >
                    .NET����汾��</td>
                <td >
                    <asp:Label ID="Label8" runat="server" ></asp:Label>
                                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ���������ƣ�</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                <td style="width: 116px" >
                    �ű���ʱʱ�䣺</td>
                <td >
                    <asp:Label ID="Label9" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ����ϵͳ��</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label3" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    ��������ʱ����</td>
                <td >
                    <asp:Label ID="Label10" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    CPU����</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label4" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    ���̿�ʼʱ�䣺</td>
                <td >
                    <asp:Label ID="Label11" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    CPU����</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label5" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    AspNet�ڴ�ռ�ã�</td>
                <td >
                    <asp:Label ID="Label12" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ��Ϣ���������</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label7" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    AspNet CPUʱ�䣺</td>
                <td >
                    <asp:Label ID="Label13" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ��������������</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label21" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    AspNet��ǰ�߳�����</td>
                <td >
                    <asp:Label ID="Label14" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ��վƽ̨�汾��</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label6" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    Session������</td>
                <td >
                    <asp:Label ID="Label22" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 90px" >
                    ȫ�ֱ�������</td>
                <td style="width: 189px" >
                    <asp:Label ID="Label23" runat="server" ></asp:Label>
                </td>
                <td style="width: 116px" >
                    ��վ�쳣��¼��</td>
                <td >
        <asp:HyperLink ID="HLsitelog" runat="server" 
            NavigateUrl="~/Teacher/sitelog.aspx" BorderStyle="None" EnableTheming="False" 
                        EnableViewState="False"  Font-Underline="False" 
                        ForeColor="Black" Target="_blank" ToolTip="�뼰ʱ������ˮ��ظ�������">��ѯ</asp:HyperLink>
                </td>
            </tr>
            </table>
    <br />
    </center>
        </div>
</asp:Content>

