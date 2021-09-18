using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PanelCloser : MonoBehaviour
{
    public GameObject Panel;
    public InputField input;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            if(input != null)
            {
                // Debug.Log("Log Input: " + input.text);
                MoneyManager.score = Convert.ToInt32(input.text);
            }
            
           Panel.SetActive(false);
        }
    }
}
