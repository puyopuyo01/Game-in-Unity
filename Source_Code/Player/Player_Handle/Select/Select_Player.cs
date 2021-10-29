using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using button;
using State;
using Character;

namespace Handle{
	public class Select_Player : Select_Handler{
	
		Select_Button_create button;
		Switch_button switch_button;
		Player_Status player;
		public Select_Button_create sel_button{
			get{return button;}
		}
		
		public Select_Player(Player_Status player){
			this.player=player;
		}
		
		public void init(){
			switch_button.On();
		}
		
		public void next_game(){
			button.notif();
		}
		
		public void create(Vector3 v){
			button=new Select_Button_create(v,player);
			switch_button=button as Switch_button;
		}
		
		public Battle update(Battle prev,Battle next){
			if(player.determ!=null){
				switch_button.Off();
				next.init();
				return next;
			}
			return prev;
		}

	}
}
