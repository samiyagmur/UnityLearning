using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{

    private void Awake()//Oyun çalýþmaya baþladýðýnda yazdýrmak istediðimiz kod lar içindir.
    {
        //Bura çalýþtýrýldýktan sonra sýrasyýla diðer fonksiyonlar çalýþtýrýlýr.
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
    private void Update()//sürekli döner// dikkat etmek gerekli//Oyun hýzý için doðru kullaným gerekli
    {
        enemyCount ++;//saniyede 60 kez döner
    }
    private void FixedUpdate()
    {
        //Oyunlarda fiziksel hesaplarýn yapýldýðý bölümdür.
        //Neden burada çarpýþma mekanikleri gibi fiziksel hesaplarýn 
        //Yazýlacaðýna gelirsek
        //Bu fonksiyon her makinada ayný hýzda çalýþýr.
        //Bunu update üzerinden yapcak olsaydýk.Hýzlý bir makinada mekanikler daha hýzlý çalýþýyoru oalcaktý
        //Buda mekaniksel olarak oyunun farklý hýzlarda iþlemesi sorununa neden olacaktýr.
    }
    private void LateUpdate()
    {
        
    }
    private void MetHod()
    {
        //Method bir fonksiyondur.Main üzerinden yapmayý istemediðimi iþlemler için Bir metot tanýmlayarak 
        //Bu methoda istediðimiz iþlemi yaptýrarak. geri çaðýrma iþlemidir.
    }
}
