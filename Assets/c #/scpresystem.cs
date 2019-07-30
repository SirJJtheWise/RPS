using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scpresystem : MonoBehaviour
{
    public Text score;
    public int scorvalue;
    // Start is called before the first frame update
    void Start()
    {
        scorvalue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = System.Convert.ToString(scorvalue);
    }
}
