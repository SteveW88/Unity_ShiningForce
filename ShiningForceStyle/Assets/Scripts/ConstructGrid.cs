using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConstructGrid : MonoBehaviour {


	public GameObject TilePrefab;
	public GameObject PlayerPrefab;
	public int GridSizeX;
	public int GridSizeY;
	private List<Tile> tileList = new List<Tile>();
	public Transform mainCameraTrans;
	public Transform gridTrans;
	private Vector3 position = Vector3.zero;
	private Quaternion rotation = Quaternion.identity;

	void Start(){
		GenerateGrid ();

		GenerateCharacters ();
	}

	void GenerateGrid(){
		mainCameraTrans.position = new Vector3 ((float)(GridSizeX - 1) / 2, (float)(GridSizeY - 1) / 2, -10);

		for (int i=0; i<GridSizeX; i++) {
			for(int j=0; j<GridSizeY; j++){
				position.x = (float)i;
				position.y = (float)j;
				GameObject tileOBJ = GameObject.Instantiate(TilePrefab,position,rotation) as GameObject;
				tileOBJ.transform.SetParent(gridTrans);
				tileList.Add(tileOBJ.GetComponent<Tile>());

			}
		}


	}

	void GenerateCharacters(){
		Vector3 pos = tileList [0].transform.position;
		pos.z = -5f;
		GameObject.Instantiate (PlayerPrefab, pos, rotation);
	}
}
