using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Black_Out;
using State;
using Character;


namespace character_select{
/*
キャラクターの選択ボタンが押されたときに処理するクラス。
マウスカーソルがボタンの上にある場合、そのキャラの説明テキストをパネルに表示させる。
*/

	public class chara_button : MonoBehaviour, IPointerEnterHandler{
		int force;
		string Name;
		string disc;
		Hero hero;
	    void Start()
	    {
	        transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(Player_Status player,Hero hero){
	    	force=player.Force_Base;
	    	Name=player.Name;
	    	disc=player.disc;
	    	player.init();
	    	GetComponent<Image>().sprite=player.image;
	    	GameObject.Find("option_character").GetComponent<Image>().sprite=GetComponent<Image>().sprite;
	    	GameObject.Find("status").GetComponent<Text>().text=force.ToString();
	    	GameObject.Find("name").GetComponent<Text>().text=Name;
	    	GameObject.Find("discription").GetComponent<Text>().text=disc;
	    	this.hero=hero;
	    }
	    
	    public void OnClick(){	//クリックされたときの処理
	    	Stage.hero=this.hero;
	    	GameObject obj=Instantiate((GameObject)Resources.Load("blackout/Blackout"),new Vector2(0,0),Quaternion.identity);
	    	Destroy(GameObject.Find("bgm"));
	    	obj.GetComponent<blackout>().init(new next_state("２ｄ"));
	    }
	  
	    public void OnPointerEnter(PointerEventData eventData){	//カーソルがボタンの上にあるときの処理
	    	GameObject.Find("option_character").GetComponent<Image>().sprite=GetComponent<Image>().sprite;
	    	GameObject.Find("status").GetComponent<Text>().text=force.ToString();
	    	GameObject.Find("name").GetComponent<Text>().text=Name;
	    	GameObject.Find("discription").GetComponent<Text>().text=disc;
			
	    }
	    
	    
	    
	}
}
