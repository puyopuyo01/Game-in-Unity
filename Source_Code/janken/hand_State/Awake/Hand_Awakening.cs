using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Win_Lose;

namespace Hand{
/*じゃんけんの選択肢「覚醒」*/
	public class Hand_Awakening : Common_Decision,Hand_State{
	
	
		public Hand_Awakening (Judge My_Judge):base(My_Judge){
		}
		
		public Hand_Awakening (){
		}
		public int State_ID{
			get{return 4;}
		}
		
		public string Name{
			get{return "覚醒";}
		}
		
		public Winner_Loser Judgement(Judge Enemy){
			Winner_Loser winner=Judgement_Base(Enemy);
			winner.Add_Value(-2,-1,0,0,20,0);
			return winner;
		}
		
		public override int add_force(){
			return 7;
		}
		
		public Hand_State Clone(Judge judge){
			return new Hand_Awakening(judge);
		}

	}
}