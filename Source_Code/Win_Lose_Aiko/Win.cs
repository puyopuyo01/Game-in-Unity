using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using State;

/*相性での勝利をしたときに行う処理*/
namespace Win_Lose{
	public class Win :W_L,Winner_Loser{
		public Win(){
			result="相性勝ち";
		}
		
		public void Win_Lose_Process(Player_Status me,Player_Status enem){
			process(me,enem);
		} 
		
		protected void process(Player_Status me,Player_Status enem){
			enem.HP-=me.RATE;
			Add(me,add_fatigue,add_injury,add_HP);
			Add(enem,add_fatigue_enem,add_injury_enem,add_damage_enem);
		}

	}
}
