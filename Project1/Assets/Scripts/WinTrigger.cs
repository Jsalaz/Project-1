using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("Win");
            BallController.instance.Win();
            GameManager.instance.PopupHighScoreCanvas.GetComponent<Canvas>().enabled = true;
            GameManager.instance.inGameCanvas.GetComponent<Canvas>().enabled = false;
            GameManager.instance.endLvlCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
}
