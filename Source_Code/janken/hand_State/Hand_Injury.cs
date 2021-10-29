using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Win_Lose;

namespace Hand{
	public class Hand_Injury : Common_Decision,Hand_State{
	
		int cont;
		public Hand_Injury(Judge My_Judge):base(My_Judge,"",""){
			cont=0;
		}
		
		public override bool Check_recreate(){
			cont++;
			if(cont>=3){
				return true;
			}
			return false;
		}
		
		public void update_hand(){
			cont++;
		}
		
		public int State_ID{
			get{return 2;}
		}
		
		public string Name{
			get{return "負傷";}
		}
		
		public Winner_Loser Judgement(Judge Enemy){
			return new injury_Lose();
		}
		
		public Hand_State Clone(Judge judge){
			return new Hand_Injury(judge);
		}

	}
}