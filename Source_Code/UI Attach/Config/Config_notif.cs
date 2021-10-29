using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace config{
	public class Config_notif:MonoBehaviour{
	/*設定変更を反映するクラス。*/
		public void notif(){
			transform.GetChild(0).GetComponent<Slider>().value=Config.BGM;
			transform.GetChild(1).GetComponent<Slider>().value=Config.SE;
		}
	}
}