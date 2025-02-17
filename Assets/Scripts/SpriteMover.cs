using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    
    //create speed variable for how fast we move along axis
    public float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Accessing local position of transform component to move object at random
        transform.localPosition = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        //create float variable that connects to input keys for horizontal and vertical axis
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
      
        Vector3 movement = new Vector3 (horizontalMovement, verticalMovement, 0.0f);

        transform.Translate(movement * speed * Time.deltaTime);

       //check if button is being pressed
       if (Input.GetButtonDown("quit"))
        {
            Application.Quit();
        }
    }
}
