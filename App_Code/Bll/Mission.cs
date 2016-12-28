using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Mission ��ժҪ˵����
	/// </summary>
	public class Mission
	{
		private readonly LearnSite.DAL.Mission dal=new LearnSite.DAL.Mission();
		public Mission()
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
        /// ��ȡ�������ֵ
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public int GetMaxMsort(int Mcid)
        {
            return dal.GetMaxMsort(Mcid);
        }
                
        /// <summary>
        /// ��ȡ�ȵ�ǰ����С�������ύ���ţ����򷵻�0
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public int GetLastMaxMsort(int Mcid,int Msort)
        {
            return dal.GetLastMaxMsort(Mcid,Msort);
        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Mid)
		{
			return dal.Exists(Mid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Mission model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������(��mcid)
		/// </summary>
		public void Update(LearnSite.Model.Mission model)
		{
			dal.Update(model);
		}
                
        /// <summary>
        /// ���ĵ������� updown ֵ0���� ����1���¡���
        /// </summary>
        /// <param name="Mid"></param>
        /// <param name="updown"></param>
        public void UpdateMsort(int Mid, bool updown)
        {
            dal.UpdateMsort(Mid, updown);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Mid)
		{
			
			dal.Delete(Mid);
		}
                
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteMission(int Mid)
        {
            dal.DeleteMission(Mid);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Mission GetModel(int Mid)
		{
			
			return dal.GetModel(Mid);
		}

                /// <summary>
        /// �Ӳ�ѯ���еõ�һ��Mission����ʵ��,TsortΪTable��¼��ţ���0��ʼ��
        /// </summary>
        public LearnSite.Model.Mission GetTableModel(DataTable dt, int Tsort)
        {
            return dal.GetTableModel(dt, Tsort);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Mission GetModelByCache(int Mid)
		{
			
			string CacheKey = "MissionModel-" + Mid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Mid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Mission)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// ��������������б�
        /// </summary>
        public DataSet GetListNoContent(string strWhere)
        {
            return dal.GetListNoContent(strWhere);
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
		public List<LearnSite.Model.Mission> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Mission> DataTableToList(DataTable dt)
		{
            List<LearnSite.Model.Mission> modelList = new List<LearnSite.Model.Mission>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                LearnSite.Model.Mission model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new LearnSite.Model.Mission();
                    if (dt.Rows[n]["Mid"].ToString() != "")
                    {
                        model.Mid = int.Parse(dt.Rows[n]["Mid"].ToString());
                    }
                    model.Mtitle = dt.Rows[n]["Mtitle"].ToString();
                    if (dt.Rows[n]["Mcid"].ToString() != "")
                    {
                        model.Mcid = int.Parse(dt.Rows[n]["Mcid"].ToString());
                    }
                    model.Mcontent = dt.Rows[n]["Mcontent"].ToString();
                    if (dt.Rows[n]["Mdate"].ToString() != "")
                    {
                        model.Mdate = DateTime.Parse(dt.Rows[n]["Mdate"].ToString());
                    }
                    if (dt.Rows[n]["Mhit"].ToString() != "")
                    {
                        model.Mhit = int.Parse(dt.Rows[n]["Mhit"].ToString());
                    }
                    model.Mfiletype = dt.Rows[n]["Mfiletype"].ToString();
                    if (dt.Rows[n]["Mupload"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Mupload"].ToString() == "1") || (dt.Rows[n]["Mupload"].ToString().ToLower() == "true"))
                        {
                            model.Mupload = true;
                        }
                        else
                        {
                            model.Mupload = false;
                        }
                    }
                    if (dt.Rows[n]["Msort"].ToString() != "")
                    {
                        model.Msort = int.Parse(dt.Rows[n]["Msort"].ToString());
                    }
                    if (dt.Rows[n]["Mpublish"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Mpublish"].ToString() == "1") || (dt.Rows[n]["Mpublish"].ToString().ToLower() == "true"))
                        {
                            model.Mpublish = true;
                        }
                        else
                        {
                            model.Mpublish = false;
                        }
                    }
                    if (dt.Rows[n]["Mgroup"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Mgroup"].ToString() == "1") || (dt.Rows[n]["Mgroup"].ToString().ToLower() == "true"))
                        {
                            model.Mgroup = true;
                        }
                        else
                        {
                            model.Mgroup = false;
                        }
                    }
                    if (dt.Rows[n]["Mgid"] != null && dt.Rows[n]["Mgid"].ToString() != "")
                    {
                        model.Mgid = int.Parse(dt.Rows[n]["Mgid"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }                
        /// <summary>
        /// ��ȡ���Ʒ�ϴ�����
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public string GetMfiletype(int Mid)
        {
            return dal.GetMfiletype(Mid);
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        /// ���ָ��ѧ�����ѷ����������б�,������
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetMission(int Mcid)
        {
            string strWhere = "Mcid="+Mcid+" and Mpublish=1  order by Msort";
            return GetListNoContent(strWhere);
        }

        /// <summary>
        /// ���ָ��ѧ�������������б�,������
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetMissions(int Mcid)
        {
            string strWhere = "Mcid=" + Mcid + " and Mdelete<>1  order by Msort";
            return GetListNoContent(strWhere);
        }
                
        /// <summary>
        /// ��������������б��б��⣩
        /// </summary>
        public DataSet GetListMission(int Mcid)
        {
            return dal.GetListMission(Mcid);
        }
                
        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public string GetMissionTitle(int Mid)
        {
            return dal.GetMissionTitle(Mid);
        }
                
        /// <summary>
        /// ��ȡMgid
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public string GetMissionGid(int Mid)
        {
            return dal.GetMissionGid(Mid);
        }
        /// <summary>
        /// ���ָ��mid��һ�������¼
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public DataSet GetMissionDetail(int Mid)
        {
            string strWhere = "Mid=" + Mid;
            return GetList(strWhere);
        }

        /// <summary>
        /// ���ָ��Mcid�����������¼    ��������ϸ���¼��
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public DataSet GetMissionDetails(int Mcid)
        {
            string strWhere = "Mcid=" + Mcid+" and Mdelete=0 order by Msort asc";
            return GetList(strWhere);
        }
        /// <summary>
        /// �Ƿ���ڸû��¼
        /// </summary>
        public bool MsortExists(int Mcid, int Msort)
        {
            return dal.MsortExists(Mcid, Msort);
        }
        /// <summary>
        /// ��ø�ѧ���Ļ����
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetMsort(int Mcid)
        {
            return dal.GetMsort(Mcid);
        }
                
        /// <summary>
        /// ��ø�ѧ������Ʒ�ύ�Ļ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetUploadMsort(int Mcid)
        {
            return dal.GetUploadMsort(Mcid);
        }
                
        /// <summary>
        /// ��ø�ѧ������Ʒ�ύ�ı�źͱ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetUploadMidMtitle(int Mcid)
        {
            return dal.GetUploadMidMtitle(Mcid);
        }                
        /// <summary>
        /// ��ø�ѧ�����л��źͱ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetMidMtitle(int Mcid)
        {
            return dal.GetMidMtitle(Mcid);
        }
        /// <summary>
        /// ��ʼ��Mgroup�ֶ�nullΪfalse
        /// </summary>
        public void InitMgroup()
        {
            dal.InitMgroup();
        }
                        
        /// <summary>
        /// ����״̬�����������
        /// </summary>
        /// <param name="Mid"></param>
        public void UpdateMpublish(int Mid)
        {
            dal.UpdateMpublish(Mid);
        }
                       
        /// <summary>
        /// ��ʼ�������ݿ������
        /// </summary>
        public void UpdateMgid()
        {
            dal.UpdateMgid();
        }
        public void InitMdelete()
        {
            dal.InitMdelete();
        }
        //��ʼ���ֶ�ֵΪ0
        public void InitMcategory()
        {
            dal.InitMcategory();
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

