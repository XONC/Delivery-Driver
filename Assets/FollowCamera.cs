using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject somethingToFollow;
   
    // Update is called once per frame
    private void LateUpdate() {
        transform.position = somethingToFollow.transform.position + new Vector3(0,0,-10);     
    }
}
