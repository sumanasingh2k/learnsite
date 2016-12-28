using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����Courses��
	/// </summary>
	public class Courses
	{
		public Courses()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Cid", "Courses"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Cid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Courses");
			strSql.Append(" where Cid=@Cid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4)};
			parameters[0].Value = Cid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ������ѧ����źͱ������ɶ���Ŀ¼�ŵ�ѧ����Ŀ¼�£������Ժ�鿴
        /// </summary>
        /// <param name="xmlpath"></param>
        public void CreatPackageNameList(string xmlpath)
        {
            string mysql = "select distinct Cid,Ctitle,Cobj,Cterm,Chid,Hname from Courses,Teacher where Chid=Hid and Cdelete=0 order by Chid,Cobj,Cterm";
            DataSet ds = DbHelperSQL.Query(mysql);
            ds.WriteXml(xmlpath, XmlWriteMode.IgnoreSchema);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.Courses model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Courses(");
			strSql.Append("Ctitle,Cclass,Ccontent,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish)");
			strSql.Append(" values (");
			strSql.Append("@Ctitle,@Cclass,@Ccontent,@Cdate,@Chit,@Cobj,@Cterm,@Cks,@Cfiletype,@Cupload,@Chid,@Cpublish)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Ctitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Cclass", SqlDbType.NVarChar,50),
					new SqlParameter("@Ccontent", SqlDbType.NText),
					new SqlParameter("@Cdate", SqlDbType.DateTime),
					new SqlParameter("@Chit", SqlDbType.Int,4),
					new SqlParameter("@Cobj", SqlDbType.Int,4),
					new SqlParameter("@Cterm", SqlDbType.Int,4),
					new SqlParameter("@Cks", SqlDbType.Int,4),
					new SqlParameter("@Cfiletype", SqlDbType.NVarChar,50),
					new SqlParameter("@Cupload", SqlDbType.Bit,1),
					new SqlParameter("@Chid", SqlDbType.Int,4),
					new SqlParameter("@Cpublish", SqlDbType.Bit,1)};
			parameters[0].Value = model.Ctitle;
			parameters[1].Value = model.Cclass;
			parameters[2].Value = model.Ccontent;
			parameters[3].Value = model.Cdate;
			parameters[4].Value = model.Chit;
			parameters[5].Value = model.Cobj;
			parameters[6].Value = model.Cterm;
			parameters[7].Value = model.Cks;
			parameters[8].Value = model.Cfiletype;
			parameters[9].Value = model.Cupload;
			parameters[10].Value = model.Chid;
			parameters[11].Value = model.Cpublish;

            object obj = SqlHelper.GetSingle(strSql.ToString(), parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
        /// <summary>
        /// ������ѧ����Ctitle,Cclass��Cdate,Cobj,Cterm,Cks,Cfiletype,Cupload,Cpublish���������Զ����
        /// </summary>
        /// <param name="Ctitle"></param>
        /// <returns></returns>
        public int Create(LearnSite.Model.Courses model)
        {            
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Courses(");
            strSql.Append("Ctitle,Cclass,Cdate,Cobj,Cterm,Cks,Chid,Cpublish)");
            strSql.Append(" values (");
            strSql.Append("@Ctitle,@Cclass,@Cdate,@Cobj,@Cterm,@Cks,@Chid,@Cpublish)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Ctitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Cclass", SqlDbType.NVarChar,50),
					new SqlParameter("@Cdate", SqlDbType.DateTime),
					new SqlParameter("@Cobj", SqlDbType.Int,4),
					new SqlParameter("@Cterm", SqlDbType.Int,4),
					new SqlParameter("@Cks", SqlDbType.Int,4),
                    new SqlParameter("@Chid", SqlDbType.Int,4),
					new SqlParameter("@Cpublish", SqlDbType.Bit,1)};
            parameters[0].Value = model.Ctitle;
            parameters[1].Value = model.Cclass;
            parameters[2].Value = model.Cdate;
            parameters[3].Value = model.Cobj;
            parameters[4].Value = model.Cterm;
            parameters[5].Value = model.Cks;
            parameters[6].Value = model.Chid;
            parameters[7].Value = model.Cpublish;
            object obj = SqlHelper.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Courses model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Courses set ");
			strSql.Append("Ctitle=@Ctitle,");
			strSql.Append("Cclass=@Cclass,");
			strSql.Append("Ccontent=@Ccontent,");
			strSql.Append("Cdate=@Cdate,");
			strSql.Append("Chit=@Chit,");
			strSql.Append("Cobj=@Cobj,");
			strSql.Append("Cterm=@Cterm,");
			strSql.Append("Cks=@Cks,");
			strSql.Append("Cfiletype=@Cfiletype,");
			strSql.Append("Cupload=@Cupload,");
			strSql.Append("Chid=@Chid,");
			strSql.Append("Cpublish=@Cpublish");
			strSql.Append(" where Cid=@Cid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4),
					new SqlParameter("@Ctitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Cclass", SqlDbType.NVarChar,50),
					new SqlParameter("@Ccontent", SqlDbType.NText),
					new SqlParameter("@Cdate", SqlDbType.DateTime),
					new SqlParameter("@Chit", SqlDbType.Int,4),
					new SqlParameter("@Cobj", SqlDbType.Int,4),
					new SqlParameter("@Cterm", SqlDbType.Int,4),
					new SqlParameter("@Cks", SqlDbType.Int,4),
					new SqlParameter("@Cfiletype", SqlDbType.NVarChar,50),
					new SqlParameter("@Cupload", SqlDbType.Bit,1),
					new SqlParameter("@Chid", SqlDbType.Int,4),
					new SqlParameter("@Cpublish", SqlDbType.Bit,1)};
			parameters[0].Value = model.Cid;
			parameters[1].Value = model.Ctitle;
			parameters[2].Value = model.Cclass;
			parameters[3].Value = model.Ccontent;
			parameters[4].Value = model.Cdate;
			parameters[5].Value = model.Chit;
			parameters[6].Value = model.Cobj;
			parameters[7].Value = model.Cterm;
			parameters[8].Value = model.Cks;
			parameters[9].Value = model.Cfiletype;
			parameters[10].Value = model.Cupload;
			parameters[11].Value = model.Chid;
			parameters[12].Value = model.Cpublish;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

        /// <summary>
        /// ����һ������,����ѧ������
        /// </summary>
        public void UpdateCourse(LearnSite.Model.Courses model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Ctitle=@Ctitle,");
            strSql.Append("Cclass=@Cclass,");
            strSql.Append("Ccontent=@Ccontent,");
            strSql.Append("Cdate=@Cdate,");
            strSql.Append("Cobj=@Cobj,");
            strSql.Append("Cterm=@Cterm,");
            strSql.Append("Cks=@Cks,");
            strSql.Append("Chid=@Chid,");
            strSql.Append("Cpublish=@Cpublish");
            strSql.Append(" where Cid=@Cid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4),
					new SqlParameter("@Ctitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Cclass", SqlDbType.NVarChar,50),
					new SqlParameter("@Ccontent", SqlDbType.NText),
					new SqlParameter("@Cdate", SqlDbType.DateTime),
					new SqlParameter("@Cobj", SqlDbType.Int,4),
					new SqlParameter("@Cterm", SqlDbType.Int,4),
					new SqlParameter("@Cks", SqlDbType.Int,4),
                    new SqlParameter("@Chid", SqlDbType.Int,4),
                    new SqlParameter("@Cpublish", SqlDbType.Bit,1)};
            parameters[0].Value = model.Cid;
            parameters[1].Value = model.Ctitle;
            parameters[2].Value = model.Cclass;
            parameters[3].Value = model.Ccontent;
            parameters[4].Value = model.Cdate;
            parameters[5].Value = model.Cobj;
            parameters[6].Value = model.Cterm;
            parameters[7].Value = model.Cks;
            parameters[8].Value = model.Chid;
            parameters[9].Value = model.Cpublish;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ����һ������,����ѧ�����ݣ�ѧ��������ʱר��
        /// </summary>
        public void UpdateCcontent(int Cid,string Ccontent)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Ccontent=@Ccontent ");
            strSql.Append(" where Cid=@Cid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4),
					new SqlParameter("@Ccontent", SqlDbType.NText)};
            parameters[0].Value = Cid;
            parameters[1].Value = Ccontent;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// �޸�ѧ������״̬
        /// </summary>
        public void UpdateCpublish(int Cid, bool Cpublish)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Cpublish=@Cpublish");
            strSql.Append(" where Cid=@Cid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4),
					new SqlParameter("@Cpublish", SqlDbType.Bit,1)};
            parameters[0].Value = Cid;
            parameters[1].Value = Cpublish;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �޸�ѧ������״̬
        /// </summary>
        public void UpdateCpublish(int Cid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Cpublish=Cpublish^1");
            strSql.Append(" where Cid=@Cid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4)};
            parameters[0].Value = Cid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �޸�ѧ�����״̬
        /// </summary>
        public void UpdateCold(int Cid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Cold=Cold^1");
            strSql.Append(" where Cid=@Cid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4)};
            parameters[0].Value = Cid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �޸�ѧ���Ƽ�״̬
        /// </summary>
        public void UpdateCgood(int Cid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set ");
            strSql.Append("Cgood=Cgood^1");
            strSql.Append(" where Cid=@Cid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4)};
            parameters[0].Value = Cid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Cid,int Chid)
		{			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Courses ");
			strSql.Append(" where Cid=@Cid and Chid=@Chid");
			SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4),
                    new SqlParameter("@Chid", SqlDbType.Int,4)};
			parameters[0].Value = Cid;
            parameters[1].Value = Chid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteCourse(int Cid, int Chid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Courses set Cdelete=1,Cpublish=0 ");
            strSql.Append(" where Cid=@Cid and Chid=@Chid");
            SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4),
                    new SqlParameter("@Chid", SqlDbType.Int,4)};
            parameters[0].Value = Cid;
            parameters[1].Value = Chid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Courses GetModel(int Cid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Cid,Ctitle,Cclass,Ccontent,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish from Courses ");
			strSql.Append(" where Cid=@Cid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Cid", SqlDbType.Int,4)};
			parameters[0].Value = Cid;

			LearnSite.Model.Courses model=new LearnSite.Model.Courses();
            DataSet ds =DbHelperSQL.Query(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Cid"].ToString()!="")
				{
					model.Cid=int.Parse(ds.Tables[0].Rows[0]["Cid"].ToString());
				}
				model.Ctitle=ds.Tables[0].Rows[0]["Ctitle"].ToString();
				model.Cclass=ds.Tables[0].Rows[0]["Cclass"].ToString();
				model.Ccontent=ds.Tables[0].Rows[0]["Ccontent"].ToString();
				if(ds.Tables[0].Rows[0]["Cdate"].ToString()!="")
				{
					model.Cdate=DateTime.Parse(ds.Tables[0].Rows[0]["Cdate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Chit"].ToString()!="")
				{
					model.Chit=int.Parse(ds.Tables[0].Rows[0]["Chit"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Cobj"].ToString()!="")
				{
					model.Cobj=int.Parse(ds.Tables[0].Rows[0]["Cobj"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Cterm"].ToString()!="")
				{
					model.Cterm=int.Parse(ds.Tables[0].Rows[0]["Cterm"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Cks"].ToString()!="")
				{
					model.Cks=int.Parse(ds.Tables[0].Rows[0]["Cks"].ToString());
				}
				model.Cfiletype=ds.Tables[0].Rows[0]["Cfiletype"].ToString();
				if(ds.Tables[0].Rows[0]["Cupload"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Cupload"].ToString()=="1")||(ds.Tables[0].Rows[0]["Cupload"].ToString().ToLower()=="true"))
					{
						model.Cupload=true;
					}
					else
					{
						model.Cupload=false;
					}
				}
				if(ds.Tables[0].Rows[0]["Chid"].ToString()!="")
				{
					model.Chid=int.Parse(ds.Tables[0].Rows[0]["Chid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Cpublish"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Cpublish"].ToString()=="1")||(ds.Tables[0].Rows[0]["Cpublish"].ToString().ToLower()=="true"))
					{
						model.Cpublish=true;
					}
					else
					{
						model.Cpublish=false;
					}
				}
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// �ӱ��е�һ����¼�õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Courses GetTableModel(DataTable dt)
        {             
            LearnSite.Model.Courses model = new LearnSite.Model.Courses();
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Cid"].ToString() != "")
                {
                    model.Cid = int.Parse(dt.Rows[0]["Cid"].ToString());
                }
                model.Ctitle = dt.Rows[0]["Ctitle"].ToString();
                model.Cclass = dt.Rows[0]["Cclass"].ToString();
                model.Ccontent = dt.Rows[0]["Ccontent"].ToString();
                if (dt.Rows[0]["Cdate"].ToString() != "")
                {
                    model.Cdate = DateTime.Parse(dt.Rows[0]["Cdate"].ToString());
                }
                if (dt.Rows[0]["Chit"].ToString() != "")
                {
                    model.Chit = int.Parse(dt.Rows[0]["Chit"].ToString());
                }
                if (dt.Rows[0]["Cobj"].ToString() != "")
                {
                    model.Cobj = int.Parse(dt.Rows[0]["Cobj"].ToString());
                }
                if (dt.Rows[0]["Cterm"].ToString() != "")
                {
                    model.Cterm = int.Parse(dt.Rows[0]["Cterm"].ToString());
                }
                if (dt.Rows[0]["Cks"].ToString() != "")
                {
                    model.Cks = int.Parse(dt.Rows[0]["Cks"].ToString());
                }
                if (dt.Rows[0]["Cupload"].ToString() != "")
                {
                    if ((dt.Rows[0]["Cupload"].ToString() == "1") || (dt.Rows[0]["Cupload"].ToString().ToLower() == "true"))
                    {
                        model.Cupload = true;
                    }
                    else
                    {
                        model.Cupload = false;
                    }
                }
                if (dt.Rows[0]["Chid"].ToString() != "")
                {
                    model.Chid = int.Parse(dt.Rows[0]["Chid"].ToString());
                }
                if (dt.Rows[0]["Cpublish"].ToString() != "")
                {
                    if ((dt.Rows[0]["Cpublish"].ToString() == "1") || (dt.Rows[0]["Cpublish"].ToString().ToLower() == "true"))
                    {
                        model.Cpublish = true;
                    }
                    else
                    {
                        model.Cpublish = false;
                    }
                }
                return model;
            }
            else
            {
                return null;
            }
        }


		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Cid,Ctitle,Cclass,Ccontent,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish ");
			strSql.Append(" FROM Courses ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ���ѧ���б�������
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListNoContent(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Cid,Ctitle,Cclass,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish,Cgood ");
            strSql.Append(" FROM Courses ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
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
            string mysql = "select Cid,Ctitle from Courses where Chid="+Chid+" and Cobj="+Cobj+" and Cterm="+Cterm+" order by Cks desc";
            return DbHelperSQL.Query(mysql);
        }

        /// <summary>
        /// ���ѧ���б������ݣ�����
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetListGoodNoContent(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Cid,Ctitle,Cclass,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish ");
            strSql.Append(" FROM Courses ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �������������ݣ�����������
        /// </summary>
        /// <param name="strOrder"></param>
        /// <returns></returns>
        public DataSet GetListNo(string strOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Cid,Ctitle,Cclass,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish ");
            strSql.Append(" FROM Courses ");
            if (strOrder.Trim() != "")
            {
                strSql.Append(strOrder);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �����ݣ� ����������ѧ�ڡ��꼶����ʱ��������
        /// </summary>
        /// <param name="Cterm"></param>
        /// <param name="Cobj"></param>
        /// <returns></returns>
        public DataSet GetListLession(int Cterm, int Cobj,int Chid)
        {
            string strWhere =" Cterm="+Cterm+ " and Cobj="+Cobj+" and Chid="+Chid+" and Cdelete=0 and Cold=0 order by Cks ASC";
            return GetListNoContent(strWhere);
        }
        /// <summary>
        /// ����ѧ����ţ�����ѧ������
        /// </summary>
        /// <param name="Fcid"></param>
        /// <returns></returns>
        public string GetTitle(int Cid)
        {
            string mysql = "select  Ctitle from Courses where Cid=" + Cid;
            return DbHelperSQL.FindString(mysql);
        }
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Cid,Ctitle,Cclass,Ccontent,Cdate,Chit,Cobj,Cterm,Cks,Cfiletype,Cupload,Chid,Cpublish ");
			strSql.Append(" FROM Courses ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// �����꼶��ʾ�����ʦ����δѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="GridViewnewkc"></param>
        public DataTable ShowNewCourse(int Sgrade, int Cterm, int Chid, string Cids)
        {            
            string mysql = "SELECT  Cid,Cclass,Ctitle,CONVERT(nvarchar(10), Cdate, 120) as Cdate,Cobj,Cterm,Cks,Cupload FROM Courses Where Chid=" + Chid + " AND Cobj=" + Sgrade + "  AND Cterm=" + Cterm + " AND Cpublish=1 AND Cdelete=0  ORDER BY Cobj DESC,Cks DESC";
            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            int dtcount = dt.Rows.Count;
            string[] CidsStr = Cids.Split(',');
            if (CidsStr.Length > 0)
            {
                for (int i = 0; i < dtcount; i++)
                {
                    string Cid = dt.Rows[i]["Cid"].ToString();
                    foreach (string ch in CidsStr)
                    {
                        if (ch == Cid)
                        {
                            dt.Rows[i].Delete();//������Ͼ�ɾ��
                            break;
                        }
                    }
                }
            }
            return dt;
        }
        /// <summary>
        /// �����꼶��ʾ�����ʦ����δѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="GridViewnewkc"></param>
        public DataTable ShowNewCourseNew(int Sgrade, int Cterm, int Chid, string Cids)
        {
            string mysql = "SELECT  Cid,Cclass,Ctitle,CONVERT(nvarchar(10), Cdate, 120) as Cdate,Cobj,Cterm,Cks,Cupload FROM Courses Where Chid=" + Chid + " AND Cobj=" + Sgrade + "  AND Cterm=" + Cterm + " AND Cpublish=1 AND Cdelete=0 AND Cold=0 ORDER BY Cobj DESC,Cks DESC";
            if (Cids != "")
                mysql = "SELECT  Cid,Cclass,Ctitle,CONVERT(nvarchar(10), Cdate, 120) as Cdate,Cobj,Cterm,Cks,Cupload FROM Courses Where Chid=" + Chid + " AND Cobj=" + Sgrade + "  AND Cterm=" + Cterm + " AND Cpublish=1 AND Cdelete=0 AND Cold=0 AND Cid not in (" + Cids + ") ORDER BY Cobj DESC,Cks DESC";

            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            return dt;
        }
        /// <summary>
        /// ����Snum��ʾ��ѧѧ�� (SnumΪStudents���ѧ��)
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="GridViewdonekc"></param>
        public DataTable ShowDoneCourse(string Cids)
        {
            string mysql = "SELECT Cid,Cclass,Ctitle,CONVERT(nvarchar(10), Cdate, 120) as Cdate,Cobj,Cks,Cterm,Cupload FROM Courses  ORDER BY Cobj DESC, Cterm DESC, Cks DESC";
            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            dt.Columns.Add("Checker");
            int dtcount = dt.Rows.Count;
            string[] CidsStr = Cids.Split(',');
            if (CidsStr.Length > 0)
            {
                for (int i = 0; i < dtcount; i++)
                {
                    string Cid = dt.Rows[i]["Cid"].ToString();
                    foreach (string ch in CidsStr)
                    {
                        if (ch == Cid)
                        {
                            dt.Rows[i]["Checker"] = "1";//������Ͼͱ�־��˵����ѧ��
                            break;
                        }
                    }
                }
                for (int i = 0; i < dtcount; i++)
                {
                    if (dt.Rows[i]["Checker"] == null || dt.Rows[i]["Checker"].ToString()!="1")
                    {
                        dt.Rows[i].Delete();
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// ����Snum��ʾ��ѧѧ�� (SnumΪStudents���ѧ��)
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="GridViewdonekc"></param>
        public DataTable ShowDoneCourseNew(string Cids)
        {
            if (Cids != "")
            {
                string mysql = "SELECT Cid,Cclass,Ctitle,CONVERT(nvarchar(10), Cdate, 120) as Cdate,Cobj,Cks,Cterm,Cupload FROM Courses where Cid in (" + Cids + ") ORDER BY Cobj DESC, Cterm DESC, Cks DESC";
                DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
                return dt;
            }
            else
            {
                return null;
            }
        }     

        /// <summary>
        /// ���ݰ༶��ʾ��ѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable ShowClassDoneCourse(int Sgrade,int Chid,string Cids)
        {
            int Cterm = LearnSite.Common.XmlHelp.GetIntTerm();
            string mysql = "SELECT Cid,Ctitle,Cks FROM Courses Where Chid=" + Chid + " and  Cterm=" + Cterm + " and Cobj=" + Sgrade + "  AND Cdelete=0  order by Cks Asc";
            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            dt.Columns.Add("Checker");

            int dtcount = dt.Rows.Count;
            string[] CidsStr = Cids.Split(',');
            if (CidsStr.Length > 0)
            {
                for (int i = 0; i < dtcount; i++)
                {
                    string Cid = dt.Rows[i]["Cid"].ToString();
                    foreach (string ch in CidsStr)
                    {
                        if (ch == Cid)
                        {
                            dt.Rows[i]["Checker"] = "1";//������Ͼͱ�־��˵����ѧ��
                            break;
                        }
                    }
                }
                for (int i = 0; i < dtcount; i++)
                {
                    if (dt.Rows[i]["Checker"] == null||dt.Rows[i]["Checker"].ToString() != "1")
                    {
                        dt.Rows[i].Delete();
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// ���ݰ༶��ʾδѧѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable ShowClassnewCourse(int Sgrade, int Chid, string Cids)
        {
            int Cterm = LearnSite.Common.XmlHelp.GetIntTerm();
            string mysql = "SELECT Cid,Ctitle,Cks,Cpublish FROM Courses Where Chid=" + Chid + " and  Cterm=" + Cterm + " and Cobj=" + Sgrade + " and Cdelete=0  and Cold=0  order by Cks Asc";
            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            int dtcount = dt.Rows.Count;
            string[] CidsStr = Cids.Split(',');
            if (CidsStr.Length > 0)
            {
                for (int i = 0; i < dtcount; i++)
                {
                    string Cid = dt.Rows[i]["Cid"].ToString();
                    foreach (string ch in CidsStr)
                    {
                        if (ch == Cid)
                        {
                            dt.Rows[i].Delete();//������Ͼ�ɾ��
                            break;
                        }
                    }
                }
            }
            return dt;
        }
        /// <summary>
        /// ����ѧ����ŷ���ѧ������
        /// </summary>
        /// <param name="Cid"></param>
        /// <returns></returns>
        public string ShowCtitle(int Cid)
        {
            string mysql = "SELECT Ctitle FROM Courses WHERE Cid="+Cid;
            return DbHelperSQL.FindString(mysql);
        }

        /// <summary>
        /// ���ݽ�ʦ���꼶��ѧ�ڷ���ѧ�����ƺͱ��
        /// </summary>
        /// <param name="Cobj"></param>
        /// <param name="Cterm"></param>
        /// <param name="Chid"></param>
        /// <returns></returns>
        public DataSet ShowCidCtitle(int Chid,int Cobj,int Cterm)
        {
            string mysql = "SELECT Cid,Ctitle FROM Courses WHERE Cpublish=1 and Cdelete=0 and Cold=0 and Chid=" + Chid + " and Cobj=" + Cobj + " and Cterm=" + Cterm + " order by Cks desc";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ȡָ��ѧ�ڣ�ָ���꼶�Ŀ�ʱ���ֵ
        /// </summary>
        /// <param name="Cterm"></param>
        /// <param name="Cobj"></param>
        /// <returns></returns>
        public  int CksMaxValue(int Cterm,int Cobj,int Chid)
        {
            string strsql = "select max(Cks)+1 from Courses where Cdelete=0 and Cold=0 and Cobj="+Cobj+" and Cterm="+Cterm+" and Chid="+Chid;
            object obj = DbHelperSQL.GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }
        /// <summary>
        /// ��ȡ��ҳ����ѧ�����꼶�б�
        /// </summary>
        /// <returns></returns>
        public DataSet GethtmGrade()
        {
            string mysql = "select distinct Cobj from Courses,Mission where Cid=Mcid and Mfiletype='htm' order by Cobj asc";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ȫ��ѧ���ջ�����
        /// </summary>
        public void HideCourse()
        {
            string mysql = "update Courses set Cpublish=0";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ѧ�����ϴ����͸���ѧ�������һ��
        /// </summary>
        public void UpdateCfiletype()
        {
            string mysql = "update Courses set Cfiletype=Mfiletype  from Courses,Mission where Cid=Mcid ";
            DbHelperSQL.ExecuteSql(mysql);
        }

        public void InitCdelete()
        {
            string mysql = "update Courses set Cdelete=0 where Cdelete is null";
            DbHelperSQL.ExecuteSql(mysql);
        }
        public void InitCold()
        {
            string mysql = "update Courses set Cold=0 where Cold is null";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ȡCid��������ѧ���б������ֶ�Cid,Cobj,Cks,Ctitle,Cclass
        /// </summary>
        /// <param name="cids"></param>
        /// <returns></returns>
        public DataSet getCidsCourses(string cids)
        {
            string mysql = "select Cid,Cobj,Cks,Ctitle,Cclass from Courses where Cid in (" + cids + ") order by Cid desc";
            return DbHelperSQL.Query(mysql);
        }
		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Courses";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

