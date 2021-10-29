using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace State{
/*
何かを選択したとき、その選択したものが「選択不可」、「選択可能」、「重複選択可能」といった状態を表すインタフェース。
派生クラスで選択状態の処理を書く必要がなくなる。
*/

	public interface Sel_State{
		bool available(ref Sel_State state);
	}

}
