using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.Linq;
using State;
using Hand;
using Win_Lose;

namespace Hand{

/*����񂯂�̑I�����ɕK�v�ȕϐ���N���X���܂Ƃ߂��N���X�B���̃N���X�Œl�̃J�v�Z�������s���B
���g��ID+1�ɑ����ŏ��ĂāA���g��ID-1�ɑ����ŕ�����B
�I�����ɂ́A���́A��J�x�A�����x�̃p�����[�^������A��Ԃ����B�i�ŏ��̏�Ԃ͐���j*/


	public class select_type:sel_button_available,Judge {
		Stack<Hand_State> state=new Stack<Hand_State>();	//�I�����̏�ԁB
		Sel_State sel_state;
		Hand_State hand_state;
		string last_result;	//�Ō�̂���񂯂�̌��ʂ�ێ��B
		Sprite information;
		int ID;	//�O�[�A�`���L���̑I�����̎��ʔԍ��B
		int inju;	//	�����x�p�����[�^�B
		int fatig; //��J�x�p�����[�^�B
		int force;	//���̓p�����[�^�B
		int Win;
		int Lose;
		int baseforce;
		
		public select_type(int ID,int baseforce,Sprite image,Hand_State init_state){
			sel_state=new Non_Select();
			this.ID=ID;
			this.Win=ID+1;
			if(Win>=5){ Win=0;}
			this.Lose=ID-1;
			if(Lose<0){ Lose=4;}
			this.baseforce=baseforce;
			this.information=image;
			force=0;
			this.hand_state=init_state;
			Stack(this.hand_state.Clone(this));
		}
		
		public virtual void init(){
			sel_state=new Non_Select(); //���^�[���̑I���Łu�I���ς݁v����u���I���v�ɂ���B
		}
		
		public Winner_Loser win_or_lose(Judge judge){
			return state.Peek().Judgement(judge);
		}
		
		public Sprite image{
			get{return information;}
		}
		
		
		
		public void Stack(Hand_State state){
			state.receive(Win,Lose);
			this.state.Push(state);
		}
		
		public void pop(){
			if(state.Count<=1){
				return;
			}
			state.Pop();
		}
		
		public int pass_ID{
			get{return ID;}
		}
		
		
		public string state_name{
			get{return state.Peek().Name;}
		}
		
		public int state_id{
			get{return state.Peek().State_ID;}
		}
		
		public int injury{
			get{return inju;}
			set{inju=value;
				if(injury>5){ inju=5; }
				if(injury<0){ inju=0; }
			}
		}
		
		public int fatigue{
			get{return fatig;}
			set{fatig=value;
				if(fatig>10){ fatig=10;}
				if(fatig<0){ fatig=0;}
			}
		}
		
		public int pass_force{
			get{return force;}
			set{force=value;
				if(force>30){ force=30; }
				if(force<0){ force=0; }
			}
		}
		
		public int total_force{
			get{
				if(pass_force+baseforce+state.Peek().add_force()>30){return 30;}
				else{return pass_force+baseforce+state.Peek().add_force();}
			}
		}
		
		
		public bool select_state(){
			return sel_state.available(ref sel_state);
		}
		
		public int Lose_ID{
			get{return Lose;}
		}
		
		public Judge recreate(){
			if(state.Peek().Check_recreate()){
				return new select_type(ID,baseforce,information,hand_state);
			}
			
			return this;
		}
		
		public string Last_Result{
			get{return last_result;}
			set{
				last_result=value;
				}
		}
	}
}
