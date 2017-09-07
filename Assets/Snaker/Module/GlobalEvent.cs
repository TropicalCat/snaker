using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGF.Module.Framework;

namespace Snaker
{
	/// <summary>
	/// 全局事件
	/// 有些事件不确定应该是由谁发出
	/// 就可以通过全局事件来收和发
	/// </summary>
	public class GlobalEvent 
	{
		/// <summary>
		/// true:登录成功，false：登录失败，或者掉线
		/// </summary>
		public static ModuleEvent<bool> onLogin = new ModuleEvent<bool>();



		public static ModuleEvent<bool> onPay = new ModuleEvent<bool>();
	}
}



