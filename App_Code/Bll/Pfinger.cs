using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
using System.Web;
namespace LearnSite.BLL
{
	/// <summary>
	/// Pfinger
	/// </summary>
	public class Pfinger
	{
		private readonly LearnSite.DAL.Pfinger dal=new LearnSite.DAL.Pfinger();
		public Pfinger()
		{}
		#region  Method

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
		public bool Exists(int Pid)
		{
			return dal.Exists(Pid);
		}
               
        /// <summary>
        /// ���ظ�ѧ��ָ���ɼ�
        /// </summary>
        public string GetPsnum(string Psnum)
        {
            return dal.GetPsnum(Psnum);
        }
        /// <summary>
        /// �Ƿ���ڱ��¸�ѧ��ָ����¼������Pid
        /// </summary>
        public string ExistsMonth(string Psnum, int Pyear, int Pmonth)
        {
            return dal.ExistsMonth(Psnum, Pyear, Pmonth);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Pfinger model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.Pfinger model)
		{
			return dal.Update(model);
		}
        /// <summary>
        /// ��ձ�
        /// </summary>
        public int ClearTb()
        {
           return  dal.ClearTb();
        }        
        /// <summary>
        /// ������̰༶��ѧ��ָ����¼
        /// </summary>
        public void ClearMyTb(int Rhid)
        {
            dal.ClearMyTb(Rhid);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Pid)
		{
			
			return dal.Delete(Pid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Pidlist )
		{
			return dal.DeleteList(Pidlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Pfinger GetModel(int Pid)
		{
			
			return dal.GetModel(Pid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.Pfinger GetModelByCache(int Pid)
		{
			
			string CacheKey = "PfingerModel-" + Pid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Pid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Pfinger)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
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
		public List<LearnSite.Model.Pfinger> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Pfinger> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Pfinger> modelList = new List<LearnSite.Model.Pfinger>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Pfinger model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Pfinger();
					if(dt.Rows[n]["Pid"].ToString()!="")
					{
						model.Pid=int.Parse(dt.Rows[n]["Pid"].ToString());
					}
					model.Psnum=dt.Rows[n]["Psnum"].ToString();
					if(dt.Rows[n]["Pspd"].ToString()!="")
					{
						model.Pspd=decimal.Parse(dt.Rows[n]["Pspd"].ToString());
					}
					if(dt.Rows[n]["Pyear"].ToString()!="")
					{
						model.Pyear=int.Parse(dt.Rows[n]["Pyear"].ToString());
					}
					if(dt.Rows[n]["Pmonth"].ToString()!="")
					{
						model.Pmonth=int.Parse(dt.Rows[n]["Pmonth"].ToString());
					}
					if(dt.Rows[n]["Pdate"].ToString()!="")
					{
						model.Pdate=DateTime.Parse(dt.Rows[n]["Pdate"].ToString());
					}
					if(dt.Rows[n]["Pdegree"].ToString()!="")
					{
						model.Pdegree=int.Parse(dt.Rows[n]["Pdegree"].ToString());
					}
                    if (dt.Rows[n]["Pgrade"].ToString() != "")
                    {
                        model.Pgrade = int.Parse(dt.Rows[n]["Pgrade"].ToString());
                    }
                    if (dt.Rows[n]["Pterm"].ToString() != "")
                    {
                        model.Pterm = int.Parse(dt.Rows[n]["Pterm"].ToString());
                    }
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}                
        /// <summary>
        /// ��ʾ�༶ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowClassFingerScore(int Sgrade, int Sclass)
        {
            return dal.ShowClassFingerScore(Sgrade, Sclass);
        }
        /// <summary>
        /// ��ʾ�꼶��ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowAllFingerScore(int Sgrade)
        {
            return dal.ShowAllFingerScore(Sgrade);
        }                
        /// <summary>
        /// ��ʾѧУָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowSchoolFingerScore()
        {
            return dal.ShowSchoolFingerScore();
        }
        /// <summary>
        /// ����ɼ�
        /// </summary>
        /// <param name="psnum"></param>
        /// <param name="myspd"></param>
        /// <returns></returns>
        public bool saveSpd(string psnum, string myspd)
        {
            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.stuCookieNname] != null)
            {
                int pgrade = Int32.Parse(HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.stuCookieNname].Values["Sgrade"].ToString());

                return dal.saveSpd(psnum, myspd, pgrade);
            }
            else
                return false;
        }
                
        /// <summary>
        /// ��ʾ�꼶��ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowTopFingerScore(int Sgrade, int nTop)
        {
            return dal.ShowTopFingerScore(Sgrade, nTop);
        }
                
        /// <summary>
        /// ��ʾ�꼶��ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowTopFingerScoreAs(int Sgrade, int nTop)
        {
            return dal.ShowTopFingerScoreAs(Sgrade, nTop);
        }
                
        /// <summary>
        /// ��ʾѧУָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowSchoolTopFingerScore(int nTop)
        {
            return dal.ShowSchoolTopFingerScore(nTop);
        }
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

