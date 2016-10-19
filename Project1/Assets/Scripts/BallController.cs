using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
    public static BallController instance;

    public float speed = 2.0f;
    private Rigidbody rb;
    bool isAlive;

    void Awake()
    {
        instance = this;
        isAlive = true;
    }

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ViewInGame.instance.countTime = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        //Debug.Log (moveHorizontal + " " + moveVertical);
        if (isAlive)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Win()
    {
        isAlive = false;
        rb.constraints = RigidbodyConstraints.FreezePosition;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        //other code for winning
        ViewInGame.instance.countTime = false;

        if (PlayerPrefs.GetFloat("highscore", 0) < ViewInGame.instance.timer)
        {
            PlayerPrefs.SetFloat("highscore", ViewInGame.instance.timer);
        }
    }

    public void Kill()
    {
        isAlive = false;
        rb.constraints = RigidbodyConstraints.FreezePosition;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        ViewInGame.instance.countTime = false;
    }
}
