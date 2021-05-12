﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    /// <summary>
    /// Turns the game object on/off
    /// </summary>
    public void ToggleCube()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
