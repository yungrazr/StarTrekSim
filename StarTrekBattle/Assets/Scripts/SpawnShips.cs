﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShips : MonoBehaviour {

    public GameObject EnemyShipPrefab;
    public GameObject target;
    Vector3 mothershipPos;

	// Use this for initialization
	void Start () {
        mothershipPos = transform.position;
        for(int i = 0; i<5; i++)
        {
            GameObject prefab = Instantiate(EnemyShipPrefab, mothershipPos, Quaternion.identity);
            prefab.GetComponent<Seek>().target = transform.position - transform.up * 50 + transform.forward * 5 * i;
            prefab.GetComponent<Seek>().target2 = target;
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}