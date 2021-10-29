using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Schemes{
/*必殺技のクラスに継承させるインタフェース。*/
	public interface Scheme
	{
		int morale{
			get;
		}
		
		void scheme();	//この関数に必殺技の処理を書く。
		
		
		string Name{
			get;
		}
		
		string discription{
			get;
		}
		
		string disc_stage{
			get;
		}
	}
}
