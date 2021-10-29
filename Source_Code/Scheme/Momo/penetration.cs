using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using Hand;

namespace Schemes{

	public class penetration:Scheme{
		Judge judge;
		Player_Status player;
		public string Name{
			get{return "貫通魔法";}
		}
		
		public string disc_stage{
			get{return "選択した属性の魔力値を上げ、「貫通」状態にする。\n";}
		}
		
		public string discription{
			get{return "選択した属性の魔力値を上げ、「貫通」状態にする。\n" + State_discription.discription("penetration");}
		}
		
		public int morale{
			get{return 2;}
		}
		
		public penetration(Player_Status me,Judge judge){
			this.judge=judge;
			this.player=me;
		}
		
		public void scheme(){
			judge.pass_force+=2;
			judge.Stack(new Hand_Penetration(judge));
			player.Morale-=morale;
		}
	}
}
