using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using State;

namespace button{

/*
選択を決定するか確認するボタンの処理をするクラス。
OKかNOの2つだけなので、Stringで識別を行う。
*/

	public class Check_Button : MonoBehaviour
	{
		string OK_No;	
		Check_Observer obs;
	    void Start()
	    {
	    	transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(Check_Observer obs,string role){
	    	this.obs=obs;
	    	this.OK_No=role;
	    	transform.GetChild(0).GetComponent<Text>().text=role;
	    }

	    
	    public void OnClick(){
	    	if(OK_No=="OK"){
	    		obs.OK();
	    	}
	    	else if(OK_No=="NO"){
	    		obs.No();
	    	}
	    }
	}
}
