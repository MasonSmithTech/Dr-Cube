using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    public Camera manCam;
    public Camera mapCam;
    public GameObject player;
    public GameObject HealthBar;
    public GameObject mapLabels;

    // Start is called before the first frame update
    void Start()
    {
        manCam.enabled = true;
        mapCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (manCam.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                manCam.enabled = false;
                mapCam.enabled = true;
                player.GetComponent<PlayerMovement>().enabled = false;
                player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                HealthBar.SetActive(false);
                mapLabels.SetActive(true);
            }
        }
        else if (manCam.enabled == false)
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                manCam.enabled = true;
                mapCam.enabled = false;
                HealthBar.SetActive(true);
                mapLabels.SetActive(false);
                player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                player.GetComponent<Rigidbody2D>().WakeUp();
                player.GetComponent<PlayerMovement>().enabled = true;

                
                
            }
        }
    }
}
