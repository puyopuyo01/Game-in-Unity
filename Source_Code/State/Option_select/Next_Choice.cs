using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Character;
using Hand;
using Handle;

namespace State{
	public class Next_Choice:Battle{	//次ターンの選択肢を決定するクラス
	
		protected Next_Choice_Handler choice_handler;
		protected Battle next;
		List<Judge> sel=new List<Judge>();
		
		public void init(){
			choice_handler.init();
		}
		
		
		public Next_Choice(Next_Choice_Handler next_choice,Battle next,Player_Status enem){
			choice_handler=next_choice;
			choice_handler.init(enem);
			this.next=next;
		}
		
		public Battle update(){
			return choice_handler.update(this,next);
		}
		
}
}
