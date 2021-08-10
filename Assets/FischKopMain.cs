using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Random = System.Random;

public class FischKopMain : MonoBehaviour
{
    private static Random _wuerfel = new Random();
    private int[] _spielbrett = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    
    // Event für Sieg
    public delegate void gewonnenEventHandler();
    public event gewonnenEventHandler gewonnenEvent;
    private void onGewonnen()
    {
        if (gewonnenEvent != null)
        {
            gewonnenEvent();
        }
    }

    public static void wuerfeln()
    {
        int wert = _wuerfel.Next(1, 7);
        int wert2 = _wuerfel.Next(1, 7);
        int sum = wert + wert2;
        Debug.Log(wert + " " + wert2 + " " + sum);
    }

    private void fisch()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            wuerfeln();
        }
    }
}
