using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static int score;

    Text text;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();

        score = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Budget: $ " + score;
    }
}
