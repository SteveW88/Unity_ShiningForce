using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	// Stats
	private int attack_dmg;
	private int health;
	private int speed;
	private int movement;

	public bool playerOne;


	public void Initialize(int dmg, int hp, int spd, int mv, bool player){
		SetDmg (dmg);
		SetHealth (hp);
		SetSpeed (spd);
		SetMovement (mv);
		SetPlayerOne (player);
	}

	// Get Methods
	public int GetDmg(){
		return attack_dmg;
	}
	public int GetHealth(){
		return health;
	}
	public int GetSpeed(){
		return speed;
	}
	public int GetMovement(){
		return movement;
	}
	public bool IsPlayerOne(){
		return playerOne;
	}
	// Set Methods
	public void SetDmg(int dmg){
		attack_dmg = dmg;
	}
	public void SetHealth(int hp){
		health = hp;
	}
	public void SetSpeed(int spd){
		speed = spd;
	}
	public void SetMovement(int move){
		movement = move;
	}
	public void SetPlayerOne(bool player){
		// if true -- player 1
		playerOne = player;
	}
}
