using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : status
{
    public GameObject paper;
    public GameObject rock;
    public GameObject scissors;
    public Transform pos;
    public Animator anim;
    public float STBTw;
    private float TBtw;
    
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) { Destroy(gameObject); }
        else

       if (TBtw <= 0)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                TBtw = STBTw;
                Instantiate(rock, pos.position, Quaternion.identity);
                anim.SetTrigger("attack");
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                TBtw = STBTw;
                Instantiate(paper, pos.position, Quaternion.identity);
                anim.SetTrigger("attack");
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                TBtw = STBTw;
                Instantiate(scissors, pos.position, Quaternion.identity);
                anim.SetTrigger("attack");
            }
        }
        else TBtw -= Time.deltaTime;
    }
    
}
