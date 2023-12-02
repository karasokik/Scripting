using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minuti = 2;
    public float sec;

    public TextMeshProUGUI timerText;

    // Update is called once per frame
    void Update()
    {
        sec -= Time.deltaTime;
        if(sec <= 0)
        {
            if(minuti == 0)
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }

            else
            {
                sec = 59;
                minuti -= 1;
            }
        }

        int roundSeconds = Mathf.RoundToInt(sec);
        timerText.text = minuti + ":" + roundSeconds;
    }
}
