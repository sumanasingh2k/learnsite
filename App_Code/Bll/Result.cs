using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Result ��ժҪ˵����
	/// </summary>
	public class Result
	{
		private readonly LearnSite.DAL.Result dal=new LearnSite.DAL.Result();
		public Result()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Rid)
		{
			return dal.Exists(Rid);
		}

        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsBynumdate(int Rsid, DateTime Rdate)
        {
            return dal.ExistsBynumdate(Rsid, Rdate);
        }
                
        /// <summary>
        /// ���½������ɼ�������Ӱ�������
        /// </summary>
        /// <param name="Rnum"></param>
        /// <param name="Rscore"></param>
        /// <param name="Rdate"></param>
        /// <returns></returns>
        public int UpdateGood(string Rnum, int Rscore, DateTime Rdate)
        {
            return dal.UpdateGood(Rnum, Rscore, Rdate);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Result model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// ����һ�������е�Rscore��Rhistory��Rwrong
        /// </summary>
        public bool UpdateToday(LearnSite.Model.Result model)
        {
            return dal.UpdateToday(model);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Result model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Rid)
		{
			
			dal.Delete(Rid);
		}
                
        /// <summary>
        /// �������ǰ�Ĳ����¼
        /// </summary>
        /// <param name="Wyear"></param>
        public int DeleteOldyear(int Wyear)
        {
            return dal.DeleteOldyear(Wyear);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Result GetModel(int Rid)
		{
			
			return dal.GetModel(Rid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Result GetModelByCache(int Rid)
		{
			
			string CacheKey = "ResultModel-" + Rid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Rid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Result)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

                /// <summary>
        /// ��ø�ѧ�ŵĲ��������б�
        /// </summary>
        /// <param name="Rnum"></param>
        /// <returns></returns>
        public DataSet GetListScore(string Rnum)
        {
            return dal.GetListScore(Rnum);
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
		public List<LearnSite.Model.Result> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Result> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Result> modelList = new List<LearnSite.Model.Result>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Result model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Result();
					if(dt.Rows[n]["Rid"].ToString()!="")
					{
						model.Rid=int.Parse(dt.Rows[n]["Rid"].ToString());
					}
					model.Rnum=dt.Rows[n]["Rnum"].ToString();
					if(dt.Rows[n]["Rscore"].ToString()!="")
					{
						model.Rscore=int.Parse(dt.Rows[n]["Rscore"].ToString());
					}
					if(dt.Rows[n]["Rdate"].ToString()!="")
					{
						model.Rdate=DateTime.Parse(dt.Rows[n]["Rdate"].ToString());
					}
                    model.Rhistory = dt.Rows[n]["Rhistory"].ToString();
                    model.Rwrong = dt.Rows[n]["Rwrong"].ToString();
                    if (dt.Rows[n]["Rgrade"].ToString() != "")
                    {
                        model.Rgrade = int.Parse(dt.Rows[n]["Rgrade"].ToString());
                    } 
                    if (dt.Rows[n]["Rterm"].ToString() != "")
                    {
                        model.Rterm = int.Parse(dt.Rows[n]["Rterm"].ToString());
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
        /// ��ȡ������쳣ʶ�������а�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataSet GetListTodayScore(int Sgrade, int Sclass)
        {
            return dal.GetListTodayScore(Sgrade, Sclass);
        }
                
        /// <summary>
        /// ��ȡ������쳣ʶ����δ���е�ͬѧ����
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string GetListTodayNoScore(int Sgrade, int Sclass)
        {
            return dal.GetListTodayNoScore(Sgrade, Sclass);
        }
        /// <summary>
        /// ����ѧ����������ƽ��ֵ
        /// </summary>
        /// <param name="Rnum"></param>
        /// <returns></returns>
        public void GetAverage(int Rsid, int Rgrade, int Rterm)
        {
            dal.GetAverage(Rsid,Rgrade,Rterm);
        }        
        /// <summary>
        /// ����ѧ�����������ֵ
        /// </summary>
        /// <param name="Rnum"></param>
        /// <returns></returns>
        public int GetMax(int Rsid, string Rgrade, string Rterm)
        {
            return dal.GetMax(Rsid, Rgrade, Rterm);
        }
        /// <summary>
        /// ��ȡ���β����Ծ��ż�¼
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public string GetRhistory(int Rid)
        {
            return dal.GetRhistory(Rid);
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

