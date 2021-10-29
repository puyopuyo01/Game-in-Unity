using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;

//「負傷」状態の処理
namespace Win_Lose{
	public class injury_Lose :W_L,Winner_Loser{

		public injury_Lose(){
			result="負傷";
		}
		public void Win_Lose_Process(Player_Status me,Player_Status enem){
			me.HP-=200;
		} 
		
	}

}
