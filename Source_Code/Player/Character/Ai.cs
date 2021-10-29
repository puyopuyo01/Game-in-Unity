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

	public class Ai:Player_Status{
		public Ai(string handle):base(new Hand_Normal()){
			Play_Handler=create_handle(handle,new Awakening_Sousou(this,4),0);
			disc="賢い女の子。\n負傷度を上げる「斬撃魔法」を使える。";
		}
		
		public override void init(){
		    image=(Sprite)Resources.Load("Character/sousou",typeof(Sprite));
			information=(Sprite)Resources.Load("Character/information/sousouinfo",typeof(Sprite));
			HP=1000;
			Sendan.init_limit();
		}
		
		public override AudioClip get_music(){
			return (AudioClip)Resources.Load("bgm/sousou_bgm",typeof(AudioClip));
		}

		public override List<EnhanceMent> enhance_option(){ /*エンハンスはここで削ぐ*/
			List<limit> lim=new List<limit>();
			List<EnhanceMent> list=new List<EnhanceMent>();
			defalt_enhance(list);
			lim.Add(new Sendan());
			available(lim,list);
			return list;
		}
		
		public override List<Scheme> scheme_option(Player_Status me,Player_Status enem){
			List<Scheme> list=new List<Scheme>();
			list.Add(new Enhance_Scheme(me,enem.hand.ToList(),-3,"相手の全属性の魔力を下げる。","妨害魔法",3));
			list.Add(new Slash(me,this.determ));
			list.Add(new Awakening_Sousou(me,7));
			list.Add(new Change_fatgue_injury_Scheme(me,enem.wait_sel,"鎌鼬","相手の選択できる属性の負傷度を上げる。",5,0,0,3));
			return list;
		}
		
		public override int RATE{
			get{return 150;}
		}
		
		public override int Force_Base{
			get{return 4;}
		}
		
		public override string Name{
			get{return "アイ";}
		}

	}
}
