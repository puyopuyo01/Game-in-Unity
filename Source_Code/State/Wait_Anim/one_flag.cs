using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Flag{
	public interface inter_Animation{	/*アニメーションが終了したことを伝えられるインタフェース。
										オブジェクトの数がアニメーションによって変わるのでクラスで待つ。*/

		bool Check_Anim_Finish();
		void init();
	}
	public class one_flag  : inter_Animation{	/*このクラスで待つ場合、1つのアニメーション中のオブジェクトを待つ。*/
		public bool first_notif;
		public void init(){
			first_notif=false;
		}
		
		public bool Check_Anim_Finish(){
			if(first_notif){
				return true;
			}
			return false;
		}
	}
}
