using UnityEngine;
using System.Collections;

public class MovePiecesR : MonoBehaviour
{
    public Transform target;
    private float smoothTime = 1F;
    private Vector3 velocity = Vector3.zero;
    private Vector3 targetPositionR;

    void Start()
    { 
        targetPositionR = target.TransformPoint(new Vector3(0, 0, 1.5f));

    }

    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPositionR, ref velocity, smoothTime);
    }
}
