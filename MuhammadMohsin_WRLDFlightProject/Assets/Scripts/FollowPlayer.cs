using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public Vector3 positionOffset;
    public Vector3 rotationOffset;

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.SetPositionAndRotation(target.position + positionOffset, Quaternion.Euler(transform.rotation.x+rotationOffset.x, transform.rotation.y + rotationOffset.y, 0));
    }
}
