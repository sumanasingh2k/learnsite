using System;
using System.Data;
using System.Text;
using System.Web;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����Webstudy��
	/// </summary>
	public class Webstudy
	{
		public Webstudy()
		{}
		#region  ��Ա����

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Wid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Webstudy");
			strSql.Append(" where Wid=@Wid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wid", SqlDbType.Int,4)};
			parameters[0].Value = Wid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsWnum(string Wnum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Webstudy");
            strSql.Append(" where Wnum=@Wnum ");
            SqlParameter[] parameters = {
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50)};
            parameters[0].Value = Wnum;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ����һ����¼
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="Wpwd"></param>
        public void AddOne(string Wnum, string Wpwd)
        {
            string mysql = "insert into Webstudy (Wnum,Wpwd) values (@Wnum,@Wpwd) ";
            SqlParameter[] parameters = {
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wpwd", SqlDbType.NVarChar,50)};
            parameters[0].Value = Wnum;
            parameters[1].Value = Wpwd;

            DbHelperSQL.ExecuteSql(mysql,parameters);
        }
        /// <summary>
        /// ����һ������ģ��ѧ���˺�
        /// </summary>
        public int AddSimulation(string Wnum, string Wpwd, string Wurl)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Webstudy(");
            strSql.Append("Wnum,Wpwd,Wurl)");
            strSql.Append(" values (");
            strSql.Append("@Wnum,@Wpwd,@Wurl)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wpwd", SqlDbType.NVarChar,50),
					new SqlParameter("@Wurl", SqlDbType.NVarChar,50)};
            parameters[0].Value = Wnum;
            parameters[1].Value = Wpwd;
            parameters[2].Value = Wurl;

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
		public int Add(LearnSite.Model.Webstudy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Webstudy(");
			strSql.Append("Wnum,Wpwd,Wvote,Wegg,Wscore,Wcheck,WquotaCurrent)");
			strSql.Append(" values (");
			strSql.Append("@Wnum,@Wpwd,@Wvote,@Wegg,@Wscore,@Wcheck,@WquotaCurrent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wpwd", SqlDbType.NVarChar,50),
					new SqlParameter("@Wvote", SqlDbType.Int,4),
					new SqlParameter("@Wegg", SqlDbType.Int,4),
					new SqlParameter("@Wscore", SqlDbType.Int,4),
					new SqlParameter("@Wcheck", SqlDbType.Bit,1),
					new SqlParameter("@WquotaCurrent", SqlDbType.Int,4)};
			parameters[0].Value = model.Wnum;
			parameters[1].Value = model.Wpwd;
			parameters[2].Value = model.Wvote;
			parameters[3].Value = model.Wegg;
			parameters[4].Value = model.Wscore;
			parameters[5].Value = model.Wcheck;
			parameters[6].Value = model.WquotaCurrent;

			object obj =DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
        /// ��ѧ�����ȡWebstudy���в����ڵ����ݣ�����Webstudy����
        /// </summary>
        public void AddAll()
        {
            string mysql = "insert into Webstudy(Wnum,Wpwd,Wsid) select Snum as Wnum,Spwd as Wpwd,Sid as Wsid from Students where  Sid not in(select Wsid from Webstudy) ";
            DbHelperSQL.ExecuteSql(mysql);
            System.Threading.Thread.Sleep(500);
            WebUpdateWurl();//��������Wurl
        }
        /// <summary>
        /// ������վ��ţ�������վ�ӷ�
        /// </summary>
        /// <param name="Wid"></param>
        /// <param name="Wscore"></param>
        public void UpdateOne(int Wid, int Wscore)
        {
            string mysql = "update Webstudy set Wcheck=1,Wscore=Wscore+" + Wscore + " where Wcheck=0 and Wid=" + Wid;
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ���ð༶����δ������վȫ��ΪP����6��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        public void UpdateOneClass(int Sgrade, int Sclass)
        {
            DateTime dt = DateTime.Now;
            string Wupdate = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day;
            string mysql = "update Webstudy set Wcheck=1,Wscore=Wscore+6 where Wcheck=0 and WquotaCurrent>0 and Wupdate>'"+Wupdate+"'and Wnum in ( select Snum from Students where Sgrade=" + Sgrade + " and Sclass=" + Sclass + ")";
            DbHelperSQL.ExecuteSql(mysql);        
        }
        /// <summary>
        /// ����ĳ��ѧ�ŵ�ftp�����ѧ������һ��
        /// </summary>
        /// <param name="Wnum"></param>
        public void UpdateWpwd(string Wnum)
        {
            string mysql = "update Webstudy set Wpwd=Spwd from Webstudy,Students where Wnum='"+Wnum+"' and Wnum=Snum and Wpwd<>Spwd";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ����ĳ��ѧ�ŵ�ftp��¼����
        /// </summary>
        /// <param name="Wnum"></param>
        public void UpdateWpwd2(string Wnum,string Wpwd)
        {
            string mysql = "update Webstudy set Wpwd='"+Wpwd+"' where Wnum='" + Wnum + "'";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ���¾Wվ�u�r��B��ȡ��
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWcheck(string Wid)
        {
            string mysql = "update Webstudy set Wcheck=~Wcheck where Wid="+Wid;//Wid�����β��ӆ���̖
            DbHelperSQL.ExecuteSql(mysql);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Webstudy model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Webstudy set ");
			strSql.Append("Wnum=@Wnum,");
			strSql.Append("Wpwd=@Wpwd,");
			strSql.Append("Wvote=@Wvote,");
			strSql.Append("Wegg=@Wegg,");
			strSql.Append("Wscore=@Wscore,");
			strSql.Append("Wcheck=@Wcheck,");
			strSql.Append("WquotaCurrent=@WquotaCurrent");
			strSql.Append(" where Wid=@Wid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wid", SqlDbType.Int,4),
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wpwd", SqlDbType.NVarChar,50),
					new SqlParameter("@Wvote", SqlDbType.Int,4),
					new SqlParameter("@Wegg", SqlDbType.Int,4),
					new SqlParameter("@Wscore", SqlDbType.Int,4),
					new SqlParameter("@Wcheck", SqlDbType.Bit,1),
					new SqlParameter("@WquotaCurrent", SqlDbType.Int,4)};
			parameters[0].Value = model.Wid;
			parameters[1].Value = model.Wnum;
			parameters[2].Value = model.Wpwd;
			parameters[3].Value = model.Wvote;
			parameters[4].Value = model.Wegg;
			parameters[5].Value = model.Wscore;
			parameters[6].Value = model.Wcheck;
			parameters[7].Value = model.WquotaCurrent;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

        /// <summary>
        /// �������̰༶��վͶƱ����
        /// </summary>
        public void ResetWegg(int eggs)
        {
            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname].Values["Hid"] != null)
            {
                string hid = HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname].Values["Hid"].ToString();
                int Rhid = Int32.Parse(hid);
                string strSql = "update Webstudy set  Wcheck=0, Wegg="+eggs+" where Wnum in (select Snum from Students,Room where Sgrade=Rgrade and Sclass=Rclass and Rset=1 and Rhid=" + Rhid + ")";

                DbHelperSQL.ExecuteSql(strSql);
            }
        }

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Wid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Webstudy ");
			strSql.Append(" where Wid=@Wid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wid", SqlDbType.Int,4)};
			parameters[0].Value = Wid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Webstudy GetModel(int Wid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Wid,Wnum,Wpwd,Wvote,Wegg,Wscore,Wcheck,WquotaCurrent from Webstudy ");
			strSql.Append(" where Wid=@Wid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wid", SqlDbType.Int,4)};
			parameters[0].Value = Wid;

			LearnSite.Model.Webstudy model=new LearnSite.Model.Webstudy();
            DataSet ds =DbHelperSQL.Query(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Wid"].ToString()!="")
				{
					model.Wid=int.Parse(ds.Tables[0].Rows[0]["Wid"].ToString());
				}
				model.Wnum=ds.Tables[0].Rows[0]["Wnum"].ToString();
				model.Wpwd=ds.Tables[0].Rows[0]["Wpwd"].ToString();
				if(ds.Tables[0].Rows[0]["Wvote"].ToString()!="")
				{
					model.Wvote=int.Parse(ds.Tables[0].Rows[0]["Wvote"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Wegg"].ToString()!="")
				{
					model.Wegg=int.Parse(ds.Tables[0].Rows[0]["Wegg"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Wscore"].ToString()!="")
				{
					model.Wscore=int.Parse(ds.Tables[0].Rows[0]["Wscore"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Wcheck"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Wcheck"].ToString()=="1")||(ds.Tables[0].Rows[0]["Wcheck"].ToString().ToLower()=="true"))
					{
						model.Wcheck=true;
					}
					else
					{
						model.Wcheck=false;
					}
				}
				if(ds.Tables[0].Rows[0]["WquotaCurrent"].ToString()!="")
				{
					model.WquotaCurrent=int.Parse(ds.Tables[0].Rows[0]["WquotaCurrent"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

        /// <summary>
        /// ����ѧ�ţ��õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Webstudy GetModelByWnum(string Wnum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Wid,Wnum,Wpwd,Wvote,Wegg,Wscore,Wcheck,WquotaCurrent from Webstudy ");
            strSql.Append(" where Wnum=@Wnum ");
            SqlParameter[] parameters = {
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50)};
            parameters[0].Value = Wnum;

            LearnSite.Model.Webstudy model = new LearnSite.Model.Webstudy();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Wid"].ToString() != "")
                {
                    model.Wid = int.Parse(ds.Tables[0].Rows[0]["Wid"].ToString());
                }
                model.Wnum = ds.Tables[0].Rows[0]["Wnum"].ToString();
                model.Wpwd = ds.Tables[0].Rows[0]["Wpwd"].ToString();
                if (ds.Tables[0].Rows[0]["Wvote"].ToString() != "")
                {
                    model.Wvote = int.Parse(ds.Tables[0].Rows[0]["Wvote"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Wegg"].ToString() != "")
                {
                    model.Wegg = int.Parse(ds.Tables[0].Rows[0]["Wegg"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Wscore"].ToString() != "")
                {
                    model.Wscore = int.Parse(ds.Tables[0].Rows[0]["Wscore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Wcheck"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Wcheck"].ToString() == "1") || (ds.Tables[0].Rows[0]["Wcheck"].ToString().ToLower() == "true"))
                    {
                        model.Wcheck = true;
                    }
                    else
                    {
                        model.Wcheck = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["WquotaCurrent"].ToString() != "")
                {
                    model.WquotaCurrent = int.Parse(ds.Tables[0].Rows[0]["WquotaCurrent"].ToString());
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
			strSql.Append("select Wid,Wnum,Wpwd,Wvote,Wegg,Wscore,Wcheck,WquotaCurrent ");
			strSql.Append(" FROM Webstudy ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return DbHelperSQL.Query(strSql.ToString());
		}

        
        /// <summary>
        /// ������������б�
        /// </summary>
        public DataSet GetListWeb(int Sgrade, int Sclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Snum,Sname,Syear,Sgrade,Sclass, Wid,Wnum,Wpwd,Wvote,Wegg,Wscore,Wcheck,WquotaCurrent,Wupdate,Wurl");
            strSql.Append(" FROM Students,Webstudy ");
            strSql.Append(" where Snum=Wnum and Sgrade=@Sgrade and Sclass=@Sclass order by Snum ASC");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4)};
            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
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
			strSql.Append(" Wid,Wnum,Wpwd,Wvote,Wegg,Wscore,Wcheck,WquotaCurrent ");
			strSql.Append(" FROM Webstudy ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ѧ��������ɾ��Webstudy��ѧ�Ų���Students�ļ�¼
        /// </summary>
        public void Upgrade()
        {
            string websql = "delete Webstudy where Wnum not in (select Snum from Students)";
            DbHelperSQL.ExecuteSql(websql);
        }

        /// <summary>
        /// ����վͶƱ��1
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateWvote(int Wid)
        {
            string mysql = "update Webstudy set Wvote=Wvote+1 where Wid="+Wid;
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ����վ������1
        /// </summary>
        /// <param name="Wid"></param>
        public void UpdateMyWegg(string Wnum)
        {
            string mysql = "update Webstudy set Wegg=Wegg-1 where Wnum='"+Wnum+"'";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ȡ��վͶƱ��
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public int GetMyWegg(string Wnum)
        {
            string mysql = "select top 1 Wegg from Webstudy where Wnum='"+Wnum+"'";
            string getstr= DbHelperSQL.FindString(mysql);
            if (getstr != "")
            {
                return int.Parse(getstr);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// ��ñ��༶��վ�б�����Sname,Snum,Wid,Wvote,Wscore,Wupdate,Wurl
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Mynum"></param>
        /// <returns></returns>
        public DataSet GetAllSite(int Sgrade, int Sclass,string Mynum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sname,Snum,Wid,Wvote,Wscore,Wupdate,Wurl");
            strSql.Append(" FROM Students,Webstudy ");
            strSql.Append(" where Snum=Wnum and Sgrade=@Sgrade and Sclass=@Sclass and Snum<>@Mynum ");
            strSql.Append(" order by Wvote asc");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),
                    new SqlParameter("@Sclass", SqlDbType.Int,4),
                    new SqlParameter("@Mynum", SqlDbType.NVarChar,50)};

            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Mynum;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ��ѯWebFtp�û�������
        /// </summary>
        /// <param name="Wnum"></param>
        /// <returns></returns>
        public  string FindWebFtpPwd(string Wnum)
        {
            string mysql = "SELECT Wpwd FROM Webstudy WHERE Wnum='" + Wnum + "'";
            return DbHelperSQL.FindString(mysql);
        }

        public void WebSiteUpdateCheck(string htmlname)
        {
            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname] != null)
            {
                int Rhid = Int32.Parse(HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname].Values["Hid"].ToString());//��ʦ���
                string mysql = "select Syear,Sclass,Sid,Snum from Students,Room where Sgrade=Rgrade and Sclass=Rclass and Rset=1 and Rhid=" + Rhid;
                DataSet ds = DbHelperSQL.Query(mysql);
                int dscount = ds.Tables[0].Rows.Count;
                if (dscount > 0)
                {
                    for (int i = 0; i < dscount; i++)
                    {
                        int Syear = int.Parse(ds.Tables[0].Rows[i]["Syear"].ToString());
                        int Sclass = int.Parse(ds.Tables[0].Rows[i]["Sclass"].ToString());
                        string Snum = ds.Tables[0].Rows[i]["Snum"].ToString();
                        int Sid =int.Parse( ds.Tables[0].Rows[i]["Sid"].ToString());
                        string updatetime = LearnSite.Common.Htmlcheck.HtmlUpdatetime(Syear, Sclass, Snum, htmlname);
                        if (updatetime != "")
                        {
                            UpdateWebTime(Snum, updatetime);//����Webstudy���ѧ������
                            LearnSite.BLL.Signin sn = new LearnSite.BLL.Signin();
                            sn.UpdateQwork(Sid, 1);//ǩ������������Ʒ����Ϊ1
                        }
                    }
                }
                ClearNoSiteVote();
            }
        }

        /// <summary>
        /// ������վ�������ڿռ�ռ�ô�С
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="updatetime"></param>
        public void UpdateWebTimeSize(string Wnum, DateTime Wupdate, int WquotaCurrent)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Webstudy set Wupdate=@Wupdate,WquotaCurrent=@WquotaCurrent where Wnum=@Wnum ");
            SqlParameter[] parameters = {
					new SqlParameter("@Wnum", SqlDbType.NVarChar,50),
                    new SqlParameter("@Wupdate", SqlDbType.DateTime),
                    new SqlParameter("@WquotaCurrent", SqlDbType.Int,4)};

            parameters[0].Value = Wnum;
            parameters[1].Value = Wupdate;
            parameters[2].Value = WquotaCurrent;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ������վ��������
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="updatetime"></param>
        public void UpdateWebTime(string Wnum, string updatetime)
        {
            string mysql = "update Webstudy set  Wupdate='"+updatetime+"' where Wnum='"+Wnum+"'";
            DbHelperSQL.ExecuteSql(mysql);
        }

        /// <summary>
        ///  ������վ�ռ�ռ�ô�С
        /// </summary>
        /// <param name="Wnum"></param>
        /// <param name="WquotaCurrent"></param>
        public void UpdateWebSize(string Wnum, int WquotaCurrent)
        {
            string mysql = "update Webstudy set  WquotaCurrent=" + WquotaCurrent + " where Wnum='" + Wnum + "'";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ������վ�������ݵĵ�Ʊ����
        /// </summary>
        public void ClearNoSiteVote()
        {
            string mysql = "update Webstudy set Wvote=0,Wscore=0 where WquotaCurrent=0";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ʾָ����������վ��Ʊ�����б�
        /// </summary>
        /// <param name="TopNum"></param>
        /// <returns></returns>
        public DataSet WebTopShow(int TopNum)
        {
            StringBuilder strSql = new StringBuilder();
            string aa = "select top  " + TopNum.ToString() + "  Snum,Sname,Syear,Sgrade,Sclass, Wnum,Wvote,Wegg,Wscore,Wcheck,Wurl ";
            strSql.Append(aa);
            strSql.Append("  FROM Students,Webstudy ");
            strSql.Append("  where Snum=Wnum  order by Wscore DESC, Wvote DESC");

            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// ��������Webstudy����Wurl
        /// </summary>
        public void WebUpdateWurl(int Hid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Webstudy set Webstudy.Wurl=ts.Turl ");
            strSql.Append(" from( select Snum,('~/FtpSpace/'+ convert(varchar(10),Syear) ");
            strSql.Append(" +'/'+convert(varchar(10),Sclass)+'/'+Snum");
            strSql.Append(") as Turl from Students,Room where Sgrade=Rgrade and Sclass=Rclass and Rhid=@Hid) as ts ");
            strSql.Append("where Webstudy.Wnum=ts.Snum ");
            SqlParameter[] parameters = {
					new SqlParameter("@Hid", SqlDbType.Int,4)};
            parameters[0].Value = Hid;

            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
        }
        /// <summary>
        /// ��������Webstudy����Wurl
        /// </summary>
        public void WebUpdateWurl()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Webstudy set Webstudy.Wurl=ts.Turl ");
            strSql.Append(" from( select Snum,('~/FtpSpace/'+ convert(varchar(10),Syear) ");
            strSql.Append(" +'/'+convert(varchar(10),Sclass)+'/'+Snum");
            strSql.Append(") as Turl from Students) as ts ");
            strSql.Append("where Webstudy.Wnum=ts.Snum ");

            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// ����ð༶��webstudy���еļ�¼
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        public void DelWebClass(int Sgrade, int Sclass)
        {
            string mysql = "delete Webstudy where Wnum in (select Snum from Students where Sgrade=" + Sgrade + " and Sclass=" + Sclass + ")";
            DbHelperSQL.ExecuteSql(mysql);
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
			parameters[0].Value = "Webstudy";
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

