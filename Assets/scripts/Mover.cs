using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public GameObject go;
    public int level;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public int count;

    private void Start()
    {
        life1 = GameObject.FindGameObjectWithTag("Life1");
        life2 = GameObject.FindGameObjectWithTag("Life2");
        life3 = GameObject.FindGameObjectWithTag("Life3");
        count = 0;
    }


    //trap
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "target")
        {
            go.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Handheld.Vibrate();
            Application.LoadLevel(level);
        }
    }


    //obstacle
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Handheld.Vibrate();
            count = count + 1;
            if(count == 1)
            {
                life1.SetActive(false);
            }
            if(count == 2)
            {
                life2.SetActive(false);
            }
            if(count == 3)
            {
                life3.SetActive(false);
                Application.LoadLevel(level);
            }
        }
    }
}
