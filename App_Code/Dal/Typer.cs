using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����Typer��
	/// </summary>
	public class Typer
	{
		public Typer()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Tid", "Typer"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Tid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Typer");
			strSql.Append(" where Tid=@Tid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Tid", SqlDbType.Int,4)};
			parameters[0].Value = Tid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.Typer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Typer(");
			strSql.Append("Ttype,Tuse,Ttitle,Tcontent)");
			strSql.Append(" values (");
			strSql.Append("@Ttype,@Tuse,@Ttitle,@Tcontent)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Ttype", SqlDbType.SmallInt,2),
					new SqlParameter("@Tuse", SqlDbType.Int,4),
					new SqlParameter("@Ttitle", SqlDbType.NVarChar,100),
					new SqlParameter("@Tcontent", SqlDbType.NText)};
			parameters[0].Value = model.Ttype;
			parameters[1].Value = model.Tuse;
			parameters[2].Value = model.Ttitle;
			parameters[3].Value = model.Tcontent;

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
		public void Update(LearnSite.Model.Typer model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Typer set ");
			strSql.Append("Ttype=@Ttype,");
			strSql.Append("Tuse=@Tuse,");
			strSql.Append("Ttitle=@Ttitle,");
			strSql.Append("Tcontent=@Tcontent");
			strSql.Append(" where Tid=@Tid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Tid", SqlDbType.Int,4),
					new SqlParameter("@Ttype", SqlDbType.SmallInt,2),
					new SqlParameter("@Tuse", SqlDbType.Int,4),
					new SqlParameter("@Ttitle", SqlDbType.NVarChar,100),
					new SqlParameter("@Tcontent", SqlDbType.NText)};
			parameters[0].Value = model.Tid;
			parameters[1].Value = model.Ttype;
			parameters[2].Value = model.Tuse;
			parameters[3].Value = model.Ttitle;
			parameters[4].Value = model.Tcontent;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Tid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Typer ");
			strSql.Append(" where Tid=@Tid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Tid", SqlDbType.Int,4)};
			parameters[0].Value = Tid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ���ݱ�Ż�ȡ���±���
        /// </summary>
        /// <param name="Tid"></param>
        /// <returns></returns>
        public string GetTitle(int Tid)
        {
            string mysql = "select top 1 Ttitle from Typer where Tid=" + Tid;
            return DbHelperSQL.FindString(mysql);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Typer GetModel(int Tid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Tid,Ttype,Tuse,Ttitle,Tcontent from Typer ");
			strSql.Append(" where Tid=@Tid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Tid", SqlDbType.Int,4)};
			parameters[0].Value = Tid;

			LearnSite.Model.Typer model=new LearnSite.Model.Typer();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Tid"].ToString()!="")
				{
					model.Tid=int.Parse(ds.Tables[0].Rows[0]["Tid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Ttype"].ToString()!="")
				{
					model.Ttype=int.Parse(ds.Tables[0].Rows[0]["Ttype"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Tuse"].ToString()!="")
				{
					model.Tuse=int.Parse(ds.Tables[0].Rows[0]["Tuse"].ToString());
				}
				model.Ttitle=ds.Tables[0].Rows[0]["Ttitle"].ToString();
				model.Tcontent=ds.Tables[0].Rows[0]["Tcontent"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}


        /// <summary>
        /// ����õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Typer GetModelRnd(string tids)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  TOP 1 Tid,Ttype,Tuse,Ttitle,Tcontent FROM Typer ");
            string wherestr = " WHERE Tid in (" + tids + ")";
            if (tids != "")
                strSql.Append(wherestr);//���ָ�����£����ѯָ������
            strSql.Append(" ORDER  BY NewID() ");

            LearnSite.Model.Typer model = new LearnSite.Model.Typer();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Tid"].ToString() != "")
                {
                    model.Tid = int.Parse(ds.Tables[0].Rows[0]["Tid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Ttype"].ToString() != "")
                {
                    model.Ttype = int.Parse(ds.Tables[0].Rows[0]["Ttype"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Tuse"].ToString() != "")
                {
                    model.Tuse = int.Parse(ds.Tables[0].Rows[0]["Tuse"].ToString());
                }
                model.Ttitle = ds.Tables[0].Rows[0]["Ttitle"].ToString();
                model.Tcontent = ds.Tables[0].Rows[0]["Tcontent"].ToString();
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
			strSql.Append("select Tid,Ttype,Tuse,Ttitle,Tcontent ");
			strSql.Append(" FROM Typer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// ��������б�,������Tcontent����
        /// </summary>
        public DataSet GetListArticle(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Tid,Ttype,Tuse,Ttitle ");
            strSql.Append(" FROM Typer ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by Tid DESC");

            return DbHelperSQL.Query(strSql.ToString());
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
			strSql.Append(" Tid,Ttype,Tuse,Ttitle,Tcontent ");
			strSql.Append(" FROM Typer ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// ����������Tid�󶨵�datalist��
        /// </summary>
        /// <param name="DLTid"></param>
        public DataSet ShowAllTid()
        {
            string mysql = "SELECT  Tid,Ttitle FROM Typer ORDER  BY Tid";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ָ����������Tid�󶨵�datalist��
        /// </summary>
        /// <param name="DLTid"></param>
        public DataSet ShowAllTid(string tids)
        {
            string mysql = "SELECT  Tid,Ttitle FROM Typer ORDER  BY Tid";
            if (tids != "")
                mysql = "SELECT  Tid,Ttitle FROM Typer WHERE Tid in(" + tids + ") ORDER  BY Tid";
            return DbHelperSQL.Query(mysql);
        }
        /// <summary>
        /// ��ȡ�������±���Tid, Ttitle
        /// </summary>
        /// <returns></returns>
        public DataTable ShowAllTitle()
        {
            string mysql = "select Tid, Ttitle from Typer order by Tid";
            return DbHelperSQL.Query(mysql).Tables[0];
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
			parameters[0].Value = "Typer";
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

