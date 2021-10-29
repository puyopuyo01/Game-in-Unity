using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Character;
using Handle;

namespace State{

/*何を強化するか選択する状態のクラス。プレイヤーの強化も敵の強化もこのクラスで処理しているが、状態の追加等でコンストラクタの引数が入れ子構造となって、より複雑になるため
　、クラスを分けてもよいかもしれない。*/
	public class Next_Prepare:Battle{
	
		Queue<EnhanceMent> queue = new Queue<EnhanceMent>(); 
		Enhance_Handler enhance_handler;
		Battle next;
		int remain_cost;  //強化選択のコスト。強化する内容によって、選択できる数が変わる。
		
		public Next_Prepare(Battle next,Player_Status player){
			this.next=next;
			enhance_handler=player.Play_Handler.enhance();
		}
		
		public void init(){
			enhance_handler.init();
		}
		
		public Battle update(){
			return enhance_handler.update(this,next);	//CP,プレイヤーによって処理が変わる
		}

}
}
