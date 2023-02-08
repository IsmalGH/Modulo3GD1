using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField][Range(0,10)]float Speed = 5f;

    void Start()
    {

    }

    void Update()
    {

        float XMove = Input.GetAxis("Horizontal");
        Debug.Log(XMove);

        Vector3 playerMovement = Vector3.right * XMove * Speed * Time.deltaTime;
        transform.position += playerMovement;
    }
}
