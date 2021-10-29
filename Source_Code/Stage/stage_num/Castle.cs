using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace character_select{

	public class Castle : Stage_BackGround{
		public Sprite get_background(){
			return (Sprite)Resources.Load("background/4",typeof(Sprite));
		}
	}
}

