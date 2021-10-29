using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Win_Lose;

namespace Hand{
	public class Hand_Offensive : Common_Decision,Hand_State{
		int Damage;
	
		public Hand_Offensive(Judge My_Judge,int damage):base(My_Judge){
			Damage=damage;
		}
		
		public Hand_Offensive(int damage){
			Damage=damage;
		}
		
		public int State_ID{
			get{return 4;}
		}
		
		public string Name{
			get{return "攻勢";}
		}
		
		public Winner_Loser Judgement(Judge Enemy){
			Winner_Loser winner=Judgement_Base(Enemy);
			if(winner.Result=="魔力勝ち"||winner.Result=="相性勝ち"){
				winner.Add_Value(0,0,0,0,0,Damage);
			}
			return winner;
		}
		
		public Hand_State Clone(Judge judge){
			return new Hand_Offensive(judge,Damage);
		}

	}
}