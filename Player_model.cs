using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;
using B;

namespace B{

	public class Player_model:MonoBehaviour{
		public Dictionary<String,Win_Lose> character=new Dictionary<String,Win_Lose>()
		{
			{"Man",new Man()},
		};

		public Win_Lose chara;
		public Judge[] judge=new Judge[2];
		public Judge[] nextjudge=new Judge[2];
		
		
		public Win_Lose Chara{
			set{ this.chara=value;}
			get{ return this.chara;}
			}
			
		public Judge Determination{
			set{this.chara.Determination=value;}
			get{return chara.Determination;}
		}
		
		public Win_Lose pass_Character(){
			return this.chara;
		}
		
		public int Force{
			get{return this.chara.Force(Determination.Serch_ID());}
		}
		

		
	}
}