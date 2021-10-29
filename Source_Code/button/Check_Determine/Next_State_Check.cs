using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using button;

namespace State{
/*
選択を確認する状態クラス。
OKで次のステートへ
*/
	public class Next_State_Check:Check_Observer,Battle{
	
		Battle previous;
		Battle next;
		Battle battle;
		Dest_Button dest;
		public Check_create check;
		public Next_State_Check(Battle previous,Dest_Button dest,Battle next){
			this.dest=dest;
			this.previous=previous;
			this.next=next;
			this.battle=this;
			check=new Check_create(this);
		}
		
		public void init(){
		}
		
		public Battle update(){
			return battle;
		} 
		
		private void destroy(){
			check.Dest();
			dest.destroy();
		}
		
		public void OK(){
			destroy();
			next.init();
			battle=next;
		}
		
		public void No(){
			destroy();
			previous.init();
			battle=previous;
		}

	}
}
