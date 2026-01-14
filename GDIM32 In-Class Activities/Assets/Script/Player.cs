using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{




    private void Update()
    {
        DetectJumpKey();
    }


    void DetectJumpKey()
        {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jump key pressed");
        }
    }

}
