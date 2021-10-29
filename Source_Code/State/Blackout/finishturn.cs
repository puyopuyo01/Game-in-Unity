using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Black_Out;
using Flag;

namespace State{
	public class finishturn : Battle{	//ターン終了のクラス。暗転
		GameObject obj;
		public void init(){
		}
		
		
		public Battle update(){
			one_flag anim=new one_flag();
			anim.init();
			obj=UnityEngine.Object.Instantiate((GameObject)Resources.Load("blackout/Blackout"),new Vector2(0,0),Quaternion.identity);
			obj.GetComponent<blackout>().init(anim,new turn_end());
			return new Wait_anim(new Select(new Select(new Scheme_Check(new Scheme_Check(new Activity(),BattleState.Second_Player,BattleState.First_Player),BattleState.First_Player,BattleState.Second_Player),BattleState.Second_Player),BattleState.First_Player),anim as inter_Animation);
		}
	}
}
