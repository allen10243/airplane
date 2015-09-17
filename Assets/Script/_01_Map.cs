using UnityEngine;
using System.Collections;

public class _01_Map : MonoBehaviour {

    public float MapMoveSpeed; //The moving speed of map, UV
    float OffsetY; 

	void Start () {
	
	}
	
	void Update () {

	    OffsetY +=  MapMoveSpeed * Time.deltaTime;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, OffsetY); //some difference between unity 4 and 5
        
	}
}
