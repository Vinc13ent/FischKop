using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Networking;
using Random = System.Random;

public class FischKopMain : MonoBehaviour
{
    private Random _wuerfel = new Random();
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

    private int wuerfeln()
    {
        return _wuerfel.Next(1, 7);
    }

    private void fisch()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(wuerfeln());
        foreach (var VARIABLE in _spielbrett)
        {
            Debug.Log(VARIABLE);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
