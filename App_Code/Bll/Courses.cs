using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Courses ��ժҪ˵����
	/// </summary>
	public class Courses
	{
		private readonly LearnSite.DAL.Courses dal=new LearnSite.DAL.Courses();
		public Courses()
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
        /// ������ѧ����źͱ������ɶ���Ŀ¼�ŵ�ѧ����Ŀ¼�£������Ժ�鿴
        /// </summary>
        /// <param name="xmlpath"></param>
        public void CreatPackageNameList(string xmlpath)
        {
            dal.CreatPackageNameList(xmlpath);
        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Cid)
		{
			return dal.Exists(Cid);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Courses model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// ������ѧ����Ctitle,Cclass��Cdate,Cobj,Cterm,Cks,Cfiletype,Cupload,Cpublish���������Զ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Create(LearnSite.Model.Courses model)
        {
            return dal.Create(model);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Courses model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// ����һ�����ݣ�����ѧ������
        /// </summary>
        public void UpdateCourse(LearnSite.Model.Courses model)
        {
            dal.UpdateCourse(model);
        }                
        /// <summary>
        /// ����һ������,����ѧ�����ݣ�ѧ��������ʱר��
        /// </summary>
        public void UpdateCcontent(int Cid, string Ccontent)
        {
            dal.UpdateCcontent(Cid, Ccontent);
        }
        /// <summary>
        /// �޸�ѧ������״̬
        /// </summary>
        public void UpdateCpublish(int Cid, bool Cpublish)
        {
            dal.UpdateCpublish(Cid, Cpublish);
        }
                
        /// <summary>
        /// �޸�ѧ������״̬
        /// </summary>
        public void UpdateCpublish(int Cid)
        {
            dal.UpdateCpublish(Cid);
        }                
        /// <summary>
        /// �޸�ѧ�����״̬
        /// </summary>
        public void UpdateCold(int Cid)
        {
            dal.UpdateCold(Cid);
        }
        /// <summary>
        /// �޸�ѧ���Ƽ�״̬
        /// </summary>
        public void UpdateCgood(int Cid)
        {
            dal.UpdateCgood(Cid);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
        public void Delete(int Cid, int Chid)
		{
			
			dal.Delete(Cid,Chid);
		}
                
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteCourse(int Cid, int Chid)
        {
            dal.DeleteCourse(Cid, Chid);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Courses GetModel(int Cid)
		{
			
			return dal.GetModel(Cid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Courses GetModelByCache(int Cid)
		{
			
			string CacheKey = "CoursesModel-" + Cid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Cid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Courses)objModel;
		}


                /// <summary>
        /// �ӱ��е�һ����¼�õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Courses GetTableModel(DataTable dt)
        {
            return dal.GetTableModel(dt);
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		public  DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetListNoWhere(string strWhere)
        {
            return dal.GetListNo(strWhere);
        }
        /// <summary>
        /// ���������ѧ���б�
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListNoContent(string strWhere)
        {
            return dal.GetListNoContent(strWhere);
        }               
        /// <summary>
        /// ��ȡ��ѧ�ڱ���ʦ��ѧ����źͱ����б�
        /// </summary>
        /// <param name="Chid"></param>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <returns></returns>
        public DataSet GetListCidCtitle(int Chid, int Cobj, int Cterm)
        {
            return dal.GetListCidCtitle(Chid, Cobj, Cterm);
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
		public List<LearnSite.Model.Courses> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Courses> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Courses> modelList = new List<LearnSite.Model.Courses>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Courses model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Courses();
					if(dt.Rows[n]["Cid"].ToString()!="")
					{
						model.Cid=int.Parse(dt.Rows[n]["Cid"].ToString());
					}
					model.Ctitle=dt.Rows[n]["Ctitle"].ToString();
					model.Cclass=dt.Rows[n]["Cclass"].ToString();
					model.Ccontent=dt.Rows[n]["Ccontent"].ToString();
					if(dt.Rows[n]["Cdate"].ToString()!="")
					{
						model.Cdate=DateTime.Parse(dt.Rows[n]["Cdate"].ToString());
					}
					if(dt.Rows[n]["Chit"].ToString()!="")
					{
						model.Chit=int.Parse(dt.Rows[n]["Chit"].ToString());
					}
					if(dt.Rows[n]["Cobj"].ToString()!="")
					{
						model.Cobj=int.Parse(dt.Rows[n]["Cobj"].ToString());
					}
					if(dt.Rows[n]["Cterm"].ToString()!="")
					{
						model.Cterm=int.Parse(dt.Rows[n]["Cterm"].ToString());
					}
					if(dt.Rows[n]["Cks"].ToString()!="")
					{
						model.Cks=int.Parse(dt.Rows[n]["Cks"].ToString());
					}
					model.Cfiletype=dt.Rows[n]["Cfiletype"].ToString();
					if(dt.Rows[n]["Cupload"].ToString()!="")
					{
						if((dt.Rows[n]["Cupload"].ToString()=="1")||(dt.Rows[n]["Cupload"].ToString().ToLower()=="true"))
						{
						model.Cupload=true;
						}
						else
						{
							model.Cupload=false;
						}
					}
					if(dt.Rows[n]["Chid"].ToString()!="")
					{
						model.Chid=int.Parse(dt.Rows[n]["Chid"].ToString());
					}
					if(dt.Rows[n]["Cpublish"].ToString()!="")
					{
						if((dt.Rows[n]["Cpublish"].ToString()=="1")||(dt.Rows[n]["Cpublish"].ToString().ToLower()=="true"))
						{
						model.Cpublish=true;
						}
						else
						{
							model.Cpublish=false;
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
		public  DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        ///�����ݣ� ������������������
        /// </summary>
        /// <returns></returns>
        public DataSet GetListNo()
        {
            string strOrder = " order by Cdate DESC";
            return GetListNoWhere(strOrder);
        }
        /// <summary>
        /// �����ݣ� ����������ѧ�ڡ��꼶����ʱ��������
        /// </summary>
        /// <param name="Cterm"></param>
        /// <param name="Cobj"></param>
        /// <returns></returns>
        public DataSet GetListLession(int Cterm, int Cobj,int Chid)
        {
            return dal.GetListLession(Cterm, Cobj,Chid);
        }
        /// <summary>
        /// ���ָ���꼶��ָ��ѧ�ڵ�����ѧ����������
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <returns></returns>
        public DataSet GetLimitList(int Cobj, int Cterm)
        {
            string strWhere = "Cobj=" + Cobj + " and Cterm=" + Cterm + " order by Cks DESC";
            return GetListNoContent(strWhere);
        }
        /// <summary>
        /// ���ָ���꼶��ָ��ѧ�ڵ���ѧѧ���������ݣ�����
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <returns></returns>
        public DataSet GetLimitGoodList(int Cobj, int Cterm, string Snum)
        {
            string strWhere = "Cobj=" + Cobj + " and Cterm=" + Cterm + " and Cid in(select distinct Wcid from Works where Wnum='" + Snum + "') order by Cks ASC";
            return dal.GetListGoodNoContent(strWhere);
        }
        /// <summary>
        /// ���ָ���꼶��ָ��ѧ�ڵ�����ѧ���������ݣ�����
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <returns></returns>
        public DataSet GetAllGoodList(int Cobj, int Cterm)
        {
            string strWhere = "Cobj=" + Cobj + " and Cterm=" + Cterm + " and  Cgood=1 and  Cdelete=0 and Cold=0 order by Cks ASC";
            return dal.GetListGoodNoContent(strWhere);
        }
        /// <summary>
        /// ���ָ����ʦ��ָ���꼶��ָ��ѧ�ڵ�����ѧ���������ݣ�����
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <returns></returns>
        public DataSet GetAllGoodListByChid(int Cobj, int Cterm,int Chid)
        {
            string strWhere = "Chid=" + Chid + " and Cobj=" + Cobj + " and Cterm=" + Cterm + " and  Cgood=1 and Cdelete=0 and Cold=0 order by Cks ASC";
            return dal.GetListGoodNoContent(strWhere);
        }
        /// <summary>
        /// ��øý�ʦָ���꼶��ָ��ѧ�ڵ�����ѧ����������
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <param name="Chid"></param>
        /// <returns></returns>
        public DataSet GetLimitHidList(int Cobj, int Cterm, int Chid)
        {
            string strWhere = "Chid=" + Chid + " and  Cobj=" + Cobj + " and Cterm=" + Cterm + " and Cdelete=0 and Cold=0 order by Cks DESC";
            return GetListNoContent(strWhere);
        }
        /// <summary>
        /// ��øý�ʦ����ѧ����������
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <param name="Chid"></param>
        /// <returns></returns>
        public DataSet GetOldHidList(int Cobj, int Cterm, int Chid)
        {
            string strWhere = "Chid=" + Chid + " and  Cobj=" + Cobj + " and Cterm=" + Cterm + " and Cdelete=0 and Cold=1  order by Cks DESC";
            return GetListNoContent(strWhere);
        }
        /// <summary>
        /// ���ָ��cid��һ��ѧ����¼
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public DataSet GetCourseDetail(int Cid)
        {
            string strWhere = "Cid=" + Cid ;
            return GetList(strWhere);
        }

        /// <summary>
        /// ����ѧ����ţ�����ѧ������
        /// </summary>
        /// <param name="Fcid"></param>
        /// <returns></returns>
        public string GetTitle(int Cid)
        {
            return dal.GetTitle(Cid);
        }

        /// <summary>
        /// ���ݽ�ʦ���꼶��ѧ�ڷ���ѧ�����ƺͱ��
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <param name="Chid"></param>
        /// <returns></returns>
        public DataTable  ShowCidCtitle(int Chid, int Cobj, int Cterm)
        {
            return dal.ShowCidCtitle(Chid, Cobj, Cterm).Tables[0];
        }
        /// <summary>
        /// �����꼶��ʾ�����ʦ����δѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="GridViewnewkc"></param>
        public DataTable ShowNewCourse(int Sgrade, int Cterm, int Chid, string Cids)
        {
            return dal.ShowNewCourse(Sgrade, Cterm,Chid,Cids);
        }                
        /// <summary>
        /// �����꼶��ʾ�����ʦ����δѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="GridViewnewkc"></param>
        public DataTable ShowNewCourseNew(int Sgrade, int Cterm, int Chid, string Cids)
        {
            return dal.ShowNewCourseNew(Sgrade, Cterm, Chid, Cids);
        }
        /// <summary>
        /// ����Snum��ʾ��ѧѧ�� (SnumΪStudents���ѧ��)
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="GridViewdonekc"></param>
        public DataTable ShowDoneCourse(string Cids)
        {
            return dal.ShowDoneCourse(Cids);
        }                
        /// <summary>
        /// ����Snum��ʾ��ѧѧ�� (SnumΪStudents���ѧ��)
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="GridViewdonekc"></param>
        public DataTable ShowDoneCourseNew(string Cids)
        {
            return dal.ShowDoneCourseNew(Cids);
        }
        /// <summary>
        /// ���ݰ༶��ʾ��ѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable ShowClassDoneCourse(int Sgrade, int Chid, string Cids)
        {
            return dal.ShowClassDoneCourse(Sgrade,Chid,Cids);
        }
        /// <summary>
        /// ���ݰ༶��ʾδѧѧ������ʦ�Ͽ�ҳ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable ShowClassnewCourse(int Sgrade, int Chid, string Cids)
        {
            return dal.ShowClassnewCourse(Sgrade,Chid,Cids);
        }
        /// <summary>
        /// ����ѧ����ŷ���ѧ������
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string ShowCtitle(int Cid)
        {
          return  dal.ShowCtitle(Cid);
        }
         /// <summary>
        /// ��ȡָ��ѧ�ڣ�ָ���꼶�Ŀ�ʱ���ֵ
        /// </summary>
        /// <param name="Cterm"></param>
        /// <param name="Cobj"></param>
        /// <returns></returns>
        public int CksMaxValue(int Cterm, int Cobj,int Chid)
        {
            return dal.CksMaxValue(Cterm, Cobj,Chid);
        }
                
        /// <summary>
        /// ��ȡ��ҳ����ѧ�����꼶�б�
        /// </summary>
        /// <returns></returns>
        public DataSet GethtmGrade()
        {
            return dal.GethtmGrade();
        }
        /// <summary>
        /// ȫ��ѧ���ջ�����
        /// </summary>
        public void HideCourse()
        {
            dal.HideCourse();
        }                
        /// <summary>
        /// ��ѧ�����ϴ����͸���ѧ�������һ��
        /// </summary>
        public void UpdateCfiletype()
        {
            dal.UpdateCfiletype();
        }

        public void InitCdelete()
        {
            dal.InitCdelete();
        }

        public void InitCold()
        {
            dal.InitCold();
        }
        /// <summary>
        /// ���ر��εĻ�����顢���ۡ��� ���ܱ�
        /// </summary>
        /// <param name="Cid"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        public DataTable CourseTotals(int Cid, int Sgrade, int Sclass)
        {
            Students sbll = new Students();
            DataTable dtstus = sbll.GetStudentsSnumSname(Sgrade, Sclass).Tables[0];//ѧ�ź�����
            if (dtstus.Rows.Count > 0)
            {
                ListMenu lbll = new ListMenu();
                DataTable dt = lbll.GetShowedMenu(Cid).Tables[0];
                int dcount = dt.Rows.Count;
                if (dcount > 0)
                {
                    Works wbll = new Works();
                    SurveyFeedback fbll = new SurveyFeedback();
                    TopicReply rbll = new TopicReply();
                    TxtFormBack xbll = new TxtFormBack();

                    for (int i = 0; i < dcount; i++)
                    {
                        string Ltype = dt.Rows[i]["Ltype"].ToString();//��ȡѧ����Ŀ���ͣ�1�2����3����4��
                        int Lxid = Convert.ToInt32(dt.Rows[i]["Lxid"].ToString());//��ȡ��Ӧ��ĿID���
                        string Ltitle = dt.Rows[i]["Ltitle"].ToString().Replace(" ", "");//��ȡ�˵�����
                        string Ltitlestr = "l" + Ltype + "x" + Lxid.ToString();
                        switch (Ltype)
                        {
                            case "1"://�
                            case "5"://���
                                DataTable dtms = wbll.getScoreList(Lxid, Sgrade, Sclass);
                                if (dtms.Rows.Count > 0)
                                {
                                dtstus.Columns.Add(Ltitlestr,typeof(int));
                                     GetScore(dtstus, Ltitlestr, dtms);
                                dtstus.Columns[Ltitlestr].ColumnName = Ltitle;
                                }
                                dtms.Dispose();
                                break;
                            case "2"://����
                                DataTable dtsf = fbll.GetClassScore(Lxid, Sgrade, Sclass);
                                if (dtsf.Rows.Count > 0)
                                {
                                dtstus.Columns.Add(Ltitlestr,typeof(int));
                                    GetScore(dtstus, Ltitlestr, dtsf);
                                dtstus.Columns[Ltitlestr].ColumnName = Ltitle;
                                }
                                dtsf.Dispose();
                                break;
                            case "3"://����
                                DataTable dttr = rbll.GetClassListScore(Sgrade, Sclass, Lxid);
                                if (dttr.Rows.Count > 0)
                                {
                                dtstus.Columns.Add(Ltitlestr,typeof(int));
                                    GetScore(dtstus, Ltitlestr, dttr);
                                dtstus.Columns[Ltitlestr].ColumnName = Ltitle;
                                }
                                dttr.Dispose();
                                break;
                            case "4"://��
                                DataTable dttx =xbll.GetClassTxtFormScore(Sgrade, Sclass, Lxid);
                                if (dttx.Rows.Count > 0)
                                {
                                    dtstus.Columns.Add(Ltitlestr, typeof(int));
                                    GetScore(dtstus, Ltitlestr, dttx);
                                    dtstus.Columns[Ltitlestr].ColumnName = Ltitle;
                                }
                                dttx.Dispose();
                                break;
                        }
                    }
                }
                dt.Dispose();
                //����
                int cml = dtstus.Columns.Count;
                if (cml > 2)
                {
                    Signin gbll = new Signin();
                    DataTable dtatd = gbll.GetClassListQattitude(Sgrade, Sclass, Cid);
                    if (dtatd.Rows.Count > 0)
                    {
                        string clmatd = "clmattitude";
                        dtstus.Columns.Add(clmatd, typeof(int));
                        GetScore(dtstus, clmatd, dtatd);
                        dtstus.Columns[clmatd].ColumnName = "���ñ���";
                        cml = cml + 1;//�����˿��ñ�����
                    }
                    dtstus.Columns.Add("����", typeof(float));
                    dtTotal(dtstus, cml);
                }
            }
            dtstus.Columns["Snum"].ColumnName = "ѧ��";
            dtstus.Columns["Sname"].ColumnName = "����";
            return dtstus;
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="dtt"></param>
        /// <param name="cml"></param>
        private void dtTotal(DataTable dtt,int cml)
        {
            int cn = dtt.Rows.Count;

            if (cn > 0)
            {
                for (int i = 0; i < cn; i++)
                {
                    int totalscores = 0;
                    for (int j = 2; j < cml; j++)
                    {
                        string cmn = dtt.Rows[i][j].ToString();
                        if (!string.IsNullOrEmpty(cmn))
                            totalscores = totalscores + Int32.Parse(cmn);
                    }
                    dtt.Rows[i][cml] = totalscores;
                }
            }
        }
        /// <summary>
        /// ����2�ű��ֵ��ֵ����1����ͬѧ�ŵ�ָ������
        /// </summary>
        /// <param name="dtstu"></param>
        /// <param name="clmn"></param>
        /// <param name="dtscore"></param>
        /// <returns></returns>
        private void GetScore(DataTable dtstu, string clmn, DataTable dtscore)
        {
            int scount = dtstu.Rows.Count;
            for (int i = 0; i < scount; i++)
            {
                string snum = dtstu.Rows[i]["Snum"].ToString();
                int dcount = dtscore.Rows.Count;
                for (int j = 0; j < dcount; j++)
                {
                    string xsnum = dtscore.Rows[j]["Snum"].ToString();//��2�ű��ȡ��ѧ���ֶ�Ҫ������ΪSnum
                    string myscore= dtscore.Rows[j]["Score"].ToString();//��2�ű��ȡ�ķ�ֵ�ֶ�Ҫ������ΪScore
                    if (snum == xsnum)
                    {
                        dtstu.Rows[i][clmn] = myscore;
                        break;
                    }
                }
            }            
        }
                
        /// <summary>
        /// ��ȡCid��������ѧ���б������ֶ�Cid,Cobj,Cks,Ctitle,Cclass
        /// </summary>
        /// <param name="cids"></param>
        /// <returns></returns>
        public DataSet getCidsCourses(string cids)
        {
            return dal.getCidsCourses(cids);
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

