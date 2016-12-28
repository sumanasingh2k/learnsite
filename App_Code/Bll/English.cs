using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
using System.Web;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���English ��ժҪ˵����
	/// </summary>
	public class English
	{
		private readonly LearnSite.DAL.English dal=new LearnSite.DAL.English();
		public English()
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
		public bool Exists(int Eid)
		{
			return dal.Exists(Eid);
		}
                
        /// <summary>
        /// ͳ����Ӧ����ĵ�����
        /// </summary>
        /// <param name="Elevel"></param>
        /// <returns></returns>
        public int CountLevel(int Elevel)
        {
            return dal.CountLevel(Elevel);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.English model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
        public bool Update(LearnSite.Model.English model)
        {
            return dal.Update(model);
        }
                
        /// <summary>
        /// ���ôʱ��Ϊ��Ӧ����
        /// </summary>
        /// <param name="Eword"></param>
        /// <param name="Elevel"></param>
        public bool UpdateElevel(string Eword, int Elevel)
        {
            return dal.UpdateElevel(Eword, Elevel);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Eid)
		{
			
			dal.Delete(Eid);
		}
                
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteAll()
        {
            dal.DeleteAll();
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.English GetModel(int Eid)
		{
			
			return dal.GetModel(Eid);
		}                
        /// <summary>
        /// �����ȡһ������ʵ��
        /// </summary>
        /// <returns></returns>
        public LearnSite.Model.English GetRndModel(int Elevel)
        {
            return dal.GetRndModel(Elevel);
        }
        /// <summary>
        /// ��ȡ������ʲ��Ա�ŵ�����˼���зָ�
        /// </summary>
        /// <param name="Elevel"></param>
        /// <returns></returns>
        public string RndWord(int Elevel)
        {
            string str = "";
            Model.English emodel = new Model.English();
            emodel = dal.GetRndModel(Elevel);
            if (emodel != null)
            {
                str = emodel.Eid + "|" + emodel.Eword + "|" + emodel.Emeaning;
            }
            return str;
        }

        public string NextWord(int Eid, int Elevel)
        {
            string str = "";
            Model.English emodel = new Model.English();
            emodel = dal.GetNextModel(Eid, Elevel);
            if (emodel != null)
            {
                str = emodel.Eid + "|" + emodel.Eword + "|" + emodel.Emeaning;
            }
            return str;
        }

        /// <summary>
        /// �����ȡһ������ʵ��
        /// </summary>
        /// <returns></returns>
        public LearnSite.Model.English GetNextModel(int Eid,int Elevel)
        {
            return dal.GetNextModel(Eid,Elevel);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.English GetModelByCache(int Eid)
		{
			
			string CacheKey = "EnglishModel-" + Eid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Eid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.English)objModel;
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
		public List<LearnSite.Model.English> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<LearnSite.Model.English> DataTableToList(DataTable dt)
        {
            List<LearnSite.Model.English> modelList = new List<LearnSite.Model.English>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                LearnSite.Model.English model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new LearnSite.Model.English();
                    if (dt.Rows[n]["Eid"].ToString() != "")
                    {
                        model.Eid = int.Parse(dt.Rows[n]["Eid"].ToString());
                    }
                    model.Eword = dt.Rows[n]["Eword"].ToString();
                    model.Emeaning = dt.Rows[n]["Emeaning"].ToString();
                    if (dt.Rows[n]["Elevel"].ToString() != "")
                    {
                        model.Elevel = int.Parse(dt.Rows[n]["Elevel"].ToString());
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
        /// ��ȡĳ�ȼ����е��ʺ���˼
        /// </summary>
        /// <returns></returns>
        public string GetLevelwords(int Elevel)
        {
            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.stuCookieNname] != null)
            {
                return dal.GetLevelwords(Elevel);
            }
            else
                return "";
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

