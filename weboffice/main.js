
/****************************************************
*
*		�ر�ҳ��ʱ���ô˺������ر��ļ� 
*
****************************************************/
function window_onunload() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.Close();
	}catch(e){
	//	alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					�½��ĵ�
*
****************************************************/
function newDoc() {
	try{
		var webObj=document.getElementById("WebOffice1");
		var doctype=document.getElementById("doctype").value;
		webObj.LoadOriginalFile("", doctype);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}

/****************************************************
*
*			�ر�ҳ��ʱ���ô˺������ر��ļ� 
*
****************************************************/
function window_onunload() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.Close();
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*				 ����ĵ����� 
*
****************************************************/
function UnProtect() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.ProtectDoc(0,1, document.all.docPwd.value);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			
*				�����ĵ����� 
*
****************************************************/
function ProtectFull() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.ProtectDoc(1,1, document.all.docPwd.value);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}


/****************************************************
*
*					��ֹ����
*
/****************************************************/
function notCopy() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetSecurity(0x04); 
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					�ָ�������
*
/****************************************************/
function okCopy() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetSecurity(0x04 + 0x8000); 
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					��ֹ�϶�
*
/****************************************************/
function notDrag() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetSecurity(0x08); 
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					�ָ��϶�
*
/****************************************************/
function okDrag() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetSecurity(0x08 + 0x8000); 
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}

}

/****************************************************
*
*					�򿪱����ļ�
*
/****************************************************/
function docOpen() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.LoadOriginalFile("open", "doc");
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}

/****************************************************
*
*					���ز˵�
*
/****************************************************/
function notMenu() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetToolBarButton2("Menu Bar",1,8);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					��ʾ�˵�
*
/****************************************************/
function okMenu() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetToolBarButton2("Menu Bar",1,11);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					���س��ù�����
*
/****************************************************/
function notOfter() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetToolBarButton2("Standard",1,8);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					��ʾ���ù�����
*
/****************************************************/
function okOfter() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetToolBarButton2("Standard",1,11);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					���ظ�ʽ������
*
/****************************************************/
function notFormat() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetToolBarButton2("Formatting",1,8);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*					��ʾ��ʽ������
*
/****************************************************/
function okFormat() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.SetToolBarButton2("Formatting",1,11);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}    

/****************************************************
*
*					ȫ��
*
/****************************************************/
function bToolBar_FullScreen_onclick() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.FullScreen = true;
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*		����weboffice�Դ���������ʾ������
*
/****************************************************/
function bToolBar_onclick() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.ShowToolBar =  !webObj.ShowToolBar;
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}

/****************************************************
*
*		����weboffice�Դ���������ʾ������
*
/****************************************************/
function NobToolBar() {
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.ShowToolBar =  false;
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*			Office2007�˵����غͻָ�
*			----��ʼ�˵�����
*
/****************************************************/
function beginMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x100000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*
*			Office2007�˵����غͻָ�
*			---����˵�����
*
/****************************************************/
function insertMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x200000);
		webObj. HideMenuAction(5,0);//��������

	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			
*			Office2007�˵����غͻָ�
*			---ҳ��˵�����
*
/****************************************************/
function pageMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x400000);
		webObj. HideMenuAction(5,0);//��������
	
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			--���ò˵�����
*
/****************************************************/
function adducMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x800000);
		webObj. HideMenuAction(5,0);//��������

	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---�ʼ��˵�����
*
/****************************************************/
function	emailMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x1000000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---���Ĳ˵�����
*
/****************************************************/
function	checkMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x2000000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---��ͼ�˵�����
*
/****************************************************/
function	viewMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x4000000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---�������߲˵�����
*
/****************************************************/
function	empolderMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x8000000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---������˵�����
*
/****************************************************/
function	loadMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x10000000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---ȫ���˵�����
*
/****************************************************/
function	allHideMenu_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj.HideMenuAction(1,0x100000+0x200000+0x400000+0x800000+0x1000000+0x2000000+0x4000000+0x8000000+0x10000000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---������Ч
*
/****************************************************/
function nullityCopy_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj. HideMenuAction(1,0x2000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*			---ճ����Ч
*
/****************************************************/
function nullityAffix_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj. HideMenuAction(1,0x1000);
		webObj. HideMenuAction(5,0);//��������
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
/****************************************************
*			Office2007�˵����غͻָ�
*	---�ָ�������֮ǰ״̬���˵���ʾ�����ƣ�ճ�����ã�
*
/****************************************************/
function affixCopy_onclick()
{
	try{
		var webObj=document.getElementById("WebOffice1");
		webObj. HideMenuAction(6,0);
	}catch(e){
		alert("�쳣\r\nError:"+e+"\r\nError Code:"+e.number+"\r\nError Des:"+e.description);
	}
}
