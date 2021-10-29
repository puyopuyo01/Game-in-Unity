using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Flag;
using character_select;

namespace State{
	public interface notif{	/*会話の終了を通知するインターフェース*/
		void notif();
	}
	public class Talk : Battle,notif{	/*会話パートの状態クラス*/
		bool finish=false;
		GameObject[] chara=new GameObject[2];
		GameObject talkpanel;
		GameObject panel;
		List<Speaker> speaker=new List<Speaker>();
		
		public void notif(){
			finish=true;
		}
		
	    public void init(){
			panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Talk/Panel_Talk"),new Vector2(0,0),Quaternion.identity);
			panel.GetComponent<talk_image_script>().init();
			characreate();
			speaker.Add(new Speaker(chara[0],chara[1],false,BattleState.First_Player.Name));
			speaker.Add(new Speaker(chara[1],chara[0],false,BattleState.Second_Player.Name));
			speaker.Add(new Speaker(chara[0],chara[1],true,BattleState.First_Player.Name));
			speaker.Add(new Speaker(chara[1],chara[0],true,BattleState.Second_Player.Name));
			talkpanel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Talk/talkpanel"),new Vector2(-250,-310),Quaternion.identity);
			talkpanel.GetComponent<Panel_talk>().init(Stage.hero.text_talk,this as notif);
			talkpanel.GetComponent<Panel_talk>().receive_speaker(speaker);
			
	    }
	    
	    void characreate(){
			chara[0]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Talk/talk_image"),new Vector2(-835,0),Quaternion.identity);
			chara[1]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Talk/talk_image"),new Vector2(-835,0),Quaternion.identity);
			chara[0].GetComponent<Image>().sprite=BattleState.First_Player.image;
			chara[1].GetComponent<Image>().sprite=BattleState.Second_Player.image;
			chara[0].GetComponent<Animator>().SetBool("First",true);
			chara[1].GetComponent<Animator>().SetBool("Second",true);
			chara[0].GetComponent<talk_image_script>().init();
			chara[1].GetComponent<talk_image_script>().init();
		}
	    
	    
	    public Battle update(){
	    	if(finish){
	    		destroy();
	    		return new Select(new Select(new Scheme_Check(new Scheme_Check(new Activity(),BattleState.Second_Player,BattleState.First_Player),BattleState.First_Player,BattleState.Second_Player),BattleState.Second_Player),BattleState.First_Player);
	    	}
	    	return this;
	    }
	    
	    void destroy(){
			chara[0].GetComponent<Animator>().SetBool("finish",true);
			chara[1].GetComponent<Animator>().SetBool("finish",true);
			UnityEngine.Object.Destroy(talkpanel);
			UnityEngine.Object.Destroy(panel);
	    }
	}
}
