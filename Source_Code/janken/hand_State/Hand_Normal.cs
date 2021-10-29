using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Win_Lose;

namespace Hand{
	public class Hand_Normal : Common_Decision,Hand_State{
	
	
		public Hand_Normal(Judge My_Judge):base(My_Judge,"魔力勝ち","魔力負け"){
		}
		
		public Hand_Normal(){
		}
		
		public int State_ID{
			get{return 1;}
		}
		
		public string Name{
			get{return "正常";}
		}
		
		public Winner_Loser Judgement(Judge Enemy){
			return Judgement_Base(Enemy);
		}
		
		public Hand_State Clone(Judge judge){
			return new Hand_Normal(judge);
		}

	}
}
