using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    PickARandomColour();
        //}

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


    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
