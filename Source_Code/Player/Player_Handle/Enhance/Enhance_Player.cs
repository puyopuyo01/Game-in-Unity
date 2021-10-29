using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using button;
using State;
using Character;

namespace Handle{
	/*プレイヤーの強化選択を処理するクラス。*/
	public class Enhance_Player : Enhance_Handler,Dest_Button,Observer{
		Player_Status operate;
		Queue<EnhanceMent> queue;
		create_enhance button;
		int remain_cost;
		
		public Enhance_Player(Player_Status opera){
			this.operate=opera;
			queue=new Queue<EnhanceMent>();
			remain_cost=operate.EnhanceCost;
		}
		
		public void init(){
			this.remain_cost=operate.EnhanceCost;
			button=new create_enhance(this,operate.enhance_option()); 
			while(operate.enhance_queue.Count>0){
				operate.enhance_queue.Dequeue();
			}
		}
		
		public void destroy(){
			button.Dest();
		}

		
		public void notification(EnhanceMent enhance,int cost){
			if(this.remain_cost-cost<0){
				return;
			}
			remain_cost-=cost;
			operate.enhance_queue.Enqueue(enhance);
		}
			
		public Battle update(Battle prev,Battle next){
			if(this.remain_cost==0){
				return new Next_State_Check(prev,this as Dest_Button,next);
			}
			return prev;
		}
	}
}
