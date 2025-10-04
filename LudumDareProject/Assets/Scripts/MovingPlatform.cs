using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform[] points;
    public float speed;
    public float waitTime;
    private int currenPointIndex;
    private bool isWaiting;
    private float waitTimer;
    private void Update()
    {
        if (points.Length < 2) return;
        if (isWaiting)
        {
            waitTimer += Time.deltaTime;
            if (waitTimer > waitTime)
            {
                isWaiting = false;
                waitTimer = 0f;
                currenPointIndex = (currenPointIndex + 1) % points.Length;
            }

            return;
        }
        Transform targetPoint = points[currenPointIndex];
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.05f)
        {
            isWaiting = true;
        }
    }
}
