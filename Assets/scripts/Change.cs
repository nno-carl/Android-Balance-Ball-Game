using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    public GameObject ball;

	void Update () {
		if(ball.transform.localPosition.z == -10.5)
        {
            Application.LoadLevel("Scene/StartUI/Ui");
        }
	}
}
