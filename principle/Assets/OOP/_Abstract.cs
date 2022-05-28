using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;
//interface içerisine sadece statik kod yazýlýrken abstrac classlarda yazabiliyoruz.
//Abstrac claslarda abstract metolarý implament ederken imzayý ezmek zorundayýz.
//Ýnterfaceler içlerine field ve imza hariç hiçbirþey bulunduramaz.
//Bir classa birden fazla inteface inherit edilebilir.
//Abstrack classlardan yeni bir instance üretemezsiniz.
//Ýnteface nesnesi oluþturmadanda instance üretilebilir.
public class _Abstract
{
   
}
public abstract class BaseDb
{
    public abstract string GetDbVersion();//Kod tekrarýný önlemek için.Abstrack calsslar miras verdiði classta imzasýný imlamet ettirmek zorundadýr.

    public DataTable ExecuteSql(string sql)
    {
        return new DataTable();
    }
    //Her classýn ortak özelliðini tek bir classta yapýp miras verdirirsek kod karmaþasýndan kurtuluruz.
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
