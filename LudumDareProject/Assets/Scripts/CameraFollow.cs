using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform target;

    [Header("Camera Settings")]
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 2, -5);
    [Header("Look Settings")]
    public bool lookAtTarget = true;
    public float rotationSpeed = 5f;

    [Header("Constraints")]
    public bool enableConstraints = false;
    public float minY = 1f;
    public float maxY = 10f;

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Target not assigned to CameraFollow script!");
            return;
        }

        FollowTarget();

        if (lookAtTarget)
        {
            LookAtTarget();
        }
    }

    void FollowTarget()
    {
        Vector3 desiredPosition = target.position + offset;

        if (enableConstraints)
        {
            desiredPosition.y = Mathf.Clamp(desiredPosition.y, minY, maxY);
        }

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    void LookAtTarget()
    {
        Vector3 direction = target.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }

    public void SetOffset(Vector3 newOffset)
    {
        offset = newOffset;
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}