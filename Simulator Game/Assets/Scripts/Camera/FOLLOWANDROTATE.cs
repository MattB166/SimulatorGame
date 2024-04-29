using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Manages the behaviour of the camera during runtime and its appropriate rotations 
/// </summary>
public class FOLLOWANDROTATE : MonoBehaviour
{
    private GameObject player;
    private Transform followPos;
    public Vector3 offset;
    private float smoothDelta = 0.1f;
    private Quaternion targetRot;
    private float x, y;
    public float sensitivity = -1f;
    private Vector3 rotate;
    
    // Start is called before the first frame update
    void Start()
    {
        ///cache player here 
        followPos = FindFirstObjectByType<PlayerMovement>().gameObject.transform;
        
        transform.position = followPos.position + offset;
       Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //FollowPlayer();
        RotateCam();
       
    
    }

    private void FollowPlayer()
    {
        Vector3 desiredPos = followPos.position + offset;
        Vector3 smoothedPosition = Vector3.Slerp(transform.position, desiredPos, smoothDelta);
        transform.position = smoothedPosition;

       // Vector3 dirToPlayer = (followPos.position - transform.position).normalized;
       // targetRot = Quaternion.LookRotation(dirToPlayer);
       /// transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, smoothDelta);
        
        //add rotation of mouse look to this 
    }

    private void RotateCam()
    {
        y = Input.GetAxis("Mouse X") * sensitivity;
        x = Input.GetAxis("Mouse Y") * sensitivity;

        Quaternion camTurn = Quaternion.AngleAxis(y, Vector3.up);
        offset = camTurn * offset;

        Quaternion camTilt = Quaternion.AngleAxis(x, Vector3.right);
        offset = camTilt * offset;

        transform.position = followPos.position + offset;
        transform.LookAt(followPos);
    }
}
