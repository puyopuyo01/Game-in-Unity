using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using State;

namespace Win_Lose{
	public class Lose :W_L,Winner_Loser{
		public Lose(){
			result="相性負け";
		}

		public void Win_Lose_Process(Player_Status me,Player_Status enem){
			me.determ.injury+=2;
			Add(me,add_fatigue,add_injury,add_HP);
			Add(enem,add_fatigue_enem,add_injury_enem,add_damage_enem);
		}
		
	}
}
