using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Snaker.Service.UserManager.Data;
using SGF.UI.Framework;
using SGF.Module.Framework;
using Snaker.Module;

namespace Snaker.UI.Login
{
	public class UILoginPage : UIPage
	{
		public InputField inputId;
		public InputField inputName;

		protected override void OnOpen(object arg)
		{
			base.OnOpen (arg);
			UserData ud = AppConfig.Value.mainUserData;
			inputName.text = ud.name;
			inputId.text = ud.id.ToString ();
		}

		public void OnBtnLogin()
		{
			uint userId = 0;
			uint.TryParse (inputId.text, out userId);
			string userName = inputName.text.Trim ();
			if (userId == 0) 
			{
				userId = (uint)Random.Range (100000, 999999);
			}

			var module = ModuleManager.Instance.GetModule (ModuleDef.LoginModule) as LoginModule;
			if (module != null)
			{
				module.Login(userId, userName, "");
			}
		}
	

	}
}
