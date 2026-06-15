using UnityEngine;

public class Class10_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarSmt2(string playerName, string saludo)
    {
        Debug.Log(playerName + saludo);
    }
    public void SumaDeValores(int a, int b)
    {
        int sum = a + b;
        Debug.Log(sum);
    }

    public void CalculateDamage(float damage, float multiplier, bool isCrit)
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

    }

}
