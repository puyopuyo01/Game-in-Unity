using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

namespace Finish_Game{

	public class Result_Game_Comp: MonoBehaviour{
	//試合が終わった時表示する画像やテキストを設定するオブジェクト
		void Start(){
        	transform.SetParent(GameObject.Find("Canvas").transform,false);
		}
		
		
		public void Set_Value(Sprite sprite){
			GetComponent<Image>().sprite=sprite;
		}
		
		public void Set_Value(string result){
			GetComponent<TextMeshProUGUI>().text=result;
		}

	}
}
