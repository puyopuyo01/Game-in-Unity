using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hand;
using Character;
using continuate;

namespace Schemes{

	public class Awakening_Sousou : continuation_base,Scheme,continuation{
		int add_force;
		public string Name{
			get{return "連撃魔法";}
		}
		
		public string disc_stage{
			get{return "全属性の魔力値を上げ、8ターンの間「斬撃」状態にする。";}
		}
		
		public string discription{
			get{return "全属性の魔力値を上げ、8ターンの間「斬撃」状態にする。\n"+ State_discription.discription("slash");}
		}
		
		public int morale{
			get{return 7;}
		}
		
		public Awakening_Sousou(Player_Status me,int add){
			finish=false;
			elapsed=0;
			player=me;
			add_force=add;
			
		}
		
		public void scheme(){
			player.scheme_use.Add(this);
			Hand_Stack_All(new Hand_Slash());
			foreach(Judge judge in player.hand){
				judge.pass_force+=add_force;
			}
			player.Morale-=morale;
		}
		
		public void update_scheme(){
			elapsed++;
			if(elapsed>=8){
				finish=true;
				Hand_Pop_All();
			}
		}
		
		public bool Finish{
			get{return finish;}
		}
	}
}
