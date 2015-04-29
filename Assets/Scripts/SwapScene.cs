﻿using UnityEngine;
using UnityEditor;
using System.Collections;

public class SwapScene : MonoBehaviour {
    Material red, blue;
    GameObject[] objects;
    public bool redBool = false, blueBool = true;

	// Use this for initialization
	void Start () 
    {
        red = (Material) Resources.Load("ShadersMaterials/Red");
        blue = (Material) Resources.Load("ShadersMaterials/Blue");
        objects = GameObject.FindGameObjectsWithTag("World");
        Debug.Log(red.color);
        Debug.Log(blue.color);
        for(int i = 0; i<objects.Length;i++)
        {
            Debug.Log(objects[i].GetComponent<Renderer>().material.color);

            if (objects[i].GetComponent<Renderer>().material.color == blue.color)
                objects[i].SetActive(true);

            else if (objects[i].GetComponent<Renderer>().material.color == red.color)
                objects[i].SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            redBool = !redBool;
            blueBool = !blueBool;
            if(redBool)
            {
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i].GetComponent<Renderer>().material.color == red.color)
                        objects[i].SetActive(true);

                    else if (objects[i].GetComponent<Renderer>().material.color == blue.color)
                        objects[i].SetActive(false);
                }
            }

            else if(blueBool)
            {
                for (int i = 0; i < objects.Length; i++)
                {
                    if (objects[i].GetComponent<Renderer>().material.color == blue.color)
                        objects[i].SetActive(true);

                    else if (objects[i].GetComponent<Renderer>().material.color == red.color)
                        objects[i].SetActive(false);
                }
            }
        }
	}
}
