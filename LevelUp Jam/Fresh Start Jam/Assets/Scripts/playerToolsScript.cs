using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerToolsScript : MonoBehaviour
{
    public Sprite buildingSprite;
    bool canWater, canFight, canBuild;
    // Start is called before the first frame update
    void Start()
    {
        canWater = false; canFight = false; canBuild = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    
    {
    
    }

   void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Interactable" ) 
        {
            Debug.Log("Interacting");
            if (collision.name == "WateringCan") { canWater = true; Destroy(collision.GetComponent<GameObject>()); Debug.Log("Can"); Destroy(collision.GetComponent<GameObject>()); }
            if (collision.name == "Sword") { canFight = true; Destroy(collision.GetComponent<GameObject>()); Debug.Log("Can fight"); Destroy(collision.GetComponent<GameObject>()); }
            if (collision.name == "Hammer") { canBuild = true; Destroy(collision.GetComponent<GameObject>()); Debug.Log("Can build"); Destroy(collision.GetComponent<GameObject>()); }
            if (Input.GetKeyDown("w") && canWater) { collision.GetComponent<GameObject>().GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 100); }
            if (Input.GetKeyDown("q") && canBuild) { collision.GetComponent<SpriteRenderer>().sprite = buildingSprite; }
            if (Input.GetMouseButtonDown(1) && canFight) { Debug.Log("fight"); }


        }
    }
}
