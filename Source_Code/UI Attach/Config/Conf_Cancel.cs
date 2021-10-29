using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace config{
	public class Conf_Cancel:MonoBehaviour{
		//設定変更キャンセル時の処理。
		public void OnClick(){
			GameObject.Find("Config_Panel").SetActive(false);
		}

	}
}
