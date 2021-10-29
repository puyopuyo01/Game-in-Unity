using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace State{
/*まだ選択されていない状態かつ、重複選択できない選択状態のクラス。*/
	public class Non_Select : Sel_State
	{
		public bool available(ref Sel_State state){
			state=new Use_Select();
			return true;
		}
		
	}
}
