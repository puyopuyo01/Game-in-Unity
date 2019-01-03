using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using B;

namespace B{

	public interface Judge
	{
		string win_or_lose(Judge judge,int a_force,int b_force);
		int Serch_ID();
		
	}
	

	public class select_type  {
		public int ID=0;
		
		protected string w_l(Judge judge,int a_force,int b_force,int win,int lose){
			if(judge.Serch_ID() == win){
				return "WIN";
				}
			else if(judge.Serch_ID()==lose){
				return "LOSE";
				}
			else{
				return draw(a_force,b_force);
			}
		}
			
		protected string draw(int a_force,int b_force){
			if(a_force>b_force){
				return "DRAW_WIN";
			}
			else if(a_force<b_force){
				return "DRAW_LOSE";
			}
			else {
				return "DRAW";
			}
		}
		
		
		public int Serch_ID(){
			return ID;
		}
		

		}
}
