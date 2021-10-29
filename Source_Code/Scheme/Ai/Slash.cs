using System.Collections;
using System.Collections.Generic;
using System;
using Character;
using UnityEngine;
using Hand;

namespace Schemes{

	public class Slash :Scheme{
		Judge judge;
		Player_Status player;
		public string Name{
			get{return "斬撃魔法";}
		}
		
		public string discription{
			get{ 
				return "選択した属性の魔力値を上げ、状態を「斬撃」にする。\n" + State_discription.discription("slash");
			}
		}
		
		public string disc_stage{
			get{return "選択した属性の魔力値を上げ、状態を「斬撃」にする。";}
		}
		
		public int morale{
			get{return 3;}
		}
		
		public Slash(Player_Status me,Judge judge){
			this.judge=judge;
			player=me;
		}
		
		public void scheme(){
			judge.pass_force+=3;
			judge.Stack(new Hand_Slash(judge));
			player.Morale-=morale;
		}
	}
}
