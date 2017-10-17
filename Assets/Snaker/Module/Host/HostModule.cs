using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SGF.Module.Framework;
using SGF.UI.Framework;

namespace Snaker.Module
{
	public class HostModule : BusinessModule 
	{

		private ModuleEvent onStartServer;
		private ModuleEvent onCloseServer;

		public override void Create(object args)
		{
			base.Create (args);
			onStartServer = Event ("onStartServer");
			onCloseServer = Event ("onCloseServer");
		}
			
		protected override void Show(object arg)
		{
			UIManager.Instance.OpenPage (UIDef.UIHostWnd);
		}


	}
}
