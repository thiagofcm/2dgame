 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeetCtrl : MonoBehaviour {


    GameObject player;
	// Use this for initialization
	void Start () {
        player = transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("MovingPlatform")) {
            player.transform.parent = other.transform.parent.transform;
        }
    }


    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("MovingPlatform")) {
            player.transform.parent = null;
        }
    }
    }


