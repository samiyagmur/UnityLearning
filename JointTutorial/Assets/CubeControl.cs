using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{   
    SpringJoint joint;
    [SerializeField] private float speed = 3;
    private void OnCollisionEnter(Collision collision)
    {
       //SpringJoint spr = gameObject.AddComponent<SpringJoint>();
       
        
    }
    private void Start()
    {
        joint = GetComponent<SpringJoint>();
    }

    private void Update()
    {
            


            //joint.anchor = new Vector3 (0,1,0)*Time.deltaTime*speed* Input.GetAxis("Vertical");
            Debug.Log("girdi");
            transform.Translate(Vector3.up * Time.deltaTime * speed* Input.GetAxis("Vertical"));
            transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Horizontal"));

    }

}
