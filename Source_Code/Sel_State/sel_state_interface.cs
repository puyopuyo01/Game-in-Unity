using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hand{
/*
選択という概念を持つクラスに継承するインタフェース。
Sel_Stateインタフェースと合わせて関数で処理させる。
*/

	public interface sel_button_available{
		bool select_state();
	}
}
