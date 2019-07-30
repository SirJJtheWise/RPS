using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scissor : MonoBehaviour
{
    private float deathtime = 3f;
    public ParticleSystem death;
    public ParticleSystem scissorpart;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Instantiate(death, transform.position, Quaternion.identity);
            death.Play();
            col.GetComponent<status>().Takedammage();
            
            Instantiate(scissorpart, transform.position, Quaternion.identity);
            scissorpart.Play();
            Destroy(gameObject);
        }
        else
            if (col.CompareTag("rock"))
        {
            Instantiate(scissorpart, transform.position, Quaternion.identity);
            scissorpart.Play();
            Destroy(gameObject);
        }
        else
        if (col.CompareTag("paper"))
        {
            Destroy(col.gameObject);
        }
        else
        if (col.CompareTag("scissor"))
        {
            Instantiate(scissorpart, transform.position, Quaternion.identity);
            scissorpart.Play();
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
