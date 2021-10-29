using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using button;
using Hand;
using Character;

namespace Handle{

	public class Choice_Player : Next_Choice_Handler,Dest_Button,Observe_Choice{
	
		Player_Status operate;
		create_button button;
	
		public Choice_Player(Player_Status operate){
			this.operate=operate;
		}
		
		public void init(Player_Status enemy){
		}
		public void init(){
			operate.sel_refresh();
			button=new create_button(this,100,operate.hand); //ボタン生成するとき100ピクセルずつ間隔をあける。
			operate.Sel_Next=new List<Judge>();
		}
		
		public void next_choice(){
		}
	
		public void notif(Judge judge){
			operate.Sel_Next.Add(judge);
		}
	
		public void destroy(){
			button.Dest();
		}
		
		public Battle update(Battle prev,Battle next){
			if(operate.Sel_Next.Count==3){
				return new Next_State_Check(prev,this as Dest_Button,next);
			}
			
			return prev;
		}


	}
	
}
