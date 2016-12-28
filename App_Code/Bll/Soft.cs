using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Soft ��ժҪ˵����
	/// </summary>
	public class Soft
	{
		private readonly LearnSite.DAL.Soft dal=new LearnSite.DAL.Soft();
		public Soft()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Fid)
		{
			return dal.Exists(Fid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Soft model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Soft model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Fid)
		{
			
			dal.Delete(Fid);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Soft GetModel(int Fid)
		{
			
			return dal.GetModel(Fid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Soft GetModelByCache(int Fid)
		{
			
			string CacheKey = "SoftModel-" + Fid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Fid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Soft)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList()
		{
			return dal.GetList("");
		}
                        
        /// <summary>
        /// ���������Դ�б��޼��
        /// </summary>
        public DataSet GetSoftList(string Fhid)
        {
            string strWhere = " Fhid is null or Fhid=-1 or Fhid=" + Fhid;
            return dal.GetSoftList(strWhere);
        }
        /// <summary>
        /// ���������Դ�б��޼��
        /// </summary>
        public DataTable GetSoftList(string Fhid, string Fyid)
        {
            string strWhere = " Fyid=" + Fyid + " and ( Fhid is null or Fhid=-1 or Fhid=" + Fhid + ") ";
            return dal.GetSoftList(strWhere).Tables[0];
        }
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Soft> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Soft> DataTableToList(DataTable dt)
		{
            List<LearnSite.Model.Soft> modelList = new List<LearnSite.Model.Soft>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                LearnSite.Model.Soft model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new LearnSite.Model.Soft();
                    if (dt.Rows[n]["Fid"].ToString() != "")
                    {
                        model.Fid = int.Parse(dt.Rows[n]["Fid"].ToString());
                    }
                    model.Ftitle = dt.Rows[n]["Ftitle"].ToString();
                    model.Fcontent = dt.Rows[n]["Fcontent"].ToString();
                    model.Furl = dt.Rows[n]["Furl"].ToString();
                    if (dt.Rows[n]["Fhit"].ToString() != "")
                    {
                        model.Fhit = int.Parse(dt.Rows[n]["Fhit"].ToString());
                    }
                    if (dt.Rows[n]["Fdate"].ToString() != "")
                    {
                        model.Fdate = DateTime.Parse(dt.Rows[n]["Fdate"].ToString());
                    }
                    model.Ffiletype = dt.Rows[n]["Ffiletype"].ToString();
                    model.Fclass = dt.Rows[n]["Fclass"].ToString();
                    if (dt.Rows[n]["Fhide"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Fhide"].ToString() == "1") || (dt.Rows[n]["Fhide"].ToString().ToLower() == "true"))
                        {
                            model.Fhide = true;
                        }
                        else
                        {
                            model.Fhide = false;
                        }
                    }
                    if (dt.Rows[n]["Fopen"].ToString() != "")
                    {
                        model.Fopen = int.Parse(dt.Rows[n]["Fopen"].ToString());
                    } 
                    if (dt.Rows[n]["Fhid"].ToString() != "")
                    {
                        model.Fhid = int.Parse(dt.Rows[n]["Fhid"].ToString());
                    }
                    if (dt.Rows[n]["Fyid"].ToString() != "")
                    {
                        model.Fyid = int.Parse(dt.Rows[n]["Fyid"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }
        /// <summary>
        /// ��ȡ���ύ��Ʒ�ı�������Դ�б�
        /// </summary>
        /// <param name="Fyid"></param>
        /// <returns></returns>
        public DataTable GetListnomic(int Fyid)
        {
            return dal.GetListnomic(Fyid);
        }
        /// <summary>
        /// �������Ʒ�ύ�ķ����������б�����źͱ������
        /// </summary>
        public DataTable GetListCategory()
        {
            return dal.GetListCategory();
        }
        /// <summary>
        /// ѧ��ƽ̨��÷�������Դ�б��޼��
        /// </summary>
        public DataTable GetShowSoftList(string Fhid, int Fyid)
        {
            string strWhere = "Fyid=" + Fyid + " and  (Fhide is null or Fhide=0) and (Fhid is null or Fhid=-1 or Fhid=" + Fhid + ")";
            return dal.GetSoftList(strWhere).Tables[0];
        }   
        /// <summary>
        /// ��Դ�Ƿ񷢲�״̬����
        /// </summary>
        /// <param name="Fid"></param>
        public void UpdateFhide(int Fid)
        {
            dal.UpdateFhide(Fid);
        }

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}
        /// <summary>
        /// ������Դ�ϴ���·��
        /// </summary>
        /// <returns></returns>
       public static string SoftUploadPath()
        {
            string thePath = "~/Download/";
            if (System.Web.Configuration.WebConfigurationManager.AppSettings["Download"] != null)
                thePath = System.Web.Configuration.WebConfigurationManager.AppSettings["Download"].ToString();
            if (!thePath.EndsWith("/"))
                thePath += "/";
           return thePath;
        }


       /// <summary>
       /// �Ƿ��������Դ���Ƿ���������ʱ�䣩
       /// </summary>
       /// <returns></returns>
       public bool IsDownCan()
       {
           return dal.IsDownCan();
       }

       /// <summary>
       /// ���µ����,�������1
       /// </summary>
       /// <param name="Fid"></param>
       /// <param name="Fhit"></param>
       public void UpdateFhit(int Fid)
       {
           dal.UpdateFhit(Fid);
       }                
        /// <summary>
        /// �Ƿ���ڸ�������Դ
        /// </summary>
        /// <param name="Fyid"></param>
        /// <returns></returns>
       public bool ExistYid(int Fyid)
       {
           return dal.ExistYid(Fyid);
       }
		#endregion  ��Ա����
	}
}

