using UnityEngine;
using System.Collections;

public class BackgroundController : MonoBehaviour
 {
	void Update () {
		transform.Translate (-0.1f, 0, 0);
		if (transform.position.x < -18.8f ) {
			transform.position = new Vector3 (44.0f, 2.1f, 0);
		}
        if (Den.owari == 1)
        {
            enabled = false;
        }else
        {
            enabled = true;
        }
    }
}