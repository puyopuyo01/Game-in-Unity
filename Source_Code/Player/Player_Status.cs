using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;
using UnityEngine.UI;
using State;
using Hand;
using Schemes;
using continuate;
using Handle;


namespace Character{

	public class Player_Status {	/*プレイヤーのステータスを管理するクラス。値のカプセル化を行う。
									各インタフェースで値のカプセル化を行っているため、publicでよい。
									Builderパターンでキャラクターのステータスを実装*/
		public List<continuation> scheme_use=new List<continuation>();	//効果中の必殺技を保存するクラス。
		public List<continuation> enhance_use=new List<continuation>(); //効果中の強化を保存するクラス。
		public Sprite image;	//立ち絵
		public Sprite information; //情報切り替えのボタンの画像
		public List<Scheme> scheme_list = new List<Scheme>();
		public Queue<EnhanceMent> enhance_queue=new Queue<EnhanceMent>();
		public Judge[] hand=new Judge[5];
		public List<Judge> wait_sel=new List<Judge>();	//
		public List<Judge> Sel_Next;	//次ターンの選択肢を一度確保
		public Judge determ;	//決定した選択肢。
		private int hp;
		private int morale;
		private int enhanceCost;
		public Player_Handler Play_Handler;
		public string disc;
		
		public List<Scheme> scheme{
			get{return scheme_list;}
		}
		
		public Player_Status(Hand_State init_state){
			enhanceCost=2;
			morale=0;
			hand[0]=new select_type(0,Force_Base,(Sprite)Resources.Load("Material/fire",typeof(Sprite)),init_state);
			hand[1]=new select_type(1,Force_Base,(Sprite)Resources.Load("Material/freeze",typeof(Sprite)),init_state);
			hand[2]=new select_type(2,Force_Base,(Sprite)Resources.Load("Material/rock",typeof(Sprite)),init_state);
			hand[3]=new select_type(3,Force_Base,(Sprite)Resources.Load("Material/thunder",typeof(Sprite)),init_state);
			hand[4]=new select_type(4,Force_Base,(Sprite)Resources.Load("Material/water",typeof(Sprite)),init_state);
			wait_sel.Add(hand[0]);
			wait_sel.Add(hand[1]);
			wait_sel.Add(hand[2]);
			
		}
		
		public int HP{
			get{return hp;}
			set{
				hp=value;
				if(hp<0){ hp=0;}
				else if(hp>1000){ hp=1000;}
			}
		}
		
		public int Morale{
			get{return morale;}
			set{
				morale=value;
				if(morale<0){ morale=0;}
				else if(morale>=13){ morale = 12;}
			}
		}
		
		
		public int EnhanceCost{
			get{return enhanceCost;}
		}
		
/*handle変数は、プレイヤーか敵かを判定する。
scheme変数は、CPだった場合に使用するSchemeインターフェース
levelは、CPだった場合のアルゴリズムを決定する変数。*/
		protected Player_Handler create_handle(string handle,Scheme scheme,int level){
			if(handle=="player"){ return new Player(this);}
			if(handle=="enemy"){return new Enemy(this,scheme,level);}
			return new Enemy(this,scheme,level);
		}
		
		protected void available(List<limit> Limit,List<EnhanceMent> enhance){ //使用制限のある強化選択の回数確認
			Limit=Limit.Where(x => x.Available==true).ToList();
			foreach(limit Lim in Limit){
				enhance.Add(Lim as EnhanceMent);
			}
		}

		
		protected void defalt_enhance(List<EnhanceMent> list){
			list.Add(new Morale_Edit());
			list.Add(new Force_Each_Edit());
			list.Add(new fatigue_recover());
			list.Add(new injury_recover());
			return;
		}
		
		public void enhance_init(Player_Status me,Player_Status enem){
			foreach(EnhanceMent enh in enhance_queue){
				enh.init(me,enem);
			}
		}
		
		
		public void sel_refresh(){	//選択状態をリセット
			foreach(Judge judge in hand){
				judge.init();
			}
		}
		
		public void next_game(){	//次ターンの更新。効果中の強化や必殺技等もこの関数で処理。
			scheme_use=scheme_use.Where(x => x.Finish==false).ToList();
			enhance_use=enhance_use.Where(x => x.Finish==false).ToList();
			wait_sel=Sel_Next;
			sel_refresh();
			int i=0;
			
			for(i=0;i<5;i++){
				hand[i]=hand[i].recreate();
				if(hand[i].injury==Define.Injury_Param && hand[i].state_id!=Define.Injury_ID){
					hand[i].Stack(new Hand_Injury(hand[i]));
				}
			}
			
			for(i=0;i<scheme_use.Count;i++){
				scheme_use[i].update_scheme();
			}
			for(i=0;i<enhance_use.Count;i++){
				enhance_use[i].update_scheme();
			}
			Play_Handler.select().next_game();
			determ=null;
		}
		
		
/*-----------------------以下仮想関数。キャラクタで異なる値。-----------------------*/

		public virtual int RATE{
			get{return 0;}
		}
		
		
		public virtual int Force_Base{
			get{return 0;}
		}
		
		public virtual string Name{
			get{return "";}
		}
		
		public virtual List<Scheme> scheme_option(Player_Status me,Player_Status enem){
			return new List<Scheme>();
		}
		
		public virtual List<EnhanceMent> enhance_option(){
			List<EnhanceMent> list = new List<EnhanceMent>();
			defalt_enhance(list);
			return list;
		}
		
		
		public virtual void init(){
		}
		
		public virtual AudioClip get_music(){
			return null;
		}

		
		}
	}
