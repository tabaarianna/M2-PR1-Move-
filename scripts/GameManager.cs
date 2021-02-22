using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    int counter = 8;
    float time;
    public static GameManager instance;
    public TextMeshProUGUI Text;
    public TextMeshProUGUI timeUI;

    void Awake()
    {
        instance = this;
        time = 20f;


    }

    // Update is called once per frame
    void Update()
    {
        Text.text = (counter / 2).ToString();
        if (Text.text == "0") 
        {
            Text.text = "  You Win!  ";
            

        }
        else
        {
            time -= Time.deltaTime;
        }
        
        timeUI.text = time.ToString("F2");
        if (time <= 0f)
        {
            timeUI.text = "0.00";
       
            Text.text = "You lose!";
        }


        
        
    }
    public void Decrement()
    {
        counter--;
        Debug.Log(counter);

    }
    public void IncreaseTime()
    {
        time += 2.5f;

    }

}
