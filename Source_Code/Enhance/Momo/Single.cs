using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Hand;

namespace Character{

	public class Single : Enhance_Base,EnhanceMent {
	
 		public Single(){
 			Cost=1;
 			name="魔力上昇(単体)";
 			discription="選択した属性のの魔力+4";
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			me.determ.pass_force+=4;
			
		}

	}
}
