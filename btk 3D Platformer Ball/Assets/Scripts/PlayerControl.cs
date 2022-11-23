using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    
    private Rigidbody rb;
    [SerializeField]
    private float pushForce = 1000f;
    private float movement;
    [SerializeField] 
    private float speed=5f;
    public Vector3 spawnPoint;
   
    GameManager gameManager;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint = this.transform.position;
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);
        rb.velocity = new Vector3(movement * speed, rb.velocity.y, rb.velocity.z);
        FallDedect();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Barier"))
        {
            gameManager.spawnEt();
        }
    }
    private void FallDedect()
    {
        if (rb.position.y <-2f)
        {
            gameManager.spawnEt();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndObject"))
        {
            gameManager.LevelUp();
        }
    }


}
