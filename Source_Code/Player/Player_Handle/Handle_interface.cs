using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Schemes;
using button;
using Character;
using State;

namespace Handle{
/*ハンドルのインターフェース。
「プレイヤーならボタンを生成して入力待ち」、「敵ならアルゴリズムによって選択肢を決定する」等の処理をする*/
	public interface Enhance_Handler 
	{
/*
強化するものを決めるハンドル
敵は、「魔力量上昇」、「魔力値上昇」に固定
*/
		Battle update(Battle prev,Battle next);
		void init();
	}
	
	public interface Next_Choice_Handler{
/*
次ターンに選択する3つの選択肢を決定するハンドル
敵にレベル(レベル0、レベル1)があり、レベルによってアルゴリズムが変わる
*/
		Battle update(Battle prev,Battle next);
		void init(Player_Status enemy);
		void init();
	}
	
	public interface Scheme_Handler{
/*
必殺技を決定するハンドル
*/
		void receive_scheme(List<Scheme> list);
		Battle update();
		void init(Battle prev,Battle next);
	}
	
	public interface Select_Handler{
/*
そのターンに勝負に出す手を選択するハンドル
敵は、ランダムで選択してくる
*/
		Select_Button_create sel_button{
			get;
		}
		void init();
		void create(Vector3 v);
		void next_game();
		Battle update(Battle prev,Battle next);
	}
}
