using UnityEngine;
using System.Collections;
using System;

public class Button : InteractableObject {

    InteractableObject button;
    Animator anim;
    Player activator;

    [SerializeField]
    bool isTimed;

    [SerializeField]
    float Timer;

    float currTime = 0.0f;



    public override void StartInteract(Player p)
    {
        if (button.isActive)
            return;

        button.isActive = true;
        Press();
    }

    public override void StopInteract()
    {

        if (!button.isActive)
            return;
        button.isActive = false;
        
    }

    void Press()
    {
        anim.SetBool("Pressed", true);
        button.StopInteract();
    }

    // Use this for initialization
    void Start () {
        button = GetComponent<Button>();
        button.isActive = false;
        button.type = Activate;

        anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
