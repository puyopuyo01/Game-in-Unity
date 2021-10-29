using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;


/*「貫通」状態の処理*/
namespace Win_Lose{
	public class Peneration_Lose :Draw_Lose,Winner_Loser{
		public Peneration_Lose():base("貫通"){
		}
		
		public override void Win_Lose_Process(Player_Status me,Player_Status enem){
			process(me,enem);
			enem.HP-=50;
			me.determ.fatigue++;
		} 
	}
}
