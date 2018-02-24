﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandScript : MonoBehaviour {

    private static HandScript instance;

    [SerializeField]
    private Vector3 offset;

    public static HandScript MyInstance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<HandScript>();
            }

            return instance;
        }
    }

    public IMoveable MyMoveable { get; set; }

    private Image icon;

    // Use this for initialization
    void Start () {
        icon = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        icon.transform.position = Input.mousePosition + offset;
	}

    public void TakeMoveable(IMoveable moveable) {
        this.MyMoveable = moveable;
        icon.sprite = moveable.MyIcon;
        icon.color = Color.white;
    }

    public IMoveable Put() {
        IMoveable temp = MyMoveable;

        MyMoveable = null;

        icon.color = new Color(0, 0, 0, 0);

        return temp;
    }
}
