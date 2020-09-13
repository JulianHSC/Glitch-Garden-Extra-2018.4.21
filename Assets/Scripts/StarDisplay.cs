using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] private static int stars = 100;
    Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        //Debug.Log("Instance ID of " + name + ": " + GetInstanceID());

        stars = stars + amount;
        UpdateDisplay();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;

    }

    public void SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars = stars - amount;
            UpdateDisplay();

        }
    }
}
