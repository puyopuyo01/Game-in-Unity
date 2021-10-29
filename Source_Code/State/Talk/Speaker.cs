using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace State{
/*
話しているキャラに合わせて画面のオブジェクトを動かすクラス。誰が喋っているかをIDで管理。
ID=0 プレイヤーのみが喋る
ID=1 敵のみが喋る
ID=2 プレイヤー、敵が会話。プレイヤー名を表示
ID=3 プレイヤー、敵が会話。敵名を表示
*/
	public class Speaker{
		GameObject first;
		GameObject second;
		bool second_speak;
		string name;
		
		public Speaker(GameObject first,GameObject second,bool second_speaker,string name){
			this.first=first;
			this.second=second;
			this.second_speak=second_speaker;
			this.name=name;
		}
		
		public string speak(){
			first.GetComponent<Animator>().SetBool("Non_Speak",false);
			first.GetComponent<Animator>().SetBool("Speak",true);
			if(second_speak){
				second.GetComponent<Animator>().SetBool("Speak",true);
				return this.name;
			}
			second.GetComponent<Animator>().SetBool("Non_Speak",true);
			return this.name;
		}

	}
}
