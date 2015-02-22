using UnityEngine;
using System.Collections;

public class ClickableItemPickup : Clickable {
	
	// Use this for initialization

    public GameObject itemPrefab;
    public PlayerControllerScript playerScript;

	// Update is called once per frame
	void Update () {
        playerScript = GameObject.FindObjectOfType<PlayerControllerScript>();
	}
	
	public override void OnClicked()
	{
	    GameObject temp = (GameObject)Instantiate (itemPrefab, transform.position, Quaternion.identity);
        playerScript.addInventoryItem(temp.GetComponent<InventoryItem>());
	}
}

