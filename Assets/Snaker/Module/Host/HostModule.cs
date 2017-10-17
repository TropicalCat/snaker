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
			//显示主机的窗口
			UIManager.Instance.OpenPage (UIDef.UIHostWnd);
		}

		public void StartServer()
		{
//			FSPServer.Instance.Start(0);
//
//			//自定义的游戏参数
//			//比如游戏的地图ID，随机种子，游戏模式等等
//			GameParam gameParam = new GameParam();
//			byte[] customGameParam = PBSerializer.NSerialize(gameParam);
//
//			//将自定义游戏参数传给房间
//			//以便于由房间通知玩家游戏开始时，能够将该参数转发给所有玩家
//			FSPServer.Instance.Room.SetCustomGameParam(customGameParam);
//			FSPServer.Instance.SetServerTimeout (0);
//
//			string ipport = GetRoomIP () + ":" + GetRoomPort ();
//			onStartServer.Invoke (ipport);
		}

		/// <summary>
		/// 关闭服务器
		/// </summary>
		public void CloseServer()
		{
//			FSPServer.Instance.Close();    
//			onCloseServer.Invoke (null);
		}



		/// <summary>
		/// 房间IP
		/// </summary>
		/// <returns></returns>
//		public string GetRoomIP()
//		{
//			return FSPServer.Instance.RoomIP;
//		}

		/// <summary>
		/// 房间Port
		/// </summary>
		/// <returns></returns>
//		public int GetRoomPort()
//		{
//			return FSPServer.Instance.RoomPort;
//		}

		/// <summary>
		/// 帧同步参数
		/// </summary>
		/// <returns></returns>
//		public FSPParam GetFSPParam()
//		{
//			return FSPServer.Instance.GetParam();
//		}





	}
}
