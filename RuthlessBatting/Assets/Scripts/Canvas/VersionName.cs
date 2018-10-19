﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionName : MonoBehaviour {

    void Awake()
    {
        GetComponent<Text>().text = "ALPHA VERSION V" + Application.version;
    }
}