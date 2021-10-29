using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace State{
	public class Enhance_Excution : Battle{		//選択した強化内容を処理する状態クラス。
	
		public void init(){
		}
		
		public Battle update(){
			BattleState.First_Player.enhance_init(BattleState.First_Player,BattleState.Second_Player);
			BattleState.Second_Player.enhance_init(BattleState.Second_Player,BattleState.First_Player);

			while(BattleState.First_Player.enhance_queue.Count!=0){
				BattleState.First_Player.enhance_queue.Peek().enhance(BattleState.First_Player,BattleState.Second_Player);
				BattleState.First_Player.enhance_queue.Dequeue();
			}
			
			
			while(BattleState.Second_Player.enhance_queue.Count!=0){
				BattleState.Second_Player.enhance_queue.Peek().enhance(BattleState.Second_Player,BattleState.First_Player);
				BattleState.Second_Player.enhance_queue.Dequeue();
			}
			Battle battle = new Next_Choice(BattleState.First_Player.Play_Handler.next_choice(),new Next_Choice(BattleState.Second_Player.Play_Handler.next_choice(),new finishturn(),BattleState.First_Player),BattleState.Second_Player);
			battle.init();
			return battle;
		}
}
}
