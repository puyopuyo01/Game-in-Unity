using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace Audio{
/*タイトル画面から遷移しても、BGMを管理するオブジェクトを残す処理。*/
	public class audio : MonoBehaviour{
	    void Start()
	    {
	       DontDestroyOnLoad(gameObject);
	    }
	}
}
