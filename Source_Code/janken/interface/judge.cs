using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using State;
using Win_Lose;

namespace Hand{

/*じゃんけんの選択肢のインタフェース。*/

	public interface Judge
	{
		Winner_Loser win_or_lose(Judge judge);
		void init();
		void Stack(Hand_State state);
		void pop();
		Judge recreate(); 
		int state_id{
			get;
		}
		int pass_ID{
			get;
		}
		
		Sprite image{
			get;
		}
		
		int injury{
			get;
			set;
		}
		
		int fatigue{
			get;
			set;
		}
		
		int pass_force{
			get;
			set;
		}
		
		int total_force{
			get;
		}
		
		string state_name{
			get;
		}
		
		string Last_Result{
			get;
			set;
		}
		
		int Lose_ID{
			get;
		}
		
		
	}
}
