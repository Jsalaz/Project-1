using UnityEngine;
using System.Collections;

public class MovePiecesL : MonoBehaviour
{
    [SerializeField] private Transform target;
    private float smoothTime = 1F;
    private Vector3 velocity = Vector3.zero;
    private Vector3 targetPositionL;
    private Vector3 targetPositionR;
    private Vector3 targetPositionNew;
    [SerializeField] private Vector3 startPosition;
    private Vector3 currentPosition;

    void Start()
    {
        startPosition = target.transform.localPosition; 
        currentPosition = startPosition;

        StartCoroutine(Move());
    }

    void Update()
    {
        
    }

    IEnumerator Move()
    {
        bool t = true;
        currentPosition = startPosition;

        do
        {
            targetPositionL = target.TransformPoint(new Vector3(target.transform.localPosition.x, target.transform.localPosition.y, target.transform.localPosition.z + 6f));
            targetPositionNew = new Vector3(target.transform.localPosition.x, target.transform.localPosition.y, target.transform.localPosition.z + 9f);

            float vel = 0.0f;
            float percentage = 0;

            while (percentage <= .15)
            {
                percentage = Mathf.SmoothDamp(percentage, 1.0f, ref vel, 8f);
                currentPosition = Vector3.Lerp(target.transform.localPosition, targetPositionNew, percentage);
                target.transform.localPosition = currentPosition;
                yield return 0;
            }

            yield return new WaitForSeconds(.3f);

            percentage = 0;

            while (percentage <= .15)
            {
                percentage = Mathf.SmoothDamp(percentage, 1.0f, ref vel, 8f);
                currentPosition = Vector3.Lerp(target.transform.localPosition, startPosition, percentage);
                target.transform.localPosition = currentPosition;
                yield return 0;
            }

            yield return new WaitForSeconds(.3f);
        }
        while (t);
    }
}
