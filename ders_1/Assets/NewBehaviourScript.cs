using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{

    private void Awake()//Oyun �al��maya ba�lad���nda yazd�rmak istedi�imiz kod lar i�indir.
    {
        //Bura �al��t�r�ld�ktan sonra s�rasy�la di�er fonksiyonlar �al��t�r�l�r.
    }
    
    [SerializeField]//prive public yapar
    //public int health = 100;
    public int enemyCount = 1;
    //private float attackDamage = 5.5f;
    //private bool isGameFinished = false;
    //healt += 1
    void Start()
    {
        Debug.Log(message:"Enemy Count: " + enemyCount);
        Debug.Log(message: "2" + "2");
        //healt == 0
        //healt != 0
    }

    // Update is called once per frame
    private void Update()//s�rekli d�ner// dikkat etmek gerekli//Oyun h�z� i�in do�ru kullan�m gerekli
    {
        enemyCount ++;//saniyede 60 kez d�ner
    }
    private void FixedUpdate()
    {
        //Oyunlarda fiziksel hesaplar�n yap�ld��� b�l�md�r.
        //Neden burada �arp��ma mekanikleri gibi fiziksel hesaplar�n 
        //Yaz�laca��na gelirsek
        //Bu fonksiyon her makinada ayn� h�zda �al���r.
        //Bunu update �zerinden yapcak olsayd�k.H�zl� bir makinada mekanikler daha h�zl� �al���yoru oalcakt�
        //Buda mekaniksel olarak oyunun farkl� h�zlarda i�lemesi sorununa neden olacakt�r.
    }
    private void LateUpdate()
    {
        
    }
    private void MetHod()
    {
        //Method bir fonksiyondur.Main �zerinden yapmay� istemedi�imi i�lemler i�in Bir metot tan�mlayarak 
        //Bu methoda istedi�imiz i�lemi yapt�rarak. geri �a��rma i�lemidir.
    }
}
