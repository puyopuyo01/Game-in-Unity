using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace config{
/*変更した設定を適用したときその処理を行うオブジェクト*/
	public class Conf_Appli:MonoBehaviour{
		public void OnClick(){
			Config.SE=GameObject.Find("SE").GetComponent<Slider>().value;
			Config.BGM=GameObject.Find("BGM").GetComponent<Slider>().value;
			GameObject.Find("Config_Panel").SetActive(false);
		}

	}
}

