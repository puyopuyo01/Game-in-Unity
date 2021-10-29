using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Schemes;
using button;
using Flag;
using Character;

namespace Handle{

	public class Scheme_Enemy : Scheme_Handler{
		Battle battle;
		Scheme scheme;
		Selection_Scheme_create Scheme;
		List<Scheme> list;
		Player_Status player;
		
		public Scheme_Enemy(Player_Status player,Scheme scheme){
			this.player=player;
			this.scheme=scheme;
		}
		
		public void init(Battle prev,Battle next){
			battle=next;
		}
		
		public void receive_scheme(List<Scheme> list){
			this.list=list;
		}
		
		
		public Battle update(){
			if(player.Morale>=scheme.morale){
				two_flag animation=new two_flag();
				animation.init();
				new create_Scheme_stage(animation,scheme.Name,scheme.disc_stage,player);
				scheme.scheme();
				return new Wait_anim(battle,animation as inter_Animation);
			}
			battle.init();
			return battle;
		}
	}
}
