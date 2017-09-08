using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SGF;

namespace SGF.UI.Framework
{
	public abstract class UIPanel : MonoBehaviour
	{
		
		public virtual void Open(object arg = null)
		{
			this.Log ("Open() arg:{0}", arg);
		}

		public virtual void Close(object arg = null)
		{
			this.Log ("Close() arg:{0}", arg);
		}

		/// <summary>
		/// 当前UI是否打开
		/// </summary>
		/// <value><c>true</c> if this instance is open; otherwise, <c>false</c>.</value>
		public bool IsOpen { get { return this.gameObject.activeSelf; } }

		/// <summary>
		/// 当UI关闭时，会响应这个函数
		/// 该函数在重写时，需要支持可重复调用
		/// </summary>
		/// <param name="arg">Argument.</param>
		protected virtual void OnClose(object arg = null)
		{
			this.Log ("OnClose()");
		}

		/// <summary>
		/// 当UI打开时，会响应这个函数
		/// </summary>
		protected virtual void OnOpen(object arg = null)
		{
			this.Log ("OnOpen()");
		}

	}
}

