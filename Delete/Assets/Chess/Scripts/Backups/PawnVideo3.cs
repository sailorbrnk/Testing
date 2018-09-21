using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnVideo3 : Chessman {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	public override bool[,] PossibleMove ()
//	{
//		bool[,] r = new bool[8, 8];
//		Chessman c, c2;
//		//r [3, 3] = true;
//
//		//White Team Move
//		if (isWhite) {
//			//Diagonal Left
//			if (CurrentX != 0 && CurrentY != 7) 
//			{
//				c = RonsChessboard.Instance.Chessmans [CurrentX - 1, CurrentY + 1];
//				if (c != null && !c.isWhite)
//					r [CurrentX - 1, CurrentY + 1] = true;
//			}
//		
//			//Diagonal Right
//			if (CurrentX != 7 && CurrentY != 7) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX + 1, CurrentY + 1];
//				if (c != null && !c.isWhite)
//					r [CurrentX + 1, CurrentY + 1] = true;
//			}
//		
//			//Middle
//			if (CurrentY != 7) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX, CurrentY + 1];
//				if (c == null)
//					r [CurrentX, CurrentY + 1] = true;
//			}
//
//
//			//Middle on First Move
//			if (CurrentY == 1) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX, CurrentY + 1];
//				c2 = RonsChessboard.Instance.Chessmans [CurrentX, CurrentY + 2];
//				if (c == null & c2 == null)
//					r [CurrentX, CurrentY + 2] = true;
//			}
//		}
//		else 
//		{
//			//Diagonal Left
//			if (CurrentX != 0 && CurrentY != 0) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX - 1, CurrentY - 1];
//				if(c != null && c.isWhite)
//					r[CurrentX - 1, CurrentY - 1] = true;
//			}
//			
//			//Diagonal Right
//			if (CurrentX != 7 && CurrentY != 0) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX + 1, CurrentY - 1];
//				if(c != null && c.isWhite)
//					r[CurrentX + 1, CurrentY - 1] = true;
//			}
//
//			//Middle
//			if (CurrentY != 0) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX, CurrentY - 1];
//				if(c == null)
//					r[CurrentX, CurrentY - 1] = true;
//			}
//
//
//			//Middle on First Move
//			if (CurrentY == 6) {
//				c = RonsChessboard.Instance.Chessmans [CurrentX, CurrentY - 1];
//				c2 = RonsChessboard.Instance.Chessmans [CurrentX, CurrentY - 2];
//				if(c == null & c2 == null)
//					r[CurrentX, CurrentY - 2] = true;
//			}
//		}
//
//		return r;
//	}
}
