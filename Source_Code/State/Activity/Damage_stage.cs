using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Flag;


namespace State{
/*内部で処理したダメージ等のじゃんけんの結果を画面に反映させる処理をするクラス。*/
	public class Damage_stage :Battle
	{
		Battle next;
		two_flag strength;
		
		
		public void init(){
		}
		
		public Damage_stage(Battle next){
			this.next=next;
			strength=new two_flag();
			strength.init();
		}
		
		public Battle update(){
			Battle battle=new Wait_anim(next,strength as inter_Animation);
			GameObject.Find("firstbar").GetComponent<Bar>().set(strength,BattleState.First_Player.HP,0);
			GameObject.Find("secondbar").GetComponent<Bar>().set(strength,BattleState.Second_Player.HP,1);
			return battle;
		}
	}
}
