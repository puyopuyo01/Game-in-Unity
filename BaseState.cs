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

	public class BaseState : MonoBehaviour {
		public Text tex;
		// Use this for initialization
		public int Timmer (int time) {
			this.tex.text = time.ToString();
			var timer = new System.Timers.Timer(1000);
			timer.Elapsed += (sender,e) =>{
				tex.text=time.ToString();
				if(time==0){
					this.tex.text=time.ToString();
					timer.Stop();
					
					}
				else{
					time--;
					this.tex.text=time.ToString();
					}
					};
					return time;
				}
			}
	}
