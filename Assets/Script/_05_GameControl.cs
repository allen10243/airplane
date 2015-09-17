using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class _05_GameControl : MonoBehaviour {

    public GameObject Monster;
    public float MonsterFire;
    public float MonsterFireTime;
    public float Scale;

    public Text ScoreShow;
    public static int Score;


    void Start () {
        Score = 0;

	}
	
	// Update is called once per frame
	void Update () {

        MonsterFire -= 1 * Time.deltaTime;

        if (MonsterFire <= 0)
        {
            int Produce = Random.Range(0, 5);

            if (Produce == 0){
                Instantiate(Monster, new Vector3(0 * Scale, 0, 15), transform.rotation);
            }
            if (Produce == 1){
                Instantiate(Monster, new Vector3(5.5f * Scale, 0, 15), transform.rotation);
            }
            if (Produce == 2){
                Instantiate(Monster, new Vector3(11 * Scale, 0, 15), transform.rotation);
            }
            if (Produce == 3){
                Instantiate(Monster, new Vector3(-5.5f * Scale, 0, 15), transform.rotation);
            }
            if (Produce == 4){
                Instantiate(Monster, new Vector3(-11 * Scale, 0, 15), transform.rotation);
            }

            MonsterFire = MonsterFireTime;
        }


        ScoreShow.text = "" + Score;
        

    }
}
