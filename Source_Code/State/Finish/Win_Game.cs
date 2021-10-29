using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;
using State;

namespace Finish_Game{

/*プレイヤーが勝利したときのオブジェクトを生成するクラス。*/
	public class Win_Game:Battle{	//勝利時の画面。クリックすると次ステージに遷移
		public Win_Game(Sprite spr){
			create(spr);
		}
		public void init(){
		}
		
		
		async void create(Sprite spr){
			await Task.Delay(1000);
			UnityEngine.Object.Instantiate((GameObject)Resources.Load("Panel"),new Vector2(0,0),Quaternion.identity);
			await Task.Delay(500);
			GameObject str=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Text/Result"),new Vector2(0,0),Quaternion.identity);
			GameObject sprite=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Image/Result_Image"),new Vector2(0,0),Quaternion.identity);
			str.GetComponent<Result_Game_Comp>().Set_Value("Win");
			sprite.GetComponent<Result_Game_Comp>().Set_Value(spr);
			await Task.Delay(1000);
			UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Win/Next_Stage"),new Vector2(-230,50),Quaternion.identity);
		}
	
		public Battle update(){
			return this;
		}
			
	}
}
