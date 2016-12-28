using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Webstudy ��ժҪ˵����
	/// </summary>
	public class Webstudy
	{
		private readonly LearnSite.DAL.Webstudy dal=new LearnSite.DAL.Webstudy();
		public Webstudy()
		{}
		#region  ��Ա����
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Wid)
		{
			return dal.Exists(Wid);
		}
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsWnum(string Wnum)
        {
            return dal.ExistsWnum(Wnum);
        }
                
        /// <summary>
        /// ����һ������ģ��ѧ���˺�
        /// </summary>
        public int AddSimulation(string Wnum, string Wpwd, string Wurl)
        {
            return dal.AddSimulation(Wnum, Wpwd, Wurl);
        }
        /// <summary>
        /// ����һ����¼
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wpwd"></param>
        public void AddOne(string Wnum, string Wpwd)
        {
            dal.AddOne(Wnum, Wpwd);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Webstudy model)
		{
			return dal.Add(model);
		}

                /// <summary>
        /// ������վ��ţ�������վ�ӷ�
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wscore"></param>
        public void UpdateOne(int Wid, int Wscore)
        {
            dal.UpdateOne(Wid, Wscore);
        }
        /// <summary>
        /// ����ĳ��ѧ�ŵ�ftp�����ѧ������һ��
        /// </summary>
        /// <param name="Wnum"></param>
        public void UpdateWpwd(string Wnum)
        {
            dal.UpdateWpwd(Wnum);
        }
        /// <summary>
        /// ����ĳ��ѧ�ŵ�ftp��¼����
        /// </summary>
        /// <param name="Wnum"></param>
        public void UpdateWpwd2(string Wnum, string Wpwd)
        {
            dal.UpdateWpwd2(Wnum, Wpwd);
        }                
        /// <summary>
        /// ���¾Wվ�u�r��B��ȡ��
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWcheck(string Wid)
        {
            dal.UpdateWcheck(Wid);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Webstudy model)
		{
			dal.Update(model);
		}

                /// <summary>
        /// ���ð༶����δ������վȫ��ΪP����6��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        public void UpdateOneClass(int Sgrade, int Sclass)
        {
            dal.UpdateOneClass(Sgrade, Sclass);
        }

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Wid)
		{
			
			dal.Delete(Wid);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Webstudy GetModel(int Wid)
		{
			
			return dal.GetModel(Wid);
		}

                /// <summary>
        /// ����ѧ�ţ��õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Webstudy GetModelByWnum(string Wnum)
        {
            return dal.GetModelByWnum(Wnum);
        }

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Webstudy GetModelByCache(int Wid)
		{
			
			string CacheKey = "WebstudyModel-" + Wid;
			object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Wid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Webstudy)objModel;
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
		public List<LearnSite.Model.Webstudy> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Webstudy> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Webstudy> modelList = new List<LearnSite.Model.Webstudy>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Webstudy model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Webstudy();
					if(dt.Rows[n]["Wid"].ToString()!="")
					{
						model.Wid=int.Parse(dt.Rows[n]["Wid"].ToString());
					}
					model.Wnum=dt.Rows[n]["Wnum"].ToString();
					model.Wpwd=dt.Rows[n]["Wpwd"].ToString();
					if(dt.Rows[n]["Wvote"].ToString()!="")
					{
						model.Wvote=int.Parse(dt.Rows[n]["Wvote"].ToString());
					}
					if(dt.Rows[n]["Wegg"].ToString()!="")
					{
						model.Wegg=int.Parse(dt.Rows[n]["Wegg"].ToString());
					}
					if(dt.Rows[n]["Wscore"].ToString()!="")
					{
						model.Wscore=int.Parse(dt.Rows[n]["Wscore"].ToString());
					}
					if(dt.Rows[n]["Wcheck"].ToString()!="")
					{
						if((dt.Rows[n]["Wcheck"].ToString()=="1")||(dt.Rows[n]["Wcheck"].ToString().ToLower()=="true"))
						{
						model.Wcheck=true;
						}
						else
						{
							model.Wcheck=false;
						}
					}
					if(dt.Rows[n]["WquotaCurrent"].ToString()!="")
					{
						model.WquotaCurrent=int.Parse(dt.Rows[n]["WquotaCurrent"].ToString());
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
        ///��ѧ�����ȡWebstudy���в����ڵ����ݣ�����Webstudy����
        /// </summary>
        public void AddAll()
        {
            dal.AddAll();
        }

                /// <summary>
        /// ������������б�
        /// </summary>
        public DataSet GetListWeb(int Sgrade, int Sclass)
        {
            return dal.GetListWeb(Sgrade, Sclass);
        }

                /// <summary>
        /// �������Ͽΰ༶��վͶƱ����
        /// </summary>
        public void ResetWegg(int eggs)
        {
            dal.ResetWegg(eggs);
        }

        /// <summary>
        /// ѧ��������ɾ��Webstudy��ѧ�Ų���Students�ļ�¼
        /// </summary>
        public void Upgrade()
        {
            dal.Upgrade();
        }


        /// <summary>
        /// ����վͶƱ��1
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWvote(int Wid)
        {
            dal.UpdateWvote(Wid);
        }
        /// <summary>
        /// ����վ������1
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateMyWegg(string Wnum)
        {
            dal.UpdateMyWegg(Wnum);
        }
        /// <summary>
        /// ��ȡ��վͶƱ��
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public int GetMyWegg(string Wnum)
        {
            return dal.GetMyWegg(Wnum);
        }
        /// <summary>
        /// ��ñ��༶��վ�б�����Sname,Snum,Wid,Wvote,Wscore,Wupdate
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataSet GetAllSite(int Sgrade, int Sclass, string Mynum)
        {
            return dal.GetAllSite(Sgrade, Sclass,Mynum);
        }
        /// <summary>
        /// ��ѯWebFtp�û�������
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public string FindWebFtpPwd(string Wnum)
        {
            return dal.FindWebFtpPwd(Wnum);
        }
        public void WebSiteUpdateCheck(string htmlname)
        {
            dal.WebSiteUpdateCheck(htmlname);
        }
        /// <summary>
        /// ������վ�������ڿռ�ռ�ô�С
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="updatetime"></param>
        public void UpdateWebTimeSize(string Wnum, DateTime Wupdate, int WquotaCurrent)
        {
            dal.UpdateWebTimeSize(Wnum, Wupdate, WquotaCurrent);
        }
        /// <summary>
        /// ������վ��������
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="updatetime"></param>
        public void UpdateWebTime(string Wnum, string updatetime)
        {
            dal.UpdateWebTime(Wnum, updatetime);
        }
                
        /// <summary>
        ///  ������վ�ռ�ռ�ô�С
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="WquotaCurrent"></param>
        public void UpdateWebSize(string Wnum, int WquotaCurrent)
        {
            dal.UpdateWebSize(Wnum, WquotaCurrent);
        }
               
        /// <summary>
        /// ������վ�������ݵĵ�Ʊ����
        /// </summary>
        public void ClearNoSiteVote()
        {
            dal.ClearNoSiteVote();
        }
        /// <summary>
        /// ��ʾָ����������վ��Ʊ�����б�
        /// </summary>
        /// <param name="TopNum"></param>
        /// <returns></returns>
        public DataSet WebTopShow(int TopNum)
        {
           return dal.WebTopShow(TopNum);
        }
                
        /// <summary>
        /// ��������Webstudy����Wurl
        /// </summary>
        public void WebUpdateWurl(int Hid)
        {
            dal.WebUpdateWurl(Hid);
        }                
        /// <summary>
        /// ����ð༶��webstudy���еļ�¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        public void DelWebClass(int Sgrade, int Sclass)
        {
            dal.DelWebClass(Sgrade, Sclass);
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

