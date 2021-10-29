using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Win_Lose;

namespace Hand{
	public class Hand_Slash : Common_Decision,Hand_State{
	
	
		public Hand_Slash(Judge My_Judge):base(My_Judge,"斬撃","魔力負け"){
		}
		
		public Hand_Slash(){
		}
		
		public int State_ID{
			get{return 3;}
		}
		
		public string Name{
			get{return "斬撃";}
		}
		
		public Winner_Loser Judgement(Judge Enemy){
			Winner_Loser winner=Judgement_Base(Enemy);
			if(winner.Result=="斬撃"){
				winner.Add_Value(0,0,0,1,0,0);
			}
			return winner;
		}
		
		public Hand_State Clone(Judge judge){
			return new Hand_Slash(judge);
		}

	}
}