using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            GameUI.manage.gameFinished = true;
        }
        if (other.tag == "AI")
        {
            GameUI.manage.gameFailed = true;
        }
    }

}
