using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Black_Out{
	public class next_state : blackout_game{
	/*次シーンへ移動するクラス*/
		string next;
		
		public next_state(string next){
			this.next=next;
		}
		
		public void update(){
			UnityEngine.SceneManagement.SceneManager.LoadScene(next);
		}
	}
}
