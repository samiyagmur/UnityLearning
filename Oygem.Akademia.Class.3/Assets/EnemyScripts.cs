using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    private float offset;
    public GameObject enemyBullet;
    void Start()
    {
        StartCoroutine(EnemyBullet());
        offset = Random.Range(-5f, 5f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x:(Mathf.Sin(Time.time)*offset*5f),transform.position.y,transform.position.z);
    }

    IEnumerator EnemyBullet()
    {
        while (true)
        {
            GameObject bull = Instantiate(enemyBullet, transform.position + new Vector3(0f, 31f, 0f),Quaternion.identity);
            bull.GetComponent<Rigidbody>().velocity += Vector3.down * 10f;
            yield return new WaitForSeconds(2f);
        }
    }

    private void OnCollisionEnter(Collision other)//çalýþmýyor?
    {
        if (other.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }
}
