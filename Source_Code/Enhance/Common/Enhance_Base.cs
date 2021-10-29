using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using State;
using Hand;

namespace Character{
/*強化処理のインタフェース*/
	public interface EnhanceMent{
		void enhance(Player_Status me,Player_Status enem);	//この関数に強化処理を書く。
		void init(Player_Status me,Player_Status enem);
		int Cost{
			set;
			get;
		}
		string Name{
			get;
		}
		string Discription{
			get;
		}
	}

	public class Enhance_Base:sel_button_available{
		int cost;
		protected Sel_State sel_state;
		protected string name;
		protected string discription;
		
		
		public Enhance_Base(){
			sel_state=new Non_Select();
		}
		
		public bool select_state(){
			return sel_state.available(ref sel_state);
		}
		
		public virtual void init(Player_Status me,Player_Status enem){
		}
		
		public virtual void refresh(){
			sel_state=new Non_Select();
		}
		
	
		public int Cost{
			set{
				cost=value;
				if(cost<0){cost=0;}
				}
			get{ return cost;}
		}
		
		public string Name{
			get{return name;}
		}
		
		public string Discription{
			get{return discription;}
		}

	}
}
