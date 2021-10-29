using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class size : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
/*マウスカーソルが上に来たらサイズを大きくする処理。基本的にクリックできるものに適用*/
	Vector2 size_button;
    // Start is called before the first frame update
    void Start()
    {
 	    size_button=GetComponent<RectTransform>().sizeDelta;
    }
    
	 public void OnPointerEnter(PointerEventData eventData){
		GetComponent<RectTransform>().sizeDelta=new Vector2(size_button.x+20,size_button.y+20);
		
    }
    
    public void OnPointerExit(PointerEventData eventData){
    	GetComponent<RectTransform>().sizeDelta=new Vector2(size_button.x,size_button.y);
    }
	    
}
