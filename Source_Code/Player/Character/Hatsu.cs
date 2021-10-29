using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Handle;
using Hand;
using Schemes;

namespace Character{

	public class Hatsu:Player_Status{
	
		public Hatsu(string handle):base(new Hand_Normal()){
			Play_Handler=create_handle(handle,new True_Game(this),0);
			disc="少し高飛車な女の子。\n「攻勢魔法」で大ダメージを与えることができる。";
		}
		
		public override void init(){
		    image=(Sprite)Resources.Load("Character/ensho",typeof(Sprite));
			information=(Sprite)Resources.Load("Character/information/enshoinfo",typeof(Sprite));
			HP=1000;
			Rebirth.init_limit();
		}
		
		public override AudioClip get_music(){
			return (AudioClip)Resources.Load("bgm/ensyo_bgm",typeof(AudioClip));
		}
		
		public override List<EnhanceMent> enhance_option(){ /*エンハンスはここで削ぐ*/
			List<limit> lim=new List<limit>();
			List<EnhanceMent> list=new List<EnhanceMent>();
			defalt_enhance(list);
			lim.Add(new Rebirth());
			available(lim,list);
			return list;
		}

		public override List<Scheme> scheme_option(Player_Status me,Player_Status enem){
			List<Scheme> list=new List<Scheme>();
			list.Add(new Enhance_Scheme(me,me.wait_sel,3,"選択できる属性の魔力を+3","集中強化",3));
			list.Add(new Awakening_Ensho(me));
			list.Add(new Offensive(me,me.determ));
			list.Add(new True_Game(me));
			return list;
		}
		
		public override int RATE{
			get{return 130;}
		}
		
		
		public override int Force_Base{
			get{return 5;}
		}
		
		public override string Name{
			get{return "ハツ";}
		}
		

	}
}
