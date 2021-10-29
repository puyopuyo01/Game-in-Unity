using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using scheme_stage;
using Flag;
using Character;

namespace Schemes{

	public class create_Scheme_stage{//必殺技使用時の演出に使うオブジェクトを生成。
		GameObject Panel;
		GameObject Character;
		public create_Scheme_stage(two_flag animation,string name,string disc,Player_Status player){
			Panel=UnityEngine.Object.Instantiate((GameObject)Resources.Load("scheme/stage/scheme_textpanel"),new Vector2(-1030,-220),Quaternion.identity);
			Character=UnityEngine.Object.Instantiate((GameObject)Resources.Load("scheme/stage/Scheme_player"),new Vector2(-850,0),Quaternion.identity);
			Panel.GetComponent<scheme_player>().init(animation,"text");
			Panel.GetComponent<scheme_player>().receive_name(name,disc);
			Character.GetComponent<scheme_player>().init(animation,"img");
			Character.GetComponent<scheme_player>().receive_image(player.information);
		}
	}
}
