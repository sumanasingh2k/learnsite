using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����NotSign
	/// </summary>
	public class NotSign
	{
		public NotSign()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Nid", "NotSign"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Nid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NotSign");
			strSql.Append(" where Nid=@Nid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Nid", SqlDbType.Int,4)};
			parameters[0].Value = Nid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// �Ƿ���ڽ���δǩ����¼
        /// </summary>
        public bool ExistsToday(string Nnum)
        {
            DateTime dt = DateTime.Now;
            int Nyear = dt.Year;
            int Nmonth = dt.Month;
            int Nday = dt.Day;
            string strSql = "select count(1) from NotSign where Nnum='" + Nnum + "' and Nyear=" + Nyear + " and Nmonth=" + Nmonth + " and Nday=" + Nday;
            
            return DbHelperSQL.Exists(strSql);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.NotSign model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NotSign(");
			strSql.Append("Nnum,Ndate,Nyear,Nmonth,Nday,Nweek,Nnote,Ngrade,Nterm)");
			strSql.Append(" values (");
			strSql.Append("@Nnum,@Ndate,@Nyear,@Nmonth,@Nday,@Nweek,@Nnote,@Ngrade,@Nterm)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Nnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Ndate", SqlDbType.DateTime),
					new SqlParameter("@Nyear", SqlDbType.Int,4),
					new SqlParameter("@Nmonth", SqlDbType.Int,4),
					new SqlParameter("@Nday", SqlDbType.Int,4),
					new SqlParameter("@Nweek", SqlDbType.NVarChar,50),
					new SqlParameter("@Nnote", SqlDbType.NVarChar),
                    new SqlParameter("@Ngrade", SqlDbType.Int,4),
					new SqlParameter("@Nterm", SqlDbType.Int,4)};
			parameters[0].Value = model.Nnum;
			parameters[1].Value = model.Ndate;
			parameters[2].Value = model.Nyear;
			parameters[3].Value = model.Nmonth;
			parameters[4].Value = model.Nday;
			parameters[5].Value = model.Nweek;
			parameters[6].Value = model.Nnote;
            parameters[7].Value = model.Ngrade;
            parameters[8].Value = model.Nterm;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public void Update(LearnSite.Model.NotSign model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NotSign set ");
			strSql.Append("Nnum=@Nnum,");
			strSql.Append("Ndate=@Ndate,");
			strSql.Append("Nyear=@Nyear,");
			strSql.Append("Nmonth=@Nmonth,");
			strSql.Append("Nday=@Nday,");
			strSql.Append("Nweek=@Nweek,");
			strSql.Append("Nnote=@Nnote");
            strSql.Append("Ngrade=@Ngrade");
            strSql.Append("Nterm=@Nterm");
			strSql.Append(" where Nid=@Nid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Nid", SqlDbType.Int,4),
					new SqlParameter("@Nnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Ndate", SqlDbType.DateTime),
					new SqlParameter("@Nyear", SqlDbType.Int,4),
					new SqlParameter("@Nmonth", SqlDbType.Int,4),
					new SqlParameter("@Nday", SqlDbType.Int,4),
					new SqlParameter("@Nweek", SqlDbType.NVarChar,50),
					new SqlParameter("@Nnote", SqlDbType.NVarChar),                    
                    new SqlParameter("@Ngrade", SqlDbType.Int,4),
					new SqlParameter("@Nterm", SqlDbType.Int,4)};
			parameters[0].Value = model.Nid;
			parameters[1].Value = model.Nnum;
			parameters[2].Value = model.Ndate;
			parameters[3].Value = model.Nyear;
			parameters[4].Value = model.Nmonth;
			parameters[5].Value = model.Nday;
			parameters[6].Value = model.Nweek;
			parameters[7].Value = model.Nnote;
            parameters[8].Value = model.Ngrade;
            parameters[9].Value = model.Nterm;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ���±�עһ������
        /// </summary>
        public void UpdateNote(string Nnum,string Nnote)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update NotSign set ");  
            strSql.Append(" Nnote=@Nnote");
            strSql.Append(" where Nnum=@Nnum ");
            SqlParameter[] parameters = {
					new SqlParameter("@Nnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Nnote", SqlDbType.NVarChar)};
            parameters[0].Value = Nnum;
            parameters[1].Value = Nnote;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Nid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NotSign ");
			strSql.Append(" where Nid=@Nid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Nid", SqlDbType.Int,4)};
			parameters[0].Value = Nid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.NotSign GetModel(int Nid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Nid,Nnum,Ndate,Nyear,Nmonth,Nday,Nweek,Nnote,Ngrade,Nterm from NotSign ");
			strSql.Append(" where Nid=@Nid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Nid", SqlDbType.Int,4)};
			parameters[0].Value = Nid;

			LearnSite.Model.NotSign model=new LearnSite.Model.NotSign();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Nid"].ToString()!="")
				{
					model.Nid=int.Parse(ds.Tables[0].Rows[0]["Nid"].ToString());
				}
				model.Nnum=ds.Tables[0].Rows[0]["Nnum"].ToString();
				if(ds.Tables[0].Rows[0]["Ndate"].ToString()!="")
				{
					model.Ndate=DateTime.Parse(ds.Tables[0].Rows[0]["Ndate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Nyear"].ToString()!="")
				{
					model.Nyear=int.Parse(ds.Tables[0].Rows[0]["Nyear"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Nmonth"].ToString()!="")
				{
					model.Nmonth=int.Parse(ds.Tables[0].Rows[0]["Nmonth"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Nday"].ToString()!="")
				{
					model.Nday=int.Parse(ds.Tables[0].Rows[0]["Nday"].ToString());
				}
				model.Nweek=ds.Tables[0].Rows[0]["Nweek"].ToString();
				model.Nnote=ds.Tables[0].Rows[0]["Nnote"].ToString();
                if (ds.Tables[0].Rows[0]["Ngrade"].ToString() != "")
                {
                    model.Ngrade = int.Parse(ds.Tables[0].Rows[0]["Ngrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Nterm"].ToString() != "")
                {
                    model.Nterm = int.Parse(ds.Tables[0].Rows[0]["Nterm"].ToString());
                }
				return model;
			}
			else
			{
				return null;
			}
		}
        /// <summary>
        /// ��ȡ����δǩ����ע
        /// </summary>
        /// <param name="Nnum"></param>
        /// <returns></returns>
        public string GetNoteToday(string Nnum)
        {
            DateTime dt = DateTime.Now;
            int Nyear = dt.Year;
            int Nmonth = dt.Month;
            int Nday = dt.Day;
            string mysql = "select Nnote from NotSign where Nnum='" + Nnum + "' and Nyear=" + Nyear + " and Nmonth=" + Nmonth + " and Nday=" + Nday;

            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// ��ȡĳ��δǩ����ע
        /// </summary>
        /// <param name="Nnum"></param>
        /// <returns></returns>
        public string GetNoteThisday(string Nnum,int Nyear,int Nmonth,int Nday)
        {
            string mysql = "select Nnote from NotSign where Nnum='" + Nnum + "' and Nyear=" + Nyear + " and Nmonth=" + Nmonth + " and Nday=" + Nday;

            return DbHelperSQL.FindString(mysql);
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Nid,Nnum,Ndate,Nyear,Nmonth,Nday,Nweek,Nnote,Ngrade,Nterm ");
			strSql.Append(" FROM NotSign ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ����ѧ�Ż�ȡȱϯ��¼�б�����������
        /// </summary>
        /// <param name="Snum"></param>
        /// <returns></returns>
        public DataSet NotSignSnumdetail(string Snum)
        {
            string mysql = "SELECT  Snum,Sgrade,Sclass,Sname,Sex,Sheadtheacher,Nnote,Ndate from Students,NotSign where Snum=Nnum and Snum='" + Snum + "' order by Ndate desc";
            return DbHelperSQL.Query(mysql);
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
            strSql.Append(" Nid,Nnum,Ndate,Nyear,Nmonth,Nday,Nweek,Nnote,Ngrade,Nterm ");
			strSql.Append(" FROM NotSign ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// �����ֶγ�ʼ��
        /// </summary>
        public void upgradefix()
        {
            string Nterm = LearnSite.Common.XmlHelp.GetTerm();

            string mysql = "update NotSign set Nterm="+Nterm+",Ngrade=Sgrade from NotSign,Students where Nnum=Snum and Nyear=2011 and Nmonth between 9 and 10";
            DbHelperSQL.ExecuteSql(mysql);
        }

        /// <summary>
        /// ĳ�༶ǩ��������Excel
        /// </summary>
        public void NotSignExcel(int Sgrade, int Sclass, int Nterm)
        {
            DateTime dt = DateTime.Now;
            string today = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day;
            string FileName = Sgrade.ToString() + "_" + Sclass.ToString() + "_" + Nterm.ToString() + System.Web.HttpUtility.UrlEncode("ȱϯ") + today;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Nnum as ѧ��, Sname as ����,Sgrade as �꼶,Sclass as �༶,Nnote as ȱϯԭ��,Ndate as ����");
            strSql.Append(" FROM NotSign,Students ");
            strSql.Append(" WHERE Nnum=Snum AND Sgrade=Ngrade AND Sgrade=@Sgrade AND Sclass=@Sclass AND Nterm=@Nterm ORDER BY Nnum ASC");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Nterm", SqlDbType.Int,4)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Nterm;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            Common.DataExcel.DataSetToExcel(ds, FileName);
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
			parameters[0].Value = "NotSign";
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

