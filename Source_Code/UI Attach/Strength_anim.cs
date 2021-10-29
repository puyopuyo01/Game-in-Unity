using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using Character;
using Flag;

namespace State{

	public class Strength_anim : MonoBehaviour{
	//体力バーの反映処理を行うクラス
		int strength;	//HPを一時保存
		Player_Status player;
		int num;
		int ID;
		two_flag finish;
		
	    
	    public void init(Player_Status player,two_flag finish,int num){
	    	this.player=player;
	    	strength=player.HP;
	    	this.finish=finish;
	    	this.num=num;
	    }

	    public void set(){	/*Unityのアニメーションイベント機能でこの関数を呼び出す。*/
	    	if(this.strength>player.HP){
	    		GetComponent<Animator>().SetBool("decrease",true);
	    	}
	    	else{
	    		finish_notif();
	    	}
			transform.GetChild(0).GetComponent<Slider>().value=player.HP;
	    	this.strength=player.HP;
	    }
	    
		public void finish_notif(){
			if(num==0){ 
				finish.first_notif=true;
			}
			
			if(num==1){
				finish.second_notif=true;
			}
	    	GetComponent<Animator>().SetBool("decrease",false);
		}

	}
}
