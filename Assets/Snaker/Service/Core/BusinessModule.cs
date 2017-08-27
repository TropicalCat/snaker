using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGF;

namespace Snaker.Service.Core
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

	}
}


