using System;
namespace LearnSite.Model
{
	/// <summary>
	/// Ip:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class Ip
	{
		public Ip()
		{}
		#region Model
		private int _iid;
		private int? _ihid;
		private int? _inum;
		private string _iip;
		/// <summary>
		/// 
		/// </summary>
		public int Iid
		{
			set{ _iid=value;}
			get{return _iid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Ihid
		{
			set{ _ihid=value;}
			get{return _ihid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Inum
		{
			set{ _inum=value;}
			get{return _inum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Iip
		{
			set{ _iip=value;}
			get{return _iip;}
		}
		#endregion Model

	}
}

