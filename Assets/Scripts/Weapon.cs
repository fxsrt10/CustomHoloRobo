using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Stats stats;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Stats
{
    public int attack { get; set; }
    public int homing { get; set; }
    public int speed { get; set; }
    public int down { get; set; }
    public int reload { get; set; }
    public int size { get; set; }
    public int time { get; set; }

}
