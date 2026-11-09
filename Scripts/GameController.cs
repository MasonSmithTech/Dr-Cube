using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    private GameObject player;
    public static Action<GameObject> onPlayerSpawned;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
