using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using button;
using State;
using Character;

namespace Handle{
public class Select_Enemy : Select_Handler
	{
			Select_Button_create button;
			Player_Status player;
			Switch_button switch_button;
			
			public Select_Button_create sel_button{
				get{return button;}
			}
			
			public Select_Enemy(Player_Status player){
				this.player=player;
			}
			
			public void init(){
			}
			
			public void next_game(){
				button.notif();
			}
			
			public void create(Vector3 v){
				button=new Select_Button_create(v,player);
				switch_button=button as Switch_button;
			}
			
			public Battle update(Battle prev,Battle next){	/*敵の選択する手は完全ランダム*/
				System.Random rnd=new System.Random();
				player.determ=player.wait_sel[rnd.Next(player.wait_sel.Count)];
				next.init();
				return next;
			}
			
	}
}
