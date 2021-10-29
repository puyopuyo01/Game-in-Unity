using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using continuate;
using Hand;

namespace Character{

	public class Sendan : Enhance_Base,EnhanceMent,continuation,limit {
		static bool available;
		bool finish;
		int elapsed;
		Player_Status player;
 		public Sendan(){
 			Cost=1;
			finish=false;
			elapsed=0;
 			name="栴檀双葉";
 			discription="全属性の魔力を+5。ただしターン毎に全属性の魔力が減少する。(3ターン)\nこのエンハンスは1度しか使えない。";
		}
		
		public static void init_limit(){
			available=true;
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			me.enhance_use.Add(this);
			available=false;
			foreach(Judge judge in me.hand){
				judge.pass_force+=5;
			}
			player=me;
			
		}
		
		public void update_scheme(){
			elapsed++;
			if(elapsed>3){
				finish=true;
				return ;
			}
			foreach(Judge judge in player.hand){
				judge.pass_force--;
			}
			
		}
		
		public bool Finish{
			get{return finish;}
		}
		
		public bool Available{
			get{return available;}
		}

	}
}