using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Common;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// House
	/// </summary>
	public partial class House
	{
		private readonly LearnSite.DAL.House dal=new LearnSite.DAL.House();
		public House()
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
		public bool Exists(int Hid)
		{
			return dal.Exists(Hid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.House model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.House model)
		{
			return dal.Update(model);
		}
        /// <summary>
        /// ����һ������
        /// </summary>
        public bool UpdateHseat(int Hid, string Hseat)
        {
            return dal.UpdateHseat(Hid, Hseat);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Hid)
		{
			
			return dal.Delete(Hid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Hidlist )
		{
			return dal.DeleteList(Hidlist );
		}
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.House GetModel(string Hname)
        {
            return dal.GetModel(Hname);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.House GetModel(int Hid)
		{
			
			return dal.GetModel(Hid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.House GetModelByCache(int Hid)
		{
			
			string CacheKey = "HouseModel-" + Hid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Hid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.House)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
                
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetListHouse()
        {
            return dal.GetListHouse();
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public string GetHseat(int Hid)
        {
            return dal.GetHseat(Hid);
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
		public List<LearnSite.Model.House> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.House> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.House> modelList = new List<LearnSite.Model.House>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.House model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.House();
					if(dt.Rows[n]["Hid"].ToString()!="")
					{
						model.Hid=int.Parse(dt.Rows[n]["Hid"].ToString());
					}
					model.Hname=dt.Rows[n]["Hname"].ToString();
					model.Hseat=dt.Rows[n]["Hseat"].ToString();
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

