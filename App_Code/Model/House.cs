using System;
namespace LearnSite.Model
{
	/// <summary>
	/// House:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class House
	{
		public House()
		{}
		#region Model
		private int _hid;
		private string _hname;
		private string _hseat;
		/// <summary>
		/// 
		/// </summary>
		public int Hid
		{
			set{ _hid=value;}
			get{return _hid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Hname
		{
			set{ _hname=value;}
			get{return _hname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Hseat
		{
			set{ _hseat=value;}
			get{return _hseat;}
		}
		#endregion Model

	}
}

