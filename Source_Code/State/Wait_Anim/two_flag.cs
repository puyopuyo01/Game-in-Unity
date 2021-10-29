using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flag{
	public class two_flag  : inter_Animation{
		public bool first_notif;
		public bool second_notif;
		public void init(){
			first_notif=false;
			second_notif=false;
		}
		
		public bool Check_Anim_Finish(){
			if(first_notif && second_notif){
				return true;
			}
			return false;
		}
	}
}
