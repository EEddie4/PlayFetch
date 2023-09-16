using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogDelay = 1.0f;
    public float nextShot;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextShot)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextShot = Time.time + dogDelay;
        }
    }
}
