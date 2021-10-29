using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using State;
using Black_Out;
using character_select;

namespace Finish_Game{

	public interface LoseSelect{
		string Cont_Back{
			get;
		}
	}

	public class Loseselect : MonoBehaviour{	//敗北したときの選択画面
		LoseSelect lose;
	    void Start()
	    {
	        transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(LoseSelect lose){
	    	this.lose=lose;
	    	transform.GetChild(0).GetComponent<Text>().text=lose.Cont_Back;
	    }
	    
	    public void OnClick(){
	    	GameObject obj=Instantiate((GameObject)Resources.Load("blackout/Blackout"),new Vector2(0,0),Quaternion.identity);
			obj.GetComponent<blackout>().init(lose as blackout_game);
	    }
	}
	
	public class Continue_Game:LoseSelect,blackout_game{
		public string Cont_Back{
			get{return "continue";}
		}
		
		public void update(){
			UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
		}
	}
	
	public class Back_Title:LoseSelect,blackout_game{
		public string Cont_Back{
			get{return "タイトルへ";}
		}
		
		
		public void update(){
			Stage.stagenum=1;
			UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
		}
	}
}
