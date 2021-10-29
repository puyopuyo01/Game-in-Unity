using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hand{
/*状態の説明テキストを管理するクラス*/
	public static class State_discription{
		static Dictionary<string,TextAsset> state=new Dictionary<string,TextAsset>()
		{
			{"penetration",Resources.Load("State_Disc/penet")as TextAsset},
			{"slash",Resources.Load("State_Disc/slash")as TextAsset},
			{"offensive",Resources.Load("State_Disc/offensive")as TextAsset},
			{"awakening",Resources.Load("State_Disc/awake")as TextAsset},
		};
		public static string discription(string ID){
			return state[ID].text;
		}
	}
}
