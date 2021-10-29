using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using Schemes;

namespace button{

	public class Scheme_Button_create
	{
	/*必殺技を使用するかを確認するボタンを生成する。*/
		GameObject scheme;
		GameObject OK;
		GameObject NO;
	    public Scheme_Button_create(Check_Observer obs){
	    	scheme=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Scheme/Scheme_select/Scheme_Panel"),new Vector2(-250,-270),Quaternion.identity);
	    	OK=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Scheme/Scheme_select/Scheme_Button"),new Vector2(-45,-270),Quaternion.identity);
	    	OK.GetComponent<Check_Button>().init(obs,"OK");
	    	NO=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Scheme/Scheme_select/Scheme_Button"),new Vector2(70,-270),Quaternion.identity);
	    	NO.GetComponent<Check_Button>().init(obs,"NO");
	    }
	    
	    
	    public void Dest(){
			UnityEngine.Object.Destroy(scheme);
			UnityEngine.Object.Destroy(OK);
			UnityEngine.Object.Destroy(NO);
	    }
	}
	
}
