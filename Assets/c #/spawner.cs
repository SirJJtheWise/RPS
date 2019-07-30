using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    private int ran;
    private float tbtw;
    public float stbtw;
    public GameObject[] enemys;

    // Start is called before the first frame update
    void Start()
    {
        tbtw = stbtw;
    }

    // Update is called once per frame
    void Update()
    {if(tbtw <= 0)
        {
            ran = Random.Range(0, 3);
            Instantiate(enemys[ran], transform.position, Quaternion.identity);
            tbtw = stbtw;
        }
        else { tbtw -= Time.deltaTime; }
        
    }
    
}
