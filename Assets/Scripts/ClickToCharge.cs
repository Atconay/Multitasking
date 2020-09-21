using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickToCharge : MonoBehaviour
{

    public float ChargedLife = 1f;
    public Image ChargedImage;
    public bool holding = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChargedImage.fillAmount = ChargedLife;
        ChargedLife -= (Time.deltaTime / 20f);

        if (ChargedLife <= 0f)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    public void OnMouseDown()
    {
        if (ChargedLife < 1f)
        {
            ChargedLife += .02f;
        }
       
    }
}
