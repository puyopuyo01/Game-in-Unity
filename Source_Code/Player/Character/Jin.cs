using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
using UnityEngine.UI;
using Handle;
using Hand;
using Schemes;

namespace Character{

	public class Jin:Player_Status{
		public Jin(string handle):base(new Hand_Offensive(-50)){
			Play_Handler=create_handle(handle,new Change_fatgue_injury_Scheme(this,hand.ToList(),"回復魔法","全属性の疲労度と負傷度を回復する。",4,0,-10,-10),1); 
		}
		
		public override void init(){
		    image=(Sprite)Resources.Load("Character/ryofu",typeof(Sprite));
			information=(Sprite)Resources.Load("Character/information/ryofuinfo",typeof(Sprite));
			HP=1000;
		}
		
		public override AudioClip get_music(){
			return (AudioClip)Resources.Load("bgm/jin_bgm",typeof(AudioClip));
		}
		
		public override List<Scheme> scheme_option(Player_Status me,Player_Status enem){ /**/
			List<Scheme> list=new List<Scheme>();
			list.Add(new Change_fatgue_injury_Scheme(this,hand.ToList(),"回復魔法","全属性の疲労度と負傷度を回復する。",4,0,-10,-10));
			return list;
		}
		
		public override int RATE{
			get{return 100;}
		}
		
		
		public override int Force_Base{
			get{return 8;}
		}
		
		public override string Name{
			get{return "ジン";}
		}

		

	}
}
