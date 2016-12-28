using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Common;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// Ip
	/// </summary>
	public partial class Ip
	{
		private readonly LearnSite.DAL.Ip dal=new LearnSite.DAL.Ip();
		public Ip()
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
		public bool Exists(int Iid)
		{
			return dal.Exists(Iid);
		}
                
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsIp(int Ihid, string Iip)
        {
            return dal.ExistsIp(Ihid, Iip);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Ip model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.Ip model)
		{
			return dal.Update(model);
		}
                
        /// <summary>
        /// ����һ������
        /// </summary>
        public bool UpdateIip(string Iip, int Iid)
        {
            return dal.UpdateIip(Iip, Iid);
        }
        /// <summary>
        /// ɾ���û�������IP��¼
        /// </summary>
        public bool DeleteIhid(int Ihid)
        {
            return dal.DeleteIhid(Ihid);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Iid)
		{
			
			return dal.Delete(Iid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Iidlist )
		{
			return dal.DeleteList(Iidlist );
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Ip GetModel(int Iid)
		{
			
			return dal.GetModel(Iid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.Ip GetModelByCache(int Iid)
		{
			
			string CacheKey = "IpModel-" + Iid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Iid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Ip)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        public DataTable GetHouseIp(int Ihid)
        {
            string strWhere = " Ihid=" + Ihid + " order by Inum asc";
            return GetList(strWhere).Tables[0];
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
		public List<LearnSite.Model.Ip> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Ip> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Ip> modelList = new List<LearnSite.Model.Ip>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Ip model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Ip();
					if(dt.Rows[n]["Iid"].ToString()!="")
					{
						model.Iid=int.Parse(dt.Rows[n]["Iid"].ToString());
					}
					if(dt.Rows[n]["Ihid"].ToString()!="")
					{
						model.Ihid=int.Parse(dt.Rows[n]["Ihid"].ToString());
					}
					if(dt.Rows[n]["Inum"].ToString()!="")
					{
						model.Inum=int.Parse(dt.Rows[n]["Inum"].ToString());
					}
					model.Iip=dt.Rows[n]["Iip"].ToString();
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
        /// ��ȡ���൱��ǩ��ͬѧ�� Qnum,Qname,Inum
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable GetSiginStudents(int Sgrade, int Sclass, int Ihid)
        {
            return dal.GetSiginStudents(Sgrade, Sclass, Ihid);
        }
                
        /// <summary>
        /// ��ȡ���൱��ǩ��ͬѧ��Inum- Qnum- Qname-phototype| ��ʽ���ַ���
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string GetSiginStudentStr(int Sgrade, int Sclass, int Ihid, bool isshow)
        {
            return dal.GetSiginStudentStr(Sgrade, Sclass, Ihid,isshow);
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

