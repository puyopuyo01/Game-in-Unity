using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using Hand;

namespace Schemes{

	public class Offensive : Scheme{
		Judge judge;
		Player_Status player;
		public string Name{
			get{return "攻勢魔法";}
		}
		
		public string discription{
			get{return "選択した属性の魔力値を上げ、「攻勢」状態にする。\n"+ State_discription.discription("offensive");}
		}
		
		public string disc_stage{
			get{return "選択した属性の魔力値を上げ、選択した属性を「攻勢」状態にする。";}
		}
		public int morale{
			get{return 3;}
		}
		
		public Offensive(Player_Status me,Judge judge){
			this.judge=judge;
			player=me;
		}
		
		public void scheme(){
			judge.pass_force+=2;
			judge.Stack(new Hand_Offensive(judge,-80));
			player.Morale-=morale;
		}
	}
}
