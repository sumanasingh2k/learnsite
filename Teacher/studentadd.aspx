<%@ Page Title="" Language="C#"  StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="studentadd.aspx.cs" Inherits="Teacher_studentadd" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<div  class="placehold">
    ѧ��������Ϣ<br />
    <div class="teacherdiv">    
         <table width="100%" style="border-right: WhiteSmoke 1px solid; border-top: WhiteSmoke 1px solid; border-left: WhiteSmoke 1px solid; border-bottom: WhiteSmoke 1px solid; text-align: left; font-size: 9pt;">
            <tr>
                <td style="width: 180px; height: 22px ">
                    &nbsp;ѧ��
                    <asp:TextBox ID="Tsnum" runat="server" BorderColor="Gainsboro"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px"  
                        ToolTip="�Զ����ɣ�" ></asp:TextBox></td>
                <td style="width: 180px; height: 22px ">
                    &nbsp;����
                    <asp:TextBox ID="Tsname" runat="server" BackColor="Cornsilk" BorderColor="#E0E0E0"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px"></asp:TextBox></td>
                <td style="width: 180px; height: 22px ">
                    &nbsp;��ѧ
                    <asp:DropDownList ID="DDLyear" runat="server" Font-Size="9pt" Width="60px" 
                        BackColor="Cornsilk">
    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 180px; height: 22px">
                    &nbsp;�꼶
                    <asp:DropDownList ID="DDLgrade" runat="server" Font-Size="9pt" 
                Width="60px" BackColor="Cornsilk">
    </asp:DropDownList></td>
                <td style="width: 180px; height: 22px">
                    &nbsp;�༶
                    <asp:DropDownList ID="DDLclass" runat="server" Font-Size="9pt" Width="60px" 
                        BackColor="Cornsilk">
    </asp:DropDownList></td>
                <td style="width: 180px; height: 22px">
                    &nbsp;����
                    <asp:TextBox ID="Tsheadtheacher" runat="server" BackColor="Cornsilk" BorderColor="#E0E0E0"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 180px; height: 22px">
                    &nbsp;����
                    <asp:TextBox ID="Tspwd" runat="server" BackColor="White" BorderColor="Gainsboro"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px" ReadOnly="True" ToolTip="���벻���޸ģ�">12345</asp:TextBox></td>
                <td style="width: 180px; height: 22px">
                    &nbsp;�Ա�
                    <asp:DropDownList ID="DDLsex" runat="server" Font-Size="9pt" Width="60px" 
                        BackColor="Cornsilk">
    </asp:DropDownList></td>
                <td style="width: 180px; height: 22px">
                    &nbsp;��ĸ <asp:TextBox ID="Tsparents" runat="server" BackColor="Cornsilk" BorderColor="#E0E0E0"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 180px; height: 22px">
                    &nbsp;���� <asp:TextBox ID="Tsattitude" runat="server" BackColor="White" BorderColor="Gainsboro"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px"   ReadOnly="True" ToolTip="���ֲ����޸ģ�">0</asp:TextBox></td>
                <td style="width: 180px; height: 22px">
                    &nbsp;�ɼ�
                    <asp:TextBox ID="Tsscore" runat="server" BackColor="White" BorderColor="Gainsboro"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px" ReadOnly="True" ToolTip="�ɼ������޸ģ�">0</asp:TextBox></td>
                <td style="width: 180px; height: 22px">
                    &nbsp;�绰 <asp:TextBox ID="Tsphone" runat="server" BackColor="Cornsilk" BorderColor="#E0E0E0"
                        BorderStyle="Solid" BorderWidth="1px" Width="110px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 22px" colspan="3">
                    &nbsp;��ַ 
                    <asp:TextBox ID="Tsaddress" runat="server" BackColor="Cornsilk" BorderColor="#E0E0E0"
                        BorderStyle="Solid" BorderWidth="1px" Width="508px"></asp:TextBox>&nbsp;</td>
            </tr>
        </table>       			
</div>
    <asp:Label ID="Labelmsg" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Btnadd" runat="server"  OnClick="Btnadd_Click" Text="���" SkinID="BtnNormal" />
    <br />
    </div> 
    </form>
</body>
</html>

