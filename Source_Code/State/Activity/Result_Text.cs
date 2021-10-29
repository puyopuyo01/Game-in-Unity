using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State{

	public class Result_Text : MonoBehaviour{
	/*じゃんけん結果のテキストオブジェクトにアタッチするクラス。効果音を再生する。*/
	    void Start()
	    {
	         transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void music(){
	    	GetComponent<AudioSource>().Play();
	    }

	}
}

