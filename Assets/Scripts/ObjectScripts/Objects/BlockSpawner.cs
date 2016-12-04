using UnityEngine;
using System.Collections;

public class BlockSpawner : InteractableObject {


    InteractableObject spawner;
    [SerializeField]
    InteractableObject trigger;

    [SerializeField]
    GameObject spawned;

    bool blockactive;

	// Use this for initialization
	void Start () {

        spawner = GetComponent<BlockSpawner>();
        spawner.isActive = false;
        blockactive = false;
        spawner.type = Switch;
	
	}


    void StartInteract()
    {
        if (spawner.isActive)
            return;
        

        spawner.isActive = true;
        Spawn();
    }


    void Spawn()
    {

        if (blockactive)
            return;

        Instantiate(spawned, transform.position, Quaternion.identity);
        blockactive = true;
        trigger.StopInteract();

        
    }
	
	// Update is called once per frame
	void Update () {
        if (trigger.isActive)
            StartInteract();
	
	}
}
