using UnityEngine;
using System.Collections;

public class FloorTrigger : InteractableObject
{


    InteractableObject floorTrigger;
    [SerializeField]
    GameObject trigger;

    Animator anim;



    void StartInteract()
    {
        if (floorTrigger.isActive)
            return;
        floorTrigger.isActive = true;
        anim.SetBool("Active", true);

    }


    public override void StopInteract()
    {
        if (!floorTrigger.isActive)
            return;
        floorTrigger.isActive = false;
        anim.SetBool("Active", false);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == trigger)
            StartInteract();

    }

    void OnCollisionExit(Collision col)
    {

        if (col.gameObject == trigger)
            StopInteract();

    }



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        floorTrigger = GetComponent<FloorTrigger>();
        floorTrigger.isActive = false;
        floorTrigger.type = Trigger;

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
