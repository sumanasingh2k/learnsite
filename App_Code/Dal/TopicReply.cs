using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����:TopicReply
	/// </summary>
	public class TopicReply
	{
		public TopicReply()
		{}
		#region  Method


		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TopicReply");
			strSql.Append(" where ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.TopicReply model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TopicReply(");
            strSql.Append("Rtid,Rsnum,Rwords,Rtime,Rip,Rscore,Rban,Rgrade,Rterm,Rcid,Rclass,Rsid,Ryear,Redit,Ragree)");
            strSql.Append(" values (");
            strSql.Append("@Rtid,@Rsnum,@Rwords,@Rtime,@Rip,@Rscore,@Rban,@Rgrade,@Rterm,@Rcid,@Rclass,@Rsid,@Ryear,@Redit,@Ragree)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Rtid", SqlDbType.Int,4),
					new SqlParameter("@Rsnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Rwords", SqlDbType.NText),
					new SqlParameter("@Rtime", SqlDbType.DateTime),
					new SqlParameter("@Rip", SqlDbType.NVarChar,50),
					new SqlParameter("@Rscore", SqlDbType.Int,4),
					new SqlParameter("@Rban", SqlDbType.Bit,1),
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rterm", SqlDbType.Int,4),
                    new SqlParameter("@Rcid", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rsid", SqlDbType.Int,4),
					new SqlParameter("@Ryear", SqlDbType.Int,4),
					new SqlParameter("@Redit", SqlDbType.Int,4),
					new SqlParameter("@Ragree", SqlDbType.Int,4)};
            parameters[0].Value = model.Rtid;
            parameters[1].Value = model.Rsnum;
            parameters[2].Value = model.Rwords;
            parameters[3].Value = model.Rtime;
            parameters[4].Value = model.Rip;
            parameters[5].Value = model.Rscore;
            parameters[6].Value = model.Rban;
            parameters[7].Value = model.Rgrade;
            parameters[8].Value = model.Rterm;
            parameters[9].Value = model.Rcid;
            parameters[10].Value = model.Rclass;
            parameters[11].Value = model.Rsid;
            parameters[12].Value = model.Ryear;
            parameters[13].Value = model.Redit;
            parameters[14].Value = model.Ragree;

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
        /// ���ظ�����
        /// </summary>
        /// <param name="Rid"></param>
        public bool Lessscore(int Rid)
        {
            string mysql = "update TopicReply set Rscore=Rscore-2 where Rid=" + Rid;
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ���ظ�����
        /// </summary>
        /// <param name="Rid"></param>
        public bool Updatescore(int Rid)
        {
            string mysql = "update TopicReply set Rscore=Rscore+2 where Rid="+Rid;
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InitReditagree()
        {
            string mysql = "update TopicReply set Redit=0 and Ragree=0 where Redit is null and Ragree is null";
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ���������лظ�����+2
        /// </summary>
        /// <param name="Rid"></param>
        public int UpdateAllscore(int Rtid, int Rgrade, int Rclass, int Ryear)
        {
            string mysql = "update TopicReply set Rscore=2 where Rscore=0 and Rtid=" + Rtid + " and Rgrade=" + Rgrade + " and Rclass=" + Rclass + " and Ryear=" + Ryear;
            return DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// �������Ӽӽ��Ա��
        /// </summary>
        /// <param name="Rid"></param>
        public bool UpdateBan(int Rid)
        {
            string mysql = "update TopicReply set Rban=1 where Rid=" + Rid;
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// �������������޸�
        /// </summary>
        /// <param name="Rid"></param>
        public bool UpdateEdit(int Rid)
        {
            string mysql = "update TopicReply set Redit=Redit^1 where Rid=" + Rid;
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// �������ӵ���
        /// </summary>
        /// <param name="Rid"></param>
        /// <returns></returns>
        public bool UpdateAgree(int Rid)
        {
            string mysql = "update TopicReply set Ragree=Ragree+1 where Rid=" + Rid;
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ������ʦ�ܽ�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rnum"></param>
        /// <param name="Rwords"></param>
        /// <returns></returns>
        public bool UpdateTeacher(int Rtid, int Rsid, string Rwords)
        {
            string mysql = "update TopicReply set Rwords='" + Rwords + "' where Rsid=" + Rsid + " and Rtid=" + Rtid;
            int rowsAffected = DbHelperSQL.ExecuteSql(mysql);
            if (rowsAffected > 0)
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
		public bool Update(LearnSite.Model.TopicReply model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TopicReply set ");
            strSql.Append("Rtid=@Rtid,");
            strSql.Append("Rsnum=@Rsnum,");
            strSql.Append("Rwords=@Rwords,");
            strSql.Append("Rtime=@Rtime,");
            strSql.Append("Rip=@Rip,");
            strSql.Append("Rscore=@Rscore,");
            strSql.Append("Rban=@Rban,");
            strSql.Append("Rgrade=@Rgrade,");
            strSql.Append("Rterm=@Rterm");
            strSql.Append(" where Rid=@Rid");
            SqlParameter[] parameters = {
					new SqlParameter("@Rtid", SqlDbType.Int,4),
					new SqlParameter("@Rsnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Rwords", SqlDbType.NText),
					new SqlParameter("@Rtime", SqlDbType.DateTime),
					new SqlParameter("@Rip", SqlDbType.NVarChar,50),
					new SqlParameter("@Rscore", SqlDbType.Int,4),
					new SqlParameter("@Rban", SqlDbType.Bit,1),
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rterm", SqlDbType.Int,4),
					new SqlParameter("@Rid", SqlDbType.Int,4)};
            parameters[0].Value = model.Rtid;
            parameters[1].Value = model.Rsnum;
            parameters[2].Value = model.Rwords;
            parameters[3].Value = model.Rtime;
            parameters[4].Value = model.Rip;
            parameters[5].Value = model.Rscore;
            parameters[6].Value = model.Rban;
            parameters[7].Value = model.Rgrade;
            parameters[8].Value = model.Rterm;
            parameters[9].Value = model.Rid;

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
        ///Rid ����һ������ Rwords Rtime Redit Ragree
        ///rtid, rsid
        /// </summary>
        public bool UpdateOne(LearnSite.Model.TopicReply model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TopicReply set ");            
            strSql.Append("Rwords=@Rwords,");
            strSql.Append("Rtime=@Rtime,");
            strSql.Append("Redit=@Redit,");
            strSql.Append("Ragree=@Ragree");
            strSql.Append(" where Rtid=@Rtid and Rsid=@Rsid");
            SqlParameter[] parameters = {					
					new SqlParameter("@Rwords", SqlDbType.NText),
					new SqlParameter("@Rtime", SqlDbType.DateTime),
					new SqlParameter("@Redit", SqlDbType.Bit,1),
					new SqlParameter("@Ragree", SqlDbType.Int,4),
					new SqlParameter("@Rtid", SqlDbType.Int,4),
					new SqlParameter("@Rsid", SqlDbType.Int,4)};
            parameters[0].Value = model.Rwords;
            parameters[1].Value = model.Rtime;
            parameters[2].Value = model.Redit;
            parameters[3].Value = model.Ragree;
            parameters[4].Value = model.Rtid;
            parameters[5].Value = model.Rsid;

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
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Rid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TopicReply ");
			strSql.Append(" where Rid="+Rid+"" );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Ridlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TopicReply ");
			strSql.Append(" where Rid in ("+Ridlist + ")  ");
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
        /// ɾ��һ���༶�����ۼ�¼
        /// </summary>
        public int DelClass(int Rgrade, int Rclass, int Ryear)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TopicReply ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass and Ryear=@Ryear ");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),                                        
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Ryear", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Ryear;

            return DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.TopicReply GetModel(int Rid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
            strSql.Append(" Rid,Rtid,Rsnum,Rwords,Rtime,Rip,Rscore,Rban,Rgrade,Rterm,Rcid,Rclass ");
			strSql.Append(" from TopicReply ");
			strSql.Append(" where Rid="+Rid+"" );
			LearnSite.Model.TopicReply model=new LearnSite.Model.TopicReply();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Rid"].ToString()!="")
				{
					model.Rid=int.Parse(ds.Tables[0].Rows[0]["Rid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Rtid"].ToString()!="")
				{
					model.Rtid=int.Parse(ds.Tables[0].Rows[0]["Rtid"].ToString());
				}
				model.Rsnum=ds.Tables[0].Rows[0]["Rsnum"].ToString();
				model.Rwords=ds.Tables[0].Rows[0]["Rwords"].ToString();
				if(ds.Tables[0].Rows[0]["Rtime"].ToString()!="")
				{
					model.Rtime=DateTime.Parse(ds.Tables[0].Rows[0]["Rtime"].ToString());
				}
				model.Rip=ds.Tables[0].Rows[0]["Rip"].ToString();
				if(ds.Tables[0].Rows[0]["Rscore"].ToString()!="")
				{
					model.Rscore=int.Parse(ds.Tables[0].Rows[0]["Rscore"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Rban"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["Rban"].ToString()=="1")||(ds.Tables[0].Rows[0]["Rban"].ToString().ToLower()=="true"))
					{
						model.Rban=true;
					}
					else
					{
						model.Rban=false;
					}
				}
                if (ds.Tables[0].Rows[0]["Rgrade"].ToString() != "")
                {
                    model.Rgrade = int.Parse(ds.Tables[0].Rows[0]["Rgrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rterm"].ToString() != "")
                {
                    model.Rterm = int.Parse(ds.Tables[0].Rows[0]["Rterm"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rcid"].ToString() != "")
                {
                    model.Rcid = int.Parse(ds.Tables[0].Rows[0]["Rcid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rclass"].ToString() != "")
                {
                    model.Rclass = int.Parse(ds.Tables[0].Rows[0]["Rclass"].ToString());
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
            strSql.Append("select Rid,Rtid,Rsnum,Rwords,Rtime,Rip,Rscore,Rban,Rgrade,Rterm,Rcid,Rclass ");
			strSql.Append(" FROM TopicReply ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ��ø����Ȿ��ظ������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Rtid"></param>
        /// <returns></returns>
        public DataSet GetClassList(int Sgrade,int Sclass,int Rtid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Rid,Rtid,Rsnum,Rwords,Rtime,Rip,Rscore,Rban,Rgrade,Rterm,Redit,Ragree,Sname ");
            strSql.Append(" FROM TopicReply,Students ");
            string strWhere = " Rsnum=Snum and Rban=0 and Rtid="+Rtid+" and Sgrade="+Sgrade+ " and Sclass="+Sclass +" order by Rtime asc";
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// ��ȡ����δ�ظ���ͬѧ�����б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Rtid"></param>
        /// <returns></returns>
        public DataTable GetNoReplay(int Sgrade, int Sclass, int Rtid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Sname ");
            strSql.Append(" FROM Students ");
            strSql.Append(" where  Sid not in (");
            strSql.Append(" select Rsid FROM TopicReply where Rtid=@Rtid  and Rgrade=@Sgrade  and Rclass=@Sclass ");
            strSql.Append(") and Sgrade=@Sgrade  and Sclass=@Sclass ");
            SqlParameter[] parameters = {
					new SqlParameter("@Sgrade", SqlDbType.Int,4),                                        
					new SqlParameter("@Sclass", SqlDbType.Int,4),
					new SqlParameter("@Rtid", SqlDbType.Int,4)};
            parameters[0].Value = Sgrade;
            parameters[1].Value = Sclass;
            parameters[2].Value = Rtid;

            return DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
        }
        /// <summary>
        /// ��ø����Ȿ��ظ������б�
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <param name="Rtid"></param>
        /// <returns></returns>
        public DataTable GetClassListScore(int Sgrade, int Sclass, int Rtid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  Rsnum as Snum,Rscore as Score ");
            strSql.Append(" FROM TopicReply ");
            string strWhere = " Rtid=" + Rtid + " and Rgrade=" + Sgrade + " and Rclass=" + Sclass + " order by Rsnum ";
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
        /// <summary>
        /// ��ȡ��ʦģ��ѧ���ظ���Ϊ�ܽ�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsnum"></param>
        /// <returns></returns>
        public string getteareply(int Rtid, string Rsnum)
        {
            string mysql = "select Rwords from TopicReply where Rtid="+Rtid+" and Rsnum='"+Rsnum+"'";
            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// �жϸ�ѧ�ű���ظ��Ƿ񱻽��Թ�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsnum"></param>
        /// <returns></returns>
        public bool Isban(int Rtid, int Rsid)
        {
            string mysql = "select  count(1) from TopicReply where Rban=1 and  Rtid=" + Rtid + " and Rsid=" + Rsid;
            return DbHelperSQL.Exists(mysql);
        }
        /// <summary>
        /// �жϸ�ѧ�ű���ظ��Ƿ�����ظ��޸�
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsid"></param>
        /// <returns></returns>
        public bool Isedit(int Rtid, int Rsid)
        {
            string mysql = "select  count(1) from TopicReply where Redit=1 and  Rtid=" + Rtid + " and Rsid=" + Rsid;
            return DbHelperSQL.Exists(mysql);
        }
        /// <summary>
        /// �жϸ�ѧ�ű���ظ�����
        /// </summary>
        /// <param name="Rtid"></param>
        /// <param name="Rsnum"></param>
        /// <returns></returns>
        public int ReplyCount(int Rtid, int Rsid)
        {
            string mysql = "select count(*) from TopicReply where   Rtid=" + Rtid + " and Rsid=" + Rsid ;
            string strCount = DbHelperSQL.FindString(mysql);
            if (strCount != "")
                return Int32.Parse(strCount);
            else
                return 0;
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
            strSql.Append(" Rid,Rtid,Rsnum,Rwords,Rtime,Rip,Rscore,Rban,Rgrade,Rterm,Rcid,Rclass");
			strSql.Append(" FROM TopicReply ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ��ʼ������Rcid�ֶ�
        /// </summary>
        public void InitRcid()
        {
            string mysql = "update TopicReply set Rcid=Tcid from TopicReply,TopicDiscuss where Rtid=Tid ";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ʼ������Rclass�ֶ�
        /// </summary>
        public void InitRclass()
        {
            string mysql = "update TopicReply set Rclass=Sclass from TopicReply,Students where Rsnum=Snum ";
            DbHelperSQL.ExecuteSql(mysql);
        }

        /// <summary>
        /// ��ȡ��ǰ�༶ѧ����ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowDoneReplyCids(int Rgrade, int Rclass, int Rterm, int Ryear)
        {
            string mysql = "SELECT DISTINCT Rcid FROM TopicReply where Rterm=" + Rterm + " and Rgrade=" + Rgrade + " and Rclass=" + Rclass + " and Ryear=" + Ryear;
            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            int n = dt.Rows.Count;
            if (n > 0)
            {
                string strtemp = "";
                for (int i = 0; i < n; i++)
                {
                    strtemp = strtemp + dt.Rows[i]["Rcid"].ToString() + ",";
                }
                return strtemp;
            }
            else
            {
                return "";
            }
        }
        /// <summary>
        /// ��ȡĳѧ��ѧ����ѧ��Cid
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public string ShowStuDoneReplyCids(string Snum, int Rterm, int Rgrade)
        {
            string mysql = "SELECT DISTINCT Rcid FROM TopicReply where Rsnum='" + Snum + "' and Rterm=" + Rterm + " and Rgrade=" + Rgrade;
            DataTable dt = DbHelperSQL.Query(mysql).Tables[0];
            int n = dt.Rows.Count;
            if (n > 0)
            {
                string strtemp = "";
                for (int i = 0; i < n; i++)
                {
                    strtemp = strtemp + dt.Rows[i]["Rcid"].ToString() + ",";
                }
                return strtemp;
            }
            else
            {
                return "";
            }
        }
		/*
		*/

		#endregion  Method
	}
}

