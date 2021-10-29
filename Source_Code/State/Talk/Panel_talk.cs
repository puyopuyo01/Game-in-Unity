using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using String_Separate;

namespace State{
	public class Panel_talk : MonoBehaviour{
		bool set=false;
		bool wait_flag;
		int i;
		List<Speaker> speaker;
		TextAsset text;
		string[,] textword;
		int max;
		notif noti;
	    void Start(){
	        i=1;
	    }
	    


	    void Update(){
	    	if(set && wait_flag){	//<- 配列に文字が入ってるか
	    		if(Input.GetMouseButton(0)){
	    			try{
	    				transform.GetChild(0).GetComponent<Text>().text=textword[I,1];
						transform.GetChild(1).GetComponent<Text>().text=speaker[int.Parse(textword[I,0])].speak();
					}
					catch(Exception ){
						noti.notif();
	    				return;
	    			}
	    			wait();
	    		}
				if (Input.GetKey(KeyCode.Space)){
					noti.notif();
					return ;
				}
	    	}
	        
	    }
	    
	    async void wait(){
	    	set=false;
	    	await Task.Delay(500);
	    	I+=1;
	    	set=true;
	    }
	    
	    async void wait_start(){
	    	await Task.Delay(3000);
	    	wait_flag=true;
	    }
	    
	    public void init(TextAsset text,notif ntf){
	     	transform.SetParent(GameObject.Find("Canvas").transform,false);
	     	transform.SetAsLastSibling();
	    	this.text=text;
	    	this.noti=ntf;
	    	textword=new Talk_Separate().Separate(text);
	    	max=new Talk_Separate().row(text);
	    	set=true;
			transform.GetChild(0).GetComponent<Text>().text=textword[i,1];
		    wait_flag=false;
	        wait_start();
	    }
	    
	    public void receive_speaker(List<Speaker> speaker){
			this.speaker=speaker;
			transform.GetChild(1).GetComponent<Text>().text=speaker[int.Parse(textword[i,0])].speak();
	    }
	    
	    int I{
	    	get{ return i;}
	    	set{
	    		i=value;
	    		if(i>=max){
	    			i=max;
	    		}
	    	}
	    }
	}
}
