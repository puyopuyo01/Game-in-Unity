using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Flag;

namespace State{
/*アニメーション終了待ちクラス*/
	public class Wait_anim: Battle{
		inter_Animation now_anim;
		Battle next;
		public Wait_anim(Battle next,inter_Animation now_anim){
			this.next=next;
			this.now_anim=now_anim;
		}
		
		public void init(){
		}
		
		
		public Battle update(){
			
			if(now_anim.Check_Anim_Finish()){
				next.init();
				return next;
			}
			
			return this;
		}
	}
}
