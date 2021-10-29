using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using background;

namespace character_select{
/*ステージ進行の管理を行うクラス。背景は共通なのでここで渡す。*/
	public static class Stage{
		public static int stagenum=1;
		public static Hero hero;
		
		public static Sprite get_background(){
			Dictionary<int,Stage_BackGround> back=new Dictionary<int,Stage_BackGround>()
			{
				{1,new Town()},
				{2,new Forest()},
				{3,new Sky()},
				{4,new Castle()},
			};
			
			return back[stagenum].get_background();
		}
		
	}
}
