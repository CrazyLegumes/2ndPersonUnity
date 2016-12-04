using UnityEngine;
using System.Collections;
using System;

public class Lever : InteractableObject
{


    Player activator;
    Animator anim;



    InteractableObject lever;
    [SerializeField]
    bool isTimed;

    [SerializeField]
    float timer;




    // Use this for initialization
    void Start()
    {
        lever = GetComponent<Lever>();
        lever.isActive = false;
        lever.type = Activate;
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void StartInteract(Player p)
    {
        if (isActive)
            return;

        activator = p;
        isActive = true;
        TurnOn();
    }


    public override void StopInteract()
    {
        if (!isActive)
            return;
        activator = null;
        isActive = false;
        TurnOff();
    }

    void TurnOn()
    {
        anim.SetBool("On", true);
    }
    void TurnOff()
    {
        anim.SetBool("On", false);

    }
}
