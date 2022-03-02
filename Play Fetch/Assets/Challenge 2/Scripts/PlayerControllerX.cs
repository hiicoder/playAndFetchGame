using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float lastCall = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastCall > 0.5f )
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastCall = Time.time;
        }
    }
}
