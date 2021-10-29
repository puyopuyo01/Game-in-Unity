using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace character_select{

	public class State_manage : MonoBehaviour{
	/*主人公選択画面の管理クラス。*/
		GameObject momo;
		GameObject ai;
		GameObject hatu;

	    void Start()
	    {
	        momo=Instantiate((GameObject)Resources.Load("Character_Select/Character_Button"),new Vector2(-85,-50),Quaternion.identity);
	        ai=Instantiate((GameObject)Resources.Load("Character_Select/Character_Button"),new Vector2(115,-50),Quaternion.identity);
	        hatu=Instantiate((GameObject)Resources.Load("Character_Select/Character_Button"),new Vector2(315,-50),Quaternion.identity);
	        momo.GetComponent<chara_button>().init(new Momo("enemy"),new Momo_Story());
	        ai.GetComponent<chara_button>().init(new Ai("enemy"),new Ai_Story());
	        hatu.GetComponent<chara_button>().init(new Hatsu("enemy"),new Hatsu_Story());
	    }
	}
}
