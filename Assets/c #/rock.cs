using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{ private  float deathtime=3f;
    public ParticleSystem death;
    public ParticleSystem rockpart;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Instantiate(death, transform.position, Quaternion.identity);
            death.Play();
            col.GetComponent<status>().Takedammage();
            
            
            Instantiate(rockpart, transform.position, Quaternion.identity);
            rockpart.Play();
            Destroy(gameObject);

        }
        else
            if (col.CompareTag("paper"))
        {
            Instantiate(rockpart, transform.position, Quaternion.identity);
            rockpart.Play();
            Destroy(gameObject);
        }
        else
        if (col.CompareTag("scissor"))
        {
            GameObject.FindGameObjectWithTag("score").GetComponent<scpresystem>().scorvalue += 1;
            Destroy(col.gameObject);
        }
        else
        if (col.CompareTag("rock"))
        {
            Instantiate(rockpart, transform.position, Quaternion.identity);
            rockpart.Play();
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
