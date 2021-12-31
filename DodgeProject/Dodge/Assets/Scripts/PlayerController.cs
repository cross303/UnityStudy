using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playertRigidbody;
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        playertRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        var velocity = new Vector3(xSpeed, 0, zSpeed);
        playertRigidbody.velocity = velocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);
        var gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
