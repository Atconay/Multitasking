using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScore : MonoBehaviour
{
    public TextMeshProUGUI WinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WinText.text = "Time: " + Mathf.Round(PlayerPrefs.GetFloat("EndTime"));
    }
}
