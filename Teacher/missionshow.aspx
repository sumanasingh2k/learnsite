<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" Validaterequest="false"  AutoEventWireup="true" CodeFile="missionshow.aspx.cs" Inherits="Teacher_missionshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
<div class="courseshow">
    <br />
        <div   class="missiontitle">
    <asp:Label ID="LabelMtitle"  runat="server" ></asp:Label>
   </div><br />
    <div class="courseother">
       ���ڣ�<asp:Label ID="LabelMdate"  runat="server" ></asp:Label>
			&nbsp;��Ʒ���ͣ�<asp:Image ID="ImageType" runat="server" />
			<asp:Label ID="LabelMfiletype" runat="server" ></asp:Label>
            <asp:CheckBox ID="CkMupload" runat="server" Text="�Ƿ��ύ" Enabled="false" />
            <asp:CheckBox ID="CheckPublish" runat="server" Text="�Ƿ񷢲�" 
            Enabled="False" />
            <asp:CheckBox ID="CheckGroup" runat="server" Text="С�����" Enabled="false" />&nbsp;<asp:HyperLink 
            ID="HLMgid" runat="server">���۱�׼</asp:HyperLink>
            <asp:ImageButton ID="BtnEdit" runat="server" ToolTip="����޸�" 
            ImageUrl="~/Images/edit.gif" onclick="BtnEdit_Click" 
           style="width: 16px" />
   &nbsp;<asp:ImageButton ID="BtnReturnSmall" runat="server" ToolTip="����" 
            ImageUrl="~/Images/return.gif" onclick="BtnReturnSmall_Click" 
           style="width: 16px" />
   </div>   
    <link href="../kindeditor/plugins/syntaxhighlighter/styles/shCore.css" rel="stylesheet" type="text/css" />
    <link href="../kindeditor/plugins/syntaxhighlighter/styles/shThemeRDark.css" rel="stylesheet"   type="text/css" />
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shCore.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushCss.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushJScript.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushVb.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushCSharp.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushCpp.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushPython.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushPhp.js" type="text/javascript"></script>
    <script src="../kindeditor/plugins/syntaxhighlighter/scripts/shBrushXml.js" type="text/javascript"></script>
    <script  type="text/javascript">        SyntaxHighlighter.all();  </script>
        <div   id="Mcontent"  class="coursecontent" runat="server">	
		</div>
		<br />
         <asp:LinkButton ID="LinkBtn" runat="server"  OnClick="LinkBtn_Click" SkinID="LinkBtn">����ѧ��</asp:LinkButton>
    <br />
		<br />

</div> 
    <br />
     </asp:Content>

