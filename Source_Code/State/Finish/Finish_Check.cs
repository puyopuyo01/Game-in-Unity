using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;

namespace Finish_Game{
/*試合が終了したか判定するクラス。*/
	public class Finish_Check:Battle{
		Battle next;
		public Finish_Check(Battle next){
			this.next=next;
		}
		
		public void init(){
		}
		
		public Battle update(){
			if(BattleState.turn==15){
				if(BattleState.First_Player.HP>BattleState.Second_Player.HP){
					return new Win_Game(BattleState.First_Player.image);
				}
				else{
					return new Lose_Game(BattleState.Second_Player.image);
				}
			}
			if(BattleState.First_Player.HP==0){
					return new Lose_Game(BattleState.Second_Player.image);
			}
			if(BattleState.Second_Player.HP==0){
				return new Win_Game(BattleState.First_Player.image);
			}
			next.init();
			return next;
		}
	}		
}
