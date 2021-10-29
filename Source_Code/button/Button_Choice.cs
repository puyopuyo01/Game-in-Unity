using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hand;

namespace button{

	public interface Observe_Choice /*次ターンに使う選択肢を決めるインタフェース。
										選択したものをプレイヤーのステータス管理クラスに通知する。*/
	{
		void notif(Judge judge);
	}

	public class Button_Choice : MonoBehaviour
	{
		Observe_Choice ricipient;
		Judge judge;
	    void Start()
	    {
	       transform.SetParent(GameObject.Find("Canvas").transform,false);
	       
	    }
	    
	    public void init(Observe_Choice ricipient,Judge judge){
	    	this.ricipient=ricipient;	
	    	this.judge=judge;
	    	this.gameObject.GetComponent<Image>().sprite=judge.image;
			transform.GetChild(0).GetComponent<Text>().text="魔力　"+judge.pass_force;
	    }
	    
	    public void OnClick(){
	    	sel_button_available avail = judge as sel_button_available;
	    	if(avail.select_state()){
	    		ricipient.notif(this.judge);
	    	}
	    }
	}
}
