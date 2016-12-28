<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="quiz.aspx.cs" Inherits="Quiz_quiz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
<div   class="placehold">
    <div  class="quizleft">
        &nbsp;
        <asp:DropDownList ID="DDLqtype" runat="server" 
            Font-Size="9pt" ToolTip="����">
            <asp:ListItem Selected="True" Value="0">��ѡ��</asp:ListItem>
            <asp:ListItem Value="1">��ѡ��</asp:ListItem>
            <asp:ListItem Value="2">�ж���</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;<asp:DropDownList ID="DDLclass" runat="server" Width="100px" 
            Font-Size="9pt" ToolTip="ѧ������">
            </asp:DropDownList>
            &nbsp;
    <asp:Button ID="Btnlist" runat="server"  Text="���"  onclick="Btnlist_Click"  
            SkinID="BtnNormal" />  

    &nbsp;<asp:Label ID="Label1" runat="server" Width="180px"></asp:Label>
&nbsp;<asp:Button ID="Btnadd" runat="server"  Text="�������"  onclick="Btnadd_Click"  SkinID="BtnNormal" />  &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Btngradeset" runat="server"  Text="��������"  
            onclick="Btngradeset_Click"  SkinID="BtnNormal" />  &nbsp;&nbsp;
    </div>
    <div >            
                    <asp:GridView ID="GVQuiz" runat="server" AllowPaging="True"  SkinID="GridViewInfo"
                            AutoGenerateColumns="False"  DataKeyNames="Qid" Width="96%"  
                            onpageindexchanging="GVQuiz_PageIndexChanging" 
                            onrowdatabound="GVQuiz_RowDataBound" onrowcommand="GVQuiz_RowCommand" 
                            TabIndex="1" CellPadding="3" GridLines="Horizontal" 
                        EnableModelValidation="True" HorizontalAlign="Center">
                            <Columns>
                                <asp:BoundField HeaderText="���" HeaderStyle-Width="28px">
<HeaderStyle Width="28px"></HeaderStyle>
                                </asp:BoundField>
                                <asp:HyperLinkField DataNavigateUrlFields="Qid"  DataNavigateUrlFormatString="~/Quiz/quizedit.aspx?Qid={0}" 
                                    Text="�༭" >
                                <ItemStyle Width="30px" />
                                </asp:HyperLinkField>
                                <asp:TemplateField HeaderText="����">
                                    <ItemTemplate>
                                    <div style="overflow:hidden; width: 500px">
                                    <asp:Label ID="Labelquestion" runat="server" Text='<%# HttpUtility.HtmlDecode(DataBinder.Eval(Container.DataItem,"Question").ToString()) %>'></asp:Label>
                                    </div>
                                    </ItemTemplate>
                                    <ItemStyle Font-Size="9pt" HorizontalAlign="Left" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="Qclass" HeaderText="����" />
                                <asp:BoundField DataField="Qscore" HeaderText="��ֵ" />
                                <asp:BoundField DataField="Qanswer" HeaderText="��" />
                                <asp:TemplateField HeaderText="����">
                                    <ItemTemplate>
                                        <asp:Label ID="Labelqanalyze" runat="server" Text='��ʾ' ToolTip='<%# Bind("Qanalyze") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Qaccuracy" HeaderText="��ȷ" />
                                <asp:ButtonField Text="ɾ��" CommandName="Del" >
                                <ItemStyle Width="40px" />
                                </asp:ButtonField>
                            </Columns>
                            <pagertemplate>
                                <div style="width:100%; height:13px; text-align:right">
                                    ��<asp:Label ID="lblPageIndex" runat="server" 
                                        text="<%# ((GridView)Container.Parent.Parent).PageIndex + 1  %>" />
                                    ҳ ��<asp:Label ID="lblPageCount" runat="server" 
                                        text="<%# ((GridView)Container.Parent.Parent).PageCount  %>" />
                                    ҳ 
                                    <asp:LinkButton ID="btnFirst" runat="server" causesvalidation="False" 
                                        commandargument="First" commandname="Page" Font-Underline="False" 
                                        ForeColor="Black" text="��ҳ" />
                                    <asp:LinkButton ID="btnPrev" runat="server" causesvalidation="False" 
                                        commandargument="Prev" commandname="Page" Font-Underline="False" 
                                        ForeColor="Black" text="��һҳ" />
                                    <asp:LinkButton ID="btnNext" runat="server" causesvalidation="False" 
                                        commandargument="Next" commandname="Page" Font-Underline="False" 
                                        ForeColor="Black" text="��һҳ" />
                                    <asp:LinkButton ID="btnLast" runat="server" causesvalidation="False" 
                                        commandargument="Last" commandname="Page" Font-Underline="False" 
                                        ForeColor="Black" text="βҳ" />
                                </div>
                            </pagertemplate>
                        </asp:GridView>
                    <br />
                    <div >
                        &nbsp;
                        <asp:HyperLink ID="HlkQuizxml" runat="server" Font-Size="9pt">���������</asp:HyperLink>
                        &nbsp;<asp:Button ID="Btnexport"  runat="server"  Text="���������" 
                            SkinID="BtnNormal" TabIndex="2" onclick="Btnexport_Click" /> &nbsp;<asp:Label 
                            ID="Labelmsg" runat="server" Font-Size="9pt" Width="160px" ForeColor="Red"></asp:Label>
&nbsp;<asp:FileUpload ID="FileUploadquiz" runat="server" Font-Size="9pt" />
&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Btnimport"  runat="server"  Text="���������"  onclick="Btnimport_Click" 
                            SkinID="BtnNormal" TabIndex="2" />                    
                    &nbsp;&nbsp;                
                    </div>                  
                    <br />
                    </div>  
    </div>
</asp:Content>

