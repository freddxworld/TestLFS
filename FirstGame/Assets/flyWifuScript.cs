using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyWifuScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logic logic;
    public bool flyingStil = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && flyingStil == true)
        {
             myRigidbody.velocity = Vector2.up * flapStrength; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        flyingStil = false;
    }
}
