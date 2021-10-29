using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace button{
/*
矢印をクリックしたときの処理をするクラス
矢印の種類は右と左のみなので、クラスを作らずにintで識別を行う。(1か-1)
*/

	public class Arrow : MonoBehaviour{
		GameObject obj;
		List<EnhanceMent> enhance;
		int num;	//識別番号
		
	    void Start()
	    {
	        transform.SetParent(GameObject.Find("Canvas").transform,false);
	    }
	    
	    public void init(GameObject obj,List<EnhanceMent> enhance,int number){
	    	this.num=number;
	    	this.enhance=enhance;
	    	this.obj=obj;
	    	if(number==-1){
	    		gameObject.GetComponent<Image>().sprite=(Sprite)Resources.Load("UI/sozai/rightarrow",typeof(Sprite));
	    	}
	    	
	    	if(number==1){
	    		gameObject.GetComponent<Image>().sprite=(Sprite)Resources.Load("UI/sozai/leftarrow",typeof(Sprite));
	    	}
	    }
	    	
	    public void OnClick(){
	    	obj.GetComponent<Button_Base>().num+=this.num;
	    	if(obj.GetComponent<Button_Base>().num<0){
	    		obj.GetComponent<Button_Base>().num=(obj.GetComponent<Button_Base>().enhance.Count)-1;
	    	}
	    	if(obj.GetComponent<Button_Base>().num>=obj.GetComponent<Button_Base>().enhance.Count){
	    		obj.GetComponent<Button_Base>().num=0;
	    	}
	    	obj.GetComponent<Button_Base>().update();
	    }
	}
}
