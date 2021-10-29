using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using State;
using UnityEngine;
using UnityEngine.UI;

namespace Finish_Game{

	public class Finish:Battle{	//ターン終了時の状態クラス
		Battle next;
		GameObject Player_Image_Name;
		GameObject Result_Text;
		GameObject Panel;
		
		public Finish(Sprite sprite,string result,Battle battle){
			next=this;
			create(sprite,result,battle);
		}
		public void init(){}
		
	
		public Battle update(){
			return next;
		}
		
		async void create(Sprite sprite,string res,Battle battle){
	    	await Task.Delay(1000);	//画面が暗転するのを待って処理。
	    	Panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Panel"),new Vector2(0,0),Quaternion.identity);
	    	await Task.Delay(300);
	    	Result_Text=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Text/Result"),new Vector2(-180,-5),Quaternion.Euler(30, 10, 10));
	    	Player_Image_Name=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Game_Result/Image/Result_Image"),new Vector2(350,0),Quaternion.identity);
	    	Result_Text.GetComponent<Result_Game_Comp>().Set_Value(res);
	    	Player_Image_Name.GetComponent<Result_Game_Comp>().Set_Value(sprite);
	    	await Task.Delay(2000);
	    	next=battle;
	    	next.init();
	    	
		}
		
		public void destroy(){
			UnityEngine.Object.Destroy(Player_Image_Name);
			UnityEngine.Object.Destroy(Result_Text);
			UnityEngine.Object.Destroy(Panel);
		}
	}

}
	
