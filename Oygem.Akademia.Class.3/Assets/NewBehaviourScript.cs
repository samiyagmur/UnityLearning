using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject bulletPrefab;
    void Start()
    {
        //StartCoroutine(routine: MyCoroutine());
        //StopCoroutine(routine: MyCoroutine());
        //StopAllCoroutines();


        Instantiate(original: enemy, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 clampPos = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput*35f*Time.deltaTime, 0, 0);

        clampPos.x=Mathf.Clamp(value:transform.position.x,min:-16f,max: 16f);
        transform.position = clampPos;

        if(Input.GetKeyDown(KeyCode.Space))
        {
           GameObject bullet = Instantiate(bulletPrefab, position: transform.position + new Vector3(x:0f, y:3f,z: 0f), Quaternion.identity);
           bullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10f;
        }




    }
    //IEnumerator MyCoroutine()
    //{
    //    while (true)
    //    {
    //        Debug.Log(message: "Couroutine is working");
    //        yield return new WaitForSeconds(2f);
    //    }
        
    //}
}
