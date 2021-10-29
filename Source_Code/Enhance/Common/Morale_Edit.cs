using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Character{

	public class Morale_Edit : Enhance_Base,EnhanceMent {
	
		public Morale_Edit(){
			Cost=1;
			name="魔力量上昇";
			discription="魔力量+1";
		}

		
		public void enhance(Player_Status me,Player_Status enem){
			me.Morale++;
		
		}
	}
}

