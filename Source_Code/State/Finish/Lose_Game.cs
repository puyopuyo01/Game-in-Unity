using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using State;

namespace Finish_Game{

	public class Lose_Game:Battle{
	
		public Lose_Game(Sprite spr){
			create(spr);
		}
		public virtual void init(){
		}
		
		async void create(Sprite spr){
			await Task.Delay(1000);
			UnityEngine.Object.Instantiate((GameObject)Resources.Load("Panel"),new Vector2(0,0),Quaternion.identity);
			await Task.Delay(500);
			GameObject str=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Text/Result"),new Vector2(0,0),Quaternion.identity);
			GameObject sprite=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Image/Result_Image"),new Vector2(0,0),Quaternion.identity);
			str.GetComponent<Result_Game_Comp>().Set_Value("Lose");
			sprite.GetComponent<Result_Game_Comp>().Set_Value(spr);
			await Task.Delay(1000);
			GameObject continue_game=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Lose/Lose_Select"),new Vector2(-250,100),Quaternion.identity);
			GameObject title=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Lose/Lose_Select"),new Vector2(-250,-100),Quaternion.identity);
			continue_game.GetComponent<Loseselect>().init(new Continue_Game());
			title.GetComponent<Loseselect>().init(new Back_Title());
			
			
		}
		
		public virtual Battle update(){
			return this;
		}
	}
}
