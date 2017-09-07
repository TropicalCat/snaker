using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using SGF;

namespace SGF.Module.Framework
{
	public abstract class BusinessModule : Module
	{
		private string m_name = "";

		public string Name
		{
			get
			{
				if (string.IsNullOrEmpty (m_name)) 
				{
					m_name = this.GetType ().Name;
				}
				return m_name;
			}
		}

		public string Title;


		//===============================================

		public BusinessModule ()
		{
		}

		internal BusinessModule(string name)
		{
			m_name = name;
		}

		//===============================================
		internal void SetEventTable(EventTable tblEvent)
		{
			m_tblEvent = tblEvent;
		}

		private EventTable m_tblEvent;

		public ModuleEvent Event(string type)
		{
			return GetEventTable ().GetEvent (type);
		}

		protected EventTable GetEventTable()
		{
			if (m_tblEvent == null) 
			{
				m_tblEvent = new EventTable ();
			}
			return m_tblEvent;
		}

		//===============================================

		/// <summary>
		/// 当模块收到消息后，对消息进行一些处理
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="args"></param>
		internal void HandleMessage(string msg, object[] args)
		{
			this.Log ("HangleMessage() msg:{0}, args{1} ",msg, args);

			MethodInfo mi = this.GetType ().GetMethod (msg, 
				System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			if (mi != null) 
			{
				mi.Invoke (this, System.Reflection.BindingFlags.NonPublic, null, args, null);
			} 
			else
			{
				OnModuleMessage (msg, args);
			}
		}

		/// <summary>
		/// 由派生类去实现，用于处理消息
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="args"></param>
		protected virtual void OnModuleMessage(string msg, object[] args)
		{
			this.Log ("OnModuleMessage() msg:{0}, args{1} ",msg, args);
		}

		//===============================================

		/// <summary>
		/// 调用它以创建模块
		/// </summary>
		/// <param name="args"></param>
		public virtual void Create(object args = null)
		{
			this.Log ("Create() args = {0}", args);
		}

		/// <summary>
		/// 调用它以释放模块
		/// </summary>
		public override void Release()
		{
			if (m_tblEvent != null) 
			{
				m_tblEvent.Clear ();
				m_tblEvent = null;
			}

			base.Release ();
		}

		/// <summary>
		/// 显示业务模块的主UI
		/// 一般业务模块都有UI，这是游戏业务模块的特点
		/// </summary>
		protected virtual void Show(object arg)
		{
			this.Log("Show() arg:{0}", arg);
		}
	}
}


