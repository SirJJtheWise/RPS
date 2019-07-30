using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    private float deathtime = 3f;
    public ParticleSystem death;
    public ParticleSystem paperpart;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Instantiate(death, transform.position, Quaternion.identity);
            death.Play();
            col.GetComponent<status>().Takedammage();
            
            Instantiate(paperpart, transform.position, Quaternion.identity);
            paperpart.Play();
            Destroy(gameObject);

        }
        else
            if (col.CompareTag("scissor"))
        {
            Instantiate(paperpart, transform.position, Quaternion.identity);
            paperpart.Play();
            Destroy(gameObject);
        }
        else
        if (col.CompareTag("rock"))
        {
            Destroy(col.gameObject);
        }
        else
        if (col.CompareTag("paper"))
        {
            Instantiate(paperpart, transform.position, Quaternion.identity);
            paperpart.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (deathtime < 0)
        {
            Destroy(gameObject);
        }
    }
}


