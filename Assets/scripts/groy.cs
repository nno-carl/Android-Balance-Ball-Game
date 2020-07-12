using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
   

public class groy : MonoBehaviour {

        float x;
        float y;
        Gyroscope go;
        void Start()
        {
            go = Input.gyro;
            go.enabled = true;
        }
        void Update()
        {
            x = Input.acceleration.x;
            y = Input.acceleration.y;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-x, 0, -y) * 20);
        }

}

