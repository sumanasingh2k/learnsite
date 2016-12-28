using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LearnSite.DBUtility;//�����������
namespace LearnSite.DAL
{
	/// <summary>
	/// ���ݷ�����Mission��
	/// </summary>
	public class Mission
	{
		public Mission()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Mid", "Mission"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Mid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Mission");
			strSql.Append(" where Mid=@Mid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Mid", SqlDbType.Int,4)};
			parameters[0].Value = Mid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ��ȡ�������ֵ
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public int GetMaxMsort(int Mcid)
        {
            int result = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(Msort) from Mission ");
            strSql.Append(" where Mcid=@Mcid and Mdelete=0 ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mcid", SqlDbType.Int,4)};
            parameters[0].Value = Mcid;
            string strfind = DbHelperSQL.FindString(strSql.ToString(), parameters);
            if (strfind != "")
                result = Int32.Parse(strfind);
            return result;
        }

        /// <summary>
        /// ��ȡ�ȵ�ǰ����С�������ύ���ţ����򷵻�0
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public int GetLastMaxMsort(int Mcid,int Msort)
        {
            int result = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(Msort) from Mission ");
            strSql.Append(" where Mcid=@Mcid and Mupload=1 and Msort<@Msort ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mcid", SqlDbType.Int,4),
                    new SqlParameter("@Msort", SqlDbType.Int,4)};
            parameters[0].Value = Mcid;
            parameters[1].Value = Msort;

            string strfind = DbHelperSQL.FindString(strSql.ToString(), parameters);
            if (strfind != "")
                result = Int32.Parse(strfind);
            return result;
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(LearnSite.Model.Mission model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Mission(");
            strSql.Append("Mtitle,Mcid,Mcontent,Mdate,Mhit,Mfiletype,Mupload,Msort,Mpublish,Mgroup,Mgid,Mexample,Mcategory,Microworld)");
            strSql.Append(" values (");
            strSql.Append("@Mtitle,@Mcid,@Mcontent,@Mdate,@Mhit,@Mfiletype,@Mupload,@Msort,@Mpublish,@Mgroup,@Mgid,@Mexample,@Mcategory,@Microworld)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Mtitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Mcid", SqlDbType.Int,4),
					new SqlParameter("@Mcontent", SqlDbType.NText),
					new SqlParameter("@Mdate", SqlDbType.DateTime),
					new SqlParameter("@Mhit", SqlDbType.Int,4),
					new SqlParameter("@Mfiletype", SqlDbType.NVarChar,50),
					new SqlParameter("@Mupload", SqlDbType.Bit,1),
					new SqlParameter("@Msort", SqlDbType.Int,4),
					new SqlParameter("@Mpublish", SqlDbType.Bit,1),
					new SqlParameter("@Mgroup", SqlDbType.Bit,1),
					new SqlParameter("@Mgid", SqlDbType.Int,4),
					new SqlParameter("@Mexample", SqlDbType.NVarChar,50),
					new SqlParameter("@Mcategory", SqlDbType.Int,4),
					new SqlParameter("@Microworld", SqlDbType.Bit,1)};
            parameters[0].Value = model.Mtitle;
            parameters[1].Value = model.Mcid;
            parameters[2].Value = model.Mcontent;
            parameters[3].Value = model.Mdate;
            parameters[4].Value = model.Mhit;
            parameters[5].Value = model.Mfiletype;
            parameters[6].Value = model.Mupload;
            parameters[7].Value = model.Msort;
            parameters[8].Value = model.Mpublish;
            parameters[9].Value = model.Mgroup;
            parameters[10].Value = model.Mgid;
            parameters[11].Value = model.Mexample;
            parameters[12].Value = model.Mcategory;
            parameters[13].Value = model.Microworld;

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
		/// ����һ�����ݣ���mcid)
		/// </summary>
		public void Update(LearnSite.Model.Mission model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Mission set ");
			strSql.Append("Mtitle=@Mtitle,");
			strSql.Append("Mcontent=@Mcontent,");
			strSql.Append("Mdate=@Mdate,");
			strSql.Append("Mhit=@Mhit,");
			strSql.Append("Mfiletype=@Mfiletype,");
			strSql.Append("Mupload=@Mupload,");
			strSql.Append("Mpublish=@Mpublish,");
            strSql.Append("Mgroup=@Mgroup,");
            strSql.Append("Mgid=@Mgid,");
            strSql.Append("Mexample=@Mexample,");
            strSql.Append("Mcategory=@Mcategory,");
            strSql.Append("Microworld=@Microworld");
			strSql.Append(" where Mid=@Mid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mid", SqlDbType.Int,4),
					new SqlParameter("@Mtitle", SqlDbType.NVarChar,50),
					new SqlParameter("@Mcontent", SqlDbType.NText),
					new SqlParameter("@Mdate", SqlDbType.DateTime),
					new SqlParameter("@Mhit", SqlDbType.Int,4),
					new SqlParameter("@Mfiletype", SqlDbType.NVarChar,50),
					new SqlParameter("@Mupload", SqlDbType.Bit,1),
					new SqlParameter("@Mpublish", SqlDbType.Bit,1),
					new SqlParameter("@Mgroup", SqlDbType.Bit,1),
					new SqlParameter("@Mgid", SqlDbType.Int,4),
					new SqlParameter("@Mexample", SqlDbType.NVarChar,50),
					new SqlParameter("@Mcategory", SqlDbType.Int,4),
					new SqlParameter("@Microworld", SqlDbType.Bit,1)};
			parameters[0].Value = model.Mid;
			parameters[1].Value = model.Mtitle;
			parameters[2].Value = model.Mcontent;
			parameters[3].Value = model.Mdate;
			parameters[4].Value = model.Mhit;
			parameters[5].Value = model.Mfiletype;
			parameters[6].Value = model.Mupload;
			parameters[7].Value = model.Mpublish;
            parameters[8].Value = model.Mgroup;
            parameters[9].Value = model.Mgid;
            parameters[10].Value = model.Mexample;
            parameters[11].Value = model.Mcategory;
            parameters[12].Value = model.Microworld;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ���ĵ������� updown ֵ0���� ����1���¡���
        /// </summary>
        /// <param name="Mid"></param>
        /// <param name="updown"></param>
        public void UpdateMsort(int Mid, bool updown)
        {
            string mysql = "update Mission set Msort=Msort-1 where Mid=" + Mid;
            if (updown)
                mysql = "update Mission set Msort=Msort+1 where Mid=" + Mid;
            DbHelperSQL.ExecuteSql(mysql);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Mid)
		{			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Mission ");
			strSql.Append(" where Mid=@Mid ");
			SqlParameter[] parameters = {
					new SqlParameter("@Mid", SqlDbType.Int,4)};
			parameters[0].Value = Mid;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteMission(int Mid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Mission set Mdelete=1,Mpublish=0");
            strSql.Append(" where Mid=@Mid ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mid", SqlDbType.Int,4)};
            parameters[0].Value = Mid;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Mission GetModel(int Mid)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 * from Mission ");
            strSql.Append(" where Mid=@Mid");
            SqlParameter[] parameters = {
					new SqlParameter("@Mid", SqlDbType.Int,4)
};
            parameters[0].Value = Mid;

            LearnSite.Model.Mission model = new LearnSite.Model.Mission();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Mid"].ToString() != "")
                {
                    model.Mid = int.Parse(ds.Tables[0].Rows[0]["Mid"].ToString());
                }
                model.Mtitle = ds.Tables[0].Rows[0]["Mtitle"].ToString();
                if (ds.Tables[0].Rows[0]["Mcid"].ToString() != "")
                {
                    model.Mcid = int.Parse(ds.Tables[0].Rows[0]["Mcid"].ToString());
                }
                model.Mcontent = ds.Tables[0].Rows[0]["Mcontent"].ToString();
                if (ds.Tables[0].Rows[0]["Mdate"].ToString() != "")
                {
                    model.Mdate = DateTime.Parse(ds.Tables[0].Rows[0]["Mdate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Mhit"].ToString() != "")
                {
                    model.Mhit = int.Parse(ds.Tables[0].Rows[0]["Mhit"].ToString());
                }
                model.Mfiletype = ds.Tables[0].Rows[0]["Mfiletype"].ToString();
                if (ds.Tables[0].Rows[0]["Mupload"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Mupload"].ToString() == "1") || (ds.Tables[0].Rows[0]["Mupload"].ToString().ToLower() == "true"))
                    {
                        model.Mupload = true;
                    }
                    else
                    {
                        model.Mupload = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Msort"].ToString() != "")
                {
                    model.Msort = int.Parse(ds.Tables[0].Rows[0]["Msort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Mpublish"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Mpublish"].ToString() == "1") || (ds.Tables[0].Rows[0]["Mpublish"].ToString().ToLower() == "true"))
                    {
                        model.Mpublish = true;
                    }
                    else
                    {
                        model.Mpublish = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Mgroup"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Mgroup"].ToString() == "1") || (ds.Tables[0].Rows[0]["Mgroup"].ToString().ToLower() == "true"))
                    {
                        model.Mgroup = true;
                    }
                    else
                    {
                        model.Mgroup = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Mgid"] != null && ds.Tables[0].Rows[0]["Mgid"].ToString() != "")
                {
                    model.Mgid = int.Parse(ds.Tables[0].Rows[0]["Mgid"].ToString());
                }
                model.Mexample = ds.Tables[0].Rows[0]["Mexample"].ToString();
                if (ds.Tables[0].Rows[0]["Mcategory"].ToString() != "")
                {
                    model.Mcategory = int.Parse(ds.Tables[0].Rows[0]["Mcategory"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Microworld"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Microworld"].ToString() == "1") || (ds.Tables[0].Rows[0]["Microworld"].ToString().ToLower() == "true"))
                    {
                        model.Microworld = true;
                    }
                    else
                    {
                        model.Microworld = false;
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
        /// �Ӳ�ѯ���еõ�һ��Mission����ʵ��,TsortΪTable��¼��ţ���0��ʼ��
        /// </summary>
        public LearnSite.Model.Mission GetTableModel(DataTable dt, int Tsort)
        {

            LearnSite.Model.Mission model = new LearnSite.Model.Mission();
            int Count = dt.Rows.Count;
            if (Count > 0)
            {
                if (Tsort < Count)
                {
                    if (dt.Rows[Tsort]["Mid"].ToString() != "")
                    {
                        model.Mid = int.Parse(dt.Rows[Tsort]["Mid"].ToString());
                    }
                    model.Mtitle = dt.Rows[Tsort]["Mtitle"].ToString();
                    if (dt.Rows[Tsort]["Mcid"].ToString() != "")
                    {
                        model.Mcid = int.Parse(dt.Rows[Tsort]["Mcid"].ToString());
                    }
                    model.Mcontent = dt.Rows[Tsort]["Mcontent"].ToString();
                    if (dt.Rows[Tsort]["Mdate"].ToString() != "")
                    {
                        model.Mdate = DateTime.Parse(dt.Rows[Tsort]["Mdate"].ToString());
                    }
                    if (dt.Rows[Tsort]["Mhit"].ToString() != "")
                    {
                        model.Mhit = int.Parse(dt.Rows[Tsort]["Mhit"].ToString());
                    }
                    model.Mfiletype = dt.Rows[Tsort]["Mfiletype"].ToString();
                    if (dt.Rows[Tsort]["Mupload"].ToString() != "")
                    {
                        if ((dt.Rows[Tsort]["Mupload"].ToString() == "1") || (dt.Rows[Tsort]["Mupload"].ToString().ToLower() == "true"))
                        {
                            model.Mupload = true;
                        }
                        else
                        {
                            model.Mupload = false;
                        }
                    }
                    if (dt.Rows[Tsort]["Msort"].ToString() != "")
                    {
                        model.Msort = int.Parse(dt.Rows[Tsort]["Msort"].ToString());
                    }
                    if (dt.Rows[Tsort]["Mpublish"].ToString() != "")
                    {
                        if ((dt.Rows[Tsort]["Mpublish"].ToString() == "1") || (dt.Rows[Tsort]["Mpublish"].ToString().ToLower() == "true"))
                        {
                            model.Mpublish = true;
                        }
                        else
                        {
                            model.Mpublish = false;
                        }
                    }
                    if (dt.Columns.Contains("Mgid"))
                    {
                        if (dt.Rows[Tsort]["Mgid"] != null && dt.Rows[Tsort]["Mgid"].ToString() != "")
                        {
                            model.Mgid = int.Parse(dt.Rows[Tsort]["Mgid"].ToString());
                        }
                    }
                    if (dt.Columns.Contains("Mexample"))
                    {
                        model.Mexample = dt.Rows[Tsort]["Mexample"].ToString();
                    }
                    if (dt.Columns.Contains("Mcategory"))
                    {
                        if (dt.Rows[Tsort]["Mcategory"].ToString() != "")
                            model.Mcategory = int.Parse(dt.Rows[Tsort]["Mcategory"].ToString());
                    }
                    if (dt.Columns.Contains("Microworld"))
                    {
                        if (dt.Rows[Tsort]["Microworld"].ToString() != "")
                        {
                            if ((dt.Rows[Tsort]["Microworld"].ToString() == "1") || (dt.Rows[Tsort]["Microworld"].ToString().ToLower() == "true"))
                            {
                                model.Microworld = true;
                            }
                            else
                            {
                                model.Microworld = false;
                            }
                        }
                    }

                    return model;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
        /// <summary>
        /// ��ȡ���Ʒ�ϴ�����
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public string GetMfiletype(int Mid)
        {
            string mysql = "select Mfiletype from Mission where Mid="+Mid;
            return DbHelperSQL.FindString(mysql);
        }
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Mid,Mtitle,Mcid,Mcontent,Mdate,Mhit,Mfiletype,Mupload,Msort,Mpublish,Mgroup,Mgid  ");
			strSql.Append(" FROM Mission ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// ��������������б�
        /// </summary>
        public DataSet GetListNoContent(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Mid,Mtitle,left(Mtitle,12) as MtitleShort, Mcid,Mdate,Mhit,Mfiletype,Mupload,Msort,Mpublish,Mgroup,Mgid  ");
            strSql.Append(" FROM Mission ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// ��������������б��б��⣩
        /// </summary>
        public DataSet GetListMission(int Mcid)
        {
            string strWhere = "Mcid=" + Mcid + "and Mpublish=1  order by Msort";
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Mid,Mtitle,left(Mtitle,12) as MtitleShort, Mcid,Msort ");
            strSql.Append(" FROM Mission ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public string GetMissionTitle(int Mid)
        {
            string mysql = "select Mtitle from Mission where Mid="+Mid;
            return DbHelperSQL.FindString(mysql);
        }

        /// <summary>
        /// ��ȡMgid
        /// </summary>
        /// <param name="Mid"></param>
        /// <returns></returns>
        public string GetMissionGid(int Mid)
        {
            string mysql = "select Mgid from Mission where Mid=" + Mid;
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
            strSql.Append(" Mid,Mtitle,Mcid,Mcontent,Mdate,Mhit,Mfiletype,Mupload,Msort,Mpublish,Mgroup,Mgid  ");
			strSql.Append(" FROM Mission ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
		}
 
        /// <summary>
        /// �Ƿ���ڸû��¼
        /// </summary>
        public bool MsortExists(int Mcid,int Msort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Mission");
            strSql.Append(" where Mcid=@Mcid and Msort=@Msort and Mdelete=0 ");
            SqlParameter[] parameters = {
					new SqlParameter("@Mcid", SqlDbType.Int,4),
                    new SqlParameter("@Msort", SqlDbType.Int,4)};
            parameters[0].Value = Mcid;
            parameters[1].Value = Msort;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// ��ø�ѧ���Ļ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetMsort(int Mcid)
        {
            string strSql = "select Msort from Mission where Mcid=" + Mcid + " order by Msort ASC";
            return DbHelperSQL.Query(strSql);
        }

        /// <summary>
        /// ��ø�ѧ������Ʒ�ύ�Ļ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetUploadMsort(int Mcid)
        {
            string strSql = "select Msort from Mission where Mcid=" + Mcid + " and Mupload=1 order by Msort DESC";
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// ��ø�ѧ������Ʒ�ύ�Ļ��źͱ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetUploadMidMtitle(int Mcid)
        {
            string strSql = "select Mid,(cast(Msort as varchar(10))+' '+Mtitle)as Mstitle from Mission where Mcid=" + Mcid + " and Mupload=1 and Mdelete=0 order by Msort DESC";
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// ��ø�ѧ�����л��źͱ���
        /// </summary>
        /// <param name="Mcid"></param>
        /// <returns></returns>
        public DataSet GetMidMtitle(int Mcid)
        {
            string strSql = "select Mid,(cast(Msort as varchar(10))+' '+Mtitle)as Mstitle from Mission where Mcid=" + Mcid + " order by Msort DESC";
            return DbHelperSQL.Query(strSql);
        }
        /// <summary>
        /// ��ʼ��Mgroup�ֶ�nullΪfalse
        /// </summary>
        public void InitMgroup()
        {
            string strSql = "update Mission set Mgroup=0 where Mgroup is null";
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ����״̬�����������
        /// </summary>
        /// <param name="Mid"></param>
        public void UpdateMpublish(int Mid)
        {
            string strSql = "update Mission set Mpublish=Mpublish^1 where Mid=" + Mid;
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ��ʼ�������ݿ������
        /// </summary>
        public void UpdateMgid()
        {
            string strSql = "update Mission set Mgid=0 where Mgid is null";
            DbHelperSQL.ExecuteSql(strSql);
        }
        public void InitMdelete()
        {
            string strSql = "update Mission set Mdelete=0 where Mdelete is null";
            DbHelperSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// ��ʼ���ֶ�ֵΪ0��
        /// </summary>
        public void InitMcategory()
        {
            string strSql = "update Mission set Mcategory=0 where Mcategory is null";
            DbHelperSQL.ExecuteSql(strSql);
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
			parameters[0].Value = "Mission";
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

