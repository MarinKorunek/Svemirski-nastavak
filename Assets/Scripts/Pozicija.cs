﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozicija : MonoBehaviour {

    // Use this for initialization
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 1);
    }
}
