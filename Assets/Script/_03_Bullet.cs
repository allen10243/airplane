using UnityEngine;
using System.Collections;

public class _03_Bullet : MonoBehaviour {

    public float BulletSpeed;

	void Start () {
	
	}
	
	void Update () {

            this.gameObject.transform.Translate(0, 0, BulletSpeed * Time.deltaTime);
       
    }
}
