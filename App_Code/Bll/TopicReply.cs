using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// TopicReply
	/// </summary>
	public class TopicReply
	{
		private readonly LearnSite.DAL.TopicReply dal=new LearnSite.DAL.TopicReply();
		public TopicReply()
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
		public int  Add(LearnSite.Model.TopicReply model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// ���ظ�����
        /// </summary>
        /// <param name="Rid"></param>
        public bool Lessscore(int Rid)
        {
            return dal.Lessscore(Rid);

        }
        /// <summary>
        /// ���ظ�����
        /// </summary>
        /// <param name="Rid"></param>
        public bool Updatescore(int Rid)
        {
            return dal.Updatescore(Rid);
        }
        public bool InitReditagree()
        {
            return dal.InitReditagree();
        }
        /// <summary>
        /// ���������лظ�����+2
        /// </summary>
        /// <param name="Rid"></param>
        public int UpdateAllscore(int Rtid, int Rgrade, int Rclass, int Ryear)
        {
            return dal.UpdateAllscore(Rtid, Rgrade, Rclass, Ryear);
        }
        /// <summary>
        /// �������Ӽӽ��Ա��
        /// </summary>
        /// <param name="Rid"></param>
        public bool UpdateBan(int Rid)
        {
            return dal.UpdateBan(Rid);
        }
        /// <summary>
        /// �������������޸�
        /// </summary>
        /// <param name="Rid"></param>
        public bool UpdateEdit(int Rid)
        {
            return dal.UpdateEdit(Rid);
        }  
        /// <summary>
        /// �������ӵ���
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public bool UpdateAgree(int Rid)
        {
            return dal.UpdateAgree(Rid);
        }
        /// <summary>
        /// �жϸ�ѧ�ű���ظ��Ƿ񱻽��Թ�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsnum"></param>
        /// <returns></returns>
        public bool Isban(int Rtid, int Rsid)
        {
            return dal.Isban(Rtid, Rsid);
        }     
         /// <summary>
        /// �жϸ�ѧ�ű���ظ��Ƿ�����ظ��޸�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsid"></param>
        /// <returns></returns>
        public bool Isedit(int Rtid, int Rsid)
        {
            return dal.Isedit(Rtid, Rsid);
        }
        /// <summary>
        /// �жϸ�ѧ�ű���ظ�����
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsnum"></param>
        /// <returns></returns>
        public int ReplyCount(int Rtid, int Rsid)
        {
            return dal.ReplyCount(Rtid, Rsid);
        }
                
        /// <summary>
        /// ������ʦ�ܽ�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rnum"></param>
        /// <param name="Rwords"></param>
        /// <returns></returns>
        public bool UpdateTeacher(int Rtid, int Rsid, string Rwords)
        {
            return dal.UpdateTeacher(Rtid, Rsid, Rwords);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.TopicReply model)
		{
			return dal.Update(model);
		}
        /// <summary>
        ///Rid ����һ������Rwords Rtime Redit Ragree
        /// </summary>
        public bool UpdateOne(LearnSite.Model.TopicReply model)
        {
            return dal.UpdateOne(model);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Rid)
		{
			
			return dal.Delete(Rid);
		}
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Ridlist )
		{
			return dal.DeleteList(Ridlist );
		}
                
        /// <summary>
        /// ɾ��һ���༶�����ۼ�¼
        /// </summary>
        public int DelClass(int Rgrade, int Rclass, int Ryear)
        {
            return dal.DelClass(Rgrade, Rclass, Ryear);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.TopicReply GetModel(int Rid)
		{
			
			return dal.GetModel(Rid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.TopicReply GetModelByCache(int Rid)
		{
			
			string CacheKey = "TopicReplyModel-" + Rid;
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
			return (LearnSite.Model.TopicReply)objModel;
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
		public List<LearnSite.Model.TopicReply> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.TopicReply> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.TopicReply> modelList = new List<LearnSite.Model.TopicReply>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.TopicReply model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.TopicReply();
					if(dt.Rows[n]["Rid"].ToString()!="")
					{
						model.Rid=int.Parse(dt.Rows[n]["Rid"].ToString());
					}
					if(dt.Rows[n]["Rtid"].ToString()!="")
					{
						model.Rtid=int.Parse(dt.Rows[n]["Rtid"].ToString());
					}
					model.Rsnum=dt.Rows[n]["Rsnum"].ToString();
					model.Rwords=dt.Rows[n]["Rwords"].ToString();
					if(dt.Rows[n]["Rtime"].ToString()!="")
					{
						model.Rtime=DateTime.Parse(dt.Rows[n]["Rtime"].ToString());
					}
					model.Rip=dt.Rows[n]["Rip"].ToString();
					if(dt.Rows[n]["Rscore"].ToString()!="")
					{
						model.Rscore=int.Parse(dt.Rows[n]["Rscore"].ToString());
					}
					if(dt.Rows[n]["Rban"].ToString()!="")
					{
						if((dt.Rows[n]["Rban"].ToString()=="1")||(dt.Rows[n]["Rban"].ToString().ToLower()=="true"))
						{
						model.Rban=true;
						}
						else
						{
							model.Rban=false;
						}
					}
                    if (dt.Rows[n]["Rgrade"].ToString() != "")
                    {
                        model.Rgrade = int.Parse(dt.Rows[n]["Rgrade"].ToString());
                    }
                    if (dt.Rows[n]["Rterm"].ToString() != "")
                    {
                        model.Rterm = int.Parse(dt.Rows[n]["Rterm"].ToString());
                    }
                    if (dt.Rows[n]["Rcid"].ToString() != "")
                    {
                        model.Rcid = int.Parse(dt.Rows[n]["Rcid"].ToString());
                    }
                    if (dt.Rows[n]["Rclass"].ToString() != "")
                    {
                        model.Rclass = int.Parse(dt.Rows[n]["Rclass"].ToString());
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
        /// ��ø����Ȿ��ظ������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Rtid"></param>
        /// <returns></returns>
        public DataSet GetClassList(int Sgrade, int Sclass, int Rtid)
        {
            return dal.GetClassList(Sgrade, Sclass, Rtid);
        }
         /// <summary>
        /// ��ȡ����δ�ظ���ͬѧ�����б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Rtid"></param>
        /// <returns></returns>
        public string GetNoReplay(int Sgrade, int Sclass, int Rtid)
        {
            string stus = "δ����ͬѧ��";
             DataTable dt=dal.GetNoReplay(Sgrade, Sclass, Rtid);
            int count=dt.Rows.Count;
             if ( count> 0)
             {
                 for (int i = 0; i < count; i++)
                 {
                     stus = stus + dt.Rows[i][0].ToString();
                     if (i < count - 1)
                         stus += "��";
                 }             
             }
             return stus;
        }
        /// <summary>
        /// ��ø����Ȿ��ظ������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Rtid"></param>
        /// <returns></returns>
        public DataTable GetClassListScore(int Sgrade, int Sclass, int Rtid)
        {
            return dal.GetClassListScore(Sgrade, Sclass, Rtid);
        }
        /// <summary>
        /// ��ȡ��ʦģ��ѧ���ظ���Ϊ�ܽ�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsnum"></param>
        /// <returns></returns>
        public string getteareply(int Rtid, string Rsnum)
        {
            return dal.getteareply(Rtid, Rsnum);
        }
        /// <summary>
        /// ��ʼ������Rcid�ֶ�
        /// </summary>
        public void InitRcid()
        {
            dal.InitRcid();
        }
        /// <summary>
        /// ��ʼ������Rclass�ֶ�
        /// </summary>
        public void InitRclass()
        {
            dal.InitRclass();
        }
                
        /// <summary>
        /// ��ȡ��ǰ�༶ѧ����ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowDoneReplyCids(int Rgrade, int Rclass, int Rterm, int Ryear)
        {
            return dal.ShowDoneReplyCids(Rgrade, Rclass, Rterm, Ryear);
        }
        /// <summary>
        /// ��ȡĳѧ��ѧ����ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowStuDoneReplyCids(string Snum, int Rterm, int Rgrade)
        {
            return dal.ShowStuDoneReplyCids(Snum,Rterm,Rgrade);
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

