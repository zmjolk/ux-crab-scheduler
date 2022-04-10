using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.DateTime;

public class Game : MonoBehaviour
{

	[SerializeField]
	Transform dateBoxPrefab;

    [SerializeField]
    Transform ballSpawner;

	
	void Awake () {

        var now = System.DateTime.Now;
        
        dateBoxPrefab.transform.position = new Vector3(-15f, 2f, 0);
        for (int i = 0; i < 20; i++) {

            // add 1 day per loop to fill in boxes
            now = now.AddDays(1);

            dateBoxPrefab.transform.position = dateBoxPrefab.transform.position + new Vector3(1.5f, 0, 0);
            dateBoxPrefab.Find("Floor/Canvas/Button/Text").GetComponent<UnityEngine.UI.Text>().text = now.ToString("MMMM\ndd");
            Instantiate(dateBoxPrefab);
        }

        ballSpawner.transform.position = new Vector3(-10f, 12f, -2f);
        ballSpawner.gameObject.GetComponent<Spawner>().ballColour = "green";
        ballSpawner.Find("Canvas/Text").GetComponent<UnityEngine.UI.Text>().text = "CLICK TO RELEASE \nCONFIRM BALL";
        Instantiate(ballSpawner);

        ballSpawner.transform.position = new Vector3(10f, 12f, -2f);
        ballSpawner.gameObject.GetComponent<Spawner>().ballColour = "yellow";
        ballSpawner.Find("Canvas/Text").GetComponent<UnityEngine.UI.Text>().text = "CLICK TO RELEASE \n'MAYBE' BALL";
        Instantiate(ballSpawner);
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
