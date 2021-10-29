using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Character;
using Schemes;

namespace Handle{
	public class Enemy :Handler_Base,Player_Handler {
		public Enemy(Player_Status opera,Scheme scheme,int level){
			base.enh=new Enhance_Enemy(opera);
			base.nch=new Choice_Enemy(opera,level);
			base.sh=new Scheme_Enemy(opera,scheme);
			sel=new Select_Enemy(opera);
		}


	}
}