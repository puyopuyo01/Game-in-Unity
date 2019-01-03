using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using B;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;


namespace B{

	public interface Player_Judge{
			Task<Judge> select();
			Win_Lose Chara
			{
				get;
				set;
			}
			
			Judge Determination
			{
				get;
				set;
			}
			
			int Force{
				get;
			}
		}


	public class Player : Player_model,Player_Judge { // プレイヤーの場合
	
		public Player(string name){
			Chara=base.character[name];
			base.judge[0]=new c();
			base.judge[1]=new c();
			Determination=null;
		}

		public async Task<Judge> select(){
			while(BattleState.stime>0){
				if(Input.GetKeyDown(KeyCode.LeftArrow)){
					return base.judge[0];
				}
					
				if(Input.GetKeyDown(KeyCode.RightArrow)){
					return base.judge[1];
				}
			}				
			return base.judge[1];
			}
		
		
		
	}

	public class Enemy :Player_model,Player_Judge{	// CPUの場合
	
		public Enemy(string name){
			Chara=base.character[name];
		}

		public async Task<Judge> select(){
			return base.judge[0];

		}
		
	}



}
