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

		public class Select_NextJudge : Battle{

			public Select_NextJudge(){
			}
			public String ID{
				get{return "end";}
			}
			public Battle update(){
				text_one=ID;
				return nextjudge;
			
			}
	}


		}
}
