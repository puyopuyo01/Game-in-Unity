using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace State{
	public class valinfo : MonoBehaviour{
		
	    void Awake()
	    {
			transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(string name){
	    	transform.GetChild(1).gameObject.GetComponent<Text>().text=name;
	    }

	}

}
