using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode rotateClockwise;
    public KeyCode rotateCounterclockwise;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        
    }

    // Update is called once per frame
   public override void Update()
    {
        MovementDecisions(); 
    }


    public void MovementDecisions()
    {
        if (Input.GetKey(moveForward))
        {
            pawn.MoveForward();
        }
        if (Input.GetKey(moveBackward))
        {
            pawn.MoveBackward();
        }
        if (Input.GetKey(rotateClockwise))
        {
            pawn.RotateClockwise();
        }
        if (Input.GetKey(rotateCounterclockwise))
        {
            pawn.RotateCounterclockwise();
        }
    }
}
