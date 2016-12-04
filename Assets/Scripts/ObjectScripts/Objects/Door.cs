﻿using UnityEngine;
using System.Collections;

public class Door : InteractableObject {


    InteractableObject door;

    [SerializeField]
    InteractableObject trigger;

    Animator anim;



	// Use this for initialization
	void Start () {

        door = GetComponent<Door>();
        door.isActive = false;
        door.type = Switch;
        anim = GetComponent<Animator>();
	
	}


    void StartInteract()
    {
        if (door.isActive)
            return;
        door.isActive = true;
        Open();
    }


    public override void StopInteract()
    {
        if (!door.isActive)
            return;
        door.isActive = false;
        Close();
        
    }


    void Open()
    {
        anim.SetBool("Open", true);
    }

    void Close()
    {
        anim.SetBool("Open", false);
    }



    // Update is called once per frame
    void Update () {
        if (trigger.isActive)
            StartInteract();
        if (!trigger.isActive)
            StopInteract();
	
	}
}
