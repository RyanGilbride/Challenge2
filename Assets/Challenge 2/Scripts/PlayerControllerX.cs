﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float antiSpam = 0;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && antiSpam <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            antiSpam = 1;
        }
        if (antiSpam >= 0)
        {
            antiSpam -= Time.deltaTime;
        }
    }
}
