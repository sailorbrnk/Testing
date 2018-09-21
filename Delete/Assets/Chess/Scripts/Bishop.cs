﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : Chessman {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public override bool[,] PossibleMove ()
	{
		bool[,] r = new bool[8, 8];

		Chessman c;
		int i, j;;

		// Top Left
		i = CurrentX;
		j = CurrentY;

		while (true) {
			i--;
			j++;
			if (i < 0 || j >= 8)
				break;

			c = BoardManager.Instance.Chessmans [i, j];
			if (c == null)
				r [i, j] = true;
			else {
				if (isWhite != c.isWhite)
					r [i, j] = true;

				break;
			}
		}

		// Top Left
		i = CurrentX;
		j = CurrentY;

		while (true) {
			i--;
			j++;
			if (i < 0 || j >= 8)
				break;

			c = BoardManager.Instance.Chessmans [i, j];
			if (c == null)
				r [i, j] = true;
			else {
				if (isWhite != c.isWhite)
					r [i, j] = true;

				break;
			}
		}

		// Top Right
		i = CurrentX;
		j = CurrentY;

		while (true) {
			i++;
			j++;
			if (i >= 8 || j >= 8)
				break;

			c = BoardManager.Instance.Chessmans [i, j];
			if (c == null)
				r [i, j] = true;
			else {
				if (isWhite != c.isWhite)
					r [i, j] = true;

				break;
			}
		}

		// Down Left
		i = CurrentX;
		j = CurrentY;

		while (true) {
			i--;
			j--;
			if (i < 0 || j < 0)
				break;

			c = BoardManager.Instance.Chessmans [i, j];
			if (c == null)
				r [i, j] = true;
			else {
				if (isWhite != c.isWhite)
					r [i, j] = true;

				break;
			}
		}

		// Down right
		i = CurrentX;
		j = CurrentY;

		while (true) {
			i++;
			j--;
			if (i >= 8 || j < 0)
				break;

			c = BoardManager.Instance.Chessmans [i, j];
			if (c == null)
				r [i, j] = true;
			else {
				if (isWhite != c.isWhite)
					r [i, j] = true;

				break;
			}
		}

		return r;
	}
}
