using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] [Range(0, 10)] float Speed = 5f;
    [SerializeField] [Range(0, 100)] float Jump = 5f;
    [SerializeField] Rigidbody Body;
    [SerializeField] LayerMask GroundMask;

    int score = 0;
    bool isGrounded = true;

    
    void Start()
    {
        Body = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float XMove = Input.GetAxisRaw("Horizontal");
        float ZMove = Input.GetAxisRaw("Vertical");

        Vector3 playerMovement = (Vector3.right * XMove + Vector3.forward * ZMove).normalized * Speed;
        playerMovement.y = Body.velocity.y;
        isGrounded = Physics.Raycast(transform.position, -transform.up, 1.1f, GroundMask);
        Debug.DrawRay(transform.position, -transform.up * 1.1f, Color.cyan);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerMovement.y += Mathf.Sqrt(Jump * -2f * (-9.81f));
            //Body.AddForce(Vector3.up * Jump, ForceMode.Impulse);
        }

        Body.velocity = playerMovement;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name);
   
    }

    private void OnCollisionExit(Collision collision)
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score += 1;
            Debug.Log(score);
            Destroy(other.gameObject);
        }
        /*if (other.gameObject.CompareTag("Ground"))
            isGrounded = true;*/


    }

    private void OnTriggerExit(Collider other)
    {
        /*if (other.gameObject.CompareTag("Ground"))
            isGrounded = false;*/
    }
     

}
