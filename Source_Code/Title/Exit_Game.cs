using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

namespace Title{

	public class Exit_Game : MonoBehaviour
	{
	/*タイトルでExitボタンを押したときの処理。*/
	    public void OnClick(){
	    	UnityEngine.Application.Quit();
	    }
	}

}
