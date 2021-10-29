using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hand;

namespace State{
/*そのターンに選択した手を表示するオブジェクト。*/
	public class Determpanel : MonoBehaviour{
	    void Start()
	    {
	        transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(Judge judge){
	    	GetComponent<Image>().sprite=judge.image;
	    }
	    
	}
}
