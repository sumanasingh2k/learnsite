using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����Signin��
	/// </summary>
	public class Signin
	{
		public Signin()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Qid", "Signin"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Qid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Signin");
			strSql.Append(" where Qid=@Qid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Qid", SqlDbType.Int,4)};
			parameters[0].Value = Qid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
        public int Add(LearnSite.Model.Signin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Signin(");
            strSql.Append("Qnum,Qattitude,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine,Qnote,Qwork,Qgrade,Qterm,Qsid,Qname,Qclass,Qsyear)");
            strSql.Append(" values (");
            strSql.Append("@Qnum,@Qattitude,@Qdate,@Qyear,@Qmonth,@Qday,@Qweek,@Qip,@Qmachine,@Qnote,@Qwork,@Qgrade,@Qterm,@Qsid,@Qname,@Qclass,@Qsyear)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Qnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Qattitude", SqlDbType.Int,4),
					new SqlParameter("@Qdate", SqlDbType.DateTime),
					new SqlParameter("@Qyear", SqlDbType.Int,4),
					new SqlParameter("@Qmonth", SqlDbType.Int,4),
					new SqlParameter("@Qday", SqlDbType.Int,4),
					new SqlParameter("@Qweek", SqlDbType.NVarChar,50),
					new SqlParameter("@Qip", SqlDbType.NVarChar,50),
					new SqlParameter("@Qmachine", SqlDbType.NVarChar,50),
					new SqlParameter("@Qnote", SqlDbType.NVarChar,50),
					new SqlParameter("@Qwork", SqlDbType.Int,4),
					new SqlParameter("@Qgrade", SqlDbType.Int,4),
					new SqlParameter("@Qterm", SqlDbType.Int,4),
                    new SqlParameter("@Qsid", SqlDbType.Int,4),
                    new SqlParameter("@Qname", SqlDbType.NVarChar,50),
                    new SqlParameter("@Qclass", SqlDbType.Int,4),
                    new SqlParameter("@Qsyear", SqlDbType.Int,4)};
            parameters[0].Value = model.Qnum;
            parameters[1].Value = model.Qattitude;
            parameters[2].Value = model.Qdate;
            parameters[3].Value = model.Qyear;
            parameters[4].Value = model.Qmonth;
            parameters[5].Value = model.Qday;
            parameters[6].Value = model.Qweek;
            parameters[7].Value = model.Qip;
            parameters[8].Value = model.Qmachine;
            parameters[9].Value = model.Qnote;
            parameters[10].Value = model.Qwork;
            parameters[11].Value = model.Qgrade;
            parameters[12].Value = model.Qterm;
            parameters[13].Value = model.Qsid;
            parameters[14].Value = model.Qname;
            parameters[15].Value = model.Qclass;
            parameters[16].Value = model.Qsyear;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// ǩ��������һ������Qnum,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine
        /// </summary>
        private int AddToday(LearnSite.Model.Signin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Signin(");
            strSql.Append("Qnum,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine,Qgrade,Qterm)");
            strSql.Append(" values (");
            strSql.Append("@Qnum,@Qdate,@Qyear,@Qmonth,@Qday,@Qweek,@Qip,@Qmachine,@Qgrade,@Qterm)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Qnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Qdate", SqlDbType.DateTime),
					new SqlParameter("@Qyear", SqlDbType.Int,4),
					new SqlParameter("@Qmonth", SqlDbType.Int,4),
					new SqlParameter("@Qday", SqlDbType.Int,4),
					new SqlParameter("@Qweek", SqlDbType.NVarChar,50),
					new SqlParameter("@Qip", SqlDbType.NVarChar,50),
                    new SqlParameter("@Qmachine", SqlDbType.NVarChar,50),
					new SqlParameter("@Qgrade", SqlDbType.Int,4),
					new SqlParameter("@Qterm", SqlDbType.Int,4)};
            parameters[0].Value = model.Qnum;
            parameters[1].Value = model.Qdate;
            parameters[2].Value = model.Qyear;
            parameters[3].Value = model.Qmonth;
            parameters[4].Value = model.Qday;
            parameters[5].Value = model.Qweek;
            parameters[6].Value = model.Qip;
            parameters[7].Value = model.Qmachine;
            parameters[8].Value = model.Qgrade;
            parameters[9].Value = model.Qterm;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
		/// ����һ������
		/// </summary>
        public bool Update(LearnSite.Model.Signin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Signin set ");
            strSql.Append("Qnum=@Qnum,");
            strSql.Append("Qattitude=@Qattitude,");
            strSql.Append("Qdate=@Qdate,");
            strSql.Append("Qyear=@Qyear,");
            strSql.Append("Qmonth=@Qmonth,");
            strSql.Append("Qday=@Qday,");
            strSql.Append("Qweek=@Qweek,");
            strSql.Append("Qip=@Qip,");
            strSql.Append("Qmachine=@Qmachine,");
            strSql.Append("Qnote=@Qnote,");
            strSql.Append("Qwork=@Qwork,");
            strSql.Append("Qgrade=@Qgrade,");
            strSql.Append("Qterm=@Qterm");
            strSql.Append(" where Qid=@Qid");
            SqlParameter[] parameters = {
					new SqlParameter("@Qnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Qattitude", SqlDbType.Int,4),
					new SqlParameter("@Qdate", SqlDbType.DateTime),
					new SqlParameter("@Qyear", SqlDbType.Int,4),
					new SqlParameter("@Qmonth", SqlDbType.Int,4),
					new SqlParameter("@Qday", SqlDbType.Int,4),
					new SqlParameter("@Qweek", SqlDbType.NVarChar,50),
					new SqlParameter("@Qip", SqlDbType.NVarChar,50),
					new SqlParameter("@Qmachine", SqlDbType.NVarChar,50),
					new SqlParameter("@Qnote", SqlDbType.NVarChar,50),
					new SqlParameter("@Qwork", SqlDbType.Int,4),
					new SqlParameter("@Qgrade", SqlDbType.Int,4),
					new SqlParameter("@Qterm", SqlDbType.Int,4),
					new SqlParameter("@Qid", SqlDbType.Int,4)};
            parameters[0].Value = model.Qnum;
            parameters[1].Value = model.Qattitude;
            parameters[2].Value = model.Qdate;
            parameters[3].Value = model.Qyear;
            parameters[4].Value = model.Qmonth;
            parameters[5].Value = model.Qday;
            parameters[6].Value = model.Qweek;
            parameters[7].Value = model.Qip;
            parameters[8].Value = model.Qmachine;
            parameters[9].Value = model.Qnote;
            parameters[10].Value = model.Qwork;
            parameters[11].Value = model.Qgrade;
            parameters[12].Value = model.Qterm;
            parameters[13].Value = model.Qid;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ���¸�ѧ�Ž������Ʒ����
        /// </summary>
        /// <param name="Qnum"></param>
        /// <param name="Qwork"></param>
        public void UpdateQwork(int Qsid,int Wcid)
        {
            DateTime Qdate = DateTime.Now;
            int Qyear = Qdate.Year;
            int Qmonth = Qdate.Month;
            int Qday = Qdate.Day;
            string mysql = "update Signin set Qwork=(select count(*) from Works where Wcid=" + Wcid + " and Wsid=" + Qsid +") where Qsid=" + Qsid + " and Qyear=" + Qyear + " and Qmonth=" + Qmonth + " and Qday=" + Qday;
            DbHelperSQL.ExecuteSql(mysql);        
        }
        /// <summary>
        /// ����һ�����ݣ���ѧ��ѧϰ�������֣�
        /// </summary>
        public void UpdateAttitude(int Qid,int Qattitude,string Qnote,int Qcid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Signin set ");            
            strSql.Append("Qattitude=@Qattitude,");            
            strSql.Append("Qnote=@Qnote,");
            strSql.Append("Qcid=@Qcid");
            strSql.Append(" where Qid=@Qid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Qid", SqlDbType.Int,4),
					new SqlParameter("@Qattitude", SqlDbType.Int,4),
					new SqlParameter("@Qnote", SqlDbType.NVarChar,50),
					new SqlParameter("@Qcid", SqlDbType.Int,4)};
            parameters[0].Value = Qid;
            parameters[1].Value = Qattitude;
            parameters[2].Value = Qnote;
            parameters[3].Value = Qcid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Qid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Signin ");
			strSql.Append(" where Qid=@Qid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Qid", SqlDbType.Int,4)};
			parameters[0].Value = Qid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// �������ǰ��ǩ����¼
        /// </summary>
        /// <param name="Wyear"></param>
        public int DeleteOldyear(int Wyear)
        {
            DateTime olddate = DateTime.Now.AddYears(-Wyear);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Signin ");
            strSql.Append(" where  Qdate <@Qdate");
            SqlParameter[] parameters = {
					new SqlParameter("@Qdate", SqlDbType.DateTime)};
            parameters[0].Value = olddate;

            return DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
        public LearnSite.Model.Signin GetModel(int Qid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Qid,Qnum,Qattitude,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine,Qnote,Qwork,Qgrade,Qterm,Qgroup,Qgscore from Signin ");
            strSql.Append(" where Qid=@Qid");
            SqlParameter[] parameters = {
					new SqlParameter("@Qid", SqlDbType.Int,4)};
            parameters[0].Value = Qid;

            LearnSite.Model.Signin model = new LearnSite.Model.Signin();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Qid"].ToString() != "")
                {
                    model.Qid = int.Parse(ds.Tables[0].Rows[0]["Qid"].ToString());
                }
                model.Qnum = ds.Tables[0].Rows[0]["Qnum"].ToString();
                if (ds.Tables[0].Rows[0]["Qattitude"].ToString() != "")
                {
                    model.Qattitude = int.Parse(ds.Tables[0].Rows[0]["Qattitude"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qdate"].ToString() != "")
                {
                    model.Qdate = DateTime.Parse(ds.Tables[0].Rows[0]["Qdate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qyear"].ToString() != "")
                {
                    model.Qyear = int.Parse(ds.Tables[0].Rows[0]["Qyear"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qmonth"].ToString() != "")
                {
                    model.Qmonth = int.Parse(ds.Tables[0].Rows[0]["Qmonth"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qday"].ToString() != "")
                {
                    model.Qday = int.Parse(ds.Tables[0].Rows[0]["Qday"].ToString());
                }
                model.Qweek = ds.Tables[0].Rows[0]["Qweek"].ToString();
                model.Qip = ds.Tables[0].Rows[0]["Qip"].ToString();
                model.Qmachine = ds.Tables[0].Rows[0]["Qmachine"].ToString();
                model.Qnote = ds.Tables[0].Rows[0]["Qnote"].ToString();
                if (ds.Tables[0].Rows[0]["Qwork"].ToString() != "")
                {
                    model.Qwork = int.Parse(ds.Tables[0].Rows[0]["Qwork"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qgrade"].ToString() != "")
                {
                    model.Qgrade = int.Parse(ds.Tables[0].Rows[0]["Qgrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qterm"].ToString() != "")
                {
                    model.Qterm = int.Parse(ds.Tables[0].Rows[0]["Qterm"].ToString());
                }
                model.Qgroup = ds.Tables[0].Rows[0]["Qgroup"].ToString();
                if (ds.Tables[0].Rows[0]["Qgscore"].ToString() != "")
                {
                    model.Qgscore = int.Parse(ds.Tables[0].Rows[0]["Qgscore"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ����ѧ�ŵõ�һ������ʵ�壬�����ǩ����¼
        /// </summary>
        public LearnSite.Model.Signin GetModelm(string Qnum)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Qid,Qnum,Qattitude,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine,Qnote,Qwork,Qgrade,Qterm,Qgroup,Qgscore,Qsid,Qname,Qclass,Qsyear from Signin ");
            strSql.Append(" where Qnum=@Qnum order by Qdate desc");
            SqlParameter[] parameters = {
					new SqlParameter("@Qnum", SqlDbType.NVarChar,50)};
            parameters[0].Value = Qnum;

            LearnSite.Model.Signin model = new LearnSite.Model.Signin();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Qid"].ToString() != "")
                {
                    model.Qid = int.Parse(ds.Tables[0].Rows[0]["Qid"].ToString());
                }
                model.Qnum = ds.Tables[0].Rows[0]["Qnum"].ToString();
                if (ds.Tables[0].Rows[0]["Qattitude"].ToString() != "")
                {
                    model.Qattitude = int.Parse(ds.Tables[0].Rows[0]["Qattitude"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qdate"].ToString() != "")
                {
                    model.Qdate = DateTime.Parse(ds.Tables[0].Rows[0]["Qdate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qyear"].ToString() != "")
                {
                    model.Qyear = int.Parse(ds.Tables[0].Rows[0]["Qyear"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qmonth"].ToString() != "")
                {
                    model.Qmonth = int.Parse(ds.Tables[0].Rows[0]["Qmonth"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qday"].ToString() != "")
                {
                    model.Qday = int.Parse(ds.Tables[0].Rows[0]["Qday"].ToString());
                }
                model.Qweek = ds.Tables[0].Rows[0]["Qweek"].ToString();
                model.Qip = ds.Tables[0].Rows[0]["Qip"].ToString();
                model.Qmachine = ds.Tables[0].Rows[0]["Qmachine"].ToString();
                model.Qnote = ds.Tables[0].Rows[0]["Qnote"].ToString();
                if (ds.Tables[0].Rows[0]["Qwork"].ToString() != "")
                {
                    model.Qwork = int.Parse(ds.Tables[0].Rows[0]["Qwork"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qgrade"].ToString() != "")
                {
                    model.Qgrade = int.Parse(ds.Tables[0].Rows[0]["Qgrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qterm"].ToString() != "")
                {
                    model.Qterm = int.Parse(ds.Tables[0].Rows[0]["Qterm"].ToString());
                }
                model.Qgroup = ds.Tables[0].Rows[0]["Qgroup"].ToString();
                if (ds.Tables[0].Rows[0]["Qgscore"].ToString() != "")
                {
                    model.Qgscore = int.Parse(ds.Tables[0].Rows[0]["Qgscore"].ToString());
                }
                //,Qsid,Qname,Qclass,Qsyear
                if (ds.Tables[0].Rows[0]["Qsid"].ToString() != "")
                {
                    model.Qsid = int.Parse(ds.Tables[0].Rows[0]["Qsid"].ToString());
                }
                model.Qname = ds.Tables[0].Rows[0]["Qname"].ToString();
                if (ds.Tables[0].Rows[0]["Qclass"].ToString() != "")
                {
                    model.Qclass = int.Parse(ds.Tables[0].Rows[0]["Qclass"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Qsyear"].ToString() != "")
                {
                    model.Qsyear = int.Parse(ds.Tables[0].Rows[0]["Qsyear"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// ��ѯ�༶ĳ��ĳ��ĳ�յ���ϸ ��ǩ����¼11111111
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        public DataSet Signclassdetail(int Qgrade, int Qclass, int Qyear, int Qmonth, int Qday)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Qid, Qnum, Qname,Qgrade,Qclass,Qip,Qmachine,Qdate,Qweek,Qattitude,Qnote,Qwork,Qgroup,Qgscore ");
            strSql.Append(" FROM Signin ");
            strSql.Append(" WHERE Qgrade=@Qgrade AND Qclass=@Qclass AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday ORDER BY Qnum ASC");
            SqlParameter[] parameters = {
					new SqlParameter("@Qgrade", SqlDbType.Int,4),
                    new SqlParameter("@Qclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Qgrade;
            parameters[1].Value = Qclass;
            parameters[2].Value = Qyear;
            parameters[3].Value = Qmonth;
            parameters[4].Value = Qday;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        public DataSet SignclassdetailSort(int Qgrade, int Qclass, int Qyear, int Qmonth, int Qday,int sort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Qid, Qnum, Qname,Qgrade,Qclass,Qip,Qmachine,Qdate,Qweek,Qattitude,Qnote,Qwork,Qgroup,Qgscore ");
            strSql.Append(" FROM Signin ");
            strSql.Append(" WHERE Qgrade=@Qgrade AND Qclass=@Qclass AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday ");
            if (sort == 0)
            {
                strSql.Append(" ORDER BY Qnum ASC");
            }
            else
            {
                strSql.Append(" ORDER BY Qip ASC");
            }
            SqlParameter[] parameters = {
					new SqlParameter("@Qgrade", SqlDbType.Int,4),
                    new SqlParameter("@Qclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Qgrade;
            parameters[1].Value = Qclass;
            parameters[2].Value = Qyear;
            parameters[3].Value = Qmonth;
            parameters[4].Value = Qday;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ĳ�༶ǩ��������Excel
        /// </summary>
        public void SignExcel(int Sgrade, int Sclass,int Qterm)
        {
            DateTime dt = DateTime.Now;
            string today = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day;
            string FileName =Sgrade.ToString()+"_"+Sclass.ToString()+"_"+Qterm.ToString()+System.Web.HttpUtility.UrlEncode("ǩ��") + today;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Qnum as ѧ��, Sname as ����,Sgrade as �꼶,Sclass as �༶,Qip as ǩ��IP,Qdate as ǩ������,Qattitude as ѧϰ����,Qnote as ��ע,Qwork as ��Ʒ����");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Qnum=Snum AND Sgrade=Qgrade AND Sgrade=@Sgrade AND Sclass=@Sclass AND Qterm=@Qterm ORDER BY Qnum ASC");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Qterm", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Qterm;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(),parameters);
            Common.DataExcel.DataSetToExcel(ds, FileName);
        }
        /// <summary>
        /// ����ѧ�Ų�ѯǩ����¼�����꼶��ѧ������
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public DataSet SignSnumdetail(string Snum)
        {
            string mysql = "select distinct Qid, Qnum, Sname,Sgrade,Sclass,Qip,Qdate,Qweek,Qattitude,Qnote,Qwork,Qterm  FROM Signin,Students where Qnum=Snum and Snum='" + Snum + "' order by Sgrade asc,Qterm asc";
            return DbHelperSQL.Query(mysql);
        }

        /// <summary>
        /// ѧ���������ǩ����ʾ
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        /// <returns></returns>
        public DataSet OnlineToday(int Sgrade, int Sclass, int Qyear, int Qmonth, int Qday)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Qid, Qnum, Sname,Sleader,Sgroup,Qip,right(Qdate,8) as Qdate ");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Sgrade=@Sgrade AND Sclass=@Sclass AND Qday=@Qday AND Qmonth=@Qmonth AND Qyear=@Qyear AND Qsid=Sid ORDER BY Qdate ASC");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Qyear;
            parameters[3].Value = Qmonth;
            parameters[4].Value = Qday;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ѯ�༶ĳ��ĳ��ĳ�յ���ϸ δǩ����¼0000000
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        public DataSet NoSignclassdetail(int Sgrade, int Sclass, int Qyear, int Qmonth, int Qday)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  Snum,Sgrade,Sclass,Sname,Saddress,Sphone,Sparents,Sheadtheacher,Sattitude ");
            strSql.Append(" FROM Students  ");
            strSql.Append(" WHERE Sgrade=@Sgrade AND Sclass=@Sclass AND Snum not in (");
            strSql.Append("select distinct Snum ");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Snum=Qnum AND Sgrade=@Sgrade AND Sclass=@Sclass AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday ");
            strSql.Append(")");
            strSql.Append(" ORDER BY Snum");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),
					new SqlParameter("@Qmonth", SqlDbType.Int,4),
					new SqlParameter("@Qday", SqlDbType.Int,4)};
            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Qyear;
            parameters[3].Value = Qmonth;
            parameters[4].Value = Qday;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }


        /// <summary>
        /// ��ѯ�༶ǩ���б�
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <returns></returns>
        public DataSet GetSignClass(int Sgrade,int Sclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Sgrade,Sclass,Qyear,Qmonth,Qday ");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Qnum=Snum AND Sgrade=@Sgrade AND Sclass=@Sclass ORDER BY Qyear DESC,Qmonth DESC,Qday DESC");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4)};
            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ȡ����ǩ����ͬѧ
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public DataTable GetSiginStudents(int Sgrade, int Sclass)
        {
            DateTime today = DateTime.Now;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Qnum, Sname,Qip ");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Sgrade=@Sgrade AND Sclass=@Sclass AND Sid=Qsid AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday ");

            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = today.Year;
            parameters[3].Value = today.Month;
            parameters[4].Value = today.Day;

            return DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
        }
        /// <summary>
        /// ��ѯ��ʼ�Ͽ�ҳ�棬�༶ǩ���б�
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        /// <returns></returns>
        public DataSet StartSignClass(int Sgrade, int Sclass, int Qyear, int Qmonth, int Qday, string signsort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Qid,Qip, Qnum, Qname,Sleader,Sgroup,Sgtitle,Qattitude,left(Qmachine,12) as QmachineShort,Qnote,Qwork,Qgroup,Qgscore ");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Sgrade=@Sgrade AND Sclass=@Sclass AND Sid=Qsid AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday ");
            switch (signsort)
            { 
                case "0":
                    strSql.Append(" ORDER BY QmachineShort ASC ");
                    break;
                case "1":
                    strSql.Append("  ORDER BY Qnum ASC");
                    break;
                case "2":
                    strSql.Append("  ORDER BY Sgroup ASC,Sleader DESC");
                    break;
            }
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Qyear;
            parameters[3].Value = Qmonth;
            parameters[4].Value = Qday;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ���ؽ�����Ʒδ�ύ��ѧ�� Qid, Qnum, Sname,Sscore
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        /// <param name="Qwork"></param>
        /// <returns></returns>
        public DataSet GetNoWorkStudents(int Sgrade, int Sclass,int Qyear,int Qmonth,int Qday,int Qwork)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct Qid, Qnum, Sname,Sscore ");
            strSql.Append(" FROM Signin,Students ");
            strSql.Append(" WHERE Qsid=Sid AND Sgrade=@Sgrade AND Sclass=@Sclass AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday AND Qwork=@Qwork ORDER BY Qnum ASC");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4),                    
                    new SqlParameter("@Qwork", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Qyear;
            parameters[3].Value = Qmonth;
            parameters[4].Value = Qday;
            parameters[5].Value = Qwork;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ѯ��ʼ�Ͽ�ҳ�棬�༶û��ǩ���б�
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        /// <returns></returns>
        public DataTable StartNoSignClass(int Sgrade, int Sclass, int Syear, int Qyear, int Qmonth, int Qday)
        {
            StringBuilder mySql = new StringBuilder();
            mySql.Append("select Sid, Snum,Sname,Sscore");
            mySql.Append(" FROM Students  ");
            mySql.Append(" WHERE Sgrade=@Sgrade AND Sclass=@Sclass order by Sid");

            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Syear", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Syear;
            parameters[3].Value = Qyear;
            parameters[4].Value = Qmonth;
            parameters[5].Value = Qday;

            DataTable dtstu = DbHelperSQL.Query(mySql.ToString(), parameters).Tables[0];

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Qsid ");
            strSql.Append(" FROM Signin ");
            strSql.Append(" WHERE  Qsyear=@Syear AND Qgrade=@Sgrade AND Qclass=@Sclass AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday  order by Qsid ");
            DataTable dtsignin = DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
            int sgcount = dtsignin.Rows.Count;
            if (sgcount > 0)
            {
                int stucount = dtstu.Rows.Count;
                if (sgcount < stucount)
                {
                    for (int i = 0; i < stucount; i++)
                    {
                        string Sid = dtstu.Rows[i]["Sid"].ToString();
                        for (int j = 0; j < sgcount; j++)
                        {
                            if (Sid == dtsignin.Rows[j]["Qsid"].ToString())
                            {
                                dtstu.Rows[i].Delete();//���ǩ�������м�¼��ɾ��
                                break;
                            }
                        }
                    }
                    dtsignin.Dispose();//����ǰ���ڴ��
                    return dtstu;
                }
                else
                {
                    return null;//���ǩ�����������ڰ༶��������ִ��������룬���򷵻ؿ�
                }
            }
            else
            {
                return dtstu;
            }
        }

        /// <summary>
        /// ��ѯ��ʼ�Ͽ�ҳ�棬�༶û��ǩ���б�
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <param name="Qyear"></param>
        /// <param name="Qmonth"></param>
        /// <param name="Qday"></param>
        /// <returns></returns>
        public DataTable StartNoSignClassTwo(int Sgrade, int Sclass, int Syear, int Qyear, int Qmonth, int Qday)
        {
            StringBuilder mySql = new StringBuilder();
            mySql.Append("select Sid, Snum,Sname,Sscore");
            mySql.Append(" FROM Students  ");
            mySql.Append(" WHERE Sgrade=@Sgrade AND Sclass=@Sclass AND Sid not in ");

            mySql.Append("(select Qsid ");
            mySql.Append(" FROM Signin ");
            mySql.Append(" WHERE  Qsyear=@Syear AND Qgrade=@Sgrade AND Qclass=@Sclass AND Qyear=@Qyear AND Qmonth=@Qmonth AND Qday=@Qday  ");
            mySql.Append(" ) order by Sid");

            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Syear", SqlDbType.Int,4),
                    new SqlParameter("@Qyear", SqlDbType.Int,4),                    
                    new SqlParameter("@Qmonth", SqlDbType.Int,4),                    
                    new SqlParameter("@Qday", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Syear;
            parameters[3].Value = Qyear;
            parameters[4].Value = Qmonth;
            parameters[5].Value = Qday;

            return DbHelperSQL.Query(mySql.ToString(), parameters).Tables[0];
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Qid,Qnum,Qattitude,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine,Qnote,Qwork,Qgrade,Qterm ");
            strSql.Append(" FROM Signin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// �жϵ�ǰ��¼��IP�Ƿ���������ڵ�¼��IPһ��
        /// </summary>
        /// <param name="Qnum"></param>
        /// <param name="LoginIp"></param>
        /// <returns></returns>
        public bool IsSameIp(string Qnum,string LoginIp)
        {
            string today = DateTime.Now.ToShortDateString(); //dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day;

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select top 1 Qip from Signin ");
            strSql.Append(" where Qnum=@Qnum and Qdate<@Qdate order by Qdate desc ");

            SqlParameter[] parameters = {
					new SqlParameter("@Qnum", SqlDbType.VarChar),
                    new SqlParameter("@Qdate", SqlDbType.DateTime)};

            parameters[0].Value = Qnum;
            parameters[1].Value = DateTime.Parse(today);

            string fstr = DbHelperSQL.FindString(strSql.ToString(),parameters);//��ȡ����ĵ�¼Ip
            if (fstr == "")
            {
                return true;
            }
            if (fstr == LoginIp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ��ȡ����������ڱ�����¼����ѧ������
        /// </summary>
        /// <param name="Qip"></param>
        /// <returns></returns>
        public DataSet GetIpStudents(string Qip)
        {
            DateTime dt = DateTime.Now.AddMonths(-3);
            string mysql = "select Qip,Qdate,Qmachine,Sname,Sgrade,Sclass,Sex,Sscore,Saddress,Sheadtheacher from Signin,Students where Qnum=Snum and Qip='"+Qip+"' and Qdate>'"+dt.ToString()+"' order by Qdate desc";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Qid,Qnum,Qattitude,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qmachine,Qnote,Qwork,Qgrade,Qterm ");
            strSql.Append(" FROM Signin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// ��ǩ������ɾ��ѧ�����в����ڰ༶��ѧ��
        /// </summary>
        public void Upgrade()
        {            
            string mysql = "delete Signin where Qnum not in (select Snum from Students )";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        ///ǩ������������ǩ����¼������������һ��
        ///ǩ��������ѧ�š����ڡ�IP
        /// Qnum,Qattitude,Qdate,Qyear,Qmonth,Qday,Qweek,Qip,Qnote,Qwork
        /// </summary>
        /// <param name="smodel"></param>
        public int SigninToday(string Qnum, DateTime Qdate, string Qip, int Qgrade, int Qterm, int Qsid, string Qname, int Qclass, int Qsyear)
        {
            int sg = 0;
            int Qyear = Qdate.Year;
            int Qmonth = Qdate.Month;
            int Qday = Qdate.Day;
            BLL.Computers cbll = new BLL.Computers();
            string Qmachine = cbll.GetmachineByIp(Qip);
            string Qweek = Qdate.DayOfWeek.ToString();

            Model.Signin qmodel = new LearnSite.Model.Signin();
            qmodel.Qnum = Qnum;
            qmodel.Qattitude = 0;
            qmodel.Qdate = Qdate;
            qmodel.Qyear = Qyear;
            qmodel.Qmonth = Qmonth;
            qmodel.Qday = Qday;
            qmodel.Qweek = Qweek;
            qmodel.Qip = Qip;
            qmodel.Qnote = "";
            qmodel.Qwork = 0;
            qmodel.Qgrade = Qgrade;
            qmodel.Qterm = Qterm;
            qmodel.Qmachine = Qmachine;
            qmodel.Qsid = Qsid;
            qmodel.Qname = Qname;
            qmodel.Qclass = Qclass;
            qmodel.Qsyear = Qsyear;

            string mysql = "select count(1) from Signin where Qsid=" + Qsid + " and Qday=" + Qday + " and Qmonth=" + Qmonth + " and Qyear=" + Qyear;
            if (!DbHelperSQL.Exists(mysql))
            {
                Add(qmodel);
                sg = 2;
            }
            else
            {
                string sqlstr = "update Signin set Qip='" + Qip + "',Qmachine='" + Qmachine + "' where Qsid=" + Qsid + " and Qyear=" + Qyear + " and Qmonth=" + Qmonth + " and Qday=" + Qday;
                DbHelperSQL.ExecuteSql(sqlstr);
                sg = 3;
            }
            return sg;
        }

        public  int UpdateSgroup(int Sgroup,string Qgroup,int Qgscore,int Qcid)
        {
            DateTime dt = DateTime.Now;
            string today = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day;
            string mysql = "update Signin set Qgroup='" + Qgroup + "',Qgscore=" + Qgscore + ",Qcid=" + Qcid + " where Qdate>'" + today + "' and Qnum in (select Snum from Students where Sgroup=" + Sgroup + ")";
            return DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ɾ���ð༶��ǩ����¼
        /// </summary>
        /// <param name="Qgrade"></param>
        /// <param name="Qclass"></param>
        /// <param name="Qsyear"></param>
        /// <returns></returns>
        public int DelSignClass(int Qgrade, int Qclass, int Qsyear)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" delete from Signin ");
            strSql.Append(" WHERE Qgrade=@Qgrade AND Qclass=@Qclass AND Qsyear=@Qsyear");

            SqlParameter[] parameters = {
					new SqlParameter("@Qgrade", SqlDbType.Int,4),
                    new SqlParameter("@Qclass", SqlDbType.Int,4),
                    new SqlParameter("@Qsyear", SqlDbType.Int,4)};

            parameters[0].Value = Qgrade;
            parameters[1].Value = Qclass;
            parameters[2].Value = Qsyear;

            return DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ȡ���һ����ǩ��ѧ����������IP�б�
        /// Qsid,Qgrade,Qclass,Qname,Qip
        /// </summary>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public DataTable GetQnameQip(int Rhid, int weeks)
        {
            DateTime today = DateTime.Now;
            int days = 0 - weeks * 7;
            DateTime Qdate = today.AddDays(days);

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select Qsid,Qgrade,Qclass,Qname,Qip,Qdate,Sgroup,Sleader,Sgtitle from Signin,Room,Students  ");
            strSql.Append(" where Rhid=@Rhid and Rgrade=Sgrade and Rclass=Sclass and Qgrade=Sgrade and ");
            strSql.Append(" Qclass=Sclass and Qsid=Sid and Qdate>@Qdate order by Qsid,Qdate desc");

            SqlParameter[] parameters = {
					new SqlParameter("@Rhid", SqlDbType.Int,4),
					new SqlParameter("@Qdate", SqlDbType.DateTime)};

            parameters[0].Value = Rhid;
            parameters[1].Value = Qdate;

            DataTable dt = DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];

            //string teststr =LearnSite.Common.ClassModel.ClassModeSavePath(Rhid.ToString()) + @"\sql" + Rhid + "all.xml";
            //dt.WriteXml(teststr);//������
            dt.Columns.Remove("Qdate");//dt.Columns.Remove(dt.Columns["Qdate"]);//ɾ�������У���������
            //string teststr2 = LearnSite.Common.ClassModel.ClassModeSavePath(Rhid.ToString()) + @"\sql2" + Rhid + "all.xml";
            //dt.WriteXml(teststr2);//������
            int dtcount = dt.Rows.Count;
            int lastQsid = 0;
            DataTable newTable = dt.Clone();
            for (int i = 0; i < dtcount; i++)
            {
                int Qsid = Int32.Parse(dt.Rows[i]["Qsid"].ToString());
                if (Qsid != lastQsid)
                {
                    lastQsid = Qsid;
                    newTable.ImportRow(dt.Rows[i]); //�����ǰ��Ų����ھɵ�//��һ�и��Ƶ������ͬ�ṹ                  
                }
            }
           // string teststr3 = LearnSite.Common.ClassModel.ClassModeSavePath(Rhid.ToString()) + @"\sql3" + Rhid + "all.xml";
           // newTable.WriteXml(teststr3);//������
            return newTable;
        }
        /// <summary>
        /// ��øñ��౾�εĿ��ñ���
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Qcid"></param>
        /// <returns></returns>
        public DataTable GetClassListQattitude(int Sgrade, int Sclass, int Qcid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Qnum as Snum,Qattitude as Score ");
            strSql.Append(" FROM Signin ");
            string strWhere = " Qcid=" + Qcid + " and Qgrade=" + Sgrade + " and Qclass=" + Sclass + " order by Qnum ";
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
        /// <summary>
        /// ��ȡ�鳤��С����ַ�
        /// </summary>
        /// <param name="Qnum"></param>
        /// <param name="Qcid"></param>
        /// <returns></returns>
        public string GetLeaderQgroup(string Qnum, int Qcid)
        {
            string mysql = "select  Qgroup from Signin where Qnum='" + Qnum + "' and Qcid=" + Qcid;
            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// ��ȡ�鳤��С����ַ�
        /// </summary>
        /// <param name="Qsid"></param>
        /// <param name="Qcid"></param>
        /// <returns></returns>
        public int GetLeaderQgroup(int Qsid, int Qcid)
        {
            string mysql = "select  Qgscore from Signin where Qsid=" + Qsid + " and Qcid=" + Qcid;
            return DbHelperSQL.FindNum(mysql);
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
			parameters[0].Value = "Signin";
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

