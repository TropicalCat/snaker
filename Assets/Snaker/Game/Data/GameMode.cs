using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProtoBuf;

namespace Snaker.Game.Data
{
	/// <summary>
	/// 游戏模式
	/// </summary>
	public enum GameMode 
	{
		EndlessPVE,
		TimelimitPVE,
		EndlessPVP,
		TimelimitPVP
	}
}
