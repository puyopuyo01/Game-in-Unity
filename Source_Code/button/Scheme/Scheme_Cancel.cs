using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using button;

namespace button{
	public class Scheme_Cancel : MonoBehaviour{
		Scheme_Observer obs;
		void Start()
	    {
	    	transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
		public void init(Scheme_Observer obs){
			this.obs=obs;
		}
	    public void OnClick(){	/*必殺技の選択をしないボタン。クリックすると次ステートへ移動するように通知*/
	    	obs.No();
	    }
	}

}
