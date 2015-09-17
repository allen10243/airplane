using UnityEngine;
using System.Collections;

public class _06_Wall : MonoBehaviour {

    void Start() {

    }

    void Update() {

    }

    void OnTriggerEnter(Collider Catch) {

        if (Catch.gameObject.tag == "Bullet" || Catch.gameObject.tag == "Monster_Bullet" || Catch.gameObject.tag == "Monster") {

            Destroy(Catch.gameObject);
        }
    }
}
    
