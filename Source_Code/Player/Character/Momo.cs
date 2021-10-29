using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;
using Handle;
using Schemes;
using Hand;

namespace Character{

	public class Momo:Player_Status{
		public Momo(string handle):base(new Hand_Normal()){
			Play_Handler=create_handle(handle,new Awakening(this),0);
			disc="元気で明るい女の子。\n「覚醒魔法」を使い、魔力を大きくして戦うことが得意。";
		}
		
		public override void init(){
		    image=(Sprite)Resources.Load("Character/ryubi",typeof(Sprite));
			information=(Sprite)Resources.Load("Character/information/ryubiinfo",typeof(Sprite));
			HP=1000;
			BigOrgan.init_limit();
		}
		
		public override AudioClip get_music(){
			return (AudioClip)Resources.Load("bgm/momo_bgm",typeof(AudioClip));
		}
		
		public override List<EnhanceMent> enhance_option(){ /*エンハンスはここで削ぐ*/
			List<EnhanceMent> list=new List<EnhanceMent>();
			List<limit> lim=new List<limit>();
			lim.Add(new BigOrgan());
			defalt_enhance(list);
			list.Add(new Single());
			available(lim,list);
			return list;
		}
		
		public override List<Scheme> scheme_option(Player_Status me,Player_Status enem){ /*特殊魔法を渡す*/
			List<Scheme> list=new List<Scheme>();
			list.Add(new Enhance_Scheme(me,me.hand.ToList(),2,"全属性の魔力値を少し上昇させる。","強化魔法",3));
			list.Add(new penetration(me,this.determ));
			list.Add(new Awakening(me));
			return list;
		}
		
		public override int RATE{
			get{return 120;}
		}
		
		
		public override int Force_Base{
			get{return 5;}
		}
		
		public override string Name{
			get{return "モモ";}
		}
		

	}
}
