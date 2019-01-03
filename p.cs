using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using B;

namespace B{


	public class p : select_type,Judge {


			public p(){
					ID=4;
			}
			
			
			
			public string win_or_lose(Judge judge,int a_force,int b_force){
				return base.w_l(judge,a_force,b_force,1,3);
			
			}

	}
	
}
