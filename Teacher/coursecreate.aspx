<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="coursecreate.aspx.cs" Inherits="Teacher_coursecreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
 <div  class="placehold">
    <br />
     <br />
     <br />
     <br />
     <br />
        <div  class ="create">
            <div  class="phead">
     ѧ������</div>
            <br />
            <br />
&nbsp;&nbsp; ѧ�����ƣ�<asp:TextBox ID="Texttitle" runat="server" Width="280px"  SkinID="TextBoxNormal"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp; ѧ�����ࣺ<asp:DropDownList ID="DDLclass" runat="server" Width="100px" 
            Font-Size="9pt">
            </asp:DropDownList>
            <br />
            <br />
            &nbsp;&nbsp; ��ѧ�꼶��<asp:DropDownList ID="DDLcobj" runat="server" Width="100px" 
            Font-Size="9pt" AutoPostBack="True" 
                onselectedindexchanged="DDLcobj_SelectedIndexChanged">
                </asp:DropDownList>        
            <br />
            <br />
&nbsp;&nbsp; ���ſνڣ�<asp:DropDownList ID="DDLCks" runat="server" Font-Size="8pt"
            Width="50px" Font-Names="Arial">          
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="Checkcpublish" runat="server" Text="�Ƿ񷢲�" 
            Checked="True" />
            <br />
            <br />
            <div class="courseshow">
                <asp:Label ID="Labelterm" runat="server" Text="Label"></asp:Label>
            </div>
            <br />
        </div>
        <br />
        <br />
                    <asp:Button ID="BtnCreate" runat="server"  Text="����ѧ��"  onclick="BtnCreate_Click"  SkinID="BtnNormal"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btnreturn" runat="server"  Text="ѧ������" onclick="Btnreturn_Click" SkinID="BtnNormal" />
                    <br />
                    <br />
     <br />           
        <asp:Label ID="Labelmsg" runat="server"></asp:Label>           
        <br />
        <br />
     <br />           
        </div>
</asp:Content>

