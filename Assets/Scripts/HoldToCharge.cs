using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoldToCharge : MonoBehaviour
{

    public float BatteryLife;
    public Image BatteryImage;
    public bool holding = false;
    // Start is called before the first frame update
    void Start()
    {
        BatteryLife = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        BatteryImage.fillAmount = BatteryLife;
        if (holding == true && BatteryLife < 1)
        {
            BatteryLife += (Time.deltaTime / 15f);
        }

        if (holding == false)
        {
            BatteryLife -= (Time.deltaTime / 15f);
        }
        if (BatteryLife <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    public void OnMouseDown()
    {
        holding = true;
    }

    public void OnMouseUp()
    {
        holding = false;
    }
}
