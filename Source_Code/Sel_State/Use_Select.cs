using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace State{
/*すでに選択されている状態かつ、重複選択できない選択状態のクラス。*/
	public class Use_Select: Sel_State{
		public bool available(ref Sel_State state){
			return false;
		}
	}
}
