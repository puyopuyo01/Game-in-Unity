using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Handle{
	public class Handler_Base{
	/*CPとプレイヤーの共通する変数をまとめた基底クラス*/
		protected Enhance_Handler enh;
		protected Next_Choice_Handler nch;
		protected Scheme_Handler sh;
		protected Select_Handler sel;
		
		
		public Enhance_Handler enhance(){
			return enh;
		}
		
		public Next_Choice_Handler next_choice(){
			return nch;
		}
		
		public Scheme_Handler scheme(){
			return sh;
		}
		
		public Select_Handler select(){
			return sel;
		}
	}
}

