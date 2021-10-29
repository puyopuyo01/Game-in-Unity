using Handle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Linq;
using Finish_Game;
using Character;
using character_select;

namespace State{

	public interface Battle /*「じゃんけんの手を選択中」や,「じゃんけんの結果処理」等、
								ゲーム進行を処理するインターフェース。*/
	{
		Battle update();
		void init();

	}
	
/*バトル中のUIや、プレイヤー、敵のオブジェクト、メインループを管理するクラス。*/
	public class BattleState : MonoBehaviour {	
		public static int turn;	//現在のターン数
		public static Player_Status First_Player;	//プレイヤーオブジェクト
		public static Player_Status Second_Player; //敵オブジェクト
		public static Player_Status Information_Player;	//表示しているキャラクターステータス
		public static GameObject[] informationbutton = new GameObject[5];
		GameObject[] valbox=new GameObject[3];	//選択できる属性のオブジェクト
		public static GameObject[] strength=new GameObject[2];	//体力バー
		public static Battle battle;	//今現在のステート



		// Use this for initialization
		void Start () {
	    	Destroy(GameObject.Find("bgm"));
			Resources.UnloadUnusedAssets();
			turn=1;
			GameObject.Find("BackGround").GetComponent<Image>().sprite=Stage.get_background();
			BattleState.First_Player=Stage.hero.hero;
			BattleState.Second_Player=Stage.hero.Enemy;
			BattleState.First_Player.init();
			BattleState.Second_Player.init();
			play_music();
			First_Player.Play_Handler.select().create(new Vector3(-480,-130,0));
			Second_Player.Play_Handler.select().create(new Vector3(0,-130,0));
			Information_Player=BattleState.First_Player;
			GameObject.Find("Turn_num").GetComponent<Text>().text=turn.ToString();
			Set_contain();
			createinformationbutton();
			BattleState.battle=new Talk();
			battle.init();

		}
		
		void Update(){	//メインループ
				BattleState.battle=BattleState.battle.update();
		}
		
		void Set_contain(){
			GameObject.Find("firstcharainfo").GetComponent<Image>().sprite=BattleState.First_Player.information;
			GameObject.Find("firstcharainfo").GetComponent<infoselplayer>().init(BattleState.First_Player);
			GameObject.Find("secondcharainfo").GetComponent<Image>().sprite=BattleState.Second_Player.information;
			GameObject.Find("secondcharainfo").GetComponent<infoselplayer>().init(BattleState.Second_Player);
			GameObject.Find("firstimage").GetComponent<Image>().sprite=BattleState.First_Player.image;
			GameObject.Find("secondimage").GetComponent<Image>().sprite=BattleState.Second_Player.image;
			valbox[0]=Instantiate((GameObject)Resources.Load("UI/valframe",typeof(GameObject)),new Vector2(240,-130),Quaternion.identity);
			valbox[1]=Instantiate((GameObject)Resources.Load("UI/valframe",typeof(GameObject)),new Vector2(400,-130),Quaternion.identity);
			valbox[2]=Instantiate((GameObject)Resources.Load("UI/valframe",typeof(GameObject)),new Vector2(560,-130),Quaternion.identity);
			valbox[0].GetComponent<valinfo>().init("魔力");
			valbox[1].GetComponent<valinfo>().init("負傷度");
			valbox[2].GetComponent<valinfo>().init("疲労度");
		}
		

		
		void createinformationbutton(){
			int i=0;
			informationbutton[0]=Instantiate((GameObject)Resources.Load("UI/informationbutton",typeof(GameObject)),new Vector2(230,60),Quaternion.identity);
			informationbutton[1]=Instantiate((GameObject)Resources.Load("UI/informationbutton",typeof(GameObject)),new Vector2(390,60),Quaternion.identity);
			informationbutton[2]=Instantiate((GameObject)Resources.Load("UI/informationbutton",typeof(GameObject)),new Vector2(550,60),Quaternion.identity);
			informationbutton[3]=Instantiate((GameObject)Resources.Load("UI/informationbutton",typeof(GameObject)),new Vector2(460,-20),Quaternion.identity);
			informationbutton[4]=Instantiate((GameObject)Resources.Load("UI/informationbutton",typeof(GameObject)),new Vector2(300,-20),Quaternion.identity);
			foreach(GameObject info in informationbutton){
				info.GetComponent<informationmagicbutton>().init(i,valbox);
				i++;
			}
			GameObject.Find("firstcharainfo").GetComponent<infoselplayer>().OnClick();
			informationbutton[0].GetComponent<informationmagicbutton>().OnClick();
		}
		
		public static void reset_information(){
			GameObject.Find("firstcharainfo").GetComponent<infoselplayer>().OnClick();
			informationbutton[0].GetComponent<informationmagicbutton>().OnClick();
		}
		
		async void play_music(){	//BGMをかける処理
			AudioSource audio=GameObject.Find("Audio Source").GetComponent<AudioSource>();
			audio.clip=BattleState.Second_Player.get_music();
	    	await Task.Delay(100);
	    	if(audio!=null){
				audio.Play();
			}
		}
		
	}

	

	
}

