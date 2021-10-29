using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading.Tasks;
using String_Separate;

namespace ending{

/*
エンディング画面の処理。テキストファイルの読み込み、テキストの分割を行う。
テキストオブジェクトは複数あるので、Mediatorパターンを使う。
*/

	public class Ending_Manager : MonoBehaviour{
		bool next=false;	//次のテキストへ進むかを判定するフラッグ
		GameObject Name;
		GameObject content;
		public static int stime;
		private static System.Timers.Timer timer;
		int row;
		string[] staffroll;
		string[] tags;
		TextAsset staff;
	    
	    
	    async void start(){
	    	await Task.Delay(3000);
	    	GameObject.Find("bgm").GetComponent<AudioSource>().Play();
	    	next=true;
	    }
	    void Start()
	    {
	    	Name=GameObject.Find("Name");
	    	content=GameObject.Find("content");
	    	staff=(TextAsset)Resources.Load("Text/staff_roll/Staff");
	        staffroll=new Talk_Separate().separate_one(staff,0);
	        tags=new Talk_Separate().separate_one(staff,1);
	        row=new Talk_Separate().row(staff);
	        Name.GetComponent<Ending_Text>().init(staffroll,this);
	        content.GetComponent<Ending_Text>().init(tags,this);
	        next=false;
	        start();
	    }

	    void Update(){
	    	if(next){
	    		if(Name.GetComponent<Ending_Text>().finish && content.GetComponent<Ending_Text>().finish){
	    			finish();
	    			return;
	    		}
	    		Name.GetComponent<Ending_Text>().receive_notif();
	    		content.GetComponent<Ending_Text>().receive_notif();
	    		next=false;
	    		
		    }
	    }
	    
	    
	    void finish(){
	    	next=false;
	    	GameObject.Find("Thanks").GetComponent<Animator>().SetBool("notif",true);
	    }
	    
	    public void notif(){
	    	if(!next){
	    	 next=true;
	    	}
	    }
	    
	}
}
