using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    private bool isColliding=false;

    void Update()
    {
        if (isColliding)
        {
            Debug.Log("Morreu.");
            SceneManager.LoadScene (4);
        }
    }



    //collided com o mar?
    private void OnTriggerEnter(Collider other)
    {
        if  (other.tag=="Player")
        {
            isColliding=true;
        }
    }

}
