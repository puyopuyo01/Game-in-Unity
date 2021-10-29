using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using character_select;
using Black_Out;
using State;

namespace Finish_Game{
/*次ステージへ遷移する処理を行うクラス。*/
	public class nextstage : MonoBehaviour,blackout_game{
			bool finish=false;
		    void Start()
		    {
		         transform.SetParent(GameObject.Find("Canvas").transform,false); 
		    }

		    // Update is called once per frame
		    void Update()
		    {
			    if(Input.GetMouseButton(0)){
		    	GameObject obj=Instantiate((GameObject)Resources.Load("blackout/Blackout"),new Vector2(0,0),Quaternion.identity);
				obj.GetComponent<blackout>().init(this as blackout_game);
			    }
		    }
		    
		    public void update(){
		    	if(!finish){
					finish=true;
					Stage.stagenum++;
			    	try{
			    		TextAsset talk=Stage.hero.text_talk;
			    	}
			    	catch(Exception ){
			    		UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
			    		return;
			    	}
					UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
			    }
		    }
		}
}
