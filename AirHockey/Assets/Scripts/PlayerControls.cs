using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-20f * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(20f * Time.deltaTime, 0, 0);
		}

        float h = 30.0f * Time.deltaTime * Input.GetAxis("Mouse X");
		transform.Translate(h, 0, 0);
    }
}
