using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Image fillImg;
    float timeAmt = 600;
    float startTime;
    public Text timeText;
    private bool finished = false;

    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        startTime = timeAmt;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime > 0)
        {
            startTime -= Time.deltaTime;
            fillImg.fillAmount = startTime / timeAmt;

            string minutes = ((int)startTime / 60).ToString();
            string seconds = (startTime % 60).ToString("f2");
            timeText.text = minutes + ":" + seconds;
        }
    }
    public void Finnish()
    {
        finished = true;
        timeText.color = Color.red;
    }
}