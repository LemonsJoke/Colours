﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
    Animation anim;
    public bool pressed;
	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animation>();
        pressed = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(!pressed)
            {
                if (!anim.IsPlaying("Unpressed"))
                {
                    anim.Play("Pressed");
                    new WaitForSeconds(anim["Pressed"].length);
                    pressed = true;
                }   
            }

            else
            {
                if (!anim.IsPlaying("Pressed"))
                {   
                    anim.Play("Unpressed");
                    new WaitForSeconds(anim["Unpressed"].length);
                    pressed = false;
                }
            }
        }       
	}
}
