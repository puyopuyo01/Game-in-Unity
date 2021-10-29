using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using State;
using Flag;

namespace scheme_stage{
//必殺技の演出の処理を行うクラス。
	public class scheme_player : MonoBehaviour
	{
		two_flag finish;
		string role;
	    // Start is called before the first frame update
	    void Start()
	    {
			transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(two_flag finish,string role){
	    	this.finish=finish;
	    	this.role=role;
	    }
	    
	    public void receive_name(string name,string disc){
	    	transform.GetChild(0).GetComponent<Text>().text=name;
	    	transform.GetChild(1).GetComponent<Text>().text=disc;
	    }
	    
	    public void receive_image(Sprite image){
	    	transform.GetChild(0).GetComponent<Image>().sprite=image;

	    }
	    
	    public void Dest(){
	    	if(role=="text"){
	    		finish.first_notif=true;
	    	}
	    	else if(role=="img"){
	    		finish.second_notif=true;
	    	}
	    	Destroy(this.gameObject);
	    }
	}
}
