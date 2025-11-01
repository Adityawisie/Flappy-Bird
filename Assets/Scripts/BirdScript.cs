using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float upForce = 10f;
    public LogicScript Logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * upForce;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameover();
        birdIsAlive = false;
    }
}
