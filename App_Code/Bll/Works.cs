using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
using System.Web;
using System.IO;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Works ��ժҪ˵����
	/// </summary>
	public class Works
	{
		private readonly LearnSite.DAL.Works dal=new LearnSite.DAL.Works();
		public Works()
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
		public bool Exists(int Wid)
		{
			return dal.Exists(Wid);
		}
                 /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsWcid(int Wcid)
        {
            return dal.ExistsWcid(Wcid);
        }
        /// <summary>
        /// �Ƿ���ڸ�ѧ��������Ʒ
        /// </summary>
        public bool ExistsMyMissonWork(int Wmid, string Wnum)
        {
            return dal.ExistsMyMissonWork(Wmid, Wnum);
        }
               
        /// <summary>
        /// �Ƿ���ڸ�ѧ����һ��������Ʒ,WmsortΪ��һ�����ύ�������
        /// </summary>
        public bool ExistsMyFirstWork(int Wcid, string Wnum, int Wmsort)
        {
            return dal.ExistsMyFirstWork(Wcid, Wnum, Wmsort);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Works model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Works model)
		{
			dal.Update(model);
		}
        /// <summary>
        /// ��ʼ��������ֶ�Woffice
        /// </summary>
        /// <returns></returns>
        public int UpdateWoffice()
        {
            return dal.UpdateWoffice();
        }  
                
        /// <summary>
        /// ��ʼ��������ֶ�Wfscore ������ƽ����
        /// </summary>
        /// <returns></returns>
        public void InitWfscore()
        {
            dal.InitWfscore();
        }
                
        /// <summary>
        /// �����ֶ�Wfscore
        /// </summary>
        /// <returns></returns>
        public void UpdateWfscore(int Wid, int Wfscore)
        {
            dal.UpdateWfscore(Wid, Wfscore);
        }
                
        /// <summary>
        /// ��ȡWfscore
        /// </summary>
        /// <returns></returns>
        public int GetWfscore(int Wid)
        {
            return dal.GetWfscore(Wid);
        }
        /// <summary>
        /// ����ð༶�û��Ʒ���쳣ת����־
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wid"></param>
        /// <param name="Wcid"></param>
        public void ClearWflasherror(int Sgrade, int Sclass, int Wmid, int Wcid)
        {
            dal.ClearWflasherror(Sgrade, Sclass, Wmid, Wcid);
        }
        /// <summary>
        /// ����һ������,��һ����Ʒ����(�������� Wid,Wscore, Wcheck)
        /// </summary>
        public int ScoreOneWork(LearnSite.Model.Works model)
        {
           return dal.ScoreOneWork(model);
        }

        /// <summary>
        /// ����ָ��Wid��Ʒ�Ļ���,������������
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wscore"></param>
        public void ScoreWork(int Wid, int Wscore)
        {
            dal.ScoreWork(Wid, Wscore);
        }
                
        /// <summary>
        /// ��ȡ���౾�ѧ���б�
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wgrade"></param>
        /// <param name="Wclass"></param>
        /// <returns></returns>
        public DataTable getScoreList(int Wmid, int Wgrade, int Wclass)
        {
            return dal.getScoreList(Wmid, Wgrade, Wclass);
        }
        /// <summary>
        /// ����ָ��Wid��Ʒ������״̬�ͻ���Ϊ��
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wcheck"></param>
        public void CancleScoreWork(int Wid, bool Wcheck)
        {
            dal.CancleScoreWork(Wid, Wcheck);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Wid)
		{
			
			dal.Delete(Wid);
		}
                
        /// <summary>
        /// ɾ��һ���༶����ҵ��¼
        /// </summary>
        public int DelClass(int Wgrade, int Wclass, int Wyear)
        {
            return dal.DelClass(Wgrade, Wclass, Wyear);
        }
        /// <summary>
        /// �������ǰ��δ�Ƽ�����Ʒ��¼
        /// </summary>
        /// <param name="Wyear"></param>
        public int DeleteOldyear(int Wyear)
        {
            return dal.DeleteOldyear(Wyear);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Works GetModel(int Wid)
		{
			
			return dal.GetModel(Wid);
		}
                
        /// <summary>
        /// ѧ���ͻ��ŵõ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Works GetModelByStu(int Mid, string Snum)
        {
            return dal.GetModelByStu(Mid, Snum);
        }
		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Works GetModelByCache(int Wid)
		{
			
			string CacheKey = "WorksModel-" + Wid;
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
			return (LearnSite.Model.Works)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        public string GetWid(string Wmid, string Wnum)
        {
            return dal.GetWid(Wmid, Wnum);
        }
        /// <summary>
        /// ����ѧ������꼶���༶(��Ӱ��༶��ѧ)
        /// ������ϲ�ѯ��Ʒ������dataset
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wcheck"></param>
        /// <returns></returns>
        public DataSet GetListWcheckWork(int Wcid, int Sgrade, int Sclass, int Wmid, bool Wcheck,string sort)
        {
            return dal.GetListWcheckWork(Wcid, Sgrade, Sclass, Wmid, Wcheck, sort);
        }                
        /// <summary>
        /// ��ʾ���̰༶��ѧ������δ����Ʒ
        /// select Wid,Wnum,Wmid,Wmsort,Wurl,Wtype,Wscore,Wtime,Wvote,Wcheck,Wself,Wcan,Wgood,Sname,Sgrade,Sclass,Mtitle
        /// </summary>
        /// <param name="Wcid"></param>
        /// <returns></returns>
        public DataTable GetListNoWcheckWork(int Wcid, int Wclass)
        {
            return dal.GetListNoWcheckWork(Wcid, Wclass);
        }
         /// <summary>
        /// ��ʾ���̰༶��ѧ������δ���༶
        /// select Sclass
        /// </summary>
        /// <param name="Wcid"></param>
        /// <returns></returns>
        public DataTable GetListNoWcheckClass(int Wcid)
        {
            return dal.GetListNoWcheckClass(Wcid);
        }
        /// <summary>
        /// ��ʾ����ĳ�༶��ѧ������δ����Ʒ
        /// select Wid,Wnum,Wmid,Wmsort,Wurl,Wtype,Wscore,Wtime,Wvote,Wcheck,Wself,Wcan,Wgood,Sname,Sgrade,Sclass,Mtitle
        /// </summary>
        /// <param name="Wcid"></param>
        /// <returns></returns>
        public DataTable GetListNoWcheckWork(int Wcid, int Wgrade, int Wclass)
        {
            return dal.GetListNoWcheckWork(Wcid, Wgrade, Wclass);
        } 
        /// <summary>
        /// ��ʾ����ѧ������δ����Ʒ�İ༶
        /// Wgrade,Wclass
        /// </summary>
        /// <param name="Wcid"></param>
        /// <returns></returns>
        public DataTable GetListNoWcheckWclass(int Wcid)
        {
            return dal.GetListNoWcheckWclass(Wcid);
        }
        /// <summary>
        /// ����ѧ�������꼶���༶(��Ӱ��༶��ѧ)
        /// ���øð౾ѧ��δ���۵Ļȫ������Ϊ10
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmid"></param>
        public void WorkSetA(int Wcid, int Sgrade, int Sclass, int Wmsort)
        {
            dal.WorkSetA(Wcid, Sgrade, Sclass, Wmsort);
        }
        /// <summary>
        /// ���øð౾ѧ��δ���۵Ļȫ������Ϊ6
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmsort"></param>
        public void WorkSetP(int Wcid, int Sgrade, int Sclass, int Wmsort)
        {
            dal.WorkSetP(Wcid, Sgrade, Sclass, Wmsort);
        }
                /// <summary>
        /// ����ѧ�������꼶���༶(��Ӱ��༶��ѧ)
        /// ���øð౾ѧ��δ���۵Ļȫ������ΪWscore
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wscore"></param>
        public void WorkSetScore(int Wcid, int Sgrade, int Sclass, int Wmid, int Wscore)
        {
            dal.WorkSetScore(Wcid, Sgrade, Sclass, Wmid, Wscore);
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
		public List<LearnSite.Model.Works> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}

        /// <summary>
        /// ��������б�
        /// </summary>
        public List<LearnSite.Model.Works> DataTableToList(DataTable dt)
        {
            List<LearnSite.Model.Works> modelList = new List<LearnSite.Model.Works>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                LearnSite.Model.Works model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new LearnSite.Model.Works();
                    if (dt.Rows[n]["Wid"].ToString() != "")
                    {
                        model.Wid = int.Parse(dt.Rows[n]["Wid"].ToString());
                    }
                    model.Wnum = dt.Rows[n]["Wnum"].ToString();
                    if (dt.Rows[n]["Wcid"].ToString() != "")
                    {
                        model.Wcid = int.Parse(dt.Rows[n]["Wcid"].ToString());
                    }
                    if (dt.Rows[n]["Wmid"].ToString() != "")
                    {
                        model.Wmid = int.Parse(dt.Rows[n]["Wmid"].ToString());
                    }
                    if (dt.Rows[n]["Wmsort"].ToString() != "")
                    {
                        model.Wmsort = int.Parse(dt.Rows[n]["Wmsort"].ToString());
                    }
                    model.Wfilename = dt.Rows[n]["Wfilename"].ToString();
                    model.Wurl = dt.Rows[n]["Wurl"].ToString();
                    if (dt.Rows[n]["Wlength"].ToString() != "")
                    {
                        model.Wlength = int.Parse(dt.Rows[n]["Wlength"].ToString());
                    }
                    if (dt.Rows[n]["Wscore"].ToString() != "")
                    {
                        model.Wscore = int.Parse(dt.Rows[n]["Wscore"].ToString());
                    }
                    if (dt.Rows[n]["Wdate"].ToString() != "")
                    {
                        model.Wdate = DateTime.Parse(dt.Rows[n]["Wdate"].ToString());
                    }
                    model.Wip = dt.Rows[n]["Wip"].ToString();
                    model.Wtime = dt.Rows[n]["Wtime"].ToString();
                    if (dt.Rows[n]["Wvote"].ToString() != "")
                    {
                        model.Wvote = int.Parse(dt.Rows[n]["Wvote"].ToString());
                    }
                    if (dt.Rows[n]["Wegg"].ToString() != "")
                    {
                        model.Wegg = int.Parse(dt.Rows[n]["Wegg"].ToString());
                    }
                    if (dt.Rows[n]["Wcheck"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Wcheck"].ToString() == "1") || (dt.Rows[n]["Wcheck"].ToString().ToLower() == "true"))
                        {
                            model.Wcheck = true;
                        }
                        else
                        {
                            model.Wcheck = false;
                        }
                    }
                    model.Wself = dt.Rows[n]["Wself"].ToString();
                    if (dt.Rows[n]["Wcan"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Wcan"].ToString() == "1") || (dt.Rows[n]["Wcan"].ToString().ToLower() == "true"))
                        {
                            model.Wcan = true;
                        }
                        else
                        {
                            model.Wcan = false;
                        }
                    }
                    if (dt.Rows[n]["Wgood"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Wgood"].ToString() == "1") || (dt.Rows[n]["Wgood"].ToString().ToLower() == "true"))
                        {
                            model.Wgood = true;
                        }
                        else
                        {
                            model.Wgood = false;
                        }
                    }
                    model.Wtype = dt.Rows[n]["Wtype"].ToString();
                    if (dt.Rows[n]["Wgrade"].ToString() != "")
                    {
                        model.Wgrade = int.Parse(dt.Rows[n]["Wgrade"].ToString());
                    }
                    if (dt.Rows[n]["Wterm"].ToString() != "")
                    {
                        model.Wterm = int.Parse(dt.Rows[n]["Wterm"].ToString());
                    }
                    if (dt.Rows[n]["Whit"].ToString() != "")
                    {
                        model.Whit = int.Parse(dt.Rows[n]["Whit"].ToString());
                    }
                    if (dt.Rows[n]["Wlscore"].ToString() != "")
                    {
                        model.Wlscore = int.Parse(dt.Rows[n]["Wlscore"].ToString());
                    }
                    if (dt.Rows[n]["Wlemotion"].ToString() != "")
                    {
                        model.Wlemotion = int.Parse(dt.Rows[n]["Wlemotion"].ToString());
                    }
                    if (dt.Rows[n]["Woffice"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Woffice"].ToString() == "1") || (dt.Rows[n]["Woffice"].ToString().ToLower() == "true"))
                        {
                            model.Woffice = true;
                        }
                        else
                        {
                            model.Woffice = false;
                        }
                    }
                    if (dt.Rows[n]["Wflash"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Wflash"].ToString() == "1") || (dt.Rows[n]["Wflash"].ToString().ToLower() == "true"))
                        {
                            model.Wflash = true;
                        }
                        else
                        {
                            model.Wflash = false;
                        }
                    }
                    if (dt.Rows[n]["Werror"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Werror"].ToString() == "1") || (dt.Rows[n]["Werror"].ToString().ToLower() == "true"))
                        {
                            model.Wflash = true;
                        }
                        else
                        {
                            model.Wflash = false;
                        }
                    }
                    if (dt.Rows[n]["Wfscore"].ToString() != "")
                    {
                        model.Wfscore = int.Parse(dt.Rows[n]["Wfscore"].ToString());
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
        /// ��ʾ���꼶������Ʒ��50����¼
        /// </summary>
        /// <param name="Wgrade"></param>
        /// <param name="GridViewwork"></param>
        public DataTable ShowBestWork(int Sgrade, int Syear, int Sterm)
        {
            return dal.ShowBestWork(Sgrade, Syear, Sterm).Tables[0];
        }

        /// <summary>
        /// ��ʾ�ҵ�������Ʒ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public DataTable ShowMywork(string Snum)
        {
            return dal.ShowMywork(Snum);
        }                
        /// <summary>
        /// ��ʾ�ұ��꼶��ѧ�ڵ�������Ʒ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wgrade"></param>
        /// <param name="Wterm"></param>
        /// <returns></returns>
        public DataSet ShowThisTermWorks(string Wnum, int Wgrade, int Wterm)
        {
            return dal.ShowThisTermWorks(Wnum, Wgrade, Wterm);
        }
         /// <summary>
        /// ��ʾ�ұ��꼶��ѧ�ڵ�������Ʒ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wgrade"></param>
        /// <param name="Wterm"></param>
        /// <returns></returns>
        public DataSet ShowThisTermWorksCircle(string Wnum, int Wgrade, int Wterm)
        {
            return dal.ShowThisTermWorksCircle(Wnum, Wgrade, Wterm);
        }
        /// <summary>
        /// ��ʾ�ҵ�������Ʒ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public DataTable ShowMyAllWorks(string Wnum)
        {
            return dal.ShowMyAllWorks(Wnum);
        }
        /// <summary>
        /// �б���������Ʒ��ѧ������źͷ�ֵ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public DataSet ShowMyworkScore(string Wnum)
        {
            return ShowMyworkScore(Wnum);
        }
        /// <summary>
        /// ������ƷWid���ѧ������
        /// </summary>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public string GetCtitle(int Wid)
        {
            return dal.GetCtitle(Wid);
        }


        /// <summary>
        /// ͶƱWvote��1
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWvote(int Wid)
        {
            dal.UpdateWvote(Wid);
        }
        /// <summary>
        /// ͶƱWegg��1
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWegg(int Wid)
        {
            dal.UpdateWegg(Wid);
        }
        public void UpdateWegg(int Wmid, string Wnum)
        {
            dal.UpdateWegg(Wmid, Wnum);
        }
        /// <summary>
        /// ��ñ���ƷWegg
        /// </summary>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public int GetWegg(int Wid)
        {
           return dal.GetWegg(Wid);
        }
                
        /// <summary>
        /// ��ñ���ƷWegg
        /// </summary>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public int GetWegg(int Wmid, string Wnum)
        {
            return dal.GetWegg(Wmid, Wnum);
        }
                
        /// <summary>
        /// ��ñ���ƷWegg
        /// </summary>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public int GetWegg(int Wmid, int Wsid)
        {
            return dal.GetWegg(Wmid, Wsid);//�������Լ����ҳ���������������վӦ�ó����ֹͣ
        }
        /// <summary>
        /// ��ʾ��ѧ����ѧ�������Ʒ������
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public string HowCidWorks(int Wcid, string Wnum)
        {
            return dal.HowCidWorks(Wcid, Wnum);
        }
                /// <summary>
        /// ��ʾ��ѧ����ѧ�������Ʒ������
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public int CountCidWorks(int Wcid, string Wnum)
        {
            return dal.CountCidWorks(Wcid, Wnum);
        }
                /// <summary>
        /// ��ʾ��ѧ����ѧ�������Ʒ������
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public string HowCidWorks(int Wcid, int Wsid)
        {
            return dal.HowCidWorks(Wcid, Wsid);
        }
        /// <summary>
        /// ��ʾ��ѧ�����������Ʒ������
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Snums"></param>
        /// <returns></returns>
        public string HowCourseWorks(int Wcid, string Snums)
        {
            return dal.HowCourseWorks(Wcid, Snums);
        }

        /// <summary>
        /// ��ʾ��ѧ�����������Ʒ������
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string HowCourseWorks(int Wcid, int Sgrade, int Sclass)
        {
            return dal.HowCourseWorks(Wcid, Sgrade, Sclass);
        }
        /// <summary>
        /// ��ʾ��ѧ�������񱾰������Ʒ������
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmsort"></param>
        /// <returns></returns>
        public string HowWorks(int Syear, int Sgrade, int Sclass, int Wmid)
        {
            return dal.HowWorks(Syear,Sgrade, Sclass, Wmid);
        }

        /// <summary>
        /// ����ѧ�ţ���ñ�ѧ������Ʒ�б�ֻ����Wid,Wmsort,Wurl,Wscore,Wip,Wcheck
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public DataSet MyHowWorks(int Wcid, string Wnum)
        {
            return dal.MyHowWorks(Wcid, Wnum);
        }
        /// <summary>
        /// ����ѧ�źͻmid����ñ������Ʒ�б�ֻ����Wid,Wmsort,Wurl,Wscore,Wip,Wcheck,Wself,Wcan
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public DataSet MyMissonWorks(int Wmid, string Wnum)
        {
            return dal.MyMissonWorks(Wmid, Wnum);
        }
        /// <summary>
        /// ��ø�ѧ�������񱾰������Ʒ
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public DataTable ShowMissionWorks(int Syear, int Sgrade, int Sclass, int Wmid)
        {
            return dal.ShowMissionWorks(Syear, Sgrade, Sclass, Wmid);
        }

        /// <summary>
        /// ��ø�ѧ�������񱾰����������Ʒ
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public DataTable ShowMissionWorksGroup(int Sgrade, int Sclass, int Wmid,int Sgroup)
        {
            return dal.ShowMissionWorksGroup(Sgrade, Sclass, Wmid,Sgroup);
        }

        /// <summary>
        /// ��ѯ���챾�౾������Ʒ�б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns>Wid,Sname,Wurl,Wvote,Wscore,Qwork</returns>
        public DataSet ShowTodayWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {            
            return dal.ShowTodayWorks(Sgrade, Sclass, Wcid, Wmid);
        }
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns>Wid,Sname,Wurl,Wvote,Wscore,Qwork</returns>
        public DataSet ShowClassWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowClassWorks(Sgrade, Sclass, Wcid, Wmid);
        }             
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns>Wid,Sname,Wurl,Wvote,Wscore,Qwork</returns>
        public DataTable ShowClassWorksBySort(int Sgrade, int Sclass, int Wmid, string Sort)
        {
            return dal.ShowClassWorksBySort(Sgrade, Sclass, Wmid, Sort);
        }
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns>Wid,Sname,Wurl</returns>
        public DataTable ShowCircleWorksSelect(int Sgrade, int Sclass, int Wcid, int Wmid, bool Wgood)
        {
            if (Wgood)
                return dal.ShowCircleGood(Sgrade, Sclass, Wcid, Wmid);
            else
                return dal.ShowCircleWorks(Sgrade, Sclass, Wcid, Wmid);
        }

        /// <summary>
        /// ��ѯ���౾������Ʒ�б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns>Wid,Sname,Wurl</returns>
        public DataTable ShowCircleWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowCircleWorks(Sgrade, Sclass, Wcid, Wmid);
        }
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�,flashר��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public DataSet ShowClassFlashWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowClassFlashWorks(Sgrade, Sclass, Wcid, Wmid);
        }  
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�,officeר��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public DataSet ShowClassOfficeWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowClassOfficeWorks(Sgrade, Sclass, Wcid, Wmid);
        }
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�,Photoר��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public DataSet ShowClassPhotoWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowClassPhotoWorks(Sgrade, Sclass, Wcid, Wmid);
        }                
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�,Swfר��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public DataSet ShowClassSwfWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowClassWtypeWorks(Sgrade, Sclass, Wcid, Wmid,"swf");
        }
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�,htmר��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public DataSet ShowClasshtmWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowClassWtypeWorks(Sgrade, Sclass, Wcid, Wmid,"htm");
        }
        /// <summary>
        /// ��ѯ���౾������Ʒ�б�,ͨ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wtype"></param>
        /// <returns></returns>
        public DataSet ShowClassWtypeWorks(int Sgrade, int Sclass, int Wcid, int Wmid,string Wtype)
        {
            return dal.ShowClassWtypeWorks(Sgrade, Sclass, Wcid, Wmid, Wtype);
        }
        /// <summary>
        /// ��ѯ���౾����δ���ѧ�������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public DataTable ShowClassNoWorks(int Syear, int Sgrade, int Sclass, int Wmid)
        {
            return dal.ShowClassNoWorks(Syear, Sgrade, Sclass,Wmid);
        }
                /// <summary>
        /// ��ѯ���챾�౾����δ���ѧ�������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public DataSet ShowTodayNotWorks(int Syear, int Sgrade, int Sclass, int Wmid)
        {
            return dal.ShowTodayNotWorks(Syear, Sgrade, Sclass, Wmid);
        }
        /// <summary>
        /// ��ѯ���챾�౾����δ���ѧ�������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public DataSet ShowTodayNoWorks(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowTodayNoWorks(Sgrade, Sclass, Wcid, Wmid);
        }
        /// <summary>
        /// ��ѯ���챾��ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string GetTodayCid(int Sgrade, int Sclass,int Syear)
        {
            return dal.GetTodayCid(Sgrade, Sclass,Syear);
        }
        /// <summary>
        /// ���ұ��౾ѧ�������񱾻�Ip �Ѿ���ɵ�ѧ��
       /// </summary>
       /// <param name="Sgrade"></param>
       /// <param name="Sclass"></param>
       /// <param name="Wcid"></param>
       /// <param name="Wmid"></param>
       /// <param name="Wip"></param>
       /// <returns></returns>
        public string IpWorkDoneSnum(int Sgrade, int Sclass, int Wcid, int Wmid, string Wip)
        {
            return dal.IpWorkDoneSnum(Sgrade, Sclass, Wcid, Wmid, Wip);
        }                
        /// <summary>
        /// ����ѧ�źͻ��ŷ�����Ʒ����
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public string WorkUrl(string Wnum, int Wmid)
        {
            return dal.WorkUrl(Wnum, Wmid);
        }

        /// <summary>
        /// �жϸ�ѧ�ű�������Ʒ�Ƿ��ύ����¼,����Wid��ֵ
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string WorkDone(string Wnum, int Wcid, int Wmid)
        {
            return dal.WorkDone(Wnum, Wcid, Wmid);

        }
                
        /// <summary>
        /// �жϸ�ѧ�ű�������Ʒ�Ƿ��ύ����
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public bool WorkDoneChecked(string Wnum, int Wcid, int Wmid)
        {
            return dal.WorkDoneChecked(Wnum, Wcid, Wmid);
        }
        /// <summary>
        /// ������Ʒ�Ƿ��Ѿ�����,���򷵻���
        /// </summary>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public  bool IsChecked(int Wid)
        {
            return dal.IsChecked(Wid);
        }
        /// <summary>
        /// ��Ʒ�ύ�� ����һ������
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wurl"></param>
        /// <param name="Wfilename"></param>
        /// <param name="Wlength"></param>
        /// <param name="Wdate"></param>
        /// <param name="Wcan"></param>
        public void UpdateWorkUp(int Wid, string Wurl, string Wfilename, int Wlength, DateTime Wdate, bool Wcan, string Wthumbnail)
        {
            dal.UpdateWorkUp(Wid, Wurl, Wfilename, Wlength, Wdate, Wcan, Wthumbnail);
        }
        /// <summary>
        /// ��Ʒ�ύ�� ����һ������
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wurl"></param>
        /// <param name="Wfilename"></param>
        /// <param name="Wlength"></param>
        /// <param name="Wdate"></param>
        /// <param name="Wcan"></param>
        public void UpdateWorkUp(int Wid, string Wurl, string Wfilename, int Wlength, DateTime Wdate, bool Wcan, string Wthumbnail, string Wtitle)
        {
            dal.UpdateWorkUp(Wid, Wurl, Wfilename, Wlength, Wdate, Wcan, Wthumbnail,Wtitle);
        }

        /// <summary>
        ///��Ʒ�ύ ����һ������
        ///(Wnum, Wcid,Wmid,Wmsort, Wfilename,Wtype, Wurl,Wlength, Wdate, Wip, Wtime)
        /// </summary>
        /// 
        public int AddWorkUp(LearnSite.Model.Works model)
        {
           return dal.AddWorkUp(model);
        }
                
        /// <summary>
        /// ������������
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wself"></param>
        public void UpdateWself(int Wid, string Wself)
        {
            dal.UpdateWself(Wid,Wself);    
        }
        /// <summary>
        /// �����Ƿ�Ҫ���ʦ������Ʒ
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <param name="Wcan"></param>
        public void UpdateWcan(int Wmid, int Wnum, bool Wcan)
        {
            dal.UpdateWcan(Wmid, Wnum, Wcan);
        }        
        /// <summary>
        /// �����Ʒ�Ƽ��ֶ��Զ�ȡ��
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWgood(int Wid)
        {
            dal.UpdateWgood(Wid);
        }
                
        /// <summary>
        /// �����Ʒ�Ƽ��ֶ�����Ϊ��
        /// </summary>
        /// <param name="Wid"></param>
        public void WgoodBest(int Wid)
        {
            dal.WgoodBest(Wid);
        }
        /// <summary>
        /// �����Ʒ�Ƽ��ֶ�����Ϊ��
        /// </summary>
        /// <param name="Wid"></param>
        public void WgoodNormal(int Wid)
        {
            dal.WgoodNormal(Wid);
        }
                /// <summary>
        /// ��ø�ѧ�������Ʒ�б�Wid,Sname,Wurl,Wvote,Wgood
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <returns></returns>
        public DataSet ShowCourseBestWorks(int Wcid, int Sgrade)
        {
            return dal.ShowCourseBestWorks(Wcid, Sgrade);
        }
                  
        /// <summary>
        /// �����̰༶����δ����Ʒ�����ֶ�����ΪP����6��
        /// </summary>
        public void WorkNoScoreSetP()
        {
            dal.WorkNoScoreSetP();
        }
        /// <summary>
        /// ��ʾ��ѧ��δ����
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <returns></returns>
        public string ShowNotCheckCounts(int Wcid, int Sgrade)
        {
            return dal.ShowNotCheckCounts(Wcid, Sgrade);
        }

        /// <summary>
        /// ��ʾ��ѧ�������񱾰�δ����
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public string ClassNotCheckWorks(int Wcid, int Sgrade, int Sclass, int Wmid)
        {
            return dal.ClassNotCheckWorks(Wcid, Sgrade, Sclass, Wmid);
        }
                
        /// <summary>
        /// ��ȡ������ҵ��ƽ����
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public int GetTodayWorkScores(string Wnum)
        {
            return dal.GetTodayWorkScores(Wnum);
        }
                
        /// <summary>
        /// ��ʦδ��ʱ�ɸ����ڳ�Ա��Ʒ����
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wlscore"></param>
        public void Updatelscore(int Wid, int Wlscore)
        {
            dal.Updatelscore(Wid, Wlscore);
        }   
        /// <summary>
        ///  ��ѧ����Ʒ���
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <param name="Wlscore"></param>
        public void Updatemscore(int Wmid, string Wnum, int Wlscore)
        {
            dal.Updatemscore(Wmid, Wnum, Wlscore);
        }
         /// <summary>
        /// ��ѯ���౾������Ʒ�б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <returns>Wid,Sname,Wurl</returns>
        public DataTable ShowCircleGood(int Sgrade, int Sclass, int Wcid, int Wmid)
        {
            return dal.ShowCircleGood(Sgrade, Sclass, Wcid, Wmid);
        }
        /// <summary>
        /// ��ѧ����Ʒ��ֲ�����
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <param name="Wlscore"></param>
        /// <param name="Wself"></param>
        public void Updatemscoreself(int Wmid, string Wnum, int Wlscore, string Wself, int Wdscore)
        {
            dal.Updatemscoreself(Wmid, Wnum, Wlscore, Wself, Wdscore);
        }

        /// <summary>
        /// ��ѧ����Ʒ��ֲ�����
        /// </summary>
        /// <param name="Wcid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <param name="Wlscore"></param>
        /// <param name="Wself"></param>
        /// <param name="Wdscore"></param>
        public void Updatemscoreself(string Wcid, string Wmid, string Wnum, int Wlscore, string Wself, int Wdscore)
        {
            dal.Updatemscoreself(Wcid,Wmid, Wnum, Wlscore, Wself,Wdscore);
        }
        /// <summary>
        /// ����ѧ�ź�����ID���سɼ�ֵ
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public string GetmyScore(int Wmid, string Wnum)
        {
            return dal.GetmyScore(Wmid, Wnum);
        }                
        ///<summary>
        /// ɾ����ѧ�Ÿû����Ʒ
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        public void Delmywork(int Wmid, string Wnum)
        {
            dal.Delmywork(Wmid,Wnum);
        }
        /// <summary>
        /// ����ѧ�ź�����ID���سɼ�ֵ������
        /// </summary>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public string[] GetmyScoreWself(int Wmid, string Wnum)
        {
            return dal.GetmyScoreWself(Wmid, Wnum);
        }                
        /// <summary>
        /// ����ѧ�ź�����ID���سɼ�ֵ������
        /// </summary>
        /// <param name="Cid"></param>
        /// <param name="Wmid"></param>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public string[] GetmyScoreWself(string Cid, string Wmid, string Wnum)
        {
            return dal.GetmyScoreWself(Cid,Wmid,Wnum);
        }
        /// <summary>
        /// ��ȡ������ͬѧ��Ʒ
        /// </summary>
        /// <param name="Sgroup"></param>
        /// <param name="Wmid"></param>
        /// <returns></returns>
        public DataSet GetGroupWorks(int Sgroup, int Wmid)
        {
            return dal.GetGroupWorks(Sgroup, Wmid);
        }
               
        /// <summary>
        /// ��ʾ��ѧ����δѧ���ĳ������������Ʒ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Cobj"></param>
        /// <param name="Cid"></param>
        /// <param name="Sgrade"></param>
        /// <returns></returns>
        public DataSet ShowAllGood(string Wnum, int Cobj, int Cid, int Sgrade)
        {
            return dal.ShowAllGood(Wnum, Cobj, Cid, Sgrade);
        }
                
        /// <summary>
        /// ��ʾ��ѧ���������Ƽ���Ʒ
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public DataSet ShowCourseGoodWorks(int Cid)
        {
            return dal.ShowCourseGoodWorks(Cid);
        }
                
        /// <summary>
        /// ��ȡ��ǰ�༶ѧ����ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowDoneWorkCids(int Sgrade, int Sclass, int Wterm, int Wyear)
        {
            return dal.ShowDoneWorkCids(Sgrade,Sclass, Wterm, Wyear);
        }
                
        /// <summary>
        /// ��ȡWurl
        /// </summary>
        /// <param name="Wid"></param>
        /// <returns></returns>
        public string GetWorkWurl(int Wid)
        {
            return dal.GetWorkWurl(Wid);
        }
        /// <summary>
        /// ��ȡĳѧ��ѧ����ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowStuDoneWorkCids(string Snum, int Wterm, int Wgrade)
        {
            return dal.ShowStuDoneWorkCids(Snum,Wterm,Wgrade);
        }
                
        /// <summary>
        /// ��ȡ���µ���Ʒ����
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public string[] ShowLastWorkSelf(int Sid)
        {
            return dal.ShowLastWorkSelf(Sid);
        }                
        /// <summary>
        /// ��ȡ��ѧ�����µ���ҵ�б�8����¼
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public DataTable ShowLastWorks(int Sid, int Sgrade, int Term, int Cid)
        {
            return dal.ShowLastWorks(Sid, Sgrade, Term, Cid);
        }
        
        public DataTable ShowWyears()
        {
            return dal.ShowWyears();
        }

        public DataTable ShowWgrades(int Wyear)
        {
            return dal.ShowWgrades(Wyear);
        }

        public DataTable ShowWclass(int Wyear, int Wgrade)
        {
            return dal.ShowWclass(Wyear, Wgrade);
        }
        public DataTable ShowWclassWcids(int Wyear, int Wgrade, int Wclass, int Wterm)
        {
            return dal.ShowWclassWcids(Wyear, Wgrade, Wclass, Wterm);
        }
        public DataTable ShowWclassWmids(int Wyear, int Wgrade, int Wclass, int Wterm, int Wcid)
        {
            return dal.ShowWclassWmids(Wyear, Wgrade, Wclass, Wterm, Wcid);
        }
        public DataTable ShowWclassWorks(int Wyear, int Wgrade, int Wclass, int Wterm,int Wmid)
        {
            return dal.ShowWclassWorks(Wyear, Wgrade, Wclass, Wterm, Wmid);
        }
                
        /// <summary>
        /// ��ȡ���е÷�12��������Ʒ�б�
        /// Wid,Wcid,Wmid,Wurl,Wname,Wgrade,Wclass,Wyear,Wtype,Wscore,Wdate,Ctitle
        /// </summary>
        /// <returns></returns>
        public DataTable GetListGoodWorks()
        {
            return dal.GetListGoodWorks();
        }
        /// <summary>
        /// Wid,Wurl,Wname,Wscore
        /// </summary>
        /// <param name="Wcid"></param>
        /// <returns></returns>
        public DataTable GetCourseWorks(int Wcid)
        {
            return dal.GetCourseWorks(Wcid);
        }
        public string GetHtmMid(int Wcid, string Wnum)
        {
            return dal.GetHtmMid(Wcid, Wnum);
        }
        public string GetHtmCid(string Wnum)
        {
            return dal.GetHtmCid(Wnum);
        }
        /// <summary>
        /// ��ʼ���ӷ�ֵ
        /// </summary>
        public void initWdscore()
        {
            dal.initWdscore();
        }

        /// <summary>
        /// �������ͼ
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wmid"></param>
        /// <param name="imgurl"></param>
        public void upWthumbnail(string Wnum, string Wmid, string imgurl)
        {
            dal.upWthumbnail(Wnum, Wmid,imgurl);
        }

        public void SaveProject(string id)
        {
            string[] arrayid = id.Split('-');
            string Wcid = arrayid[0];
            string Wmid = arrayid[1];

            int Wsid = Int32.Parse(HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sid"].ToString());
            string Wnum = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Snum"].ToString();
            string Wname = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sname"].ToString();
            string Wgrade = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sgrade"].ToString();
            string Wclass = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sclass"].ToString();
            string Wyear = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Syear"].ToString();
            string Wterm = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["ThisTerm"].ToString();
            string Wip = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["LoginIp"].ToString();
            string Wtime = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["LoginTime"].ToString();
            DateTime Wdate = DateTime.Now;

            string MySavePath = LearnSite.Common.WorkUpload.GetWurl(Wyear, Wgrade, Wclass, Wcid, Wmid);//�����Ʒ����·������������ڣ��Զ�������
            string RndTime = LearnSite.Common.WordProcess.GetRandomNum(99).ToString();
            string OnlyFileName = Wnum + "_" + Wcid + "_" + Wmid + "_" + RndTime;
            string NewFileName = OnlyFileName + ".sb2";
            string Wurl = MySavePath + "/" + NewFileName;
            string SaveFile = HttpContext.Current.Server.MapPath(Wurl);

            string NewThumbnail = OnlyFileName + ".jpg";
            string Wthumbnail = MySavePath + "/" + NewThumbnail;
            string thumbnailpath = HttpContext.Current.Server.MapPath(Wthumbnail);
            int len = 0;
            string title = "δ����" + ".sb2";
            try
            {
                HttpPostedFile pngf = HttpContext.Current.Request.Files[0];
                Stream streampng = pngf.InputStream;
                Image image = Image.FromStream(streampng);
                image.Save(thumbnailpath, System.Drawing.Imaging.ImageFormat.Jpeg);

                HttpPostedFile sbf = HttpContext.Current.Request.Files[1];
                len = sbf.ContentLength;
                title = HttpUtility.HtmlEncode(sbf.FileName) + ".sb2";
                sbf.SaveAs(SaveFile);

                image.Dispose();
            }
            catch (Exception ec)
            {
                LearnSite.Common.Log.Addlog("���������Ϣ", ec.StackTrace );// ec.StackTrace���Գ���ϸ��Ϣ
            }

            bool checkcan = true;

            BLL.Works bll = new BLL.Works();
            string Wid = bll.WorkDone(Wnum, Int32.Parse(Wcid), Int32.Parse(Wmid));//���ؿ��ַ���ʾ�����ڸü�¼
            //��¼�����ݿ�
            if (Wid != "")
            {
                bll.UpdateWorkUp(Int32.Parse(Wid), Wurl, NewFileName, len, Wdate, checkcan, Wthumbnail,title);//����Wfilename, Wurl,Wlength, Wdate
            }
            else
            {
                //Wnum,Wcid,Wmid,Wmsort,Wfilename,Wtype,Wurl,Wlength,Wdate,Wip
                //,Wtime,Wegg,Wgrade,Wterm,Woffice,Wflash,Wsid,Wclass,Wname,Wyear
                Model.Works wmodel = new Model.Works();
                wmodel.Wnum = Wnum;
                wmodel.Wcid = Int32.Parse(Wcid);
                wmodel.Wmid = Int32.Parse(Wmid);
                wmodel.Wmsort = 5;
                wmodel.Wfilename = NewFileName;
                wmodel.Wtype = "sb2";
                wmodel.Wurl = Wurl;
                wmodel.Wlength = len;
                wmodel.Wdate = Wdate;
                wmodel.Wip = Wip;
                wmodel.Wtime = Wtime;
                wmodel.Wcan = checkcan;
                wmodel.Wcheck = false;
                wmodel.Wegg = 12;//�趨Ʊ��Ϊ12��
                wmodel.Whit = 0;
                wmodel.Wgrade = Int32.Parse(Wgrade);
                wmodel.Wterm = Int32.Parse(Wterm);
                wmodel.Woffice = false;
                wmodel.Wsid = Wsid;
                wmodel.Wclass = Int32.Parse(Wclass);
                wmodel.Wname = HttpUtility.UrlDecode(Wname);
                wmodel.Wyear = Int32.Parse(Wyear);
                wmodel.Wflash = false;
                wmodel.Werror = false;
                wmodel.Wthumbnail = Wthumbnail;
                wmodel.Wtitle = title;
                bll.AddWorkUp(wmodel);//�����Ʒ�ύ��¼
                BLL.Signin sn = new BLL.Signin();
                sn.UpdateQwork(Wsid, Int32.Parse(Wcid));//���½���ǩ�����е���Ʒ����
            }

        }
        private int FindPos(string source, string word)
        {
            Regex regex = new Regex(word);
            Match mc;
            mc = regex.Match(source);
            return mc.Index;
        }
        public void SaveThumbnail(string id, byte[] pngfile)
        {
            string[] arrayid = id.Split('-');
            string Wcid = arrayid[0];
            string Wmid = arrayid[1];

            int Wsid = Int32.Parse(HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sid"].ToString());
            string Wnum = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Snum"].ToString();
            string Wgrade = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sgrade"].ToString();
            string Wclass = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Sclass"].ToString();
            string Wyear = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["Syear"].ToString();
            string Wterm = HttpContext.Current.Request.Cookies[Common.CookieHelp.stuCookieNname].Values["ThisTerm"].ToString();
            DateTime Pdate = DateTime.Now;
            string MySavePath = Common.WorkUpload.GetWurl(Wyear, Wgrade, Wclass, Wcid, Wmid);//�����Ʒ����·������������ڣ��Զ�������
            string OnlyFileName = Wnum + "_" + Wcid + "_" + Wmid;
            string NewFileName = OnlyFileName + ".png";
            string Wurl = MySavePath + "/" + NewFileName;
            string SaveFile = HttpContext.Current.Server.MapPath(Wurl);

            Works bll = new Works();
            bll.upWthumbnail(Wnum, Wmid, Wurl);//�������ͼ
            
            //------------------------------------
            MemoryStream ms = new MemoryStream();
            ms.Write(pngfile,0, pngfile.Length);
            Image image = Image.FromStream(ms);
            
            //Bitmap bm = new Bitmap(image, new Size(160, 120));
            //bm.Save(SaveFile);
           // ------------------------------------
            image.Save(SaveFile);

            //byte[] pngfile = context.Request.BinaryRead(context.Request.TotalBytes);
            ////FileStream fs = new FileStream(SaveFile, FileMode.Create);
            ////fs.Write(pngfile, 0, pngfile.Length);//��������ͼ
           //// fs.Close();
           //// fs.Dispose();
        }

        public void SworkToBytes(string id)
        {
            string sburl = "~/Statics/Cat.sb2";

            if (id.Contains("-"))
            {
                string[] arrayid = id.Split('-');
                string Wcid = arrayid[0];
                string Wmid = arrayid[1];
                string Wnum = HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.stuCookieNname].Values["Snum"].ToString();
                Model.Works work = new Model.Works();
                work = GetModelByStu(Int32.Parse(Wmid), Wnum);
                if (work != null)
                {
                    sburl = work.Wurl;
                }
                else
                {
                    LearnSite.Model.Mission model = new LearnSite.Model.Mission();
                    LearnSite.BLL.Mission mn = new LearnSite.BLL.Mission();
                    model = mn.GetModel(Int32.Parse(Wmid));
                    if (model != null)
                    {
                        sburl = model.Mexample;
                    }
                }
            }
            else
            {
                sburl= GetWorkWurl(Int32.Parse(id));
            }

            string sbpath = HttpContext.Current.Server.MapPath(sburl);
            //��ȡ�ļ��Ķ��������ݡ�
            byte[] datas = System.IO.File.ReadAllBytes(sbpath);
            //������������д�뵽������С�
            HttpContext.Current.Response.OutputStream.Write(datas, 0, datas.Length);
        }

        public int GetSbCount()
        {
            return dal.GetSbCount();
        }

        public DataTable GetSb(int page)
        {
            return dal.GetSb(page);
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

