using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Linq;
using Hand;

namespace Character{

	public class Force_Each_Edit : Enhance_Base,EnhanceMent {
	
 		public Force_Each_Edit(){
 			Cost=1;
 			name="魔力上昇";
 			discription="選択した属性の魔力値+2\n選択できた属性の魔力値+1";
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			foreach(Judge judge in me.wait_sel){
				judge.pass_force+=1;
			}
			me.determ.pass_force+=1;
			
		}

	}
}
