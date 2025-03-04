using UnityEngine;

public class StarshipPawn : Pawn
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        transform.position = Vector3.zero; 
    }

    // Update is called once per frame
   public override void Update()
    {
        
    }

    public override void MoveForward()
    {
        transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime, Space.Self);
    }
    public override void MoveBackward()
    {
        transform.Translate(Vector3.down * MovementSpeed * Time.deltaTime, Space.Self);
    }
    public override void RotateClockwise()
    {
        transform.Rotate(0, 0, -RotationSpeed * Time.deltaTime);
    }
    public override void RotateCounterclockwise()
    {
        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);
    }
}
