<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master"  StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="typeadd.aspx.cs" Inherits="Teacher_typeadd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
<div  class="placehold">
<br />
    <div  class="typediv">
        &nbsp; �������±��⣺<asp:TextBox ID="Ttitle" runat="server"  Width="220px"  
            SkinID="TextBoxNormal"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnNoSet" runat="server" Text="�����ʽ" OnClick="BtnNoSet_Click"  SkinID="BtnNormal"  ToolTip="ϵͳ���ƺ��ֳ���Ϊ210��" />
                </div>
    <div  class="typediv">
        <asp:TextBox ID="Tcontent" runat="server" Height="180px" MaxLength="300" TextMode="MultiLine"
            Width="650px" BorderColor="#DFDFDF" BorderStyle="Solid" BorderWidth="1px" 
            BackColor="White" ></asp:TextBox>
        <br />
     <div  class="typedivcenter">
         <br />
              <asp:Button ID="BtnAdd" runat="server"  Text="���" OnClick="BtnAdd_Click"  SkinID="BtnNormal" />&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Btnreturn" runat="server"  Text="����" OnClick="Btnreturn_Click"  SkinID="BtnNormal" /><br />
               <br />
               <asp:Label ID="Labelmsg" runat="server">ϵͳ�������³���Ϊ210�����֣����ʱ�Զ�ȥ�ո񲢲ü���</asp:Label>
         <br />
         </div>
         </div>
         <br />
         <br />           
        </div>
</asp:Content>

