using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// Summary
	/// </summary>
	public partial class Summary
	{
		private readonly LearnSite.DAL.Summary dal=new LearnSite.DAL.Summary();
		public Summary()
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
		public bool Exists(int Sid)
		{
			return dal.Exists(Sid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Summary model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.Summary model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Sid)
		{
			
			return dal.Delete(Sid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Sidlist )
		{
			return dal.DeleteList(Sidlist );
		}
                        
        /// <summary>
        /// �õ�ָ������ݵ��ܽ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Summary GetModelByClass(int Scid, int Shid, int Sgrade, int Sclass)
        {
            return dal.GetModelByClass(Scid, Shid, Sgrade, Sclass);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Summary GetModel(int Sid)
		{
			
			return dal.GetModel(Sid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.Summary GetModelByCache(int Sid)
		{
			
			string CacheKey = "SummaryModel-" + Sid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Sid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Summary)objModel;
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
		public List<LearnSite.Model.Summary> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Summary> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Summary> modelList = new List<LearnSite.Model.Summary>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Summary model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Summary();
					if(dt.Rows[n]["Sid"].ToString()!="")
					{
						model.Sid=int.Parse(dt.Rows[n]["Sid"].ToString());
					}
					if(dt.Rows[n]["Scid"].ToString()!="")
					{
						model.Scid=int.Parse(dt.Rows[n]["Scid"].ToString());
					}
					if(dt.Rows[n]["Shid"].ToString()!="")
					{
						model.Shid=int.Parse(dt.Rows[n]["Shid"].ToString());
					}
					model.Scontent=dt.Rows[n]["Scontent"].ToString();
					if(dt.Rows[n]["Sdate"].ToString()!="")
					{
						model.Sdate=DateTime.Parse(dt.Rows[n]["Sdate"].ToString());
					}
					if(dt.Rows[n]["Sgrade"].ToString()!="")
					{
						model.Sgrade=int.Parse(dt.Rows[n]["Sgrade"].ToString());
					}
					if(dt.Rows[n]["Sclass"].ToString()!="")
					{
						model.Sclass=int.Parse(dt.Rows[n]["Sclass"].ToString());
					}
					if(dt.Rows[n]["Syear"].ToString()!="")
					{
						model.Syear=int.Parse(dt.Rows[n]["Syear"].ToString());
					}
					if(dt.Rows[n]["Sshow"].ToString()!="")
					{
						if((dt.Rows[n]["Sshow"].ToString()=="1")||(dt.Rows[n]["Sshow"].ToString().ToLower()=="true"))
						{
						model.Sshow=true;
						}
						else
						{
							model.Sshow=false;
						}
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
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

