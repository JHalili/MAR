using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Text;
using UnityEngine.Windows.Speech;
public class VoiceCommands : MonoBehaviour {

    private string[] stringCommands = new string[] { "up", "down", "left", "right" };
    private ConfidenceLevel msgConf = ConfidenceLevel.Medium;


    /// <summary>
    ///  USE THE PHRASE RECOGNIZER CLASS PROVIDED BY UNITY
    ///  the string commands above are just examples
    /// </summary>
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
