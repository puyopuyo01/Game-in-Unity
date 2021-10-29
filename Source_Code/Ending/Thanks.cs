using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace ending{

	public class Thanks : MonoBehaviour{
	
		async void wait(){
			await Task.Delay(1000);
		}
		
		public void finish_notif(){	//エンディング終了後、タイトル画面へ
			UnityEngine.SceneManagement.SceneManager.LoadScene("Title");
		}
	
	}
}
