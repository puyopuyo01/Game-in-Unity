using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Schemes;
using State;

namespace button{
	public class Selection_Scheme_create{
	/*必殺技を選択するときに必要なオブジェクトを生成するクラス。*/
		GameObject button;
		List<GameObject> scheme=new List<GameObject>();
		GameObject scroll;
		GameObject description;
		GameObject content;
		GameObject Panel;
		public Selection_Scheme_create(Scheme_Observer obs,List<Scheme> list){
			Panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("enhpanel"),new Vector2(-250,0),Quaternion.identity);
			scroll=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Scheme/Scroll View"),new Vector2(-400,50),Quaternion.identity);
			button=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Scheme/Scheme_Cancel"),new Vector2(-400,-260),Quaternion.identity);
		    description=UnityEngine.Object.Instantiate((GameObject)Resources.Load("UI/description/Description"),new Vector2(-20,330),Quaternion.identity);
		    content=UnityEngine.Object.Instantiate((GameObject)Resources.Load("UI/description/Content"),new Vector2(-30,-70),Quaternion.identity);
			button.GetComponent<Scheme_Cancel>().init(obs);
			
			int i;
			for(i=0;i<list.Count;i++){
				scheme.Add(UnityEngine.Object.Instantiate((GameObject)Resources.Load("scheme/scheme"),new Vector2(0,0),Quaternion.identity));
				scheme[i].GetComponent<Scheme_button>().init(obs,list[i],content);
			}
		}
		
		public void Dest(){
			UnityEngine.Object.Destroy(this.Panel);
			UnityEngine.Object.Destroy(this.scroll);
			UnityEngine.Object.Destroy(button);
			UnityEngine.Object.Destroy(content);
			UnityEngine.Object.Destroy(description);
		}
	}
}
