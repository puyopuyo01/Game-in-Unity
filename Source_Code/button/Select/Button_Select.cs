using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Hand;
using Character;


/*Start関数だと初期化の順番を管理できないのでAwakeで初期化*/
namespace button{

	public class Button_Select : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
	{
	/*そのターンで選択できるじゃんけんの手のクリック処理を行うクラス。*/
		Player_Status player;
		int ID;
		Vector2 size;
		Judge judge;
		
		public void init(){
			judge=player.hand[ID];
			transform.GetChild(0).GetComponent<Text>().text="魔力　"+judge.pass_force;
		}
		
		public void receive(Player_Status player,int ID){
			this.player=player;
			this.ID=ID;
			GetComponent<Image>().sprite=player.hand[ID].image;
			transform.GetChild(0).GetComponent<Text>().text="魔力　"+player.hand[ID].pass_force;
		}
		
		
	    void Awake()
	    {
	        transform.SetParent(GameObject.Find("Canvas").transform,false);
	        size=GetComponent<RectTransform>().sizeDelta;
	    }

	    public void OnPointerEnter(PointerEventData eventData){	//マウスカーソルが重なったら書いてある情報を別情報に変えるため、「size」スクリプトは使えない。
			GetComponent<RectTransform>().sizeDelta=new Vector2(size.x+20,size.y+20);
			transform.GetChild(0).GetComponent<Text>().text=player.hand[ID].state_name;
			
	    }
	    
	    public void OnPointerExit(PointerEventData eventData){
	    	GetComponent<RectTransform>().sizeDelta=new Vector2(size.x,size.y);
			transform.GetChild(0).GetComponent<Text>().text="魔力　"+player.hand[ID].pass_force;
	    }
	    
	    public void OnClick(){
	    	player.determ=player.hand[ID];
	    }
	}
}
