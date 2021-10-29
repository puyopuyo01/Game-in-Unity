using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using State;
using Schemes;

namespace button{

	public class Scheme_button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler{
	/*必殺技のボタン。クリックすると必殺技を発動する。*/
		Toggle tgl;
		GameObject description;
		Scheme_Observer obs;
		Scheme scheme;
		Vector2 size;
	    // Start is called before the first frame update
	    void Start()
	    {
	    	tgl=GetComponent<Toggle>();
	    	transform.SetParent(GameObject.Find("Content").transform,false);
	    	tgl.isOn=true;
	    	size=GetComponent<RectTransform>().sizeDelta;

	    }
	    public void OnPointerEnter(PointerEventData eventData){
			GetComponent<RectTransform>().sizeDelta=new Vector2(size.x+20,size.y+20);
			description.GetComponent<Text>().text=scheme.discription;
			
	    }
	    
	    public void OnPointerExit(PointerEventData eventData){
	    	GetComponent<RectTransform>().sizeDelta=new Vector2(size.x,size.y);
	    }
	    
	    public void init(Scheme_Observer obs,Scheme scheme,GameObject desc){
	    	this.obs=obs;
	    	this.scheme=scheme;
	    	this.description=desc;
	    	transform.GetChild(2).GetComponent<Text>().text=scheme.Name;
	    }
	    
	    public void OnClick(){
	    	obs.OK(scheme);
	    }
	}
}
