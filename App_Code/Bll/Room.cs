using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using LearnSite.Model;
namespace LearnSite.BLL
{
    /// <summary>
    /// ҵ���߼���Room ��ժҪ˵����
    /// </summary>
    public class Room
    {
        private readonly LearnSite.DAL.Room dal = new LearnSite.DAL.Room();
        public Room()
        { }
        #region  ��Ա����

        /// <summary>
        /// �õ����ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        public int GetMinRgrade()
        {
            return dal.GetMinRgrade();
        }
        public int GetMaxRgrade()
        {
            return dal.GetMaxRgrade();
        }
        public int GetMinRclass()
        {
            return dal.GetMinRclass();
        }
        public int GetMaxRclass()
        {
            return dal.GetMaxRclass();
        }
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int Rid)
        {
            return dal.Exists(Rid);
        }
        /// <summary>
        /// �Ƿ���ڸð༶
        /// </summary>
        public bool ExistsGC(int Rgrade, int Rclass)
        {
            return dal.ExistsGC(Rgrade, Rclass);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(LearnSite.Model.Room model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public void AddRoom(int Rgrade, int Rclass)
        {
            dal.AddRoom(Rgrade, Rclass);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(LearnSite.Model.Room model)
        {
            dal.Update(model);
        }
        /// <summary>
        /// ����һ���༶ѡ������
        /// </summary>
        public void UpdateRhid(int Rid, int Rhid)
        {
            dal.UpdateRhid(Rid, Rhid);
        }
        /// <summary>
        /// ������а༶ѡ��
        /// </summary>
        public void UpdateRhidNone()
        {
            dal.UpdateRhidNone();
        }

        /// <summary>
        /// ����ý�ʦ���а༶ѡ��
        /// </summary>
        public void ClearRhid(int Rhid)
        {
            dal.ClearRhid(Rhid);
        }
        /// <summary>
        /// ���°༶��������
        /// </summary>
        public void UpdateRseat(int Rgrade, int Rclass, int Houseid)
        {
            dal.UpdateRseat(Rgrade, Rclass, Houseid);
        }
        /// <summary>
        /// ���°༶������ʾ��ʽ��1��ʾ��0����
        /// </summary>
        public void UpdateRip(int Rgrade, int Rclass, bool isshow)
        {
            dal.UpdateRip(Rgrade, Rclass, isshow);
        }
        /// <summary>
        /// ���°༶������ʾ��ʽ��1��ʾ��0����
        /// </summary>
        public bool GetRip(int Rgrade, int Rclass)
        {
            return dal.GetRip(Rgrade, Rclass);
        }
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int Rid)
        {

            dal.Delete(Rid);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void DeleteAll()
        {
            dal.DeleteAll();
        }
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Room GetModel(int Rid)
        {

            return dal.GetModel(Rid);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public LearnSite.Model.Room GetModel(int Rgrade, int Rclass)
        {
            return dal.GetModel(Rgrade, Rclass);
        }
        /// <summary>
        /// �õ�һ������ʵ�壬�ӻ����С�
        /// </summary>
        public LearnSite.Model.Room GetModelByCache(int Rid)
        {

            string CacheKey = "RoomModel-" + Rid;
            object objModel = LearnSite.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(Rid);
                    if (objModel != null)
                    {
                        int ModelCache = LearnSite.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LearnSite.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (LearnSite.Model.Room)objModel;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// ��ȡ��������ֵ
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public bool GetRgauge(int Rgrade, int Rclass)
        {
            return dal.GetRgauge(Rgrade, Rclass);
        }
        /// <summary>
        /// ���»�������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rgauge"></param>
        public void UpdateMyRgauge(int Rgrade, int Rclass, bool Rgauge)
        {
            dal.UpdateMyRgauge(Rgrade, Rclass, Rgauge);
        }
                
        /// <summary>
        /// �༶��̿��ƿ���
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rscratch"></param>
        public void UpdateMyRscratch(int Rgrade, int Rclass, bool Rscratch)
        {
            dal.UpdateMyRscratch(Rgrade, Rclass, Rscratch);
        }
        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<LearnSite.Model.Room> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<LearnSite.Model.Room> DataTableToList(DataTable dt)
        {
            List<LearnSite.Model.Room> modelList = new List<LearnSite.Model.Room>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                LearnSite.Model.Room model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new LearnSite.Model.Room();
                    if (dt.Rows[n]["Rid"].ToString() != "")
                    {
                        model.Rid = int.Parse(dt.Rows[n]["Rid"].ToString());
                    }
                    if (dt.Rows[n]["Rhid"].ToString() != "")
                    {
                        model.Rhid = int.Parse(dt.Rows[n]["Rhid"].ToString());
                    }
                    if (dt.Rows[n]["Rgrade"].ToString() != "")
                    {
                        model.Rgrade = int.Parse(dt.Rows[n]["Rgrade"].ToString());
                    }
                    if (dt.Rows[n]["Rclass"].ToString() != "")
                    {
                        model.Rclass = int.Parse(dt.Rows[n]["Rclass"].ToString());
                    }
                    if (dt.Rows[n]["Rset"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Rset"].ToString() == "1") || (dt.Rows[n]["Rset"].ToString().ToLower() == "true"))
                        {
                            model.Rset = true;
                        }
                        else
                        {
                            model.Rset = false;
                        }
                    }
                    model.Rpwd = dt.Rows[n]["Rpwd"].ToString();
                    if (dt.Rows[n]["Rlock"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Rlock"].ToString() == "1") || (dt.Rows[n]["Rlock"].ToString().ToLower() == "true"))
                        {
                            model.Rlock = true;
                        }
                        else
                        {
                            model.Rlock = false;
                        }
                    }
                    model.Rip = dt.Rows[n]["Rip"].ToString();
                    if (dt.Rows[n]["Rgauge"] != null && dt.Rows[n]["Rgauge"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Rgauge"].ToString() == "1") || (dt.Rows[n]["Rgauge"].ToString().ToLower() == "true"))
                        {
                            model.Rgauge = true;
                        }
                        else
                        {
                            model.Rgauge = false;
                        }
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
        /// ���ָ��Rhid�İ༶�����б�(�꼶�༶����ΪRgradeclass
        /// </summary>
        public DataSet GetMyClassList(int Rhid)
        {
            return dal.GetMyClassList(Rhid);
        }
        /// <summary>
        ///  ���꼶���л�ò��ظ����꼶
        /// </summary>
        /// <returns></returns>
        public DataTable GetGrade()
        {
            return dal.GetGrade().Tables[0];
        }
        /// <summary>
        /// ���꼶���л�ò��ظ��������꼶
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllGrade()
        {
            return dal.GetAllGrade();
        }       
        /// <summary>
        /// ���꼶���л�ò��ظ������п�ע���꼶
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllRegGrade()
        {
            return dal.GetAllRegGrade();
        }

        /// <summary>
        /// ѧ���꼶�б�ר�ã���ʾ�̹����꼶����ǰ�༶�б��е��꼶
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllCourseGrade()
        {
            return dal.GetAllCourseGrade();
        }

        /// <summary>
        /// ���ָ��Rhid�İ༶�����б�(Rgrade,Rclass
        /// </summary>
        public DataTable GetMyGradeClass(int Rhid)
        {
            return dal.GetMyGradeClass(Rhid);
        }
        /// <summary>
        /// ���꼶���л�ò��ظ��İ༶
        /// </summary>
        /// <returns></returns>
        public DataSet GetClass()
        {
            return dal.GetClass();
        }

        /// <summary>
        /// �������б����ѡȡ�꼶�����»�ò��ظ��İ༶,�������̰༶
        /// </summary>
        /// <returns></returns>
        public DataTable GetLimitClass(int Rgrade)
        {
            return dal.GetLimitClass(Rgrade).Tables[0];
        }

        /// <summary>
        /// �������б����ѡȡ�꼶�����»�ò��ظ������а༶��������
        /// </summary>
        /// <returns></returns>
        public DataSet GetLimitAllClass(int Rgrade)
        {
            return dal.GetLimitAllClass(Rgrade);
        }                
        /// <summary>
        /// ��ȡ��ע��༶
        /// </summary>
        /// <returns></returns>
        public DataSet GetRegClass(int Rgrade)
        {
            return dal.GetRegClass(Rgrade);
        }
        /// <summary>
        /// ��Ҫ�Ͽΰ༶���ã�����ѧ����ѯ�˺ţ�������������(6λ)
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public string TeachingRoomSet(int Rhid, int Rgrade, int Rclass, int pwdlen)
        {
            return dal.TeachingRoomSet(Rhid, Rgrade, Rclass, pwdlen);
        }

        /// <summary>
        /// �����꼶��Χ�Ͱ༶���ֵ��ѭ���������а༶��
        /// </summary>
        /// <param name="RgradeMin"></param>
        /// <param name="RgradeMax"></param>
        /// <param name="RclassMax"></param>
        public void CreateRoom(int RgradeMin, int RgradeMax, int RclassMax)
        {
            dal.CreateRoom(RgradeMin, RgradeMax, RclassMax);
        }


        /// <summary>
        /// ��ѯ�༶���м�¼��
        /// </summary>
        /// <returns></returns>
        public int GradeCount()
        {
            return dal.GradeCount();
        }

        /// <summary>
        /// �����꼶�Ͱ༶����ȡ����
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRoomPwd(int Rgrade, int Rclass)
        {
            return dal.GetRoomPwd(Rgrade, Rclass);
        }
        /// <summary>
        /// �����꼶�Ͱ༶����ȡ��ʦRhid
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRoomRhid(int Rgrade, int Rclass)
        {
            return dal.GetRoomRhid(Rgrade, Rclass);
        }
        /// <summary>
        /// �����̵ĵ�ǰ�Ͽΰ༶��Ϊ���Ͽ�
        /// </summary>
        /// <param name="Rhid"></param>
        public void UnlineClass(int Rhid)
        {
            dal.UnlineClass(Rhid);
        }

        /// <summary>
        /// ��ѯ��ǰ�Ͽΰ༶������ѧ��ѧ��
        /// </summary>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public ArrayList GetCurrentClassSnum(int Rhid)
        {
            return dal.GetCurrentClassSnum(Rhid);
        }
        /// <summary>
        /// ��ѯ�ð༶������ѧ��ѧ��
        /// </summary>
        /// <param name="Sgrade"></param>
        /// <param name="Sclass"></param>
        /// <returns></returns>
        public ArrayList GetGradeClassSnum(int Sgrade, int Sclass)
        {
            return dal.GetGradeClassSnum(Sgrade, Sclass);
        }
        /// <summary>
        /// �༶ѧ����¼IP����ȡ��
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public void UpdateLock(int Rgrade, int Rclass, bool Rlock)
        {
            dal.UpdateLock(Rgrade, Rclass, Rlock);
        }
        /// <summary>
        /// ���ݱ��ֶθ���ʱ��
        /// </summary>
        public void InitLock()
        {
            dal.InitLock();
        }

        /// <summary>
        /// �жϸð༶�ĵ�¼IP�Ƿ���������������򷵻���
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public bool IsLoginLock(int Rgrade, int Rclass)
        {
            return dal.IsLoginLock(Rgrade, Rclass);
        }
        /// <summary>
        /// ��ʼ��
        /// </summary>
        public void UpdateRgauge()
        {
            dal.UpdateRgauge();
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        public void UpdateRgroupMax()
        {
            dal.UpdateRgroupMax();
        }
        public void SetRgroupMax(int Rgrade, int Rclass, int groupMax)
        {
            dal.SetRgroupMax(Rgrade, Rclass, groupMax);
        }
        public int GetRgroupMax(int Rgrade, int Rclass)
        {
            return dal.GetRgroupMax(Rgrade, Rclass);
        }

        /// <summary>
        /// ��ѯ�Ƿ����ν̰༶
        /// </summary>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public bool ExistMyClass(int Rhid)
        {
            return dal.ExistMyClass(Rhid);
        }

        public void SetRclassedit(int Rgrade, int Rclass, bool Rclassedit)
        {
            dal.SetRclassedit(Rgrade, Rclass, Rclassedit);
        }

        public void SetRphotoedit(int Rgrade, int Rclass, bool Rphotoedit)
        {
            dal.SetRphotoedit(Rgrade, Rclass, Rphotoedit);
        }


        public void SetRsexedit(int Rgrade, int Rclass, bool Rsexedit)
        {
            dal.SetRsexedit(Rgrade, Rclass, Rsexedit);
        }

        public void SetRreg(int Rgrade, int Rclass, bool Rreg)
        {
            dal.SetRreg(Rgrade, Rclass, Rreg);
        }

        public void SetRnameedit(int Rgrade, int Rclass, bool Rnameedit)
        {
            dal.SetRnameedit(Rgrade, Rclass, Rnameedit);
        }

        public bool GetRclassedit(int Rgrade, int Rclass)
        {
            return dal.GetRclassedit(Rgrade, Rclass);
        }
        public bool GetRphotoedit(int Rgrade, int Rclass)
        {
            return dal.GetRphotoedit(Rgrade, Rclass);
        }
        public bool GetRsexedit(int Rgrade, int Rclass)
        {
            return dal.GetRsexedit(Rgrade, Rclass);
        }
        public bool GetRnameedit(int Rgrade, int Rclass)
        {
            return dal.GetRnameedit(Rgrade, Rclass);
        }

        /// <summary>
        /// ���༶�����Ͽε�ѧ����ű�־
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rcid"></param>
        public void UpdateRcid(int Rgrade, int Rclass, int Rcid)
        {
            dal.UpdateRcid(Rgrade, Rclass, Rcid);
        }
        /// <summary>
        /// ��ȡ�ð༶��ǰ�Ͽ�ѧ���ı��
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRcid(int Rgrade, int Rclass)
        {
            return dal.GetRcid(Rgrade, Rclass);
        }

        /// <summary>
        /// ����Ropen
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Ropen"></param>
        public void UpdateRopen(int Rgrade, int Rclass, bool Ropen)
        {
            dal.UpdateRopen(Rgrade, Rclass, Ropen);
        }
        /// <summary>
        /// �ж��ǲ��ǹ�����ģʽ
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public bool IsRopen(int Rgrade, int Rclass)
        {
            return dal.IsRopen(Rgrade, Rclass);
        }

        /// <summary>
        /// �ж��ǲ��ǹ�����ģʽ������Rcid��������ǣ�����""���ַ�
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string IsRopenRcid(int Rgrade, int Rclass)
        {
            return dal.IsRopenRcid(Rgrade, Rclass);
        }
        public int initRshare()
        {
            return dal.initRshare();
        }
        public int initRgroupshare()
        {
            return dal.initRgroupshare();
        }
        public void initRpwdsee()
        {
            dal.initRpwdsee();
        }
                
        /// <summary>
        /// ����Rshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rshare"></param>
        public void UpdateRshare(int Rgrade, int Rclass, bool Rshare)
        {
            dal.UpdateRshare(Rgrade, Rclass, Rshare);
        }       
        /// <summary>
        /// ����Rgroupshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rgroupshare"></param>
        public void UpdateRgroupshare(int Rgrade, int Rclass, bool Rgroupshare)
        {
            dal.UpdateRgroupshare(Rgrade, Rclass, Rgroupshare);
        }
        /// <summary>
        /// �ж��Ƿ���Rshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public bool IsRshare(int Rgrade, int Rclass)
        {
            return dal.IsRshare(Rgrade, Rclass);
        }                
        /// <summary>
        /// �ж��Ƿ���Rgroupshare
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public bool IsRgroupshare(int Rgrade, int Rclass)
        {
            return dal.IsRgroupshare(Rgrade, Rclass);
        }
        /// <summary>
        /// ����Rpwdsee
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <param name="Rpwdsee"></param>
        public void UpdateRpwdsee(int Rgrade, int Rclass, bool Rpwdsee)
        {
            dal.UpdateRpwdsee(Rgrade, Rclass, Rpwdsee);
        }
        /// <summary>
        /// �ж��Ƿ�༶����ɲ�Rpwdsee
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        public bool IsRpwdsee(int Rgrade, int Rclass)
        {
            return dal.IsRpwdsee(Rgrade, Rclass);
        }
        /// <summary>
        /// ��ȡ�꼶���Ĵ�������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public string GetRtyper(int Rgrade, int Rhid)
        {
            return dal.GetRtyper(Rgrade, Rhid);
        }                
        /// <summary>
        /// ��ȡ�༶���Ĵ�������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRtyperByClass(int Rgrade, int Rclass)
        {
            return dal.GetRtyperByClass(Rgrade, Rclass);
        }
        /// <summary>
        /// ���������꼶���Ĵ���ָ������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rtyper"></param>
        /// <param name="Rhid"></param>
        public void SetRtyper(int Rgrade, string Rtyper, int Rhid)
        {
            dal.SetRtyper(Rgrade, Rtyper, Rhid);
        }


        /// <summary>
        /// ��ȡ�꼶ƴ�������������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rhid"></param>
        /// <returns></returns>
        public string GetRchinese(int Rgrade, int Rhid)
        {
            return dal.GetRchinese(Rgrade, Rhid);
        }
        /// <summary>
        /// ��ȡ�༶ƴ�������������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rclass"></param>
        /// <returns></returns>
        public string GetRchineseByClass(int Rgrade, int Rclass)
        {
            return dal.GetRchineseByClass(Rgrade, Rclass);
        }
        /// <summary>
        /// ���������꼶ƴ���������ָ������
        /// </summary>
        /// <param name="Rgrade"></param>
        /// <param name="Rchinese"></param>
        /// <param name="Rhid"></param>
        public void SetRchinese(int Rgrade, string Rchinese, int Rhid)
        {
            dal.SetRchinese(Rgrade, Rchinese, Rhid);
        }
        /// <summary>
        /// ��ʼ���ֶ�Ĭ��Ϊ0
        /// </summary>
        public void initRreg()
        {
            dal.initRreg();
        }

        public bool IsRscratch(int Rgrade, int Rclass)
        {
           return dal.IsRscratch(Rgrade, Rclass);
        }

        public void updateRscratch(int Rgrade, int Rclass, bool Rscratch)
        {
            dal.updateRscratch(Rgrade, Rclass, Rscratch);
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

