using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//Please add references
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����:Pfinger
	/// </summary>
	public class Pfinger
	{
		public Pfinger()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Pid", "Pfinger"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Pid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Pfinger");
			strSql.Append(" where Pid=@Pid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4)};
			parameters[0].Value = Pid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// �Ƿ���ڱ��¸�ѧ��ָ����¼������Pid
        /// </summary>
        public string ExistsMonth(string Psnum, int Pyear,int Pmonth)
        {
            string astrSql = "select top 1 Pid from Pfinger where Psnum='"+Psnum+"' and Pyear="+Pyear+" and Pmonth="+Pmonth;
            return DbHelperSQL.FindString(astrSql);
        }

        /// <summary>
        /// �Ƿ���ڸ�ѧ��ָ����¼������Pid
        /// </summary>
        public string ExistsPsnum(string Psnum)
        {
            string astrSql = "select top 1 Pid from Pfinger where Psnum='" + Psnum+"'";
            return DbHelperSQL.FindString(astrSql);
        }
        /// <summary>
        /// ���ظ�ѧ��ָ���ɼ�
        /// </summary>
        public string GetPsnum(string Psnum)
        {
            string strSql = "select top 1 Pspd from Pfinger where Psnum='" + Psnum + "'";
            return DbHelperSQL.FindString(strSql);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.Pfinger model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Pfinger(");
			strSql.Append("Psnum,Pspd,Pyear,Pmonth,Pdate,Pgrade,Pterm)");
			strSql.Append(" values (");
            strSql.Append("@Psnum,@Pspd,@Pyear,@Pmonth,@Pdate,@Pgrade,@Pterm)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Psnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Pspd", SqlDbType.Decimal,9),
					new SqlParameter("@Pyear", SqlDbType.Int,4),
					new SqlParameter("@Pmonth", SqlDbType.Int,4),
					new SqlParameter("@Pdate", SqlDbType.DateTime),
					new SqlParameter("@Pgrade", SqlDbType.Int,4),
					new SqlParameter("@Pterm", SqlDbType.Int,4)};
			parameters[0].Value = model.Psnum;
			parameters[1].Value = model.Pspd;
			parameters[2].Value = model.Pyear;
			parameters[3].Value = model.Pmonth;
			parameters[4].Value = model.Pdate;
            parameters[5].Value = model.Pgrade;
            parameters[6].Value = model.Pterm;
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
        /// ����ĳ��Pid��Pspdֵ
        /// </summary>
        /// <param name="Pid"></param>
        /// <param name="Pspd"></param>
        /// <returns></returns>
        public bool UpdatePspd(int Pid, decimal Pspd,DateTime Pdate,int Pgrade,int Pterm)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Pfinger set ");           
            strSql.Append("Pspd=@Pspd,");
            strSql.Append("Pdate=@Pdate,");
            strSql.Append("Pgrade=Pgrade,");
            strSql.Append("Pterm=@Pterm ");
            strSql.Append(" where Pid=@Pid and Pspd<@Pspd");
            SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4),
					new SqlParameter("@Pspd", SqlDbType.Decimal,9),
					new SqlParameter("@Pdate", SqlDbType.DateTime),
					new SqlParameter("@Pgrade", SqlDbType.Int,4),
					new SqlParameter("@Pterm", SqlDbType.Int,4)};
            parameters[0].Value = Pid;
            parameters[1].Value = Pspd;
            parameters[2].Value = Pdate;
            parameters[3].Value = Pgrade;
            parameters[4].Value = Pterm;

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
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.Pfinger model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Pfinger set ");
			strSql.Append("Psnum=@Psnum,");
			strSql.Append("Pspd=@Pspd,");
			strSql.Append("Pyear=@Pyear,");
			strSql.Append("Pmonth=@Pmonth,");
			strSql.Append("Pdate=@Pdate,");
			strSql.Append("Pdegree=@Pdegree");
			strSql.Append(" where Pid=@Pid");
			SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4),
					new SqlParameter("@Psnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Pspd", SqlDbType.Decimal,9),
					new SqlParameter("@Pyear", SqlDbType.Int,4),
					new SqlParameter("@Pmonth", SqlDbType.Int,4),
					new SqlParameter("@Pdate", SqlDbType.DateTime),
					new SqlParameter("@Pdegree", SqlDbType.Int,4)};
			parameters[0].Value = model.Pid;
			parameters[1].Value = model.Psnum;
			parameters[2].Value = model.Pspd;
			parameters[3].Value = model.Pyear;
			parameters[4].Value = model.Pmonth;
			parameters[5].Value = model.Pdate;
			parameters[6].Value = model.Pdegree;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
        /// ��ձ�
        /// </summary>
        public int ClearTb()
        {
            string strSql = "delete from Pfinger ";
            return DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ������̰༶��ѧ��ָ����¼
        /// </summary>
        public void ClearMyTb(int Rhid)
        {
            string strSql = "delete from Pfinger where Psnum in(select Snum from Students,Room where Sgrade=Rgrade and Sclass=Rclass and Rhid=" + Rhid + ")";
            DbHelperSQL.ExecuteSql(strSql);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Pfinger ");
			strSql.Append(" where Pid=@Pid");
			SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4)
};
			parameters[0].Value = Pid;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Pidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Pfinger ");
			strSql.Append(" where Pid in ("+Pidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Pfinger GetModel(int Pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Pid,Psnum,Pspd,Pyear,Pmonth,Pdate,Pdegree,Pgrade,Pterm from Pfinger ");
			strSql.Append(" where Pid=@Pid");
			SqlParameter[] parameters = {
					new SqlParameter("@Pid", SqlDbType.Int,4)
};
			parameters[0].Value = Pid;

			LearnSite.Model.Pfinger model=new LearnSite.Model.Pfinger();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Pid"].ToString()!="")
				{
					model.Pid=int.Parse(ds.Tables[0].Rows[0]["Pid"].ToString());
				}
				model.Psnum=ds.Tables[0].Rows[0]["Psnum"].ToString();
				if(ds.Tables[0].Rows[0]["Pspd"].ToString()!="")
				{
					model.Pspd=decimal.Parse(ds.Tables[0].Rows[0]["Pspd"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Pyear"].ToString()!="")
				{
					model.Pyear=int.Parse(ds.Tables[0].Rows[0]["Pyear"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Pmonth"].ToString()!="")
				{
					model.Pmonth=int.Parse(ds.Tables[0].Rows[0]["Pmonth"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Pdate"].ToString()!="")
				{
					model.Pdate=DateTime.Parse(ds.Tables[0].Rows[0]["Pdate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Pdegree"].ToString()!="")
				{
					model.Pdegree=int.Parse(ds.Tables[0].Rows[0]["Pdegree"].ToString());
				}
                if (ds.Tables[0].Rows[0]["Pgrade"].ToString() != "")
                {
                    model.Pgrade = int.Parse(ds.Tables[0].Rows[0]["Pgrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Pterm"].ToString() != "")
                {
                    model.Pterm = int.Parse(ds.Tables[0].Rows[0]["Pterm"].ToString());
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
            strSql.Append("select Pid,Psnum,Pspd,Pyear,Pmonth,Pdate,Pdegree,Pgrade,Pterm ");
			strSql.Append(" FROM Pfinger ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ��ʾ�༶ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowClassFingerScore(int Sgrade,int Sclass)
        {
            string mysql = "SELECT  Psnum,Pid,Sname,Sgrade,Sclass,Pspd,Pdate,Pgrade,Pterm from Pfinger,Students WHERE Psnum=Snum and Sgrade=" + Sgrade + " and Sclass=" + Sclass + " ORDER BY Pspd DESC,Pdate DESC";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ʾ�꼶��ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowAllFingerScore(int Sgrade)
        {
            string mysql = "SELECT  Psnum,Pid,Sname,Sgrade,Sclass,Pspd,Pdate,Pgrade,Pterm from Pfinger,Students WHERE Psnum=Snum and Sgrade=" + Sgrade + " ORDER BY Pspd DESC,Pdate DESC";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ʾѧУָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowSchoolFingerScore()
        {
            string mysql = "SELECT  Psnum,Pid,Sname,Sgrade,Sclass,Pspd,Pdate,Pgrade,Pterm from Pfinger,Students WHERE Psnum=Snum  ORDER BY Pspd DESC,Pdate DESC";
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
            strSql.Append(" Pid,Psnum,Pspd,Pyear,Pmonth,Pdate,Pdegree,Pgrade,Pterm ");
			strSql.Append(" FROM Pfinger ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ����ɼ�
        /// </summary>
        /// <param name="psnum"></param>
        /// <param name="myspd"></param>
        /// <returns></returns>
        public bool saveSpd(string psnum, string myspd,int pgrade)
        {            
            bool isok = false;
            if (psnum.Trim() != "" && myspd.Trim() != "")
            {
                DateTime nowdate = DateTime.Now;
                int Pyear = nowdate.Year;
                int Pmonth = nowdate.Month;
                decimal Pspd = decimal.Parse(myspd);
                string pstr = ExistsPsnum(psnum);
                int pterm = Int32.Parse(LearnSite.Common.XmlHelp.GetTerm());
                if (pstr != "")
                {
                    isok = UpdatePspd(Int32.Parse(pstr), Pspd, nowdate,pgrade,pterm);//�������������ٶ�
                    string mysql = "update Students set Sfscore=" + Pspd + " where Snum='" + psnum + "'";//ѧ����ɼ�ͬ��
                    DbHelperSQL.ExecuteSql(mysql);
                }
                else
                {
                    Model.Pfinger pmodel = new Model.Pfinger();
                    pmodel.Psnum = psnum;
                    pmodel.Pspd = Pspd;
                    pmodel.Pyear = Pyear;
                    pmodel.Pmonth = Pmonth;
                    pmodel.Pdate = nowdate;
                    pmodel.Pdegree = 0;
                    pmodel.Pgrade = pgrade;
                    pmodel.Pterm = pterm;
                    if (Add(pmodel) > 0)
                    {
                        isok = true;
                        string mysql = "update Students set Sfscore="+Pspd+" where Snum='"+psnum+"'";
                        DbHelperSQL.ExecuteSql(mysql);
                        string sqlstr = "update Pfinger set Psid=Sid from Pfinger,Students where Psnum='"+psnum+"' and  Psnum=Snum ";
                        DbHelperSQL.ExecuteSql(sqlstr);
                    }
                }
            }
            return isok;
        }

        /// <summary>
        /// ��ʾ�꼶��ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowTopFingerScore(int Sgrade,int nTop)
        {
            string mysql = "SELECT TOP " + nTop.ToString() + "  Psnum,Sname,Sgrade,Sclass,Pspd from Pfinger,Students WHERE Pspd>0 and  Psnum=Snum and Sgrade=" + Sgrade + " ORDER BY Pspd DESC";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ʾ�꼶��ָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowTopFingerScoreAs(int Sgrade, int nTop)
        {
            string mysql = "SELECT TOP " + nTop.ToString() + "  Psnum,Sname,Sgrade,Sclass,Pspd as Pscore from Pfinger,Students WHERE Pspd>0 and  Psnum=Snum and Sgrade=" + Sgrade + " ORDER BY Pspd DESC";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ʾѧУָ��Ӣ�۰��¼
        /// </summary>
        /// <param name="GVtyper"></param>
        public DataSet ShowSchoolTopFingerScore(int nTop)
        {
            string mysql = "SELECT  TOP " + nTop.ToString() + "   Psnum,Pdate,Sname,Sgrade,Sclass,Pspd from Pfinger,Students WHERE Pspd>0 and  Psnum=Snum  ORDER BY Pspd DESC,Pdate DESC";
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
			parameters[0].Value = "Pfinger";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

