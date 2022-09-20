using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    public float jumpForce = 5;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 oldVelocity = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().velocity = new Vector3(oldVelocity.x, jumpForce, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Game Over!");
        // SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        score++;
        print(score);
    }
}
