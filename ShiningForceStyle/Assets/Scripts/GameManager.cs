using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	private List<Tile> tileList;
	private List<Character> characterList;
	public ConstructGrid CG_grid;
	public Transform mainCameraTrans;
	private Vector3 camPos;

	private int currentTurn;
	private Character currentCharacter;

	void Update () {
		if (CG_grid.grid_constructed) {
			GetLists();

			if(Input.GetButtonDown("Fire1"))
				IncrementTurn();

			currentCharacter = characterList[currentTurn];

			camPos = currentCharacter.transform.position;
			camPos.z = -10.0f;
			mainCameraTrans.position = camPos;





		}
	}

	void GetLists(){
		tileList = CG_grid.tileList;
		characterList = CG_grid.characterList;
	}

	public void IncrementTurn(){
		currentTurn++;
		if (currentTurn == characterList.Count)
			currentTurn = 0;
	}
}
