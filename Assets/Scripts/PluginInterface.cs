﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PluginInterface : MonoBehaviour
{

    public TMP_Text DebugText;

    // Start is called before the first frame update
    void Start()
    {
        InstallTestEnv();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstallTestEnv()
    {
        DebugText.text = SettingsPlugin.InstallEnvironment();
        Debug.Log(DebugText.text);
    }
}
