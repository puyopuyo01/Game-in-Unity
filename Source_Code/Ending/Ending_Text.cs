using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

/*エンディング画面のスタッフロールのテキスト処理。*/

namespace ending{

	public class Ending_Text : MonoBehaviour{
	    public bool finish;
	    int count;
	    Ending_Manager manager;
	    string[] string_staff;
	    
	    
	    public void init(string[] staff,Ending_Manager manager){
	    	string_staff=staff;
	    	this.manager=manager;
	    	finish=false;
	    	count=0;
	    }
	    
	    public void change_text(){
	    	try{
	    		GetComponent<Text>().text=string_staff[count];
	    	}
	    	catch(Exception ){
	    		GetComponent<Text>().text="";
	    		finish=true;
	    	}
	    }
	    
	    public void notif(){ //次テキストへの移動をUnityのイベント機能を用いてEnding_Managerへ通知してもらう。
	    	GetComponent<Animator>().SetBool("change",false);
	    	manager.notif();
	    	count++;
	    }
	    
	    public void receive_notif(){
	    		GetComponent<Animator>().SetBool("change",true);
	    }
	}
}

