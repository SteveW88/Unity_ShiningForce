using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConstructGrid : MonoBehaviour {


	public GameObject TilePrefab;
	public GameObject[] Character_Prefabs;	
	public int GridSizeX;
	public int GridSizeY;
	public List<Tile> tileList = new List<Tile>();
	public List<Character> characterList = new List<Character>();

	public Transform gridTrans;
	private Vector3 position = Vector3.zero;
	private Quaternion rotation = Quaternion.identity;
	public bool grid_constructed = false;

	void Start(){
		GenerateGrid ();

		GenerateCharacters ();

		InitializeCharacters ();

		grid_constructed = true;
	}

	void GenerateGrid(){
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
		for (int i=0; i < Character_Prefabs.Length; i++) {
			Vector3 pos = tileList [i].transform.position;
			pos.z = -5f;
			GameObject Character =GameObject.Instantiate (Character_Prefabs[i], pos, rotation) as GameObject;
			characterList.Add(Character.GetComponent<Character>());

		}
	}

	void InitializeCharacters(){
		characterList[0].Initialize(10,100,1,2,true);
		characterList[1].Initialize(10,100,1,1,false);
		characterList[2].Initialize(10,100,1,2,true);

	}
}
