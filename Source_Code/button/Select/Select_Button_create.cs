using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using button;
using Hand;
using Character;

namespace button{

	public class Select_Button_create:Switch_button{
	/*そのターンで選択できるじゃんけんの手のオブジェクトを生成、更新をするクラス*/
		GameObject[] button=new GameObject[3];
		Player_Status player;
		public Select_Button_create(Vector3 v,Player_Status player){
			this.player=player;
			button[0]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Selection/Selection"),v,Quaternion.identity);
			button[1]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Selection/Selection"),new Vector3(v.x-80,v.y-130),Quaternion.identity);
			button[2]=UnityEngine.Object.Instantiate((GameObject)Resources.Load("Selection/Selection"),new Vector3(v.x+80,v.y-130),Quaternion.identity);
			notif();
			Off();
			
		}
		
		public void notif(){
			int i=0;
			foreach(GameObject obj in button){
				obj.GetComponent<Button_Select>().receive(player,player.wait_sel[i].pass_ID);
				i++;
			}
		}
		
		public void On(){
			foreach(GameObject obj in button){	/*ボタンのクリック操作を有効にする。*/
				obj.GetComponent<Button>().enabled=true;
			}
		}
		
		public void Off(){
			foreach(GameObject obj in button){
				obj.GetComponent<Button>().enabled=false;
			}
		}
		
		public void Dest(){
			foreach(GameObject obj in button){
				UnityEngine.Object.Destroy(obj);
			}
		}

	}
}
