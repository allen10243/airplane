using UnityEngine;
using System.Collections;

public class _04_Monster : MonoBehaviour {

    public float MonsterSpeed;
    public GameObject Monster_Bullet;

    public float Monsterfire;
    public float MonsterfireTime;

    public int MonsterScore;
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Monsterfire -= 1 * Time.deltaTime;
        this.gameObject.transform.Translate(0, 0, MonsterSpeed * Time.deltaTime * -1);

        if (Monsterfire <= 0)
        {
            Instantiate(Monster_Bullet, transform.position, transform.rotation);
            Monsterfire = MonsterfireTime;
        }


    }

    void OnTriggerEnter(Collider Catch)
    {

        if (Catch.gameObject.tag == "Bullet"){

            _05_GameControl.Score += MonsterScore;
            Destroy(gameObject);
            Destroy(Catch.gameObject); 
        }
    }

}