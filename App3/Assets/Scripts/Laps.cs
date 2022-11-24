using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laps : MonoBehaviour
{
    public GameObject lapLine;
    public TMPro.TMP_Text lapText;
    public int lapTotal;
    private int lapCount = 1;

    void Update()
    {
        lapText.text = string.Format("Laps: {0}/{1}", lapCount, lapTotal);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerCar")
        {
            lapCount++;

            if(lapCount > lapTotal)
            {
                SceneManager.LoadScene("OnePlayerLeaderboard");
            }
        }
    }
}
