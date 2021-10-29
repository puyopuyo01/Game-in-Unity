using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hand;
using Character;
using System.Linq;
using continuate;

namespace Schemes{

	public class Awakening : continuation_base,Scheme,continuation{
		public string Name{
			get{return "覚醒魔法";}
		}
		
		public string discription{
			get{return "5ターンの間、全属性を「覚醒」状態にする。\n" + State_discription.discription("awakening");}
		}
		
		public string disc_stage{
			get{return "5ターンの間、全属性を「覚醒」状態にする。";}
		}
		public int morale{
			get{return 7;}
		}
		
		public Awakening(Player_Status me){
			finish=false;
			elapsed=0;
			player=me;
		}
		
		public void scheme(){
			player.scheme_use.Add(this);
			Hand_Stack_All(new Hand_Awakening());
			player.Morale-=morale;
		}
		
		public void update_scheme(){
			elapsed++;
			if(elapsed>=5){
				finish=true;
				Hand_Pop_All();
				
			}
		}
		
		public bool Finish{
			get{return finish;}
		}
	}
}
