using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace background{
/*背景を呼び出す処理*/
	public static class Background{
		public static string[] sprite_str=new string[4];
		public static Sprite back_sprite(){
			return (Sprite)Resources.Load("background/sprite_str[Stage.stage_num-1]",typeof(Sprite));
		}
	}

}
