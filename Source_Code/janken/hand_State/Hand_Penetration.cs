using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Win_Lose;

namespace Hand{
	public class Hand_Penetration : Common_Decision,Hand_State{
	
	
		public Hand_Penetration(Judge My_Judge):base(My_Judge,"魔力勝ち","魔力負け"){
		}
		
		public Hand_Penetration(){
		}
		
		public int State_ID{
			get{return 3;}
		}
		
		public string Name{
			get{return "貫通";}
		}
		
		public Winner_Loser Judgement(Judge Enemy){
			Winner_Loser winner=Judgement_Base(Enemy);
			if(winner.Result=="魔力負け"){
				winner=new Peneration_Lose();
			}
			return winner;
		}

		public Hand_State Clone(Judge judge){
			return new Hand_Penetration(judge);
		}

	}
}
