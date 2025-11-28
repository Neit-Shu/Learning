using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class BallMove : MonoBehaviour
{
    private Rigidbody ball;
    [SerializeField] private float powerImpulse = 80f;

    private void Start()
    {
        ball = gameObject.GetComponent<Rigidbody>();
    }

    public void MoveUp()
    {
        ball.AddForce(Vector3.forward *  powerImpulse);
    }
    public void MoveDown()
    {
        ball.AddForce(-Vector3.forward * powerImpulse);
    }
    public void MoveLeft()
    {
        ball.AddForce(Vector3.left * powerImpulse);
    }
    public void MoveRight()
    {
        ball.AddForce(-Vector3.left * powerImpulse);
    }
}
