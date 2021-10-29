using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using button;
using Flag;
using Schemes;
using Character;

namespace State{
	public interface Scheme_Observer{
		void OK(Scheme scheme);
		void No();
	}
	/*必殺技を使用するか確認するクラス。*/
	public class Scheme_Select : Battle,Dest_Button,Scheme_Observer{
		Selection_Scheme_create selection;
		Battle battle;	//決定された状態。update処理でthisかnextを返す。
		Battle next; 
		Player_Status player;
		
		public Scheme_Select(List<Scheme> available,Battle next,Player_Status player){
			selection=new Selection_Scheme_create(this,available);
			this.next=next;
			battle=this;
			this.player=player;
		}
		
		public void OK(Scheme scheme){	//必殺技を選択したときの処理。必殺技を実行
			destroy();
			two_flag animation=new two_flag();
			animation.init();
			new create_Scheme_stage(animation,scheme.Name,scheme.disc_stage,player);
			scheme.scheme();
			battle=new Wait_anim(next,animation as inter_Animation);
		}
		
		public void No(){
			destroy();
			battle=next;
			next.init();
		}
		
		public void destroy(){
			selection.Dest();
		}
		
		public void init(){
			
		}
		
		public Battle update(){
			return battle;
		}
	}	
}