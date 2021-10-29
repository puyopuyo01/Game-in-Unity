using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;

namespace Handle{
/*CPやプレイヤーの操作を管理するインターフェース。*/
	public interface Player_Handler
	{
		Enhance_Handler enhance();
		Next_Choice_Handler next_choice();
		Scheme_Handler scheme();
		Select_Handler select();
	}
}
