using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace button{

	public class create_enhance{
	/*強化する処理を行うボタンを生成するクラス。*/
		GameObject right;
		GameObject left;
		GameObject enh;
		GameObject Panel;
		GameObject description;
		GameObject content;
	    
	    public create_enhance(Observer obs,List<EnhanceMent> list){
			Panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("enhpanel"),new Vector2(-250,0),Quaternion.identity);
		    right=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Enhance/Arrow"),new Vector2(-560,-150),Quaternion.identity);
		    left=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Enhance/Arrow"),new Vector2(-400,-150),Quaternion.identity);
		    enh=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Button"),new Vector2(-480,10),Quaternion.identity);
		    description=UnityEngine.Object.Instantiate((GameObject)Resources.Load("UI/description/Description"),new Vector2(-100,330),Quaternion.identity);
		    content=UnityEngine.Object.Instantiate((GameObject)Resources.Load("UI/description/Content"),new Vector2(-100,-70),Quaternion.identity);
		    right.GetComponent<Arrow>().init(enh,list,1);
		    left.GetComponent<Arrow>().init(enh,list,-1);
		    enh.GetComponent<Button_Base>().init(obs,list,1,this.content);
		    enh.GetComponent<Button_Base>().update();
		}
		
		public void Dest(){
			UnityEngine.Object.Destroy(Panel);
			UnityEngine.Object.Destroy(right);
			UnityEngine.Object.Destroy(left);
			UnityEngine.Object.Destroy(enh);
			UnityEngine.Object.Destroy(description);
			UnityEngine.Object.Destroy(content);
		}
	}
}
