using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Typer ��ժҪ˵����
	/// </summary>
	public class Typer
	{
		private readonly LearnSite.DAL.Typer dal=new LearnSite.DAL.Typer();
		public Typer()
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
		public bool Exists(int Tid)
		{
			return dal.Exists(Tid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Typer model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Typer model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Tid)
		{
			
			dal.Delete(Tid);
		}
                
        /// <summary>
        /// ���ݱ�Ż�ȡ���±���
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public string GetTitle(int Tid)
        {
            return dal.GetTitle(Tid);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Typer GetModel(int Tid)
		{
			
			return dal.GetModel(Tid);
		}
        /// <summary>
        /// ����õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Typer GetModelRnd(string tids)
        {
            return dal.GetModelRnd(tids);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Typer GetModelByCache(int Tid)
		{
			
			string CacheKey = "TyperModel-" + Tid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Tid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Typer)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

                /// <summary>
        /// ��������б�,������Tcontent����
        /// </summary>
        public DataSet GetListArticle(string strWhere)
        {
            return dal.GetListArticle(strWhere);
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
		public List<LearnSite.Model.Typer> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Typer> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Typer> modelList = new List<LearnSite.Model.Typer>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Typer model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Typer();
					if(dt.Rows[n]["Tid"].ToString()!="")
					{
						model.Tid=int.Parse(dt.Rows[n]["Tid"].ToString());
					}
					if(dt.Rows[n]["Ttype"].ToString()!="")
					{
						model.Ttype=int.Parse(dt.Rows[n]["Ttype"].ToString());
					}
					if(dt.Rows[n]["Tuse"].ToString()!="")
					{
						model.Tuse=int.Parse(dt.Rows[n]["Tuse"].ToString());
					}
					model.Ttitle=dt.Rows[n]["Ttitle"].ToString();
					model.Tcontent=dt.Rows[n]["Tcontent"].ToString();
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
        /// ���ָ��Tid������
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public DataSet GetOneArticle(int Tid)
        {
            string strWhere = " Tid="+Tid;
            return GetList(strWhere);
        }
                /// <summary>
        /// ��������б�,������Tcontent���ݵĴ��������б�
        /// </summary>
        public DataSet GetListArticle()
        {
            return GetListArticle("");
        }
        /// <summary>
        /// ����������Tid�󶨵�datalist��
        /// </summary>
        /// <param name="DLTid"></param>
        public DataSet ShowAllTid()
        {
            return dal.ShowAllTid();
        }
        /// <summary>
        /// ��ָ����������Tid�󶨵�datalist��
        /// </summary>
        /// <param name="DLTid"></param>
        public DataSet ShowAllTid(string tids)
        {
            return dal.ShowAllTid(tids);
        }
        /// <summary>
        /// ��ȡ�������±���Tid, Ttitle
        /// </summary>
        /// <returns></returns>
        public DataTable ShowAllTitle()
        {
            return dal.ShowAllTitle();
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

