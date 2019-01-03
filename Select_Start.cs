using B;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.IO;
using System.Linq;


namespace B{
	public partial class BattleState : MonoBehaviour {
		public class Select_Start : Battle {
			public Player_Judge AP,BP;
			public Task[] task = new Task[2];
			public int time = 10;
			public Text te;
			public Text ttt;

			public String ID{
				get{return "Select_Start";}
			}

			public Select_Start(){
				text_one=ID;
			}
			
			public Battle update(){
				var timer = new System.Timers.Timer(1000);
				timer.Elapsed += (sender,e) =>{
					if(stime==0){ timer.Stop(); }
					else if(stime==10){ InputWait(); stime--; }
					else{ stime--; }
						};
				timer.Start();
				return actselect;
			}
			
			private async void InputWait(){
				AP_Player.Determination=await AP_Player.select();
				BP_Player.Determination=await BP_Player.select();
			}
			
		}
	}
}
