using System;
using System.Data;
using System.Collections.Generic;
using LearnSite.Model;
using System.Collections;
namespace LearnSite.BLL
{
	/// <summary>
	/// Computers
	/// </summary>
	public class Computers
	{
		private readonly LearnSite.DAL.Computers dal=new LearnSite.DAL.Computers();
		public Computers()
		{}
		#region  Method

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

        public void initPxy()
        {
            dal.initPxy();
        }
        /// <summary>
        /// ��ȡ����������
        /// </summary>
        /// <returns></returns>
        public DataTable CmpRoom()
        {
            return dal.CmpRoom();
        }
        /// <summary>
        /// ������ʦ��ȡ�����ҵģɣС�������������
        /// select Pip,Pmachine,Px,Py from Computers
        /// </summary>
        /// <param name="Ph"></param>
        /// <returns></returns>
        public SeatCollect GetSeat(string Pm)
        {
            SeatCollect sct = new SeatCollect();
            DataTable dt = dal.GetSeat(Pm);
            int count = dt.Rows.Count;
            sct.Dt = dt;
            sct.Online = count;
            sct.Column = 8;
            if (count > 6)
            {
                int beginX = Int32.Parse(dt.Rows[0][2].ToString());//��ȡ��ʼX����
                ArrayList arrayX = new ArrayList();
                arrayX.Add(beginX);

                #region    ��׼��X����  ͬ��ƫ��60�� �Զ���ֱ����  dt

                for (int i = 0; i < count; i++)
                {
                    int Px = Int32.Parse(dt.Rows[i][2].ToString());//��ȡĳIP��X����
                    if (Px > beginX + 60)
                    {
                        beginX = Px;//�õ���ǰX����
                        arrayX.Add(beginX);
                    }
                    else
                    {
                        dt.Rows[i][2] = beginX; //���С�ڲ�ֵ��ȫ������Ϊ��ǰֵ
                    }
                }
                #endregion

                DataView dv = dt.DefaultView;
                dv.Sort = "Py  Asc";
                DataTable dt2 = dv.ToTable();//�õ���Y��������ı�
                int beginY = Int32.Parse(dt2.Rows[0][3].ToString());//��ȡ��ʼY����
                ArrayList arrayY = new ArrayList();
                arrayY.Add(beginY);

                #region    ��׼��Y����   ͬ��ƫ��60�� �Զ�ˮƽ���� dt2

                for (int i = 0; i < count; i++)
                {
                    int Py = Int32.Parse(dt2.Rows[i][3].ToString());//��ȡĳIP��X����
                    if (Py > beginY + 60)
                    {
                        beginY = Py;//�õ���ǰY����
                        arrayY.Add(beginY);
                    }
                    else
                    {
                        dt2.Rows[i][3] = beginY; //���С�ڲ�ֵ��ȫ������Ϊ��ǰֵ
                    }
                }
                #endregion

                #region ��ѯ��׼λ�ã��ڱ��д��ڲ����ڣ�����������ӿ�λ
                int empty = 0;
                for (int i = 0; i < arrayX.Count; i++)
                {
                    int x = Int32.Parse(arrayX[i].ToString());
                    for (int j = 0; j < arrayY.Count; j++)
                    {
                        int y = Int32.Parse(arrayY[j].ToString());
                        //��ѯ��׼λ�ã��ڱ��д��ڲ����ڣ�����������Ӽ�¼
                        if (dt2.Select("Px=" + x + " and Py=" + y).Length < 1)
                        {
                            empty++;
                            DataRow dr = dt2.NewRow();//Pip,Pmachine,Px,Py 
                            dr[0] = "";
                            dr[1] = "";
                            dr[2] = x;
                            dr[3] = y;
                            dt2.Rows.Add(dr);
                        }
                    }
                }
                #endregion

                DataView dvok = dt2.DefaultView;
                dvok.Sort = "Px Asc , Py Asc";

                DataTable dt3 = dvok.ToTable();//�õ����ձ�׼��ʽλ�ñ�����λ��
                dt.Dispose();
                dt2.Dispose();
                sct.Column = arrayX.Count;
                sct.Dt = dt3;
            }
            return sct;
        }

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int Pid)
		{
			return dal.Exists(Pid);
		}
                
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool ExistsIp(string Pip)
        {
            return dal.ExistsIp(Pip);
        }                
        /// <summary>
        /// ����������
        /// </summary>
        public string GetmachineByIp(string Pip)
        {
            return dal.GetmachineByIp(Pip);
        }
        /// <summary>
        /// �Ƿ���δ�󶨵�������IP
        /// </summary>
        /// <returns></returns>
        public string ExistPlock(string Pip)
        {
            return dal.ExistPlock(Pip);
        }
		/// <summary>
        /// ����һ������Pip,Pmachine,Plock,Pdate
		/// </summary>
		public int  Add(LearnSite.Model.Computers model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// ����һ������Pip,Pmachine,Plock,Pdate,Px,Py,Pm
        /// </summary>
        public int AddModel(LearnSite.Model.Computers model)
        {
            return dal.AddModel(model);
        }
        /// <summary>
        /// ������Plockֵȡ��������
        /// </summary>
        /// <param name="Pid"></param>
        public void UpLock(int Pid)
        {
            dal.UpLock(Pid);
        }
        /// <summary>
        /// ������PlockֵΪ0��������
        /// </summary>
        public void UnLockAll()
        {
            dal.UnLockAll();
        }
                
        /// <summary>
        /// ������PlockֵΪ0��������
        /// </summary>
        public void OnLockAll()
        {
            dal.OnLockAll();
        }
        /// <summary>
        /// ����IP���µ��������͵�������
        /// </summary>
        public bool UpdateIpPxPy(string Pip, int Px, int Py, string Pm)
        {
            return dal.UpdateIpPxPy(Pip, Px, Py, Pm);
        }
        /// <summary>
        /// ����Pid����һ������Pmachine,Plock,Pdate
        /// </summary>
        public bool UpdateMachine(LearnSite.Model.Computers model)
        {
            return UpdateMachine(model);
        }
		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(LearnSite.Model.Computers model)
		{
			return dal.Update(model);
		}                
        /// <summary>
        /// ����IP�����������������������
        /// </summary>
        public bool UpdateIp(string Pip, string Pmachine)
        {
            bool isok = false;
            if (!ExistsIp(Pip))
            {
                Model.Computers cmodel = new Model.Computers();
                cmodel.Pdate = DateTime.Now;
                cmodel.Pip = Pip;
                cmodel.Plock = true;
                cmodel.Pmachine = Pmachine;
                BLL.Computers cbll = new Computers();
                if (cbll.Add(cmodel) > 0)
                {
                    isok = true;
                }
            }
            else
            {
                isok = dal.UpdateIp(Pip, Pmachine);
            }
            return isok;
        }
                        
        /// <summary>
        /// ����Pid����������������
        /// </summary>
        public bool UpdateByPid(int Pid, string Pmachine)
        {
            return dal.UpdateByPid(Pid, Pmachine);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int Pid)
		{
			
			return dal.Delete(Pid);
		}
                
        /// <summary>
        /// ɾ����������
        /// </summary>
        public bool DeleteAll()
        {
            return dal.DeleteAll();
        }
                
        /// <summary>
        /// ɾ��������֮ǰ�ļ�¼
        /// </summary>
        /// <param name="pdate"></param>
        /// <returns></returns>
        public bool DeleteThis(string pdate)
        {
            return dal.DeleteThis(pdate);
        }
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool DeleteList(string Pidlist )
		{
			return dal.DeleteList(Pidlist );
		}
                /// <summary>
        /// ����Pip�õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Computers GetModelByIp(string Pip)
        {
            return dal.GetModelByIp(Pip);
        }
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public LearnSite.Model.Computers GetModel(int Pid)
		{
			
			return dal.GetModel(Pid);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ�����
		/// </summary>
		public LearnSite.Model.Computers GetModelByCache(int Pid)
		{
			
			string CacheKey = "ComputersModel-" + Pid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Pid);
					if (objModel != null)
					{
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LearnSite.Model.Computers)objModel;
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// ��������б���������
        /// </summary>
        public DataSet GetListOrderBy(string str)
        {
            string strOrder = "";
            switch (str)
            {
                case "1":
                    strOrder=" order by Pip asc";
                    break;
                case "2":
                    strOrder = " order by Pmachine asc";
                    break;
                case "3":
                    strOrder = " order by Pdate asc";
                    break;
            }
            return dal.GetListOrder(strOrder);
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
		public List<LearnSite.Model.Computers> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<LearnSite.Model.Computers> DataTableToList(DataTable dt)
		{
			List<LearnSite.Model.Computers> modelList = new List<LearnSite.Model.Computers>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LearnSite.Model.Computers model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LearnSite.Model.Computers();
					if(dt.Rows[n]["Pid"].ToString()!="")
					{
						model.Pid=int.Parse(dt.Rows[n]["Pid"].ToString());
					}
					model.Pip=dt.Rows[n]["Pip"].ToString();
					model.Pmachine=dt.Rows[n]["Pmachine"].ToString();
					if(dt.Rows[n]["Plock"].ToString()!="")
					{
						if((dt.Rows[n]["Plock"].ToString()=="1")||(dt.Rows[n]["Plock"].ToString().ToLower()=="true"))
						{
						model.Plock=true;
						}
						else
						{
							model.Plock=false;
						}
					}
					if(dt.Rows[n]["Pdate"].ToString()!="")
					{
						model.Pdate=DateTime.Parse(dt.Rows[n]["Pdate"].ToString());
					}
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
        /// ��ȡIP����������Ӧ��
        /// </summary>
        /// <returns></returns>
        public DataTable GetPipPmachine()
        {
            return dal.GetPipPmachine();
        }
		/// <summary>
		/// ��ҳ��ȡ�����б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

