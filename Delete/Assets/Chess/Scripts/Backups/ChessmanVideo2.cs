using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessmanVideo2 : MonoBehaviour {

	public int CurrentX{ set; get; }
	public int CurrentY{ set; get; }
	public bool isWhite;

	public void SetPosition(int x, int y)
	{
		CurrentX = x;
		CurrentY = y;
	}

	public virtual bool PossibleMove(int x, int y)
	{
		return true;
	}

//	// Use this for initialization
//	void Start () {
//		
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		
//	}
}
