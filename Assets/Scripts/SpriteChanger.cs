using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    //Declare our variables
    private SpriteRenderer theRenderer;
    public Color spriteColor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Laod the SpriteRenderer component from the same object this component is on
        theRenderer = gameObject.GetComponent<SpriteRenderer>();

        // Change the color from our color picker so hat the alpha is 1
        spriteColor.a = 1.0f;

        // As long as theRenderer has been set
        if (theRenderer != null )

        // Change the "color" value of our SpriteRenderer component to green
        theRenderer.color = spriteColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
