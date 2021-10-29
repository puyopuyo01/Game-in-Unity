using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace button{
/*
確認画面を作るクラス。
*/

	public class Check_create
	{
		Dictionary<string,GameObject> dic = new Dictionary<string,GameObject>{};
		GameObject Panel;
		GameObject Text;
		public Check_create(Check_Observer obs){
			this.Panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Panel"),new Vector2(0,0),Quaternion.identity);
			Text=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Check_Text"),new Vector2(0,200),Quaternion.identity);
			dic.Add("OK",UnityEngine.Object.Instantiate((GameObject)Resources.Load("OK"),new Vector3(-290,-270,0),Quaternion.identity));
			dic["OK"].GetComponent<Check_Button>().init(obs,"OK");
			dic.Add("No",UnityEngine.Object.Instantiate((GameObject)Resources.Load("OK"),new Vector3(240,-270,0),Quaternion.identity));
			dic["No"].GetComponent<Check_Button>().init(obs,"NO");
		}
		
		public void Dest(){
			UnityEngine.Object.Destroy(this.Panel);
			UnityEngine.Object.Destroy(Text);
			UnityEngine.Object.Destroy(dic["OK"]);
			UnityEngine.Object.Destroy(dic["No"]);
		}


	}
}
