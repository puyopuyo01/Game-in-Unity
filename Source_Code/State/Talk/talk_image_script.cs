using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace State{

	public class talk_image_script : MonoBehaviour
	{

	    
	    public void init(){
	    	transform.SetParent(GameObject.Find("Canvas").transform,false);
	    	transform.SetAsLastSibling();
	    }
	    public void non_speak(){
	    	GetComponent<Animator>().SetBool("Speak",false);
	    }
	    
	    public void finish(){
	    	Destroy(this.gameObject);
	    }
	}
}
