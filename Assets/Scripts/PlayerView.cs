using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerView : MonoBehaviour
{
    [SerializeField] private Text hpCount;
    [SerializeField] private Text timer;
    [SerializeField] private GameObject revivePanel;

    private bool lostLives = true;
    private float timeTimer = 15;

    public void LefillHp(int currentHp)
    {
        hpCount.text = currentHp.ToString();

        revivePanel.SetActive(false);

        timeTimer = 15;
        lostLives = false;
    }

    public void TakeDamage(int currentHp)
    {
        if(currentHp <= 0)
        {  
            revivePanel.SetActive(true);
            lostLives = true;
        }
        hpCount.text = currentHp.ToString();
    }

    private void Update()
    {
        if(lostLives)
        {
            if(timeTimer > 0)
            {
                timeTimer -= Time.deltaTime;
                Debug.Log(timeTimer);
                timer.text = "00:" + timeTimer.ToString("F00");
            }
            else if(timeTimer <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
