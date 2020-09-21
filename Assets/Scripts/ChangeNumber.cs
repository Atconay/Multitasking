using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeNumber : MonoBehaviour
{

    public float Number = 7.5f;
    public Slider Slide;
    public bool direction = true;
    public Image Handle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Slide.value = Number;

        if (direction == true)
        {
            Number += (Time.deltaTime);
        }

        if (direction == false)
        {
            Number -= (Time.deltaTime);
        }
        
        if (Number > 4 && Number < 11)
        {
            Handle.color = Color.green;
        }
        else
        {
            Handle.color = Color.red;
        }

        if (Number <= 0 || Number >= 15)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    public void Higher()
    {
        direction = true;
    }
    public void Lower()
    {
        direction = false;
    }
}
