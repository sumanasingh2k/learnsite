using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Students ��ժҪ˵����
	/// </summary>
	public class Students
	{
		private readonly LearnSite.DAL.Students dal=new LearnSite.DAL.Students();
		public Students()
		{}
		#region  ��Ա����
        
        /// <summary>
        /// ��ʼ����ҵ�ӷ��ܼ�
        /// </summary>
        public void initSwdscore()
        {
            dal.initSwdscore();
        }
               
        /// <summary>
        /// ��ʼ������ƴ�������ܼ�
        /// </summary>
        public void initSchinese()
        {
            dal.initSchinese();
        }
        /// <summary>
        /// ��ʼ���������ܼ�
        /// </summary>
        public void initStxtform()
        {
            dal.initStxtform();
        }
		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

                /// <summary>
        /// �õ����ֵѧ��Snum�����жϰ༶�����꼶����ȫУ��
        /// </summary>
        public long GetMaxSnum(int Sgrade,int Sclass)
        {
            return dal.GetMaxSnum(Sgrade,Sclass);
        }
                
        /// <summary>
        /// �Ƿ���ڸ�ѧ��
        /// </summary>
        public bool ExistsSnum(string Snum)
        {
            return dal.ExistsSnum(Snum);
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
		public int  Add(LearnSite.Model.Students model)
		{
			return dal.Add(model);
		}

                /// <summary>
        /// ����һλѧ��
        /// </summary>
        public int AddStudent(LearnSite.Model.Students model)
        {
            return dal.AddStudent(model);
        }
        public void UpdateMyClassPwd(int Sgrade, int Sclass)
        {
            dal.UpdateMyClassPwd(Sgrade, Sclass);
        }
        /// <summary>
        /// ���¸�ѧ��ѧ��������
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Spwd"></param>
        public void UpdatePwd(string Snum, string Spwd)
        {
            dal.UpdatePwd(Snum, Spwd);
        }
        /// <summary>
        /// ���¸�Sidѧ��������
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="Spwd"></param>
        public void UpdateSidPwd(string Sid, string Spwd)
        {
            dal.UpdateSidPwd(Sid, Spwd);
        }        
        /// <summary>
        /// ���¸�ѧ��ѧ�����Ա�
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Sex"></param>
        public void UpdateSex(string Snum, string Sex)
        {
            dal.UpdateSex(Snum, Sex);
        }                
        /// <summary>
        /// �Ը�������
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Sname"></param>
        /// <returns></returns>
        public bool UpdateDivide(int Sgrade, int Sclass, string Sname)
        {
            return dal.UpdateDivide(Sgrade, Sclass, Sname);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Students model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Sid)
		{
			
			dal.Delete(Sid);
		}
                
        /// <summary>
        /// �����꼶�Ͱ༶ ����õ��ð�ĳ��ѧ��һ������ʵ��
        /// </summary>
        public LearnSite.Model.Students GetRndModel(int Sgrade, int Sclass)
        {
            return dal.GetRndModel(Sgrade, Sclass);
        }
        /// <summary>
        /// ����ѧ�ź����� �õ�ѧ��һ������ʵ��
        /// </summary>
        public LearnSite.Model.Students GetStudentModel(string Snum, string Spwd)
        {
          return  dal.GetStudentModel(Snum, Spwd);
        }
                
        /// <summary>
        /// ����ѧ�ţ��õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Students SnumGetModel(string Snum)
        {
            return dal.SnumGetModel(Snum);
        }
                
        /// <summary>
        /// �����Զ���ŷ�������
        /// </summary>
        /// <param name="Sid"></param>
        /// <returns></returns>
        public string GetSnameBySid(int Sid)
        {
            return dal.GetSnameBySid(Sid);
        }
                
        /// <summary>
        /// ����ѧ�ŷ�������
        /// </summary>
        /// <param name="Sid"></param>
        /// <returns></returns>
        public string GetSnameBySnum(string Snum)
        {
            return dal.GetSnameBySnum(Snum);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Students GetModel(int Sid)
		{
			
			return dal.GetModel(Sid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Students GetModelByCache(int Sid)
		{
			
			string CacheKey = "StudentsModel-" + Sid;
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
			return (LearnSite.Model.Students)objModel;
		}

        /// <summary>
        /// �����Ʒ���������б�
		/// </summary>
        public DataSet GetListTerm(int Sgrade, int Sclass)
        {
            return dal.GetListTerm(Sgrade, Sclass);
        }

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
                /// <summary>
        /// ������������б�
        /// </summary>
        public DataSet GetSqlList(string strSql)
        {
           return dal.GetSqlList(strSql);
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
		public List<LearnSite.Model.Students> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Students> DataTableToList(DataTable dt)
		{
            List<LearnSite.Model.Students> modelList = new List<LearnSite.Model.Students>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                LearnSite.Model.Students model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new LearnSite.Model.Students();
                    if (dt.Rows[n]["Sid"].ToString() != "")
                    {
                        model.Sid = int.Parse(dt.Rows[n]["Sid"].ToString());
                    }
                    model.Snum = dt.Rows[n]["Snum"].ToString();
                    if (dt.Rows[n]["Syear"].ToString() != "")
                    {
                        model.Syear = int.Parse(dt.Rows[n]["Syear"].ToString());
                    }
                    if (dt.Rows[n]["Sgrade"].ToString() != "")
                    {
                        model.Sgrade = int.Parse(dt.Rows[n]["Sgrade"].ToString());
                    }
                    if (dt.Rows[n]["Sclass"].ToString() != "")
                    {
                        model.Sclass = int.Parse(dt.Rows[n]["Sclass"].ToString());
                    }
                    model.Sname = dt.Rows[n]["Sname"].ToString();
                    model.Spwd = dt.Rows[n]["Spwd"].ToString();
                    model.Sex = dt.Rows[n]["Sex"].ToString();
                    model.Saddress = dt.Rows[n]["Saddress"].ToString();
                    model.Sphone = dt.Rows[n]["Sphone"].ToString();
                    model.Sparents = dt.Rows[n]["Sparents"].ToString();
                    model.Sheadtheacher = dt.Rows[n]["Sheadtheacher"].ToString();
                    if (dt.Rows[n]["Sscore"].ToString() != "")
                    {
                        model.Sscore = int.Parse(dt.Rows[n]["Sscore"].ToString());
                    }
                    if (dt.Rows[n]["Squiz"].ToString() != "")
                    {
                        model.Squiz = int.Parse(dt.Rows[n]["Squiz"].ToString());
                    }
                    if (dt.Rows[n]["Sattitude"].ToString() != "")
                    {
                        model.Sattitude = int.Parse(dt.Rows[n]["Sattitude"].ToString());
                    }
                    model.Sape = dt.Rows[n]["Sape"].ToString();
                    if (dt.Rows[n]["Swscore"].ToString() != "")
                    {
                        model.Swscore = int.Parse(dt.Rows[n]["Swscore"].ToString());
                    }
                    if (dt.Rows[n]["Stscore"].ToString() != "")
                    {
                        model.Stscore = int.Parse(dt.Rows[n]["Stscore"].ToString());
                    }
                    if (dt.Rows[n]["Sallscore"].ToString() != "")
                    {
                        model.Sallscore = int.Parse(dt.Rows[n]["Sallscore"].ToString());
                    }
                    if (dt.Rows[n]["Spscore"].ToString() != "")
                    {
                        model.Spscore = int.Parse(dt.Rows[n]["Spscore"].ToString());
                    }
                    if (dt.Rows[n]["Sgroup"].ToString() != "")
                    {
                        model.Sgroup = int.Parse(dt.Rows[n]["Sgroup"].ToString());
                    }
                    if (dt.Rows[n]["Sleader"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Sleader"].ToString() == "1") || (dt.Rows[n]["Sleader"].ToString().ToLower() == "true"))
                        {
                            model.Sleader = true;
                        }
                        else
                        {
                            model.Sleader = false;
                        }
                    }
                    if (dt.Rows[n]["Svote"].ToString() != "")
                    {
                        model.Svote = int.Parse(dt.Rows[n]["Svote"].ToString());
                    }
                    if (dt.Rows[n]["Sgscore"].ToString() != "")
                    {
                        model.Sgscore = int.Parse(dt.Rows[n]["Sgscore"].ToString());
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
        /// ��õ�ǰ�༶ѧ�����������б�
        /// </summary>
        /// <param name="Syear"></param>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable GetListSattitude(int Syear, int Sgrade, int Sclass)
        {
            return dal.GetListSattitude(Syear, Sgrade, Sclass);
        }
        /// <summary>
        /// ��õ���ѧ������
        /// </summary>
        public DataSet GetOneStudent(int Sid)
        {
            return dal.GetOneStudent(Sid);
        }

        /// <summary>
        /// ������������ѧ���ܻ���
        /// </summary>
        public void TeamScores()
        {
            dal.TeamScores();
        }
        public void TotalSgscore(string gstudnets, int Cobj, int Cterm)
        {
            dal.TotalSgscore(gstudnets, Cobj, Cterm);
        }
        /// <summary>
        /// �����������̰༶��ǰѧ��С�������
        /// </summary>
        public void ThisTeamGroupScores()
        {
            dal.ThisTeamGroupScores();
        }      
        /// <summary>
        /// �����������̰༶��ǰѧ����Ʒ�ܻ��ֺͱ����ܻ��֡���������//ISNULL  COALESCE
        /// </summary>
        public void ThisTeamScoresNew()
        {
            dal.ThisTeamScoresNew();
        }
        /// <summary>
        /// �������¸ð༶��ǰѧ����Ʒ�ܻ��ֺͱ����ܻ��֣�����group������
        /// </summary>
        public void ThisClassTeamScoresNew(int Sgrade, int Sclass)
        {
            dal.ThisClassTeamScoresNew(Sgrade, Sclass);
        }

        /// <summary>
        /// �ս�������
        /// </summary>
        /// <param name="perA"></param>
        /// <param name="perE"></param>
        public void TermAPE(int perA, int perE)
        {
            dal.TermAPE(perA,perE);
        }

              /// <summary>
        /// ���ճɼ���������Excel��
        /// </summary>
        public void TermExcel()
        {
            dal.TermExcel();
        }
                /// <summary>
        /// ѧ����������ݵ���Excel
        /// </summary>
        public void StudentsToExcel()
        {
            dal.StudentsToExcel();
        }
                /// <summary>
        /// ���ѧ������ҳ�����б�
        /// </summary>
        public DataSet GetListStudents(int Sgrade, int Sclass)
        {
            return dal.GetListStudents(Sgrade, Sclass);
        }        
        /// <summary>
        /// ��ñ���ѧ��ѧ�ź����������б�
        /// </summary>
        public DataSet GetStudentsSnumSname(int Sgrade, int Sclass)
        {
            return dal.GetStudentsSnumSname(Sgrade, Sclass);
        }
        /// <summary>
        /// ��ñ��꼶����ѧ���б�Snum,Sclass,Sname
        /// </summary>
        public DataTable GetStudentsSnumSname(int Sgrade)
        {
            return dal.GetStudentsSnumSname(Sgrade);
        }
        /// <summary>
        /// ���ȫ��ѧ����ѧ���б�
        /// </summary>
        public DataSet GetAllYears()
        {
            return dal.GetAllYears();
        }

                /// <summary>
        /// ��ѧ����õ�����ݵļ�¼��
        /// </summary>
        /// <param name="Syear"></param>
        /// <returns></returns>
        public int FindCount(int Syear)
        {
            return dal.FindCount(Syear);
        }

        /// <summary>
        /// ѧ��������ѧ���꼶����һ������ɾ���༶���в����ڰ༶��ѧ��
        /// </summary>
        public void Upgrade()
        {
            dal.Upgrade();
        }

        /// <summary>
        /// ��ø��꼶����ѧ���
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <returns></returns>
        public string GetYear(int Sgrade)
        {
            return dal.GetYear(Sgrade);
        }
        /// <summary>
        /// ��ø��꼶����ѧ���
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public int GetYear(int Sgrade, int Sclass)
        {
            return dal.GetYear(Sgrade, Sclass);
        }

        /// <summary>
        /// �����꼶���༶���������ѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataSet GetNameNum(int Sgrade, int Sclass)
        {
            return dal.GetNameNum(Sgrade, Sclass);
        }

        /// <summary>
        /// ��ʾ���꼶������ߵ�50����¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="GridViewscore"></param>
        public  DataTable  ShowTopScore(int Sgrade)
        {
            return dal.ShowTopScore(Sgrade).Tables[0];
        }
        
        /// <summary>
        /// ��ʾ���༶���л��ּ�¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataSet ShowMyclassScore(int Sgrade, int Sclass)
        {
            return dal.ShowMyclassScore(Sgrade, Sclass);
        }
                
        /// <summary>
        /// ��ѯѧ����ļ�¼����
        /// </summary>
        /// <returns></returns>
        public int GetCounts()
        {
          return  dal.GetCounts();
        }

                /// <summary>
        /// ���¸�ѧ��ѧ���Ĳ���ɼ�
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Squiz"></param>
        public void SetSquiz(int Rsid, int Squiz)
        {
            dal.SetSquiz(Rsid, Squiz);
        }
               
        /// <summary>
        /// ������ѧ���Ĳ���ͳ�Ƴɼ�����Ϊ�������߷�
        /// </summary>
        public void UpdateBestSquiz()
        {
            dal.UpdateBestSquiz();
        }
        /// <summary>
        /// ��ñ��꼶����ɼ���ߵ�50����¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <returns></returns>
        public DataSet TopGradeQuiz(int Sgrade)
        {
            return dal.TopGradeQuiz(Sgrade);
        }
        /// <summary>
        /// ��ñ��༶����ɼ����м�¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataSet TopClassQuiz(int Sgrade, int Sclass)
        {
            return dal.TopClassQuiz(Sgrade, Sclass);
        }

                /// <summary>
        /// ����ҵĲ���ƽ���ɼ�
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public string MySquiz(string Snum)
        {
            return dal.MySquiz(Snum);
        }
        /// <summary>
        /// ����ѧ�źͰ༶���룬�жϸ�ѧ���Ƿ����
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Rpwd"></param>
        /// <returns></returns>
        public bool ExistsLogin(string Snum, string Rpwd)
        {
            return dal.ExistsLogin(Snum, Rpwd);
        }       
        /// <summary>
        /// ����ѧ�ź͸������룬�жϸ�ѧ���Ƿ����
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Spwd"></param>
        /// <returns></returns>
        public bool ExistsLoginSelf(string Snum, string Spwd)
        {
            return dal.ExistsLoginSelf(Snum, Spwd);
        }
                
        /// <summary>
        /// ����ѧ��������ҳ�����ɼ�
        /// </summary>
        public void UpdateWebScore()
        {
            dal.UpdateWebScore();
        }
                
        /// <summary>
        /// ��¼�˺Ž�ʦ���̰༶���趨�ٷֱȼ����ܷ�
        /// </summary>
        /// <param name="persscore"></param>
        /// <param name="persquiz"></param>
        /// <param name="perswscore"></param>
        /// <param name="perstscore"></param>
        public void UpdateAllScore(int persscore, int persquiz, int perswscore, int perstscore, int perattitude, int persurvey)
        {
            dal.UpdateAllScore(persscore, persquiz, perswscore, perstscore,perattitude,persurvey);
        }        
        /// <summary>
        /// ����ѧ����Ĵ��ֳɼ�
        /// </summary>
        public void UpdateStscore()
        {
            dal.UpdateStscore();
        }

        /// <summary>
        /// ����ѧ�ţ����°༶
        /// </summary>
        /// <param name="Sclass"></param>
        /// <param name="Snum"></param>
        public void UpdateStuclass(int Sclass, string Snum)
        {
            dal.UpdateStuclass(Sclass, Snum);
        }
                
        /// <summary>
        /// ���ݽ�ʦ�Զ����Hid���������̰༶��Syear,Sclass���ݼ�
        /// </summary>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public DataSet TeacherSyearSclass(int hid)
        {
            return dal.TeacherSyearSclass(hid);
        }                
        /// <summary>
        /// �����̰༶��ѧ���������Ϊԭ��ʼ�����������ת��Ϊ����ƴ����д�����ת���Ĳ�����ĸ�����֣��򲻸������룩
        /// ��������ѧ��������ת���ɹ�������
        /// </summary>
        /// <param name="hid"></param>
        /// <param name="Spwd"></param>
        public string SpwdToSpell(int hid, string Spwd)
        {
            return dal.SpwdToSpell(hid, Spwd);
        }
               
        /// <summary>
        /// ��ʼ��Sleaderֵ�����ݿ�����ʱ��
        /// </summary>
        public void InitSleader()
        {
            dal.InitSleader();
        }
                
        /// <summary>
        /// ������ж���鳤
        /// </summary>
        /// <param name="Snum"></param>
        public void ChangeSleader(int Sid)
        {
            dal.ChangeSleader(Sid);
        }       
        /// <summary>
        /// ��ȡ�༶����С��ӳ���Ϣ
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataSet ClassGroup(int Sgrade, int Sclass)
        {
            return dal.ClassGroup(Sgrade, Sclass);
        }        
        /// <summary>
        /// ��ȡ��С���Ա����
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Sgroup"></param>
        /// <returns></returns>
        public string GroupMember(int Sgrade, int Sclass, int Sgroup)
        {
            return dal.GroupMember(Sgrade, Sclass, Sgroup);
        }        
        /// <summary>
        /// ���¸�ѧ�ŵ�С���
        /// ���ԭ�鳤��ж���������С��
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Sgroup"></param>
        public void AddThisGroup(string Snum, int Sgroup)
        {
            dal.AddThisGroup(Snum, Sgroup);
        }
        public void AddThisGroup(int Sid, int Sgroup)
        {
            dal.AddThisGroup(Sid, Sgroup);
        }
        /// <summary>
        /// ��ȡ���౾С������
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Sgroup"></param>
        /// <returns></returns>
        public int GetGroupCount(int Sgrade, int Sclass, int Sgroup)
        {
            return dal.GetGroupCount(Sgrade, Sclass, Sgroup);
        }
                
        /// <summary>
        ///  ����ѧ�ŷ��鳤ͬѧ����
        /// </summary>
        /// <param name="Snum"></param>
        public void QuitThitGroup(string Snum)
        {
            dal.QuitThitGroup(Snum);
        }   
           /// <summary>
        /// ����ѧ�ŷ��鳤ͬѧ����
        /// </summary>
        /// <param name="Sid"></param>
        public void QuitThitGroup(int Sid)
        {
            dal.QuitThitGroup(Sid);
        }
        /// <summary>
        /// �Ƿ��鳤
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public bool IsLeader(string Snum)
        {
            return dal.IsLeader(Snum);
        }
                
        /// <summary>
        /// �Ƿ��鳤
        /// </summary>
        /// <param name="Sid"></param>
        /// <returns></returns>
        public bool IsLeaderSid(int Sid)
        {
            return dal.IsLeaderSid(Sid);
        }
                
        /// <summary>
        /// ��ȡС������
        /// </summary>
        /// <param name="Sid"></param>
        /// <returns></returns>
        public string GetSgtitle(int Sgroup)
        {
            return dal.GetSgtitle(Sgroup);
        }
                
        /// <summary>
        /// ����С������
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="Sgtitle"></param>
        /// <returns></returns>
        public int UpdateSgtitle(int Sid, string Sgtitle)
        {
            return dal.UpdateSgtitle(Sid, Sgtitle);
        }
        /// <summary>
        /// ����ѧ�Ż�ȡͬ���Ա������ѧ��
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public string GroupSnum(string Snum)
        {
            return dal.GroupSnum(Snum);
        }
                
        /// <summary>
        /// ��ȡ��ѧ���꼶
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public int GetSgrade(string Snum)
        {
            return dal.GetSgrade(Snum);
        }
                        
        /// <summary>
        /// ����ѧ�ţ��޸�����
        /// </summary>
        /// <param name="Snum"></param>
        /// <param name="Sname"></param>
        /// <returns></returns>
        public int ChangeSname(string Snum, string Sname)
        {
            return dal.ChangeSname(Snum, Sname);
        }
        /// <summary>
        /// ��ʼ��ָ���ɼ��ֶ�
        /// </summary>
        /// <returns></returns>
        public int InitSfscore()
        {
            return dal.InitSfscore();
        }
        /// <summary>
        /// ��ʼ�����õ������ɼ�
        /// </summary>
        /// <returns></returns>
        public int InitSvscore()
        {
            return dal.InitSvscore();
        }
        /// <summary>
        /// ����ָ���ɼ�
        /// </summary>
        /// <returns></returns>
        public int UpdateSfscore()
        {
            return dal.UpdateSfscore();
        }
                
        /// <summary>
        /// ��������ƴ���ɼ�
        /// </summary>
        /// <returns></returns>
        public int UpdateSchinese()
        {
            return dal.UpdateSchinese();
        }
        /// <summary>
        /// ͳ��ǰ�������ѧ���ɼ�
        /// </summary>
        public void ClearAllScores()
        {
            dal.ClearAllScores();
        }
        /// <summary>
        /// ���ضӳ�����
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public string GetLeader(int Sid)
        {
            return dal.GetLeader(Sid);
        }
        public string GetLeaderByGroup(int Sgroup)
        {
            return dal.GetLeaderByGroup(Sgroup);
        }
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public int NoGroup(int Sgrade, int Sclass)
        {
            return dal.NoGroup(Sgrade, Sclass);
        }
                
        /// <summary>
        /// ��ȡ��ǰ�༶ѧ�ż�����,�ָ�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowClassSnums(int Sgrade, int Sclass)
        {
            return dal.ShowClassSnums(Sgrade, Sclass);
        }
                
        /// <summary>
        /// ��ȡ��ǰ�༶ѧ����ż�����,�ָ�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowClassSids(int Sgrade, int Sclass)
        {
            return dal.ShowClassSids(Sgrade, Sclass);
        }                
        /// <summary>
        /// ��ȡ��ǰ�꼶ѧ����ż�����,�ָ�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <returns></returns>
        public string ShowGradeSids(int Sgrade)
        {
            return dal.ShowGradeSids(Sgrade);
        }
        /// <summary>
        /// ��ȡ�ð༶������
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public int CountClassMate(int Sgrade, int Sclass)
        {
            return dal.CountClassMate(Sgrade, Sclass);
        }
        /// <summary>
        /// ����ð༶������ѧ����¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public int DeleteClassMate(int Sgrade, int Sclass)
        {
            return dal.DeleteClassMate(Sgrade, Sclass);
        }
                
        /// <summary>
        /// ���ܱ�С��ͳ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="dttotal"></param>
        /// <returns></returns>
        public DataTable groupscores(int Sgrade, int Sclass, DataTable dttotal, int Gcid)
        {
            return dal.groupscores(Sgrade, Sclass, dttotal,Gcid);
        }
                
        /// <summary>
        /// ��ȡδ����༶��ѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable NoGroupStudents(int Sgrade, int Sclass, string sort)
        {
            return dal.NoGroupStudents(Sgrade, Sclass, sort);
        }                
        /// <summary>
        /// ��ȡ��С���Ա
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Sgroup"></param>
        /// <returns></returns>
        public DataTable GroupMembers(int Sgrade, int Sclass, int Sgroup)
        {
            return dal.GroupMembers(Sgrade, Sclass, Sgroup);
        }                   
        /// <summary>
        /// ��ȡ��С�����̳�Ա�������鳤��Sid,Snum,Sname
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Sgroup"></param>
        /// <returns></returns>
        public DataTable GroupDiskMembers(int Sgrade, int Sclass, int Sgroup)
        {
            return dal.GroupDiskMembers(Sgrade, Sclass, Sgroup);
        }
        /// <summary>
        /// ��ȡ�����ڵĸ�����Ʒƽ����
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Sgroup"></param>
        /// <returns></returns>
        public string MyGroupSscores(int Sgrade, int Sclass, int Sgroup)
        {
            return dal.MyGroupSscores(Sgrade, Sclass, Sgroup);
        }
                
        /// <summary>
        /// ��ʼ��С������Ϊ�鳤������������С������Ϊ�գ�
        /// </summary>
        /// <returns></returns>
        public int InitSgtitle()
        {
            return dal.InitSgtitle();
        }
                
        /// <summary>
        /// ����Sid��ȡ���
        /// </summary>
        /// <param name="Sid"></param>
        /// <returns></returns>
        public int GetSgroup(int Sid)
        {
            return dal.GetSgroup(Sid);
        }
        public void UpdateKaoxu(string kaoxu, string Sname)
        {
            dal.UpdateKaoxu(kaoxu, Sname);
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

