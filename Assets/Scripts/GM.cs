using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

	public static GM instance = null;
	public float yMinLive = -10f;
	public Transform spawnPoint;
	public GameObject playerPrefab;	
	public float TimeToRespawn = 2f;
	public UI ui;
	PlayerController player;
	GameData data = new GameData();

	void Awake(){
		if(instance == null){
		if (instance ==null){
			instance = this;
		}
	
	}
	}

	
	void Start () {
		if (player == null){
			RespawnPlayer();
		}
	}
	

	void Update () {
		if (player == null){
			GameObject obj = GameObject.FindGameObjectWithTag("Player");
			if( obj != null) {
				player = obj.GetComponent<PlayerController>();
			}
		}
		 DisplayHudData();
		
	}

	void DisplayHudData() {
		ui.hud.txtCoinCount.text = "x " + data.coinCount;
	}

	public void IncrementCoinCount(){
		data.coinCount++;
	}

	public void RespawnPlayer(){
		Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
	}

    public void KillPlayer(){
		if (player != null){
			Destroy(player.gameObject);
			Invoke("RespawnPlayer", TimeToRespawn);
		}
	}
}