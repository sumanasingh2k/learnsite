using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���GroupWork ��ժҪ˵����
	/// </summary>
	public class GroupWork
	{
		private readonly LearnSite.DAL.GroupWork dal=new LearnSite.DAL.GroupWork();
		public GroupWork()
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
		public bool Exists(int Gid)
		{
			return dal.Exists(Gid);
		}
        /// <summary>
        /// �Ƿ����С����Ʒ
        /// </summary>
        /// <param name="Gnum"></param>
        /// <param name="Gmid"></param>
        /// <returns></returns>
        public bool Exists(string Gnum, int Gmid)
        {
            return dal.Exists(Gnum, Gmid);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.GroupWork model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.GroupWork model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Gid)
		{
			
			dal.Delete(Gid);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.GroupWork GetModel(int Gid)
		{
			
			return dal.GetModel(Gid);
		}
        /// <summary>
        /// �����鳤ѧ�źͻ��ŵõ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.GroupWork GetModelBySnum(string Gnum, int Gmid)
        {
            return dal.GetModelBySnum(Gnum, Gmid);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.GroupWork GetModelByCache(int Gid)
		{
			
			string CacheKey = "GroupWorkModel-" + Gid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Gid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.GroupWork)objModel;
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
		public List<LearnSite.Model.GroupWork> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.GroupWork> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.GroupWork> modelList = new List<LearnSite.Model.GroupWork>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.GroupWork model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.GroupWork();
					if(dt.Rows[n]["Gid"].ToString()!="")
					{
						model.Gid=int.Parse(dt.Rows[n]["Gid"].ToString());
					}
					model.Gnum=dt.Rows[n]["Gnum"].ToString();
					model.Gstudents=dt.Rows[n]["Gstudents"].ToString();
					if(dt.Rows[n]["Gterm"].ToString()!="")
					{
						model.Gterm=int.Parse(dt.Rows[n]["Gterm"].ToString());
					}
					if(dt.Rows[n]["Ggrade"].ToString()!="")
					{
						model.Ggrade=int.Parse(dt.Rows[n]["Ggrade"].ToString());
					}
					if(dt.Rows[n]["Gclass"].ToString()!="")
					{
						model.Gclass=int.Parse(dt.Rows[n]["Gclass"].ToString());
					}
					if(dt.Rows[n]["Gcid"].ToString()!="")
					{
						model.Gcid=int.Parse(dt.Rows[n]["Gcid"].ToString());
					}
					if(dt.Rows[n]["Gmid"].ToString()!="")
					{
						model.Gmid=int.Parse(dt.Rows[n]["Gmid"].ToString());
					}
					model.Gfilename=dt.Rows[n]["Gfilename"].ToString();
					model.Gtype=dt.Rows[n]["Gtype"].ToString();
					model.Gurl=dt.Rows[n]["Gurl"].ToString();
					if(dt.Rows[n]["Glengh"].ToString()!="")
					{
						model.Glengh=int.Parse(dt.Rows[n]["Glengh"].ToString());
					}
					if(dt.Rows[n]["Gscore"].ToString()!="")
					{
						model.Gscore=int.Parse(dt.Rows[n]["Gscore"].ToString());
					}
					if(dt.Rows[n]["Gtime"].ToString()!="")
					{
						model.Gtime=int.Parse(dt.Rows[n]["Gtime"].ToString());
					}
					if(dt.Rows[n]["Gvote"].ToString()!="")
					{
						model.Gvote=int.Parse(dt.Rows[n]["Gvote"].ToString());
					}
					if(dt.Rows[n]["Gcheck"].ToString()!="")
					{
						if((dt.Rows[n]["Gcheck"].ToString()=="1")||(dt.Rows[n]["Gcheck"].ToString().ToLower()=="true"))
						{
						model.Gcheck=true;
						}
						else
						{
							model.Gcheck=false;
						}
					}
					model.Gnote=dt.Rows[n]["Gnote"].ToString();
					if(dt.Rows[n]["Grank"].ToString()!="")
					{
						model.Grank=int.Parse(dt.Rows[n]["Grank"].ToString());
					}
					if(dt.Rows[n]["Ghit"].ToString()!="")
					{
						model.Ghit=int.Parse(dt.Rows[n]["Ghit"].ToString());
					}
					model.Gip=dt.Rows[n]["Gip"].ToString();
					if(dt.Rows[n]["Gdate"].ToString()!="")
					{
						model.Gdate=DateTime.Parse(dt.Rows[n]["Gdate"].ToString());
					}
                    if (dt.Rows[n]["Ggroup"].ToString() != "")
                    {
                        model.Ggroup = int.Parse(dt.Rows[n]["Ggroup"].ToString());
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
        /// ��ȡ�Լ�����С��ĺ�����Ʒ
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public DataSet GetMyWorks(string Snum)
        {
            return dal.GetMyWorks(Snum);
        }
                
        /// <summary>
        /// ��ȡ��ѧ���鳤�ύ��Ʒ���Ƿ����
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Gmid"></param>
        /// <returns></returns>
        public bool DoneGroupWork(string Snum, int Gmid)
        {
            return dal.DoneGroupWork(Snum, Gmid);
        }
                 
        /// <summary>
        /// ��ȡ������ύ��Ʒ���Ƿ����
        /// </summary>
        /// <param name="Ggroup"></param>
        /// <param name="Gmid"></param>
        /// <returns></returns>
        public bool DoneGroupWork(int Ggroup, int Gmid)
        {
            return dal.DoneGroupWork(Ggroup, Gmid);
        }
        /// <summary>
        /// ��ȡ��ѧ���鳤�ύ��Ʒ���Ƿ����
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Gmid"></param>
        /// <returns></returns>
        public string DoneGroupWorkUrl(string Snum, int Gmid)
        {
            return dal.DoneGroupWorkUrl(Snum, Gmid);
        }
        /// <summary>
        /// �ж���Ʒ�Ƿ�����
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Gmid"></param>
        /// <returns></returns>
        public bool CheckGroupWork(string Snum, int Gmid)
        {
            return dal.CheckGroupWork(Snum, Gmid);
        }
        /// <summary>
        /// ��С����Ʒ����
        /// </summary>
        /// <param name="Gid"></param>
        /// <param name="Gscore"></param>
        public void UpdateGscore(int Gid, int Gscore, int Cobj, int Cterm)
        {
            dal.UpdateGscore(Gid, Gscore, Cobj, Cterm);
        }
                
        /// <summary>
        /// ��С����Ʒȡ������
        /// </summary>
        /// <param name="Gid"></param>
        /// <param name="Gscore"></param>
        public void CancelGscore(int Gid, bool Gcheck)
        {
            dal.CancelGscore(Gid, Gcheck);
        }
        /// <summary>
        /// ��ȡĳ�༶ĳ�С�������Ʒ�б�
        /// </summary>
        /// <param name="Ggrade"></param>
        /// <param name="Gclass"></param>
        /// <param name="Gmid"></param>
        /// <returns></returns>
        public DataSet GetMissionGroup(int Ggrade, int Gclass, int Gmid)
        {
            return dal.GetMissionGroup(Ggrade, Gclass, Gmid);
        }
               
        /// <summary>
        /// ��ȡ���γ�С����Ʒ�ܷ�
        /// </summary>
        /// <param name="Gnum"></param>
        /// <param name="Gcid"></param>
        /// <returns></returns>
        public int GetGscore(string Gnum, int Gcid)
        {
            return dal.GetGscore(Gnum, Gcid);
        }
         /// <summary>
        /// ��ȡ����С����Ʒ�ܷ�
        /// </summary>
        /// <param name="Ggroup">���</param>
        /// <param name="Gcid">ѧ�����</param>
        /// <returns></returns>
        public int GetGscore(int Ggroup, int Gcid)
        {
            return dal.GetGscore(Ggroup, Gcid);
        }
        /// <summary>
        /// ��ȡ���౾ѧ�ڱ�С��ĺ�����Ʒ�ܷ�
        /// </summary>
        /// <param name="Ggroup">���</param>
        /// <param name="Ggrade"></param>
        /// <param name="Gclass"></param>
        /// <param name="Gterm"></param>
        /// <returns></returns>
        public int GetGscoreAll(int Ggroup, int Ggrade, int Gclass, int Gterm)
        {
            return dal.GetGscoreAll(Ggroup, Ggrade, Gclass, Gterm);
        }
                
        /// <summary>
        /// ��ʼ�������ֶ�Ggroup ��ţ�С����Ʒ��
        /// </summary>
        /// <returns></returns>
        public int initGgroup()
        {
            return dal.initGgroup();
        }               
        /// <summary>
        /// ��ʼ�������ֶ�Gyear �鳤��ѧ��ȣ�С����Ʒ��
        /// </summary>
        /// <returns></returns>
        public int initGyear()
        {
            return dal.initGyear();
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

