using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;
using B;

namespace B{
	public partial class BattleState : MonoBehaviour {
		public partial class Activity:Battle{
			public Battle NextState;
			public Win_Lose Winner;
			public Win_Lose Loser;
			public static Winner_Loser Win=new Win();
			public static Winner_Loser Lose=new Lose();
			public static Winner_Loser Draw=new Draw();
			public static Winner_Loser Draw_Win=new Draw_Win();
			private static Winner_Loser Draw_Lose=new Draw_Lose();
			public Judge AP_Judge;
			public Judge BP_Judge;
			public Player_Judge AAP,BBP;
			public Text t;
			private Dictionary<String,Winner_Loser> JudgeMent=new Dictionary<String,Winner_Loser>()
			{
				{"WIN",Win},
				{"LOSE",Lose},
				{"DRAW",Draw},
				{"DRAW_WIN",Draw_Win},
				{"DRAW_LOSE",Draw_Lose},
			};
			
			public String ID{
				get{return "act";}
			}		
			public Activity(){
			}
			
			public Battle update(){
				text_one=ID;
				this.JudgeMent[AP_Player.Determination.win_or_lose(BP_Player.Determination,AP_Player.Force,BP_Player.Force)].Win_Lose_Process(AP_Player.Chara,BP_Player.Chara);
				return nextjudge;
			}

		}
	}
}