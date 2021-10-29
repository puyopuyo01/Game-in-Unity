using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Flag;

namespace State{

	public class Active_Result:MonoBehaviour{	/*アニメーション終了の通知を受け取るクラス。オブジェクトに直接アタッチ*/
		two_flag finish;
		int num;		//アニメーションするオブジェクトID。0か1。
		GameObject determ;	//決定した選択
	
		public void init(two_flag animation,int num,string result,GameObject determ){
			finish=animation;
			this.num=num;
			this.determ=determ;
			GetComponent<Text>().text=result;
			
		}

		
		public void Dest(){
			if(num==0){ 
				finish.first_notif=true;
			}
			
			if(num==1){
				finish.second_notif=true;
			}
			Destroy(this.gameObject);
			Destroy(this.determ);
		}
	}
}
