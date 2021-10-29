using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using State;
using Win_Lose;

namespace Hand{
/*選択肢が持つ状態のインタフェース。*/
	public interface Hand_State{
		Winner_Loser Judgement(Judge Enemy);	//自身の選択肢と敵の選択肢比較して結果を返す
		int add_force();	//状態の持つ魔力を返す。「覚醒」以外は、魔力値0。
		Hand_State Clone(Judge judge);	//状態を動的確保して返す。状態をまとめてポップするときに使用。
		int State_ID{
			get;
		}
		string Name{
			get;
		}
		bool Check_recreate();
		void receive(int win,int lose);
	}
	
	
/*選択肢の状態クラスの共通処理、変数をまとめたクラス。*/
	public class Common_Decision {
		Judge My_Judge;
		int Win;
		int Lose;
		string result_name_win,result_name_lose;
		
		public Common_Decision(){
		}
		
		public Common_Decision(Judge My_Judge,string name_win,string name_lose){
			this.My_Judge=My_Judge;
			result_name_win=name_win;
			result_name_lose=name_lose;
		}
		
		public Common_Decision(Judge My_Judge){
			this.My_Judge=My_Judge;
			result_name_win="魔力勝ち";
			result_name_lose="魔力負け";
		}
		
		public virtual int add_force(){
			return 0;
		}
		
		public void receive(int win,int lose){
			this.Win=win;
			this.Lose=lose;
		}
		
		public virtual bool Check_recreate(){
			return false;
		}
	
		protected Winner_Loser Judgement_Base(Judge Enemy){
		/*
		じゃんけんの結果を判定。
		結果は自身の状態によって決まる。あいこは存在しない。
		*/
			Winner_Loser win_lose;
			if(Enemy.pass_ID == Win){
				win_lose=new Win();
				}
			else if(Enemy.pass_ID==Lose){
				win_lose=new Lose();
				}
			else{
				win_lose=draw(this.My_Judge.total_force,Enemy.total_force);
			}
			if(Enemy.state_id==Define.Injury_ID){
				win_lose=new Win();
			}
			My_Judge.Last_Result=win_lose.Result;
			return win_lose;
		}
			
		protected Winner_Loser draw(int first,int second){
			if(first >= second){
				return new Draw_Win(result_name_win);
			}
			else{
				return new Draw_Lose(result_name_lose);
			}
		}
		}
	
	}
