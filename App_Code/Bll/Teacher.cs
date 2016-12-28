using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
using System.Web;
namespace LearnSite.BLL
{
	/// <summary>
	/// ҵ���߼���Teacher ��ժҪ˵����
	/// </summary>
	public class Teacher
	{
		private readonly LearnSite.DAL.Teacher dal=new LearnSite.DAL.Teacher();
		public Teacher()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}
        /// <summary>
        /// ��¼��ʦ�Ͽεĵ���������
        /// </summary>
        /// <param name="Hid"></param>
        /// <param name="Hroom"></param>
        public void updateHroom(int Hid, string Hroom)
        {
            dal.updateHroom(Hid, Hroom);
        }
        /// <summary>
        /// ��ʼ���ǳ�
        /// </summary>
        public void initHnick()
        {
            dal.initHnick();
        }
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Hid)
		{
			return dal.Exists(Hid);
		}
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsHname(string Hname)
        {
            return dal.ExistsHname(Hname);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(LearnSite.Model.Teacher model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(LearnSite.Model.Teacher model)
		{
			dal.Update(model);
		}
                
        /// <summary>
        /// ��������ʦͳ��ѧ����
        /// </summary>
        public void UpdateHcountAll()
        {
            dal.UpdateHcountAll();
        }
        /// <summary>
        /// ��һλ��ʦͳ��ѧ����
        /// </summary>
        /// <param name="hid"></param>
        public void UpdateHcount(string hid)
        {
            dal.UpdateHcount(hid);
        }
                
        /// <summary>
        ///����Hid ��������
        /// </summary>
        /// <param name="Hid"></param>
        /// <param name="Hpwd"></param>
        public void UpdatePwd(int Hid, string Hpwd)
        {
            dal.UpdatePwd(Hid, Hpwd);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int Hid)
		{			
			dal.Delete(Hid);
		}
                
        /// <summary>
        /// ɾ����־һ������
        /// </summary>
        public int DownTeacher(int Hid)
        {
            return dal.DownTeacher(Hid);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Teacher GetModel(int Hid)
		{
			
			return dal.GetModel(Hid);
		}

               /// <summary>
        /// ��������������õ�һ����ʦ����ʵ�壬��������ڷ���null
        /// </summary>
        public LearnSite.Model.Teacher GetTeacherModel(string Hname, string Hpwd)
        {
            return dal.GetTeacherModel(Hname, Hpwd);
        }

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
		/// </summary>
		public LearnSite.Model.Teacher GetModelByCache(int Hid)
		{
			
			string CacheKey = "TeacherModel-" + Hid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Hid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Teacher)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
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
		public List<LearnSite.Model.Teacher> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Teacher> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Teacher> modelList = new List<LearnSite.Model.Teacher>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Teacher model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Teacher();
					if(dt.Rows[n]["Hid"].ToString()!="")
					{
						model.Hid=int.Parse(dt.Rows[n]["Hid"].ToString());
					}
					model.Hname=dt.Rows[n]["Hname"].ToString();
					model.Hpwd=dt.Rows[n]["Hpwd"].ToString();
					if(dt.Rows[n]["Hpermiss"].ToString()!="")
					{
						if((dt.Rows[n]["Hpermiss"].ToString()=="1")||(dt.Rows[n]["Hpermiss"].ToString().ToLower()=="true"))
						{
						model.Hpermiss=true;
						}
						else
						{
							model.Hpermiss=false;
						}
					}
					model.Hnote=dt.Rows[n]["Hnote"].ToString();
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
        /// ��ȡδɾ����־��ʦ�˺�
        /// </summary>
        /// <returns></returns>
        public DataSet GetTeacherList()
        {
            return GetList(" Hdelete=0 ");
        }
        /// <summary>
        /// ��ý�ʦID�������б�
        /// </summary>
        public DataSet GetListHidHname()
        {
            return dal.GetListHidHname();
        }
        /// <summary>
        /// ���øý�ʦ��ѧ���ռ䵱ǰ��ѧ��Ŀ¼
        /// </summary>
        /// <param name="Hpath"></param>
        /// <param name="Hid"></param>
        public void SetHpath(string Hpath, int Hid)
        {
            dal.SetHpath(Hpath, Hid);
        }
        /// <summary>
        /// ���ظý�ʦ��ѧ���ռ䵱ǰ��ѧ��Ŀ¼�����򷵻ؿ��ַ�""
        /// </summary>
        /// <param name="Hid"></param>
        /// <returns></returns>
        public string GetHpath(string Hid)
        {
            return dal.GetHpath(Hid);
        }
                
        /// <summary>
        /// ���ظý�ʦ��ѧ���ռ䵱ǰ��ѧ��Ŀ¼�����򷵻ؿ��ַ�""
        /// </summary>
        /// <param name="Hid"></param>
        /// <returns></returns>
        public string GetHpathfroStu(int Sgrade, int Sclass)
        {
            return dal.GetHpathfroStu(Sgrade, Sclass);
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

