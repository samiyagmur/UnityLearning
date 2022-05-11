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
//Open closed de�i�ime kapal� geli�dirmeye a��k olma prensibidir.
//Sisteme yeni bir�ey eklerken en az de�i�imi yapmak.
//Yeni bir �zellik eklerken mevcut kodda en az de�i�iklik yapmak.
//interfaceler kal�t�m verdi�i s�n�fta imzas�n� implament etmek zorundad�r.
//E�er birinci prensibi uygularsak 2. prensibi yerine getirmemiz daha kolay olacakt�r.
//kodumuz az de�i�iklikle geli�tirilebilri olmal�d�r.
//As�l yap�lan i�lem de�i�tirilmeli.
