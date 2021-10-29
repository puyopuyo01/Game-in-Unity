using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour {
//UIを覆うパネルの処理。何かを選択する場面で関係ないUIの操作をできないようにする。(情報のボタンは操作できる。)

	void Start () {
		transform.SetParent(GameObject.Find("Canvas").transform,false);
		transform.localScale=new Vector3(1,1,1);
	}
	
}
