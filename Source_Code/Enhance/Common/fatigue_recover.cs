using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Hand;

namespace Character{

	public class fatigue_recover : Enhance_Base,EnhanceMent {
	
 		public fatigue_recover(){
 			Cost=1;
 			name="疲労回復";
 			discription="選択できた属性の疲労度-3";
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			foreach(Judge judge in me.wait_sel){
				judge.fatigue-=3;
			}
			
		}

	}
}
