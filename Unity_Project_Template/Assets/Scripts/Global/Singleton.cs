﻿using UnityEngine;

/// <summary>
/// Class used to declare singleton in the project
/// </summary>
/// <typeparam name="T">Type to define the singleton</typeparam>
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T _Instance;
    public static T Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = FindObjectOfType<T>();
            }
            return _Instance;
        }
    }
}