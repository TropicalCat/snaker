using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snaker.Service.Core
{
	public class GlobaleEvent 
	{
		public static ModuleEvent<bool> onLogin = new ModuleEvent<bool>();
		public static ModuleEvent<bool> onPay = new ModuleEvent<bool>();
	}
}



