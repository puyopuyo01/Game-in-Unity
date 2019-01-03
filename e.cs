using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using B;

namespace B{

	public class e : select_type,Judge{

		
		public e(){;
			ID=2;
		}
		
		
		public string win_or_lose(Judge judge,int a_force,int b_force){
			return base.w_l(judge,a_force,b_force,3,1);
		
		}

	}
}
