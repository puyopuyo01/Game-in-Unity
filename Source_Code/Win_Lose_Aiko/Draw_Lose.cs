using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using State;


namespace Win_Lose{
	public class Draw_Lose :W_L,Winner_Loser{

		public Draw_Lose(string res){
			result=res;
		}
		public virtual void Win_Lose_Process(Player_Status me,Player_Status enem){
			process(me,enem);
		}
		
		protected void process(Player_Status me,Player_Status enem){
			me.determ.injury++;
			Add(me,add_fatigue,add_injury,add_HP);
			Add(enem,add_fatigue_enem,add_injury_enem,add_damage_enem);
		}
		
		
	}

}
