using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
   void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("I have been hit by " + hit.gameObject.name);
    }
}
