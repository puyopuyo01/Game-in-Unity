using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using continuate;
using Hand;

namespace Character{

	public class BigOrgan : Enhance_Base,EnhanceMent,continuation,limit {
		static bool available;
		bool finish;
		int elapsed;
		Player_Status player;
 		public BigOrgan(){
 			Cost=1;
 			finish=false;
 			elapsed=0;
 			name="大器晩成";
 			discription="魔力量+1。\nこのエンハンスを使用してから、経過ターンが偶数の時全属性の魔力を+1する。このエンハンスは1度しか使えない。";
		}
		
		public static void init_limit(){
			available=true;
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			me.enhance_use.Add(this);
			available=false;
			elapsed++;
			me.Morale++;
			player=me;
			
		}
		
		public void update_scheme(){
			if(elapsed%2==0){
				foreach(Judge judge in player.hand){
					judge.pass_force++;
				}
			}
			elapsed++;
		}
		
		public bool Finish{
			get{return finish;}
		}
		
		public bool Available{
			get{return available;}
		}

	}
}
