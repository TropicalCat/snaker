using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGF.Module.Framework
{
	public class LuaModule : BusinessModule 
	{
		private object m_args = null;

		internal LuaModule(string name) : base(name)
		{
		}

		public override void Create(object args = null)
		{
			base.Create (args);
			m_args = args;

			// todo:加载lua脚本
		}

		public override void Release()
		{
			base.Release ();
			// todo:卸载lua脚本
		}
	}

}

