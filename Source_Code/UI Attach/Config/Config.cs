using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace config{
	public static class Config{
	/*SEとBGMの音量の値を管理するクラス。*/
		static float se_vol=1;
		static float bgm_vol=1;
		
		public static float SE{
			get{ return se_vol;}
			set{ se_vol=value;
				if(se_vol<0){ se_vol=0;}
				if(se_vol>1){ se_vol=1;}
			}
		}
		
		public static float BGM{
			get{ return bgm_vol;}
			set{ bgm_vol=value;
				if(se_vol<0){ bgm_vol=0;}
				if(se_vol>1){ bgm_vol=1;}
			}
		}

	}
}
