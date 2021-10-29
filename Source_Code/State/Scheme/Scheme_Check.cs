using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Schemes;
using Handle;
using Character;

namespace State{
	public class Scheme_Check:Battle{	//必殺技が使用できるかを確認するクラス
		List<Scheme> scheme_list;
		Battle next;
		Scheme_Handler scheme_handler;
		Player_Status player,enem;

		public Scheme_Check(Battle next,Player_Status player,Player_Status enem){
			this.next=next;
			this.player=player;
			this.enem=enem;
		}
	    public void init(){
			scheme_handler=player.Play_Handler.scheme();
			scheme_list=player.scheme_option(player,enem);
			scheme_list=scheme_list.Where(x => x.morale <= player.Morale).ToList();
	    	if(scheme_list.Count!=0){
	    		scheme_handler.receive_scheme(scheme_list);
				scheme_handler.init(this,next);
	    	}
	    }
	    
	    public Battle update(){
	    	if(scheme_list.Count==0){
	    		next.init();
	    		return next;
	    	}
	    	return scheme_handler.update();
	    }
	}

}
