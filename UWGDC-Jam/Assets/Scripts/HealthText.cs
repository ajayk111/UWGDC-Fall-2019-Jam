﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    private Text healthText;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            healthText.text = "0";
        else
            healthText.text = Mathf.RoundToInt(player.health).ToString();
    }
}
