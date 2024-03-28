using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Manages the behaviour of the camera during runtime and its appropriate rotations 
/// </summary>
public class CameraMovement : MonoBehaviour
{
    private GameObject player;
    private Transform followPos;
    public Vector3 offset;
    private float smoothDelta = 0.1f;
    private Quaternion targetRot;
    
    // Start is called before the first frame update
    void Start()
    {
        ///cache player here 
        followPos = FindFirstObjectByType<PlayerMovement>().gameObject.transform;
        
        transform.position = followPos.position + offset;
       
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        Vector3 desiredPos = followPos.position + offset;
        Vector3 smoothedPosition = Vector3.Slerp(transform.position, desiredPos, smoothDelta);
        transform.position = smoothedPosition;

        Vector3 dirToPlayer = (followPos.position - transform.position).normalized;
        targetRot = Quaternion.LookRotation(dirToPlayer);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, smoothDelta);
       
        //add rotation of mouse look to this 
    }
}
