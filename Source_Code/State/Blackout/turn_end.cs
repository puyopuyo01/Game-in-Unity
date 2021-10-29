using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using State;

namespace Black_Out{
	public class turn_end : blackout_game{
		public void update(){
	    	BattleState.First_Player.next_game();
	    	BattleState.Second_Player.next_game();
	    	BattleState.turn++;
			GameObject.Find("Turn_num").GetComponent<Text>().text=BattleState.turn.ToString();
			BattleState.reset_information();
			 System.GC.Collect();
			Resources.UnloadUnusedAssets();
		}
	}
}

