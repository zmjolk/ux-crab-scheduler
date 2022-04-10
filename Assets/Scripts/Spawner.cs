using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    Transform ball;

    public string ballColour = "green";

    void OnMouseDown()
    {
        Material ballMaterial;
        if (ballColour == "green") {
            ballMaterial = Resources.Load("Materials/Green", typeof(Material)) as Material;
        } else {
            ballMaterial = Resources.Load("Materials/Yellow", typeof(Material)) as Material;
        }

        Debug.Log(ballMaterial);
        ball.transform.position = transform.position;
        ball.GetComponent<Renderer>().material = ballMaterial;
        Instantiate(ball);
    }

}
