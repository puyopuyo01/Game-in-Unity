using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace continuate{
/*継続効果のある強化、必殺技に継承させるインタフェース*/
	public interface continuation{
		void update_scheme();	//継続効果の更新処理。
		bool Finish{
			get;
		}
	}
}
