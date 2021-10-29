using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Character;

namespace Handle{
	public class Enhance_Enemy : Enhance_Handler{	//強化ターンの敵の動き。固定。
		Player_Status operate;
	
		public Enhance_Enemy(Player_Status opera){
			this.operate=opera;
		}
		
		public void init(){
		}
		public Battle update(Battle prev,Battle next){
			operate.enhance_queue.Enqueue(new Morale_Edit());
			operate.enhance_queue.Enqueue(new Force_Each_Edit());
			next.init();
			return next;
		}
	}
}
