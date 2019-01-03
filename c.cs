using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace B{
	public class c : select_type,Judge {
		
			public c(){
				base.ID=1;
			}
			public string win_or_lose(Judge judge,int a_force,int b_force){
				return base.w_l(judge,a_force,b_force,2,4);
		
		}

}
}
