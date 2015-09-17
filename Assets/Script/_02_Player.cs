using UnityEngine;
using System.Collections;

public class _02_Player : MonoBehaviour {

    public Transform Player;
    public float PlayerSpeed;
    public GameObject Bullet;
    // Use this for initialization}
    void Start() {

    }

    // Update is called once per frame
    void Update(){


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, transform.rotation);

        }

        if (Input.GetKey (KeyCode.UpArrow)){
            Player.position = Vector3.MoveTowards
                (Player.position, new Vector3(Player.position.x, Player.position.y, Player.position.z+20 ), PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.position = Vector3.MoveTowards
                (Player.position, new Vector3(Player.position.x, Player.position.y, Player.position.z - 20), PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.position = Vector3.MoveTowards
                (Player.position, new Vector3(Player.position.x + 20, Player.position.y, Player.position.z ), PlayerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.position = Vector3.MoveTowards
                (Player.position, new Vector3(Player.position.x - 20, Player.position.y, Player.position.z ), PlayerSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider Catch)
    {

        if (Catch.gameObject.tag == "Monster_Bullet" || Catch.gameObject.tag == "Monster")
        {
            
            Destroy(gameObject);
            Destroy(Catch.gameObject);
        }
    }

}
