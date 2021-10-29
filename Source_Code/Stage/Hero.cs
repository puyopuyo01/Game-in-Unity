using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Character;

namespace character_select{
/*各主人公のステージごとの敵やテキストを渡すインタフェース。*/
	public interface Hero{
		TextAsset text_talk{
			get;
		}
		
		Player_Status Enemy{
			get;
		}
		
		Player_Status hero{
			get;
		}
	}
}
