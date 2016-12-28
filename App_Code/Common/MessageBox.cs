using System;
using System.Text;
namespace LearnSite.Common
{
    /// <summary>
    /// ��ʾ��Ϣ��ʾ�Ի���
    /// </summary>
    public class MessageBox
    {
        private MessageBox()
        {
        }

        ///�°汾
        /// <summary>
        /// ����JavaScriptС����
        /// </summary>
        /// <param name="js">������Ϣ</param>
        public static void Alert(string message,System.Web.UI.Page page)
        {
            string js = @"<Script language='JavaScript'>
                     alert('" + message + "');</Script>";
            if (!page.ClientScript.IsStartupScriptRegistered(page.GetType(), "alert"))
            {
                page.ClientScript.RegisterStartupScript(page.GetType(), "alert", js);
            }
        }
    }
}