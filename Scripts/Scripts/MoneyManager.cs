using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static float score;
    public float budget;

    Text text;

    // Start is called before the first frame update
    void Awake()
    {
        text = GetComponent<Text>();

        //score = budget;
    }

    public void SetBudget()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score += Mathf.Round(ProfitTracker.totalProfit * 100.0f) *0.01f* Time.deltaTime;
        text.text = "Budget: $ " + Mathf.Round(score);
    }
}
