using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Schemes;
using Hand;
using Character;


namespace continuate{
/*継続効果を持つ必殺技の使用頻度の高い関数をまとめたクラス。*/
	public class continuation_base{
		protected Player_Status player;
		protected bool finish;
		protected int elapsed;
		
		protected void Hand_Stack_All(Hand_State state){
			foreach(Judge judge in player.hand){
				judge.Stack(state.Clone(judge));
			}
		}
		
		protected void Hand_Pop_All(){
			foreach(Judge judge in player.hand){
				if(judge.state_id!=2){
					judge.pop();
				}
			}
		}


	}
}
