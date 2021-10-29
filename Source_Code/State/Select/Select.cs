using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Handle;
using Character;

namespace State{
	public class Select:Battle{
		Select_Handler select_handler;
		Battle next;
		
		public Select(Battle next,Player_Status player){
			select_handler=player.Play_Handler.select();
			init();
			this.next=next;
		}
		
		public void init(){
			select_handler.init();
		}
		
		
		public Battle update(){
			return select_handler.update(this,next);
		}
	}
}