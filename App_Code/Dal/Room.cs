using System;
using System.Data;
using System.Text;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����Room��
	/// </summary>
	public class Room
	{
		public Room()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Rid", "Room"); 
		}

        public int GetMinRgrade()
        {
            return DbHelperSQL.GetMinField("Rgrade", "Room");
        }
        public int GetMaxRgrade()
        {
            return DbHelperSQL.GetMaxField("Rgrade", "Room");
        }
        public int GetMinRclass()
        {
            return DbHelperSQL.GetMinField("Rclass", "Room");
        }
        public int GetMaxRclass()
        {
            return DbHelperSQL.GetMaxField("Rclass", "Room");
        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Rid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Room");
			strSql.Append(" where Rid=@Rid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4)};
			parameters[0].Value = Rid;
            
			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// �Ƿ���ڸð༶
        /// </summary>
        public bool ExistsGC(int Rgrade, int Rclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Room");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass ");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.Room model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Room(");
            strSql.Append("Rhid,Rgrade,Rclass,Rset,Rpwd,Rlock)");
            strSql.Append(" values (");
            strSql.Append("@Rhid,@Rgrade,@Rclass,@Rset,@Rpwd,@Rlock)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Rhid", SqlDbType.Int,4),
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rset", SqlDbType.Bit,1),
					new SqlParameter("@Rpwd", SqlDbType.NVarChar,50),
					new SqlParameter("@Rlock", SqlDbType.Bit,1)};
            parameters[0].Value = model.Rhid;
            parameters[1].Value = model.Rgrade;
            parameters[2].Value = model.Rclass;
            parameters[3].Value = model.Rset;
            parameters[4].Value = model.Rpwd;
            parameters[5].Value = model.Rlock;

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
        public void AddRoom(int Rgrade,int Rclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Room(");
            strSql.Append("Rgrade,Rclass) ");
            strSql.Append(" values (");
            strSql.Append("@Rgrade,@Rclass)");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.Room model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rhid=@Rhid,");
            strSql.Append("Rgrade=@Rgrade,");
            strSql.Append("Rclass=@Rclass,");
            strSql.Append("Rset=@Rset,");
            strSql.Append("Rpwd=@Rpwd,");
            strSql.Append("Rlock=@Rlock");
            strSql.Append(" where Rid=@Rid");
            SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4),
					new SqlParameter("@Rhid", SqlDbType.Int,4),
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rset", SqlDbType.Bit,1),
					new SqlParameter("@Rpwd", SqlDbType.NVarChar,50),
					new SqlParameter("@Rlock", SqlDbType.Bit,1)};
            parameters[0].Value = model.Rid;
            parameters[1].Value = model.Rhid;
            parameters[2].Value = model.Rgrade;
            parameters[3].Value = model.Rclass;
            parameters[4].Value = model.Rset;
            parameters[5].Value = model.Rpwd;
            parameters[6].Value = model.Rlock;

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
        /// ����һ���༶ѡ������
        /// </summary>
        public void UpdateRhid(int Rid,int Rhid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append(" Rhid=@Rhid ");
            strSql.Append(" where Rid=@Rid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4),
					new SqlParameter("@Rhid", SqlDbType.Int,4)};
            parameters[0].Value = Rid;
            parameters[1].Value = Rhid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ������а༶ѡ��
        /// </summary>
        public void UpdateRhidNone()
        {
            string strSql = "update Room set  Rhid=null,Rset=0,Rlock=0,Rpwd=null ";
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ����ý�ʦ���а༶ѡ��
        /// </summary>
        public void ClearRhid(int Rhid)
        {
            string strSql = "update Room set  Rhid=null,Rset=0,Rlock=0,Rpwd=null where Rhid= " + Rhid;
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ���°༶��������
        /// </summary>
        public void UpdateRseat(int Rgrade, int Rclass, int Houseid)
        {
            string strSql = "update Room set Rseat=" + Houseid + " where Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ���°༶������ʾ��ʽ��1��ʾ��0����
        /// </summary>
        public void UpdateRip(int Rgrade, int Rclass, bool isshow)
        {
            string rip = "0";
            if (isshow)
                rip = "1";//1��ʾ��0����
            string strSql = "update Room set Rip='" + rip + "' where Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ���°༶������ʾ��ʽ��1��ʾ��0����
        /// </summary>
        public bool GetRip(int Rgrade, int Rclass)
        {
            string strSql = "select count(1) from Room  where Rgrade=" + Rgrade + " and Rclass=" + Rclass + " and Rip<>'0'";
            return DbHelperSQL.Exists(strSql);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Rid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Room ");
			strSql.Append(" where Rid=@Rid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4)};
			parameters[0].Value = Rid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteAll()
        {
            string strSql = "delete from Room ";
            DbHelperSQL.ExecuteSql(strSql);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Room GetModel(int Rid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Rid,Rhid,Rgrade,Rclass,Rset,Rpwd,Rlock,Rip,Rgauge,Rclassedit,Rphotoedit,Rsexedit,Rnameedit,Rcid,Ropen,Rseat,Rshare,Rpwdsee from Room ");
            strSql.Append(" where Rid=@Rid");
            SqlParameter[] parameters = {
					new SqlParameter("@Rid", SqlDbType.Int,4)};
            parameters[0].Value = Rid;

            LearnSite.Model.Room model = new LearnSite.Model.Room();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Rid"].ToString() != "")
                {
                    model.Rid = int.Parse(ds.Tables[0].Rows[0]["Rid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rhid"].ToString() != "")
                {
                    model.Rhid = int.Parse(ds.Tables[0].Rows[0]["Rhid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rgrade"].ToString() != "")
                {
                    model.Rgrade = int.Parse(ds.Tables[0].Rows[0]["Rgrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rclass"].ToString() != "")
                {
                    model.Rclass = int.Parse(ds.Tables[0].Rows[0]["Rclass"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rset"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rset"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rset"].ToString().ToLower() == "true"))
                    {
                        model.Rset = true;
                    }
                    else
                    {
                        model.Rset = false;
                    }
                }
                model.Rpwd = ds.Tables[0].Rows[0]["Rpwd"].ToString();
                if (ds.Tables[0].Rows[0]["Rlock"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rlock"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rlock"].ToString().ToLower() == "true"))
                    {
                        model.Rlock = true;
                    }
                    else
                    {
                        model.Rlock = false;
                    }
                }
                model.Rip = ds.Tables[0].Rows[0]["Rip"].ToString();
                if (ds.Tables[0].Rows[0]["Rgauge"] != null && ds.Tables[0].Rows[0]["Rgauge"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rgauge"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rgauge"].ToString().ToLower() == "true"))
                    {
                        model.Rgauge = true;
                    }
                    else
                    {
                        model.Rgauge = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rclassedit"] != null && ds.Tables[0].Rows[0]["Rclassedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rclassedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rclassedit"].ToString().ToLower() == "true"))
                    {
                        model.Rclassedit = true;
                    }
                    else
                    {
                        model.Rclassedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rphotoedit"] != null && ds.Tables[0].Rows[0]["Rphotoedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rphotoedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rphotoedit"].ToString().ToLower() == "true"))
                    {
                        model.Rphotoedit = true;
                    }
                    else
                    {
                        model.Rphotoedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rsexedit"] != null && ds.Tables[0].Rows[0]["Rsexedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rsexedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rsexedit"].ToString().ToLower() == "true"))
                    {
                        model.Rsexedit = true;
                    }
                    else
                    {
                        model.Rsexedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rnameedit"] != null && ds.Tables[0].Rows[0]["Rnameedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rnameedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rnameedit"].ToString().ToLower() == "true"))
                    {
                        model.Rnameedit = true;
                    }
                    else
                    {
                        model.Rnameedit = false;
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
        /// �õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Room GetModel(int Rgrade,int Rclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Rid,Rhid,Rgrade,Rclass,Rset,Rpwd,Rlock,Rip,Rgauge,Rclassedit,Rphotoedit,Rsexedit,Rnameedit,Rcid,Ropen,Rseat,Rshare,Rpwdsee,Rgroupshare,Rreg,Rscratch from Room ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;

            LearnSite.Model.Room model = new LearnSite.Model.Room();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Rid"].ToString() != "")
                {
                    model.Rid = int.Parse(ds.Tables[0].Rows[0]["Rid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rhid"].ToString() != "")
                {
                    model.Rhid = int.Parse(ds.Tables[0].Rows[0]["Rhid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rgrade"].ToString() != "")
                {
                    model.Rgrade = int.Parse(ds.Tables[0].Rows[0]["Rgrade"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rclass"].ToString() != "")
                {
                    model.Rclass = int.Parse(ds.Tables[0].Rows[0]["Rclass"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rset"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rset"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rset"].ToString().ToLower() == "true"))
                    {
                        model.Rset = true;
                    }
                    else
                    {
                        model.Rset = false;
                    }
                }
                model.Rpwd = ds.Tables[0].Rows[0]["Rpwd"].ToString();
                if (ds.Tables[0].Rows[0]["Rlock"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rlock"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rlock"].ToString().ToLower() == "true"))
                    {
                        model.Rlock = true;
                    }
                    else
                    {
                        model.Rlock = false;
                    }
                }
                model.Rip = ds.Tables[0].Rows[0]["Rip"].ToString();
                if (ds.Tables[0].Rows[0]["Rgauge"] != null && ds.Tables[0].Rows[0]["Rgauge"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rgauge"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rgauge"].ToString().ToLower() == "true"))
                    {
                        model.Rgauge = true;
                    }
                    else
                    {
                        model.Rgauge = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rclassedit"] != null && ds.Tables[0].Rows[0]["Rclassedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rclassedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rclassedit"].ToString().ToLower() == "true"))
                    {
                        model.Rclassedit = true;
                    }
                    else
                    {
                        model.Rclassedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rphotoedit"] != null && ds.Tables[0].Rows[0]["Rphotoedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rphotoedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rphotoedit"].ToString().ToLower() == "true"))
                    {
                        model.Rphotoedit = true;
                    }
                    else
                    {
                        model.Rphotoedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rsexedit"] != null && ds.Tables[0].Rows[0]["Rsexedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rsexedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rsexedit"].ToString().ToLower() == "true"))
                    {
                        model.Rsexedit = true;
                    }
                    else
                    {
                        model.Rsexedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rnameedit"] != null && ds.Tables[0].Rows[0]["Rnameedit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rnameedit"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rnameedit"].ToString().ToLower() == "true"))
                    {
                        model.Rnameedit = true;
                    }
                    else
                    {
                        model.Rnameedit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rcid"].ToString() != "")
                {
                    model.Rcid = int.Parse(ds.Tables[0].Rows[0]["Rcid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Ropen"] != null && ds.Tables[0].Rows[0]["Ropen"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Ropen"].ToString() == "1") || (ds.Tables[0].Rows[0]["Ropen"].ToString().ToLower() == "true"))
                    {
                        model.Ropen = true;
                    }
                    else
                    {
                        model.Ropen = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rseat"].ToString() != "")
                {
                    model.Rseat = int.Parse(ds.Tables[0].Rows[0]["Rseat"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Rshare"] != null && ds.Tables[0].Rows[0]["Rshare"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rshare"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rshare"].ToString().ToLower() == "true"))
                    {
                        model.Rshare = true;
                    }
                    else
                    {
                        model.Rshare = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rpwdsee"] != null && ds.Tables[0].Rows[0]["Rpwdsee"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rpwdsee"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rpwdsee"].ToString().ToLower() == "true"))
                    {
                        model.Rpwdsee = true;
                    }
                    else
                    {
                        model.Rpwdsee = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Rgroupshare"] != null && ds.Tables[0].Rows[0]["Rgroupshare"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rgroupshare"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rgroupshare"].ToString().ToLower() == "true"))
                    {
                        model.Rgroupshare = true;
                    }
                    else
                    {
                        model.Rgroupshare = false;
                    }
                }

                if (ds.Tables[0].Rows[0]["Rreg"] != null && ds.Tables[0].Rows[0]["Rreg"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rreg"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rreg"].ToString().ToLower() == "true"))
                    {
                        model.Rreg = true;
                    }
                    else
                    {
                        model.Rreg = false;
                    }
                }

                if (ds.Tables[0].Rows[0]["Rscratch"] != null && ds.Tables[0].Rows[0]["Rscratch"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Rscratch"].ToString() == "1") || (ds.Tables[0].Rows[0]["Rscratch"].ToString().ToLower() == "true"))
                    {
                        model.Rscratch = true;
                    }
                    else
                    {
                        model.Rscratch = false;
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
            strSql.Append("select Rid,Rhid,Rgrade,Rclass,Rset,Rpwd,Rlock,Rip,Rgauge ");
			strSql.Append(" FROM Room order by Rgrade,Rclass");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// ��ȡ��������ֵ
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public bool GetRgauge(int Rgrade, int Rclass)
        {
            string mysql = "select Rgauge from Room where Rgrade="+Rgrade+" and Rclass="+Rclass;
            string findstr = DbHelperSQL.FindString(mysql);
            if (findstr == "1" || findstr.ToLower() == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// ���»�������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rgauge"></param>
        public void UpdateMyRgauge(int Rgrade, int Rclass, bool Rgauge)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rgauge=@Rgauge");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rgauge", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rgauge;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �༶��̿��ƿ���
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rscratch"></param>
        public void UpdateMyRscratch(int Rgrade, int Rclass, bool Rscratch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rscratch=@Rscratch");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rscratch", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rscratch;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ���ָ��Rhid�İ༶�����б�(�꼶�༶����ΪRgradeclass
        /// </summary>
        public DataSet GetMyClassList(int Rhid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Rid,Rhid,(STR(Rgrade)+'.'+STR(Rclass)) as Rgradeclass,Rset,Rpwd,Rlock,Rip,Rgauge,Rreg ");
            strSql.Append(" FROM Room ");
            strSql.Append(" where Rhid=@Rhid order by Rgrade,Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rhid", SqlDbType.Int,4)};
            parameters[0].Value = Rhid;

            return DbHelperSQL.Query(strSql.ToString(),parameters);
        }

        /// <summary>
        /// ���ָ��Rhid�İ༶�����б�(Rgrade,Rclass
        /// </summary>
        public DataTable GetMyGradeClass(int Rhid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Rgrade,Rclass ");
            strSql.Append(" FROM Room ");
            strSql.Append(" where Rhid=@Rhid order by Rgrade,Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rhid", SqlDbType.Int,4)};
            parameters[0].Value = Rhid;

            return DbHelperSQL.Query(strSql.ToString(), parameters).Tables[0];
        }
        /// <summary>
        /// ��ѯ�Ƿ����ν̰༶
        /// </summary>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public bool ExistMyClass(int Rhid)
        {
            string mysql = "select count(1) Rid from Room where Rhid="+Rhid;
            return DbHelperSQL.Exists(mysql);
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
            strSql.Append(" Rid,Rhid,Rgrade,Rclass,Rset,Rpwd,Rlock,Rip,Rgauge ");
			strSql.Append(" FROM Room ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ���꼶���л�ò��ظ����꼶
        /// </summary>
        /// <returns></returns>
        public DataSet GetGrade()
        {
            string strSql = "select distinct Rgrade FROM Room order by Rgrade";

            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname]!= null)
            {
                string hid = HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname].Values["Hid"].ToString();
                int Rhid = Int32.Parse(hid);

                string mysql = "select count(1) from Room where Rhid=" + Rhid;
                if (DbHelperSQL.Exists(mysql))
                {
                    strSql = "select distinct Rgrade FROM Room where Rhid=" + Rhid + " order by Rgrade asc";
                }
            }

            DataSet ds = DbHelperSQL.Query(strSql);
            int dscount = ds.Tables[0].Rows.Count;
            if ( dscount == 0)
            {
                ds = NewGrade();
            }
            return ds;
        }
        /// <summary>
        /// ѧ���꼶�б�ר�ã���ʾ�̹����꼶����ǰ�༶�б��е��꼶
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCourseGrade()
        {
            string strSql = "select distinct Rgrade FROM Room order by Rgrade";
            DataSet ds = DbHelperSQL.Query(strSql);
            string mysql = "select distinct Cobj as Rgrade from Courses where Cdelete=0 order by Cobj";
            DataSet dscs = DbHelperSQL.Query(mysql);
            ds.Tables[0].Merge(dscs.Tables[0]);
            DataTable newdt = ds.Tables[0].DefaultView.ToTable(true, "Rgrade");
            newdt.DefaultView.Sort = "Rgrade asc";
            ds.Dispose();
            dscs.Dispose();
            int dscount = newdt.Rows.Count;
            if (dscount == 0)
            {
                newdt = NewGrade().Tables[0];
            }
            return newdt;
        }
        /// <summary>
        /// ���꼶���л�ò��ظ��������꼶
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllGrade()
        {
            string strSql = "select distinct Rgrade FROM Room order by Rgrade";
            DataSet ds = DbHelperSQL.Query(strSql);            
            int dscount = ds.Tables[0].Rows.Count;
            if (dscount == 0)
            {
                ds = NewGrade();
            }
            return ds;
        }

        /// <summary>
        /// ���꼶���л�ò��ظ������п�ע���꼶
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllRegGrade()
        {
            string strSql = "select distinct Rgrade FROM Room Where Rreg=1 order by Rgrade";
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// ���꼶���л�ò��ظ��İ༶���������̰༶
        /// </summary>
        /// <returns></returns>
        public DataSet GetClass()
        {
            string strSql = "select distinct Rclass FROM Room order by Rclass";

            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname] != null)
            {
                string hid = HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname].Values["Hid"].ToString();
                int Rhid = Int32.Parse(hid);

                string mysql = "select count(1) from Room where Rhid="+Rhid;
                if (DbHelperSQL.Exists(mysql))
                {
                    strSql = "select distinct Rclass FROM Room where Rhid=" + Rhid + " order by Rclass asc ";
                }
            }

            DataSet ds = DbHelperSQL.Query(strSql);
            int dscount = ds.Tables[0].Rows.Count;
            if (dscount == 0)
            {
                ds = Newclass();
            }
            return ds;
        }


        /// <summary>
        /// �������б����ѡȡ�꼶�����»�ò��ظ��İ༶���������̰༶
        /// </summary>
        /// <returns></returns>
        public DataSet GetLimitClass(int Rgrade)
        {
            string strSql = "select distinct Rclass FROM Room order by Rclass";

            if (HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname] != null)
            {
                string hid = HttpContext.Current.Request.Cookies[LearnSite.Common.CookieHelp.teaCookieNname].Values["Hid"].ToString();
                int Rhid = Int32.Parse(hid);

                string mysql = "select count(1) from Room where Rhid=" + Rhid;
                if (DbHelperSQL.Exists(mysql))
                {
                    strSql = "select distinct Rclass FROM Room where Rhid=" + Rhid + " and Rgrade="+Rgrade+" order by Rclass asc ";
                }
            }

            DataSet ds = DbHelperSQL.Query(strSql);
            int dscount = ds.Tables[0].Rows.Count;
            if (dscount == 0)
            {
                ds = Newclass();
            }
            return ds;
        }


        /// <summary>
        /// �������б����ѡȡ�꼶�����»�ò��ظ������а༶��������
        /// </summary>
        /// <returns></returns>
        public DataSet GetLimitAllClass(int Rgrade)
        {
            string strSql = "select distinct Rclass FROM Room where  Rgrade=" + Rgrade + " order by Rclass asc ";
            DataSet ds = DbHelperSQL.Query(strSql);
            int dscount = ds.Tables[0].Rows.Count;
            if (dscount == 0)
            {
                ds = Newclass();
            }
            return ds;
        }
        /// <summary>
        /// ��ȡ��ע��༶
        /// </summary>
        /// <returns></returns>
        public DataSet GetRegClass(int Rgrade)
        {
            string strSql = "select distinct Rclass FROM Room where  Rgrade=" + Rgrade + " and Rreg=1 order by Rclass asc ";
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// ��Ҫ�Ͽΰ༶���ã�����ѧ����ѯ�˺ţ�������������(3λ)
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public string TeachingRoomSet(int Rhid, int Rgrade, int Rclass, int pwdlen)
        {
            string Rpwd =LearnSite.Common.WordProcess.GenerateRandomNum(pwdlen);
            string mysql = "UPDATE Room SET Rset=0,Rpwd=''  WHERE Rhid="+Rhid;
            DbHelperSQL.ExecuteSql(mysql);
            System.Threading.Thread.Sleep(500);
            string sql = "UPDATE Room SET Rset=1,Rpwd='" + Rpwd +"' WHERE Rhid="+Rhid+" and Rgrade=" + Rgrade + " and  Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(sql);
           // string strsql = "UPDATE Students SET Spwd='" + Rpwd + "'  WHERE Sgrade=" + Rgrade + " and  Sclass=" + Rclass;
           // DbHelperSQL.ExecuteSql(strsql);
            return Rpwd;
        }
        /// <summary>
        /// �����꼶��Χ�Ͱ༶���ֵ��ѭ���������а༶��
        /// </summary>
        /// <param name="RgradeMin"></param>
        /// <param name="RgradeMax"></param>
        /// <param name="RclassMax"></param>
        public void CreateRoom(int RgradeMin, int RgradeMax, int RclassMax)
        {
            for (int i = RgradeMin; i < RgradeMax + 1; i++)
            {
                for (int j = 1; j < RclassMax + 1; j++)
                {
                    int Rgrade = i;
                    int Rclass = j;
                    AddRoom(Rgrade, Rclass);
                }            
            }        
        }
        /// <summary>
        /// ����ģ���꼶dataset
        /// </summary>
        /// <returns></returns>
        private DataSet NewGrade()
        { 
            DataSet ds=new DataSet();
            ds.Tables.Add();
            ds.Tables[0].TableName = "gradetable";
            ds.Tables[0].Columns.Add("Rgrade");
            DataRow row;
            row = ds.Tables[0].NewRow();
            row[0] = 0;
            ds.Tables[0].Rows.Add(row);
            ds.AcceptChanges();
            return ds;
        }

        /// <summary>
        /// ����ģ��༶dataset
        /// </summary>
        /// <returns></returns>
        private DataSet Newclass()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add();
            ds.Tables[0].TableName = "classtable";
            ds.Tables[0].Columns.Add("Rclass");
            DataRow row;
            row = ds.Tables[0].NewRow();
            row[0] = 0;
            ds.Tables[0].Rows.Add(row);
            ds.AcceptChanges();
            return ds;
        }
        /// <summary>
        /// ��ѯ�༶���м�¼��
        /// </summary>
        /// <returns></returns>
        public int GradeCount()
        {
            return DbHelperSQL.TableCounts("Room");             
        }

        /// <summary>
        /// �����꼶�Ͱ༶����ȡ����
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRoomPwd(int Rgrade, int Rclass)
        {
            string mysql = "select Rpwd from Room where Rset=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass + " and Rpwdsee=1";
            return DbHelperSQL.FindString(mysql);
        }

        /// <summary>
        /// �����꼶�Ͱ༶����ȡ��ʦRhid
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRoomRhid(int Rgrade, int Rclass)
        {
            string mysql = "select Rhid from Room where Rgrade=" + Rgrade + " and Rclass=" + Rclass ;
            return DbHelperSQL.FindString(mysql);
        }

        /// <summary>
        /// �����̵ĵ�ǰ�Ͽΰ༶��Ϊ���Ͽ�
        /// </summary>
        /// <param name="Rhid"></param>
        public void UnlineClass(int Rhid)
        {
            string mysql = "UPDATE Room SET Rset=0 WHERE Rset=1 and Rhid=" + Rhid;
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ѯ��ǰ�Ͽΰ༶������ѧ��ѧ��
        /// </summary>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public ArrayList GetCurrentClassSnum(int Rhid)
        {
            string mysql = "select Snum from Students,Room where Sgrade=Rgrade and Sclass=Rclass and Rset=1 and Rhid="+Rhid;
            return DbHelperSQL.ExecuteSqlArrayList(mysql);
        }

        /// <summary>
        /// ��ѯ�ð༶������ѧ��ѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public ArrayList GetGradeClassSnum(int Sgrade,int Sclass)
        {
            string mysql = "select Snum from Students where Sgrade="+Sgrade +" and Sclass="+Sclass;
            return DbHelperSQL.ExecuteSqlArrayList(mysql);
        }
        /// <summary>
        /// �༶ѧ����¼IP����ȡ��
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public void UpdateLock(int Rgrade, int Rclass,bool Rlock)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rlock=@Rlock ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rlock", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rlock;
            
            DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
        }
        /// <summary>
        /// ���ݱ��ֶθ���ʱ��
        /// </summary>
        public void InitLock()
        {
            string mysql = "update Room set Rlock=0 where Rlock is null  ";
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// �жϸð༶�ĵ�¼IP�Ƿ���������������򷵻���
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public bool IsLoginLock(int Rgrade, int Rclass)
        {
            string mysql = "select count(1) from Room where Rlock=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }
        /// <summary>
        /// ��ʼ��
        /// </summary>
        public void UpdateRgauge()
        {
            string mysql = "update Room set Rgauge=0 where Rgauge is null";
            DbHelperSQL.ExecuteSql(mysql);
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        public void UpdateRgroupMax()
        {
            int groupMax= Int32.Parse( LearnSite.Common.XmlHelp.GetGroupMax());
            string mysql = "update Room set RgroupMax="+groupMax+" where RgroupMax is null";
            DbHelperSQL.ExecuteSql(mysql);
        }
        public void SetRgroupMax(int Rgrade, int Rclass,int groupMax)
        {
            string mysql = "update Room set RgroupMax=" + groupMax + " where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }
        public int GetRgroupMax(int Rgrade, int Rclass)
        {
            string mysql = "select top 1 RgroupMax from Room where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            object obj = DbHelperSQL.GetSingle(mysql);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        public void SetRclassedit(int Rgrade, int Rclass,bool Rclassedit)
        {
            string mysql = "update Room set Rclassedit='" + Rclassedit + "' where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }

        public void SetRphotoedit(int Rgrade, int Rclass, bool Rphotoedit)
        {
            string mysql = "update Room set Rphotoedit='" + Rphotoedit + "' where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }


        public void SetRsexedit(int Rgrade, int Rclass, bool Rsexedit)
        {
            string mysql = "update Room set Rsexedit='" + Rsexedit + "' where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }

        public void SetRreg(int Rgrade, int Rclass, bool Rreg)
        {
            string mysql = "update Room set Rreg='" + Rreg + "' where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }

        public void SetRnameedit(int Rgrade, int Rclass, bool Rnameedit)
        {
            string mysql = "update Room set Rnameedit='" + Rnameedit + "' where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }

        public bool GetRclassedit(int Rgrade, int Rclass)
        {
            string mysql = "select count(1) from Room  where Rclassedit=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }
        public bool GetRphotoedit(int Rgrade, int Rclass)
        {
            string mysql = "select count(1) from Room  where Rphotoedit=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }
        public bool GetRsexedit(int Rgrade, int Rclass)
        {
            string mysql = "select count(1) from Room  where Rsexedit=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }
        public bool GetRnameedit(int Rgrade, int Rclass)
        {
            string mysql = "select count(1) from Room  where Rnameedit=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }
        /// <summary>
        /// ���༶�����Ͽε�ѧ����ű�־
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rcid"></param>
        public void UpdateRcid(int Rgrade, int Rclass, int Rcid)
        {
            string mysql = "update Room set Rcid=" + Rcid + " where Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ��ȡ�ð༶��ǰ�Ͽ�ѧ���ı��
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRcid(int Rgrade, int Rclass)
        {
            string mysql = "select Rcid from Room where  Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// ����Ropen
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Ropen"></param>
        public void UpdateRopen(int Rgrade, int Rclass,bool Ropen)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Ropen=@Ropen ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Ropen", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Ropen;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �ж��ǲ��ǹ�����ģʽ
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public bool IsRopen(int Rgrade, int Rclass)
        {
            string mysql = "select Rid from Room where Ropen=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }
        /// <summary>
        /// �ж��ǲ��ǹ�����ģʽ������Rcid��������ǣ�����""���ַ�
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string IsRopenRcid(int Rgrade, int Rclass)
        {
            string mysql = "select Rcid from Room where Ropen=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.FindString(mysql);
        }
        public int initRshare()
        {
            string mysql = "update Room set Rshare=0";
            return DbHelperSQL.ExecuteSql(mysql);
        }
        public int initRgroupshare()
        {
            string mysql = "update Room set Rgroupshare=0";
            return DbHelperSQL.ExecuteSql(mysql);
        }
        public void initRpwdsee()
        {
            string mysql = "update Room set Rpwdsee=1 where Rip='1'";
            DbHelperSQL.ExecuteSql(mysql);
            string sqlstr = "update Room set Rpwdsee=0 where Rip<>'1'";
            DbHelperSQL.ExecuteSql(sqlstr);
        }
        public bool IsRscratch(int Rgrade, int Rclass)
        {
            string mysql = "select Rid from Room where Rscratch=1 and Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.Exists(mysql);
        }

        public void updateRscratch(int Rgrade, int Rclass,bool Rscratch)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rscratch=@Rscratch ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rscratch", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rscratch;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ����Rshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rshare"></param>
        public void UpdateRshare(int Rgrade, int Rclass, bool Rshare)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rshare=@Rshare ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rshare", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rshare;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ����Rgroupshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rgroupshare"></param>
        public void UpdateRgroupshare(int Rgrade, int Rclass, bool Rgroupshare)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rgroupshare=@Rgroupshare ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rgroupshare", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rgroupshare;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �ж��Ƿ���Rshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public bool IsRshare(int Rgrade, int Rclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Room ");
            strSql.Append(" where Rshare=1 and Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;

           return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �ж��Ƿ���Rgroupshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public bool IsRgroupshare(int Rgrade, int Rclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Room ");
            strSql.Append(" where Rgroupshare=1 and Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ����Rpwdsee
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rpwdsee"></param>
        public void UpdateRpwdsee(int Rgrade, int Rclass, bool Rpwdsee)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Room set ");
            strSql.Append("Rpwdsee=@Rpwdsee ");
            strSql.Append(" where Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4),
					new SqlParameter("@Rpwdsee", SqlDbType.Bit,1)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;
            parameters[2].Value = Rpwdsee;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// �ж��Ƿ�༶����ɲ�Rpwdsee
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public bool IsRpwdsee(int Rgrade, int Rclass)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Room ");
            strSql.Append(" where Rpwdsee=1 and Rgrade=@Rgrade and Rclass=@Rclass");
            SqlParameter[] parameters = {
					new SqlParameter("@Rgrade", SqlDbType.Int,4),
					new SqlParameter("@Rclass", SqlDbType.Int,4)};
            parameters[0].Value = Rgrade;
            parameters[1].Value = Rclass;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ȡ�꼶ƴ�������������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public string GetRchinese(int Rgrade, int Rhid)
        {
            string mysql = "select  Rchinese from Room where Rgrade=" + Rgrade + " and Rhid=" + Rhid;
            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// ��ȡ�꼶���Ĵ�������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public string GetRtyper(int Rgrade, int Rhid)
        {
            string mysql = "select  Rtyper from Room where Rgrade=" + Rgrade + " and Rhid=" + Rhid;
            return DbHelperSQL.FindString(mysql);        
        }
        /// <summary>
        /// ��ȡ�༶ƴ�������������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRchineseByClass(int Rgrade, int Rclass)
        {
            string mysql = "select  Rchinese from Room where Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// ��ȡ�༶���Ĵ�������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRtyperByClass(int Rgrade, int Rclass)
        {
            string mysql = "select  Rtyper from Room where Rgrade=" + Rgrade + " and Rclass=" + Rclass;
            return DbHelperSQL.FindString(mysql);
        }
        /// <summary>
        /// ���������꼶ƴ���������ָ������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rchinese"></param>
        /// <param name="Rhid"></param>
        public void SetRchinese(int Rgrade, string Rchinese, int Rhid)
        {
            string mysql = "update Room  set Rchinese='" + Rchinese + "' where Rgrade=" + Rgrade + " and Rhid=" + Rhid;
            DbHelperSQL.ExecuteSql(mysql);
        }
        /// <summary>
        /// ���������꼶���Ĵ���ָ������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rtyper"></param>
        /// <param name="Rhid"></param>
        public void SetRtyper(int Rgrade, string Rtyper,int Rhid)
        {
            string mysql = "update Room  set Rtyper='" + Rtyper + "' where Rgrade=" + Rgrade + " and Rhid=" + Rhid;
            DbHelperSQL.ExecuteSql(mysql);
        }

        public void initRreg()
        {
            string mysql = "update Room set Rreg=0 where Rreg is null";
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
            parameters[0].Value = "Room";
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

