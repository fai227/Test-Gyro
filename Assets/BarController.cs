using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    private bool isPressed = false;

    void Update()
    {
        if(Input.touchCount > 0)
        {
            if(isPressed == false)
            {
                isPressed = true;
                GameObject ballObject = Instantiate(ballPrefab, transform.position, Quaternion.identity, transform.parent);
            }
        }
        else
        {
            isPressed = false ;
        }

      
    }
}
