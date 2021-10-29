using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hand;

namespace State{
	public class informationmagicbutton : MonoBehaviour{
		/*クリックすると各手のパラメータ、状態を表示する処理を行う。*/
	    GameObject[] valbox=new GameObject[3];
	    int ID;
	    void Awake()
	    {
	        transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }

		public void init(int ID,GameObject[] infval){
			this.ID=ID;
			valbox=infval;
			GetComponent<Image>().sprite=BattleState.Information_Player.hand[ID].image;
			
		}
		
		public void OnClick(){
			valbox[0].transform.GetChild(0).gameObject.GetComponent<Text>().text=BattleState.Information_Player.hand[ID].pass_force.ToString();
			valbox[1].transform.GetChild(0).gameObject.GetComponent<Text>().text=BattleState.Information_Player.hand[ID].injury.ToString();
			valbox[2].transform.GetChild(0).gameObject.GetComponent<Text>().text=BattleState.Information_Player.hand[ID].fatigue.ToString();
			GameObject.Find("state_str").GetComponent<Text>().text=BattleState.Information_Player.hand[ID].state_name;
		}
	}
}
