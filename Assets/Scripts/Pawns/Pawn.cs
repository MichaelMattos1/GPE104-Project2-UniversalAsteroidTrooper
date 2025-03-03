using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float MovementSpeed = 5.0f;
    public float RotationSpeed = 180.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
       
    }

    // Update is called once per frame
    public virtual void Update()
    {

    }


    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterclockwise();
}
