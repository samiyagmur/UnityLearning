using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    IMover _Mover;

    public void Movement()
    {
        _Mover = new MoveWithTranslate();
    }
    private void Update()
    {
        _Mover.Movement();
    }
}
//Open closed deðiþime kapalý geliþdirmeye açýk olma prensibidir.
//Sisteme yeni birþey eklerken en az deðiþimi yapmak.
//Yeni bir özellik eklerken mevcut kodda en az deðiþiklik yapmak.
//interfaceler kalýtým verdiði sýnýfta imzasýný implament etmek zorundadýr.
//Eðer birinci prensibi uygularsak 2. prensibi yerine getirmemiz daha kolay olacaktýr.
//kodumuz az deðiþiklikle geliþtirilebilri olmalýdýr.
//Asýl yapýlan iþlem deðiþtirilmeli.
