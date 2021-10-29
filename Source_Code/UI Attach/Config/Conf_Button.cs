using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace config{
/*コンフィグ設定のボタン処理をするオブジェクト*/
	public class Conf_Button:MonoBehaviour{
		GameObject conf;
		
		void Start(){
			conf=GameObject.Find("Config_Panel");
			conf.SetActive(false);
		}
		public void OnClick(){
			conf.SetActive(true);
			conf.transform.SetAsLastSibling();
			conf.GetComponent<Config_notif>().notif();
		}

	}
}
