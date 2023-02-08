using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Header("WOOOO")]
    [Tooltip("Impossibile")] [SerializeField] private int A;
    [Range(1,100)][SerializeField] private float B;
    [SerializeField] private int C;
    [Header("Sat")]
    [SerializeField] private int D;
    [SerializeField] private int E;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Daje x {A}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
