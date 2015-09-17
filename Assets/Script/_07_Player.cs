using UnityEngine;
using System.Collections;

public class _07_Player : MonoBehaviour {

    public Transform Player;
    public float PlayerSpeed;
    public Transform MainCamera;
    public float UpPower;
    public bool Departure;

    void Start () {
	
	}
	
    	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.position = Vector3.MoveTowards
                (Player.position, new Vector3(Player.position.x, Player.position.y, Player.position.z + 20), PlayerSpeed * Time.deltaTime);

            MainCamera.position = Vector3.MoveTowards
                (MainCamera.position, new Vector3(MainCamera.position.x, MainCamera.position.y, MainCamera.position.z + 20), PlayerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.position = Vector3.MoveTowards
                (Player.position, new Vector3(Player.position.x, Player.position.y, Player.position.z - 20), PlayerSpeed * Time.deltaTime);

            MainCamera.position = Vector3.MoveTowards
                (MainCamera.position, new Vector3(MainCamera.position.x, MainCamera.position.y, MainCamera.position.z - 20), PlayerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (Departure == false)
            {
                if (Player.position.z > 40)
                    UpPower = 8;
                if (Player.position.z > 20 && Player.position.z < 40)
                    UpPower = 5;
                if (Player.position.z < 20)
                    UpPower = 2;

                Departure = true;
            }


            if (Departure == true)
            {
                GetComponent<Rigidbody>().useGravity = true; 

                Player.position = Vector3.MoveTowards
                 (Player.position, new Vector3(Player.position.x, Player.position.y + UpPower, Player.position.z), 1000000);

                MainCamera.position = Vector3.MoveTowards
                    (MainCamera.position, new Vector3(Player.position.x, Player.position.y, Player.position.z), 1000000);
            }
        }

    }
}
