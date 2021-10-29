using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character_select{

	public class Town : Stage_BackGround{
		public Sprite get_background(){
			return (Sprite)Resources.Load("background/1",typeof(Sprite));
		}
	}
}

