using UnityEngine;

public class MovingPlatformScript : MonoBehaviour

{
    //variables
    //start
    public Transform pointA;
    //end
    public Transform pointB;
    //speed
    public float speed = 2f;
    //current target position
    private Vector3 targetPosition;

    void Start()
    {
        //start by moving towardfs point b
        targetPosition = pointB.position;
    }

    void Update()
    {
        //moving the platform towards point b, if statment then determines what to do when it reaches point b
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (targetPosition == pointA.position)
            {
                targetPosition = pointB.position;
            }
            else
            {
                targetPosition = pointA.position;
            }
        }
    }


}