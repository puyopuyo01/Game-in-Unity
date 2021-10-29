using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Schemes;
using button;
using Character;

namespace Handle{
	public class Scheme_Player :Scheme_Handler,Dest_Button,Check_Observer
	{
		Battle battle;
		Battle prev;
		Battle next;
		Scheme_Button_create button;
		Selection_Scheme_create Scheme;
		List<Scheme> list;
		Player_Status player;
		
		public Scheme_Player(Player_Status player){
			this.player=player;
		}
		
		public void init(Battle prev,Battle next){
			this.prev=prev;
			this.next=next;
			button=new Scheme_Button_create(this);
			battle=prev;
		}
		
		public void receive_scheme(List<Scheme> list){	/*このクラスの生成時に、使用できる必殺技が確認できないため関数で後で必殺技を受け取る。*/
			this.list=list;
		}
		
		public void OK(){	//選択完了。次のゲームフローを返す。
			destroy();
			battle=new Scheme_Select(list,next,player);
			battle.init();
			
		}
		
		public void No(){
			destroy();
			battle=next;
			battle.init();
		}

		public void destroy(){
			button.Dest();
		}
		
		public Battle update(){
			return battle;
		}

	}
}
