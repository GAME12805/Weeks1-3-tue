using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("Try to change the sprite please");
            //PickARandomColour();
            if(barrels.Count > 0)
            {
                PickARandomSprite();
            }
            
        }

        //NOT THIS:  spriteRenderer.sprite.bounds.Contains()
        //THIS: spriteRenderer.bouncs.Contains()

        //get the mouse position
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the shape?
        if(spriteRenderer.bounds.Contains(mousPos) == true)
        {
            //Y: set the colour with our col variable
            spriteRenderer.color = col;
        }
        else
        {
            //N: set the colour to white
            spriteRenderer.color = Color.white;
        }

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;

        //pick a random number
        randomNumber = Random.Range(0, barrels.Count);
        //use that number to choose a sprite
        //assign that sprite to the sprite renderer
        spriteRenderer.sprite = barrels[randomNumber];
    }
}
