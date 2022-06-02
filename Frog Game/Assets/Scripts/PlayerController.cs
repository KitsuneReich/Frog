using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("left") || Input.GetKeyDown("right")) {
            float horizontal = Input.GetAxis("Horizontal");
            Debug.Log(horizontal);

            Vector2 position = transform.position;
            position.x = position.x + 1 * horizontal;
            transform.position = position;
        }
        if (Input.GetKeyDown("up") || Input.GetKeyDown("down")) {
            float vertical = Input.GetAxis("Vertical");
            Debug.Log("Vertical");

            Vector2 position = transform.position;
            position.y += 1 * vertical;
            transform.position = position;
        }
    }
}
