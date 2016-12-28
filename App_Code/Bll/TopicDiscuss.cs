using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// TopicDiscuss
	/// </summary>
	public class TopicDiscuss
	{
		private readonly LearnSite.DAL.TopicDiscuss dal=new LearnSite.DAL.TopicDiscuss();
		public TopicDiscuss()
		{}
		#region  Method
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists()
		{
			return dal.Exists();
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.TopicDiscuss model)
		{
			return dal.Add(model);
		}         
        /// <summary>
        /// ������ʦ�ܽ�
        /// </summary>
        /// <param name="Tid"></param>
        /// <param name="Tresult"></param>
        /// <returns></returns>
        public bool UpdateTresult(int Tid, string Tresult)
        {
            return dal.UpdateTresult(Tid, Tresult);
        }
        /// <summary>
        /// �����������۵Ŀ�������
        /// </summary>
        /// <param name="Tid"></param>
        /// <param name="Tclose"></param>
        /// <returns></returns>
        public bool UpdateTclose(int Tid, bool Tclose)
        {
            return dal.UpdateTclose(Tid, Tclose);
        }
        /// <summary>
        /// �����������۵Ŀ�������
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public bool UpdateTclose(int Tid)
        {
            return dal.UpdateTclose(Tid);
        }
                
        /// <summary>
        /// �رոý�ʦ��������������
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public bool CloseMyAllTopic(int hid)
        {
            return dal.CloseMyAllTopic(hid);
        }
        /// <summary>
        /// ������������
        /// </summary>
        /// <param name="Tid"></param>
        /// <param name="Ttitle"></param>
        /// <param name="Tcontent"></param>
        /// <param name="Tclose"></param>
        /// <returns></returns>
        public bool UpdateTopic(int Tid, string Ttitle, string Tcontent, bool Tclose)
        {
            return dal.UpdateTopic(Tid, Ttitle, Tcontent,Tclose);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.TopicDiscuss model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Tid)
		{
			
			return dal.Delete(Tid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Tidlist )
		{
			return dal.DeleteList(Tidlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.TopicDiscuss GetModel(int Tid)
		{
			
			return dal.GetModel(Tid);
		}
                
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.TopicDiscuss GetModel(DataTable dt, int Tsort)
        {
            return dal.GetModel(dt, Tsort);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.TopicDiscuss GetModelByCache(int Tid)
		{
			
			string CacheKey = "TopicDiscussModel-" + Tid;
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
			return (LearnSite.Model.TopicDiscuss)objModel;
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
		public List<LearnSite.Model.TopicDiscuss> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.TopicDiscuss> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.TopicDiscuss> modelList = new List<LearnSite.Model.TopicDiscuss>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.TopicDiscuss model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.TopicDiscuss();
					if(dt.Rows[n]["Tid"].ToString()!="")
					{
						model.Tid=int.Parse(dt.Rows[n]["Tid"].ToString());
					}
					if(dt.Rows[n]["Tcid"].ToString()!="")
					{
						model.Tcid=int.Parse(dt.Rows[n]["Tcid"].ToString());
					}
					model.Ttitle=dt.Rows[n]["Ttitle"].ToString();
					model.Tcontent=dt.Rows[n]["Tcontent"].ToString();
					if(dt.Rows[n]["Tcount"].ToString()!="")
					{
						model.Tcount=int.Parse(dt.Rows[n]["Tcount"].ToString());
					}
					if(dt.Rows[n]["Tteacher"].ToString()!="")
					{
						model.Tteacher=int.Parse(dt.Rows[n]["Tteacher"].ToString());
					}
					if(dt.Rows[n]["Tdate"].ToString()!="")
					{
						model.Tdate=DateTime.Parse(dt.Rows[n]["Tdate"].ToString());
					}
					if(dt.Rows[n]["Tclose"].ToString()!="")
					{
						if((dt.Rows[n]["Tclose"].ToString()=="1")||(dt.Rows[n]["Tclose"].ToString().ToLower()=="true"))
						{
						model.Tclose=true;
						}
						else
						{
							model.Tclose=false;
						}
					}
					model.Tresult=dt.Rows[n]["Tresult"].ToString();
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
        /// ��ȡ��ѧ�������������б�
        /// </summary>
        /// <param name="Tcid"></param>
        /// <returns></returns>
        public DataSet GetCourseTopic(int Tcid)
        {
            string strWhere = " Tcid="+Tcid;
            return GetList(strWhere);
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

