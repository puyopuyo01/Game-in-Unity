using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using State;
using Handle;
using Character;

namespace Handle{
/*プレイヤー側の操作の初期設定をまとめたクラス。*/
	public class Player :Handler_Base,Player_Handler {
		public Player(Player_Status opera){
			base.enh=new Enhance_Player(opera);
			base.nch=new Choice_Player(opera);
			base.sh=new Scheme_Player(opera);
			base.sel=new Select_Player(opera);
		}

	}
}