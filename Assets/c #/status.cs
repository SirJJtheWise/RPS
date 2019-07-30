using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status : MonoBehaviour
{
    public Text healthbar;
    public int health;
    public GameObject winscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Takedammage()
    {
        health -= 1;
    }
}
