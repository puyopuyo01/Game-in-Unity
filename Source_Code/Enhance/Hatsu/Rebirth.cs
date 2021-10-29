using System.Collections;
using System.Collections.Generic;
using Hand;
using UnityEngine;

namespace Character{

	public class Rebirth : Enhance_Base,EnhanceMent,limit {
		static bool available;
 		public Rebirth(){
 			Cost=1;
 			name="起死回生";
 			discription="「負傷」状態の属性を「正常」にする。\nこのエンハンスは1度しか使えない。";
		}
		
		public static void init_limit(){
			available=true;
		}
		
		public void enhance(Player_Status me,Player_Status enem){
			available=false;
			foreach(Judge judge in me.hand){
				if(judge.state_id==2){ judge.Stack(new Hand_Normal(judge));}
			}
			
		}
		
		public bool Available{
			get{return available;}
		}

	}
}
