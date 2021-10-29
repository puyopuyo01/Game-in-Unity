using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using button;
using Hand;

namespace button{
	public class create_button{
	/*次ターンで使用する手を選択するときに必要なオブジェクトを生成するクラス。*/
		List<GameObject> obj=new List<GameObject>();
		GameObject Panel;
			
		public create_button(Observe_Choice obs,int interval,Judge[] list){
			int i;
			Panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("enhpanel"),new Vector2(-250,0),Quaternion.identity);
			obj.Add(UnityEngine.Object.Instantiate((GameObject)Resources.Load("Button_C"),new Vector2(-530,180),Quaternion.identity));
			obj.Add(UnityEngine.Object.Instantiate((GameObject)Resources.Load("Button_C"),new Vector2(-240,180),Quaternion.identity));
			obj.Add(UnityEngine.Object.Instantiate((GameObject)Resources.Load("Button_C"),new Vector2(30,180),Quaternion.identity));
			obj.Add(UnityEngine.Object.Instantiate((GameObject)Resources.Load("Button_C"),new Vector2(-370,-70),Quaternion.identity));
			obj.Add(UnityEngine.Object.Instantiate((GameObject)Resources.Load("Button_C"),new Vector2(-90,-70),Quaternion.identity));
			for(i=0;i<5;i++){
				obj[i].GetComponent<Button_Choice>().init(obs,list[i]);
			}
		}
		
		public void Dest(){
			UnityEngine.Object.Destroy(this.Panel);
			foreach(GameObject gobj in obj){
				UnityEngine.Object.Destroy(gobj);
			}
		}

	}
}
