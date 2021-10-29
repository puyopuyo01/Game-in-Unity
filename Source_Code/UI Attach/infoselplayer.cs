using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace State{
	public class infoselplayer : MonoBehaviour{
	/*ボタンがクリックされたらプレイヤー、敵の情報を切り替える処理。*/
		Player_Status player;


		public void init(Player_Status player){
			this.player=player;
			GameObject.Find("name").GetComponent<Text>().text=player.Name;
			GameObject.Find("morale_val").GetComponent<Text>().text=player.Morale.ToString();
			GameObject.Find("base_val").GetComponent<Text>().text=player.Force_Base.ToString();
		}
		
		public void OnClick(){
			BattleState.Information_Player=player;
			GameObject.Find("name").GetComponent<Text>().text=player.Name;
			GameObject.Find("morale_val").GetComponent<Text>().text=player.Morale.ToString();
			GameObject.Find("base_val").GetComponent<Text>().text=player.Force_Base.ToString();
			BattleState.informationbutton[0].GetComponent<informationmagicbutton>().OnClick();
		}
	}
}
