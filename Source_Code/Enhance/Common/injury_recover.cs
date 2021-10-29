using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Hand;

namespace Character{

	public class injury_recover : Enhance_Base,EnhanceMent {
	
 		public injury_recover(){
 			Cost=1;
 			name="負傷回復";
 			discription="選択できた属性の負傷度-2";
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			foreach(Judge judge in me.wait_sel){
				judge.injury-=2;
			}
			
		}

	}
}
