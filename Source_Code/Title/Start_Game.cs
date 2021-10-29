using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Black_Out;
using character_select;
using State;


namespace Title{

	public class Start_Game: MonoBehaviour{
	/*タイトルでStartボタンを押したときの処理*/
	
	    async void start(){
	    	await Task.Delay(1000);
	    	GameObject.Find("bgm").GetComponent<AudioSource>().Play();
	    }
	    
	    void Start()
	    {
	        Screen.SetResolution(1280, 800, false, 60);
	        Stage.stagenum=1;
	        start();
	    }

	    
	    public void OnClick(){
	    	GameObject obj=Instantiate((GameObject)Resources.Load("blackout/Blackout"),new Vector2(0,0),Quaternion.identity);
	    	obj.GetComponent<blackout>().init(new next_state("Character_Select"));
	    }
	}
}
