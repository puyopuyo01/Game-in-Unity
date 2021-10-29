using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character_select{

	public class Forest : Stage_BackGround{
		public Sprite get_background(){
			return (Sprite)Resources.Load("background/2",typeof(Sprite));
		}
	}
}

