using System;
namespace LearnSite.Model
{
    /// <summary>
    /// ʵ����Flection ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
    public class Flection
    {
        public Flection()
        { }
        #region Model
        private int _fid;
        private int? _fcid;
        private int? _fhid;
        private string _fcontent;
        private DateTime? _fdate;
        /// <summary>
        /// 
        /// </summary>
        public int Fid
        {
            set { _fid = value; }
            get { return _fid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Fcid
        {
            set { _fcid = value; }
            get { return _fcid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Fhid
        {
            set { _fhid = value; }
            get { return _fhid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Fcontent
        {
            set { _fcontent = value; }
            get { return _fcontent; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Fdate
        {
            set { _fdate = value; }
            get { return _fdate; }
        }
        #endregion Model
	}
}

