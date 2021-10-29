using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;

namespace mode{
/*遊ぶモードを選択するクラス
(ストーリーモードしか実装できていない)*/
	public interface Mode{
		Battle mode{
			get;
		}
	}
	public class Story_Mode:Mode{
		public Battle mode{
			get{return new Talk();}
		}
	}
}	
