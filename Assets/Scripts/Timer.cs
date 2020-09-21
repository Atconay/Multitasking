using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimeText;
    public float TimerFloat;
    // Start is called before the first frame update
    void Start()
    {
        TimerFloat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TimerFloat += Time.deltaTime;
        TimeText.text = "Time: " + Mathf.Round(TimerFloat);
        PlayerPrefs.SetFloat("EndTime", TimerFloat);
    }
}
