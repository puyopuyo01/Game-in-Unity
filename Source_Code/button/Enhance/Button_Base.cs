using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;
using Hand;


namespace button{

	public interface Observer
	{
		void notification(EnhanceMent enhance,int cost);
	}

	public class Button_Base : MonoBehaviour {	
	/*強化ターンのボタンの処理*/
		public List<EnhanceMent> enhance;
		public int num;
		Observer ricipient;
		int cost;
		GameObject Discription;

		void Start () {
			transform.SetParent(GameObject.Find("Canvas").transform,false);
		}
		
		public void init(Observer ricipient,List<EnhanceMent> enhance,int cost,GameObject discription){
			this.num=0;
			this.enhance=enhance;
			this.ricipient=ricipient;
			this.cost=cost;
			this.Discription=discription;
		}
		
		public void update(){
			transform.GetChild(0).GetComponent<Text>().text=enhance[num].Name;
			Discription.GetComponent<Text>().text=enhance[num].Discription;
		}
		
		public void OnClick(){
			sel_button_available avail = this.enhance[num] as sel_button_available;
			if(avail.select_state()){	//「未選択」の場合通知する
				ricipient.notification(enhance[num],enhance[num].Cost);
			}
		}
	}
}
