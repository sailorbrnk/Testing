﻿// https://www.youtube.com/watch?v=CzImJk7ZesI


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RonsChessboardVideo3 : MonoBehaviour {

//	public static RonsChessboard Instance{ set; get; }
//	private bool[,] allowedMoves{ set; get; }
//
//	public Chessman[,] Chessmans{ set; get; }
//	private Chessman selectedChessman;
//
//	private const float TILE_SIZE = 1.0f;
//	private const float TILE_OFFSET = 0.5f;
//
//	private int selectionX = -1;
//	private int selectionY = -1;
//
//	public List<GameObject> chessmanPrefabs;
//	private List<GameObject> activeChessman;// = new List<GameObject>();
//
//	private Quaternion orientation = Quaternion.Euler(0, 180, 0);
//	public bool isWhiteTurn = true;
//
//	// Use this for initialization
//	void Start () {
//		//SpawnChessman (0, Vector3.zero);
//		//SpawnChessman (0, GetTileCenter(3, 0));
//		SpawnAllChessmans ();
//		Instance = this;
//	}
//	
//	// Update is called once per frame
//	void Update () {
//
//		UpdateSelection ();
//		DrawChessboard ();
//
//		if (Input.GetMouseButtonDown (0)) {
//			if (selectionX >= 0 && selectionY >= 0) {
//				if (selectedChessman == null) {
//					// Select the chessman
//					SelectChessman(selectionX, selectionY);
//				} else {
//					// Move the chessman
//					MoveChessman(selectionX, selectionY);
//				}
//			}
//		}
//	}
//
//
//	//private void SpawnChessman(int index, Vector3 position)
//	private void SpawnChessman(int index, int x, int y)
//	{
//		//GameObject go = Instantiate (chessmanPrefabs [index], position, Quaternion.identity) as GameObject;
//		//GameObject go = Instantiate (chessmanPrefabs [index], position, orientation) as GameObject;
//		GameObject go = Instantiate (chessmanPrefabs [index], GetTileCenter(x, y), orientation) as GameObject;
//		go.transform.SetParent (transform);
//		Chessmans [x, y] = go.GetComponent<Chessman> ();
//		Chessmans [x, y].SetPosition (x, y);
//		activeChessman.Add (go);
//	}
//
//	private void SelectChessman (int x, int y)
//	{
//		if (Chessmans [x, y] == null)
//			return;
//		if (Chessmans [x, y].isWhite != isWhiteTurn)
//			return;
//
//		allowedMoves = Chessmans [x, y].PossibleMove ();
//		selectedChessman = Chessmans [x, y];
//		BoardHighlights.Instance.HighlightAllowedMoves (allowedMoves);
//	}
//
//	private void MoveChessman (int x, int y)
//	{
//		//if (selectedChessman.PossibleMove (x, y))
//		if (allowedMoves[x,y])
//		{
//			Chessman c = Chessmans [x, y];
//
//			if (c != null && c.isWhite != isWhiteTurn) {
//				// Capture a piece
//
//				// If it is the king
//				if (c.GetType () == typeof(King)) {
//					//End the game
//					return;
//				}
//
//				activeChessman.Remove(c.gameObject);
//				Destroy (c.gameObject);
//			}
//
//			Chessmans[selectedChessman.CurrentX, selectedChessman.CurrentY] = null;
//			selectedChessman.transform.position = GetTileCenter (x, y);
//			selectedChessman.SetPosition (x, y);
//			Chessmans [x, y] = selectedChessman;
//
//			isWhiteTurn = !isWhiteTurn;
//		}
//
//		BoardHighlights.Instance.HideHighlights ();
//		selectedChessman = null;
//	}
//
//	private void UpdateSelection()
//	{
//		if (!Camera.main)
//			return;
//
//		RaycastHit hit;
//		if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 25.0f, LayerMask.GetMask ("ChessPlane"))) {
//			//Debug.Log (hit.point);
//			selectionX = (int)hit.point.x;
//			selectionY = (int)hit.point.z;
//		} else {
//			selectionX = -1;
//			selectionY = -1;
//		}
//	}
//
//	private void SpawnAllChessmans ()
//	{
//		activeChessman = new List<GameObject> ();
//		Chessmans = new Chessman[8, 8];
//	
////		//Spawn the White team
////		SpawnChessman (0, GetTileCenter(3, 0)); //KING
////		SpawnChessman (1, GetTileCenter(4, 0)); //QUEEN
////		SpawnChessman (2, GetTileCenter(0, 0)); //ROOK (Castle)
////		SpawnChessman (2, GetTileCenter(7, 0)); //ROOK 2 (Castle)
////		SpawnChessman (3, GetTileCenter(2, 0)); //BISHOP
////		SpawnChessman (3, GetTileCenter(5, 0)); //BISHOP 2
////		SpawnChessman (4, GetTileCenter(1, 0)); //KNIGHT (Horse)
////		SpawnChessman (4, GetTileCenter(6, 0)); //KNIGHT 2 (Horse)
////	
////		//Pawns
////		for (int i = 0; i < 8; i++) {
////			SpawnChessman (5, GetTileCenter(i, 1));			
////		}
////		//====================================================================================
////		//Spawn the Black team
////		SpawnChessman (6, GetTileCenter(4, 7)); //KING
////		SpawnChessman (7, GetTileCenter(3, 7)); //QUEEN
////		SpawnChessman (8, GetTileCenter(0, 7)); //ROOK (Castle)
////		SpawnChessman (8, GetTileCenter(7, 7)); //ROOK 2 (Castle)
////		SpawnChessman (9, GetTileCenter(2, 7)); //BISHOP
////		SpawnChessman (9, GetTileCenter(5, 7)); //BISHOP 2
////		SpawnChessman (10, GetTileCenter(1, 7)); //KNIGHT (Horse)
////		SpawnChessman (10, GetTileCenter(6, 7)); //KNIGHT 2 (Horse)
////	
////		//Pawns
////		for (int i = 0; i < 8; i++) {
////			SpawnChessman (11, GetTileCenter(i, 6));			
////		}
////
//		//Spawn the White team
//		SpawnChessman (0, 3, 0); //KING
//		SpawnChessman (1, 4, 0); //QUEEN
//		SpawnChessman (2, 0, 0); //ROOK (Castle)
//		SpawnChessman (2, 7, 0); //ROOK 2 (Castle)
//		SpawnChessman (3, 2, 0); //BISHOP
//		SpawnChessman (3, 5, 0); //BISHOP 2
//		SpawnChessman (4, 1, 0); //KNIGHT (Horse)
//		SpawnChessman (4, 6, 0); //KNIGHT 2 (Horse)
//
//		//Pawns
//		for (int i = 0; i < 8; i++) {
//			SpawnChessman (5, i, 1);			
//		}
//		//====================================================================================
//		//Spawn the Black team
//		SpawnChessman (6, 3, 7); //KING
//		SpawnChessman (7, 4, 7); //QUEEN
//		SpawnChessman (8, 0, 7); //ROOK (Castle)
//		SpawnChessman (8, 7, 7); //ROOK 2 (Castle)
//		SpawnChessman (9, 2, 7); //BISHOP
//		SpawnChessman (9, 5, 7); //BISHOP 2
//		SpawnChessman (10, 1, 7); //KNIGHT (Horse)
//		SpawnChessman (10, 6, 7); //KNIGHT 2 (Horse)
//
//		//Pawns
//		for (int i = 0; i < 8; i++) {
//			SpawnChessman (11, i, 6);			
//		}
//	}
//
//	private Vector3 GetTileCenter(int x, int y)
//	{
//		Vector3 origin = Vector3.zero;
//		origin.x += (TILE_SIZE * x) + TILE_OFFSET;
//		origin.z += (TILE_SIZE * y) + TILE_OFFSET;
//		return origin;
//	}
//
//	private void DrawChessboard()
//	{
//		Vector3 widthLine = Vector3.right * 8;
//		Vector3 heightLine = Vector3.forward * 8;
//
//		// Draw the squares/tiles
//		for (int i = 0; i <= 8; i++) {
//			Vector3 start = Vector3.forward * i;
//			Debug.DrawLine (start, start + widthLine);
//			for (int j = 0; j <= 8; j++) {
//				start = Vector3.right * j;
//				Debug.DrawLine (start, start + heightLine);
//			}
//		}
//
//		// Draw the "X" in each square/tile
//		if (selectionX >= 0 && selectionY >= 0) {
//			Debug.DrawLine (
//				Vector3.forward * selectionY + Vector3.right * selectionX,
//				Vector3.forward * (selectionY + 1) + Vector3.right * (selectionX + 1));
//			Debug.DrawLine (
//				Vector3.forward * (selectionY + 1) + Vector3.right * selectionX,
//				Vector3.forward * selectionY + Vector3.right * (selectionX + 1));
//		}
//	}
}
