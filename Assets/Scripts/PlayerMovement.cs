using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // defines de variables local to the class  (instead of being local to the specific method)
    public float turnSpeed = 20f;
    public float height = 1f;
    Animator m_Animator;
    Rigidbody m_Rigidbody;
    Vector3 m_Movement;
    Quaternion m_Rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
         m_Animator = GetComponent<Animator> ();
         m_Rigidbody = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = -Input.GetAxis ("Horizontal");
        float vertical = -Input.GetAxis ("Vertical");

        m_Movement.Set(horizontal, 0f, vertical);
        m_Movement.Normalize (); // de acordo com o teorema de pitagorsa, o movimento na diagonal ia ser mais rapido. esta linha normaliza isso.

        bool hasHorizontalInput = !Mathf.Approximately (horizontal, 0f); //hasHorizontalInput is being set to true when horizontal is not approximately equal to 0.  In other words, hasHorizontalInput is true when horizontal is non-zero.
        bool hasVerticalInput = !Mathf.Approximately (vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;  //se alguma das anteriores for falsa- e falso, se alguma for vedadeira - e verdadeiro
        m_Animator.SetBool ("IsWalking", isWalking);
        Vector3 desiredForward = Vector3.RotateTowards (transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
         m_Rotation = Quaternion.LookRotation (desiredForward);

       if (Input.GetKeyDown("space")){
            float target_velocity =2*Mathf.Sqrt(height*-Physics.gravity.y)  ;
            m_Rigidbody.velocity += new Vector3(0, target_velocity, 0);
                    Debug.Log(m_Rigidbody.velocity);

        }
    }

    void OnAnimatorMove ()
    {
        m_Rigidbody.MovePosition (m_Rigidbody.position + m_Movement * m_Animator.deltaPosition.magnitude);
        m_Rigidbody.MoveRotation (m_Rotation);
    }
}
