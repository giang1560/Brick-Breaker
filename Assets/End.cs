﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  End : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            Time.timeScale = 0;
        }
    }
}
