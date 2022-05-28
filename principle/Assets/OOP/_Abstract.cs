using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;
//interface i�erisine sadece statik kod yaz�l�rken abstrac classlarda yazabiliyoruz.
//Abstrac claslarda abstract metolar� implament ederken imzay� ezmek zorunday�z.
//�nterfaceler i�lerine field ve imza hari� hi�bir�ey bulunduramaz.
//Bir classa birden fazla inteface inherit edilebilir.
//Abstrack classlardan yeni bir instance �retemezsiniz.
//�nteface nesnesi olu�turmadanda instance �retilebilir.
public class _Abstract
{
   
}
public abstract class BaseDb
{
    public abstract string GetDbVersion();//Kod tekrar�n� �nlemek i�in.Abstrack calsslar miras verdi�i classta imzas�n� imlamet ettirmek zorundad�r.

    public DataTable ExecuteSql(string sql)
    {
        return new DataTable();
    }
    //Her class�n ortak �zelli�ini tek bir classta yap�p miras verdirirsek kod karma�as�ndan kurtuluruz.
}
public class MyServerDb : BaseDb
{
    public override string GetDbVersion() => "MySql Datebase";
}
public class SqlServerDb : BaseDb
{
    public override string GetDbVersion() => "SqlServer 2012";

    public string GenerateSql(int id)
    {
        return $"SELECT * FROM USER WITH(NOLOCK) WHERE ID ={id}";
    }
    
}
public class OracleDb : BaseDb
{
    public override string GetDbVersion() => "Oracle 18c";

    public string GenerateSql(int id)
    {
        return $"SELECT * FROM USERS WHERE USER_ID ={id}";
    }
    
}
