using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���TermTotal ��ժҪ˵����
	/// </summary>
	public class TermTotal
	{
		private readonly LearnSite.DAL.TermTotal dal=new LearnSite.DAL.TermTotal();
		public TermTotal()
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
		public int  Add(LearnSite.Model.TermTotal model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.TermTotal model)
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
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.TermTotal GetModel(int Tid)
		{
			
			return dal.GetModel(Tid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.TermTotal GetModelByCache(int Tid)
		{
			
			string CacheKey = "TermTotalModel-" + Tid;
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
			return (LearnSite.Model.TermTotal)objModel;
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
		public List<LearnSite.Model.TermTotal> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.TermTotal> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.TermTotal> modelList = new List<LearnSite.Model.TermTotal>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.TermTotal model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.TermTotal();
					if(dt.Rows[n]["Tid"].ToString()!="")
					{
						model.Tid=int.Parse(dt.Rows[n]["Tid"].ToString());
					}
					model.Tnum=dt.Rows[n]["Tnum"].ToString();
					if(dt.Rows[n]["Tterm"].ToString()!="")
					{
						model.Tterm=int.Parse(dt.Rows[n]["Tterm"].ToString());
					}
					if(dt.Rows[n]["Tgrade"].ToString()!="")
					{
						model.Tgrade=int.Parse(dt.Rows[n]["Tgrade"].ToString());
					}
					if(dt.Rows[n]["Tscore"].ToString()!="")
					{
						model.Tscore=int.Parse(dt.Rows[n]["Tscore"].ToString());
					}
					if(dt.Rows[n]["Tgscore"].ToString()!="")
					{
						model.Tgscore=int.Parse(dt.Rows[n]["Tgscore"].ToString());
					}
					if(dt.Rows[n]["Tquiz"].ToString()!="")
					{
						model.Tquiz=int.Parse(dt.Rows[n]["Tquiz"].ToString());
					}
					if(dt.Rows[n]["Tattitude"].ToString()!="")
					{
						model.Tattitude=int.Parse(dt.Rows[n]["Tattitude"].ToString());
					}
					if(dt.Rows[n]["Twscore"].ToString()!="")
					{
						model.Twscore=int.Parse(dt.Rows[n]["Twscore"].ToString());
					}
					if(dt.Rows[n]["Ttscore"].ToString()!="")
					{
						model.Ttscore=int.Parse(dt.Rows[n]["Ttscore"].ToString());
					}
					if(dt.Rows[n]["Tpscore"].ToString()!="")
					{
						model.Tpscore=int.Parse(dt.Rows[n]["Tpscore"].ToString());
					}
					if(dt.Rows[n]["Tallscore"].ToString()!="")
					{
						model.Tallscore=int.Parse(dt.Rows[n]["Tallscore"].ToString());
					}
					model.Tape=dt.Rows[n]["Tape"].ToString();
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
        /// ����ѧ��ͳ�Ʊ�
        /// </summary>
        public void TermScore()
        {
            dal.TermScore();
        }
        /// <summary>
        /// ��ȡ��ѧ�ŵ�ÿѧ�ڳɼ��б�
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public DataSet GetSnumTermList(string Snum)
        {
            return dal.GetSnumList(Snum);
        }
        /// <summary>
        /// ��ȡĳ�꼶����ѧ���ۺ������ɼ�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="GradeArray"></param>
        /// <returns></returns>
        private DataTable GetOverallMerit(int Tyear, string GradeArray)
        {
            DataTable stuDt = null;
            if (GradeArray != "")
            {
                stuDt = dal.GetTyearStuTwo(Tyear);//��ȡ���꼶����ѧ�������༶��ѧ������ Tnum,Tclass,Tname
                if (stuDt != null)
                {
                    string[] grades = GradeArray.Split(',');
                    int gcount = grades.Length;

                    for (int i = 0; i < gcount; i++)
                    {
                        string grade = grades[i];
                        string gtermone = "g" + grade + "m1";
                        string gtermtwo = "g" + grade + "m2";
                        stuDt.Columns.Add(gtermone, typeof(string));
                        stuDt.Columns.Add(gtermtwo, typeof(string));
                    }
                    DataTable ApeDt = dal.GetGradeAllScores(Tyear);//��ȡ�ֶ�Tnum,Tgrade,Tterm,Tape,Tname
                    if (ApeDt != null)
                    {
                        int scount = stuDt.Rows.Count;
                        for (int j = 0; j < scount; j++)
                        {
                            string tnum = stuDt.Rows[j][1].ToString();
                            DataView dv = ApeDt.DefaultView;
                            dv.RowFilter = "Tnum='" + tnum + "'";
                            DataTable dtsnum = dv.ToTable();//Tnum,Tgrade,Tterm,Tape,Sname
                            int dtmcount = dtsnum.Rows.Count;
                            for (int k = 0; k < dtmcount; k++)
                            {
                                string tgrade = dtsnum.Rows[k][1].ToString();
                                string tterm = dtsnum.Rows[k][2].ToString();
                                string tape = dtsnum.Rows[k][3].ToString();
                                string clmname = "g" + tgrade + "m" + tterm;
                                //������������а�����ѧ�������
                                if (stuDt.Columns.Contains(clmname))
                                    stuDt.Rows[j][clmname] = tape;//����ѧ�����������±���Ӧ�е�����(�ؼ����)
                            }
                        }
                        //�����±����ݺ󣬸��������Ա������Զ����ֶα��� ԭʼ����ΪTnum,Tclass,Tname���༶��ѧ������
                        int lcount = stuDt.Columns.Count;//��ȡ��ǰ��������
                        for (int l = 4; l < lcount; l++)//�����ɵ�������ʼ
                        {
                            string clmtitle = stuDt.Columns[l].ColumnName;
                            clmtitle = clmtitle.Substring(1);//ȥ������ĸ
                            string[] clms = clmtitle.Split('m');
                            string lgrade = clms[0];
                            string lterm = clms[1];
                            string chineseGrade = Common.WordProcess.ChineseNum(lgrade);
                            string chineseTerm = Common.WordProcess.ChineseTerm(lterm);
                            stuDt.Columns[l].ColumnName = chineseGrade + chineseTerm;
                        }
                        stuDt.Columns[0].ColumnName = "���";
                        stuDt.Columns[1].ColumnName = "ѧ��";
                        stuDt.Columns[2].ColumnName = "�༶";
                        stuDt.Columns[3].ColumnName = "����";
                    }
                }
            }
            return stuDt;
        }

        public DataTable GetMerit(int Tyear, string GradeArray)
        {
            DataTable dm = null;
            if (GradeArray != "")
            {
                GradeArray = GradeArray.Substring(1);
                dm = GetOverallMerit(Tyear, GradeArray);
                if (dm != null)
                {
                    int clmcounts = dm.Columns.Count;//��ȡԭʼ���� ԭʼ����ΪSnum,Sclass,Sname
                    string allape = "Totel";//�����ۺ�����ͳ������
                    dm.Columns.Add(allape, typeof(string));
                    int dcount = dm.Rows.Count;
                    for (int i = 0; i < dcount; i++)
                    {
                        string apeset = "";
                        for (int j = 3; j < clmcounts; j++)
                        {
                            apeset = apeset + dm.Rows[i][j].ToString();
                        }
                        string Aset = "";
                        string Pset = "";
                        string Eset = "";
                        if (apeset != "")
                        {
                            int Acount = Common.WordProcess.charCount(apeset, 'A');
                            if (Acount > 0)
                                Aset = Acount.ToString() + "A";
                            int Pcount = Common.WordProcess.charCount(apeset, 'P');
                            if (Pcount > 0)
                                Pset = Pcount.ToString() + "P";
                            int Ecount = Common.WordProcess.charCount(apeset, 'E');
                            if (Ecount > 0)
                                Eset = Ecount.ToString() + "E";
                        }
                        dm.Rows[i][allape] = Aset + Pset + Eset;
                    }
                    dm.Columns[allape].ColumnName = "�ϼ�";
                }
            }
            return dm;
        }
        /// <summary>
        ///  ��ȡ��ǰ�༶�ڸ��꼶��ѧ�ڵ���ĩ�ɼ�
        /// </summary>
        /// <param name="Tyear"></param>
        /// <param name="Tgrade"></param>
        /// <param name="Tclass"></param>
        /// <param name="Tterm"></param>
        /// <returns></returns>
        public DataSet GetGradeTermScore(int Tyear, int Tgrade, int Tclass, int Tterm)
        {
            return dal.GetGradeTermScore(Tyear, Tgrade, Tclass, Tterm);
        }

        /// <summary>
        /// �������꼶��ĳ�꼶ʱĳѧ�ڵĳɼ�����
        /// </summary>
        /// <param name="Tyear"></param>
        /// <param name="Tgrade"></param>
        /// <param name="Tterm"></param>
        public void TotalTermExcel(int Tyear, int Tgrade, int Tterm)
        {
            dal.TotalTermExcel(Tyear, Tgrade, Tterm);
        }
                
        /// <summary>
        /// ��ʼ�������ֶ�TyearTclassTname
        /// </summary>
        /// <returns></returns>
        public int initTyearTclassTname()
        {
            return dal.initTyearTclassTname();
        }
                
        /// <summary>
        /// ��ȡ��ѧ����б�
        /// </summary>
        /// <returns></returns>
        public DataTable TyearList()
        {
            return dal.TyearList();
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

