using UnityEngine;
using System.Collections;

public class Liikkuminen : MonoBehaviour
{
    public float speed = 1.5f;

    void Update()
    {



        if (canJump)
        {
            canJump = false;
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
          
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        var velocidade = 9000;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 60, 0);

            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 300, 0);

        }

        }


    

    public int forceConst = 50;

    private bool canJump;
    private Rigidbody selfRigidbody;

    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
    }


   
    



}