using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 10.0f;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {

        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        //Moves Background and Obstacles Left
        if (playerControllerScript.gameOver == false)
        {

            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        //Destroys Obstacles if past x range
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {

            Destroy(gameObject);

        }
    }
}
