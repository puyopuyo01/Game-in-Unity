using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;
using B;

namespace B{
	public partial class BattleState : MonoBehaviour {
		public class Act_Selection:Battle{
			public Text te;
			public Text tt;

			public String ID{
				get{return "select";}
			}
			
			public Act_Selection(){

				}

			public Battle update(){
				if(AP_Player.Determination==null){
					return update();
				}
				text_one=ID;
				if(AP_Player.Determination!=null){
					return active;
				}
				return update();

				
			}	
		}
	}
}
