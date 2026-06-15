
using UnityEngine;

public class Class10 : MonoBehaviour
{
    public string PlayerName;

    public int X;
    public int Y;


    public float Damage;//->10
    public float Multiplier;//->2
    public bool IsCrit;//-> true
    //->

    void Start()
    {
        Debug.Log(MostrarSmt2(PlayerName ," buenos dias capitan"));
        string var = MostrarSmt2(PlayerName, " buenos dias capitan");
        MostrarSmt2(var, "gato");


        SumaDeValores(X,Y);
        SumaDeValores(10, 5);

        CalculateDamage(Damage, Multiplier,IsCrit);
        CalculateDamage(14, 3, true);
    }
    public string MostrarSmt2(string playerName,string saludo)
    {
        //Debug.Log(playerName + saludo);

        string result = playerName + saludo;

        return result;
    }

    public void SumaDeValores(int a , int b)
    {
        int sum = a + b;
        Debug.Log(sum);
    }

    public float CalculateDamage(float damage ,float multiplier , bool isCrit)
    {
        float DamageTotal = 0;
        if (isCrit)
        {
            DamageTotal = damage * multiplier;
        }
        else
        {
            DamageTotal = damage;
        }

        Debug.Log("El daño total es : " + DamageTotal);

        return DamageTotal;
    }



}
