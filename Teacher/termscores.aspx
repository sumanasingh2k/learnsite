<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher/Teach.master" StylesheetTheme="Teacher" AutoEventWireup="true" CodeFile="termscores.aspx.cs" Inherits="Teacher_termscores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content" Runat="Server">
    <div  class="placehold"> 
        <div  >        
           �꼶<asp:DropDownList ID="DDLgrade" runat="server" 
                Font-Size="9pt" Width="50px" 
                onselectedindexchanged="DDLgrade_SelectedIndexChanged" AutoPostBack="True"> </asp:DropDownList>
            �༶<asp:DropDownList ID="DDLclass" runat="server" Font-Size="9pt" 
                Width="50px" AutoPostBack="True" 
                onselectedindexchanged="DDLclass_SelectedIndexChanged">
            </asp:DropDownList>&nbsp;��<asp:Label ID="Lbterm" runat="server"></asp:Label>
            ѧ��&nbsp;
            <asp:Button   ID="BtnScoresNo" runat="server"  OnClick="BtnScoresNo_Click" 
                Text=" δ������C"  SkinID="BtnNormal" ToolTip="���̰༶δ����Ʒȫ������ΪC������ֵ6" />
            &nbsp;&nbsp;
            <asp:Button   ID="BtnScores" runat="server"  OnClick="BtnScore_Click" 
                Text="�ܷ�����"  SkinID="BtnSmall" ToolTip="��ͳ���ܷ֣��ٵó������ܷ�" />
            &nbsp;&nbsp; 
            <asp:Button ID="Btnape" runat="server"  onclick="Btnape_Click" Text="��ĩ����" 
                SkinID="BtnSmall" />
&nbsp;&nbsp;
            <asp:Button ID="BtnExcel" runat="server"  OnClick="BtnExcel_Click" 
                Text="����Excel"  SkinID="BtnSmall" ToolTip="��ѧ����ĩ�ɼ���Excel��񵼳�" />&nbsp;&nbsp;<asp:Button 
                ID="Btntermview" runat="server"  Text="ѧ�ڲ�ѯ"  OnClick="Btntermview_Click" 
                SkinID="BtnSmall" />
            &nbsp;&nbsp;<asp:Button ID="Btnback" runat="server"  Text="����"  OnClick="Btnback_Click" SkinID="BtnSmall" />
            <br />
            <br />
            �ܷ���������== ��Ʒ+С��+����+����<asp:DropDownList ID="DDLwork" runat="server" Font-Size="9pt" 
                Width="50px">
                <asp:ListItem Selected="True">100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>&nbsp;���飺<asp:DropDownList ID="DDLsurvey" runat="server" Font-Size="9pt" 
                Width="50px">
                <asp:ListItem Selected="True">100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>��ҳ��<asp:DropDownList ID="DDLweb" runat="server" 
                Font-Size="9pt" Width="50px">
                <asp:ListItem>100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem Selected="True">0</asp:ListItem>
            </asp:DropDownList>���飺<asp:DropDownList ID="DDLquiz" runat="server" 
                Font-Size="9pt" Width="50px">
                <asp:ListItem>100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem Selected="True">20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>���ģ�<asp:DropDownList ID="DDLtyper" runat="server" 
                Font-Size="9pt" Width="50px">
                <asp:ListItem>100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem Selected="True">10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            ���֣�<asp:DropDownList ID="DDLattitude" runat="server" 
                Font-Size="9pt" Width="50px">
                <asp:ListItem Selected="True">100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>0</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;
            <br />
            <br />
            ��ĩ����ÿ���༶��APE��������=== Aռ��<asp:DropDownList ID="DDLA" runat="server" Font-Size="9pt" 
                Width="50px">
                <asp:ListItem>100</asp:ListItem>
                <asp:ListItem>90</asp:ListItem>
                <asp:ListItem>80</asp:ListItem>
                <asp:ListItem>70</asp:ListItem>
                <asp:ListItem>60</asp:ListItem>
                <asp:ListItem Selected="True">50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>&nbsp;&nbsp;�����ܷ��ڰٷ�֮<asp:DropDownList ID="DDLE" runat="server" Font-Size="9pt" 
                Width="50px">
                <asp:ListItem>50</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem Selected="True">30</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
            &nbsp;�����Զ�����<br />
            <asp:Label ID="Labelmsg" runat="server"  SkinID="LabelMsgRed" 
                ></asp:Label>
            </div>
            <asp:GridView ID="GVCourse" runat="server" AutoGenerateColumns="False"
                 DataKeyNames="Sid"  SkinID="GVmission" OnRowDataBound="GVCourse_RowDataBound"
                PageSize="25" Width="98%" EnableModelValidation="True" >
                <Columns>
                    <asp:BoundField HeaderText="���" />
                    <asp:BoundField DataField="Snum" HeaderText="ѧ��" />
                    <asp:BoundField DataField="Sgradeclass" HeaderText="�༶" />
                    <asp:HyperLinkField DataNavigateUrlFields="Snum" 
                        DataNavigateUrlFormatString="studentwork.aspx?Snum={0}" DataTextField="Sname" 
                        HeaderText="����" Target="_blank"  />
                    <asp:BoundField DataField="Sscore" HeaderText="��Ʒ" />
                    <asp:BoundField DataField="Sgscore" HeaderText="С��" />
                    <asp:BoundField DataField="Spscore" HeaderText="����" />
                    <asp:BoundField DataField="Stxtform" HeaderText="��" />
                    <asp:BoundField DataField="Svscore" HeaderText="����" />
                    <asp:BoundField DataField="Swscore" HeaderText="��ҳ" />
                    <asp:BoundField DataField="Squiz" HeaderText="����" />
                    <asp:BoundField DataField="Schinese" HeaderText="ƴ��" />
                    <asp:BoundField DataField="Sfscore" HeaderText="Ӣ��" />
                    <asp:BoundField DataField="Stscore" HeaderText="����" />
                    <asp:BoundField DataField="Sattitude" HeaderText="����" />
                    <asp:BoundField DataField="Sallscore" HeaderText="�ܷ�" />
                    <asp:BoundField DataField="Sape" HeaderText="����" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
</asp:Content>

