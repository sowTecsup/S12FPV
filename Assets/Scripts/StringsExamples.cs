using UnityEngine;

public class StringsExamples : MonoBehaviour
{
    public string PlayerName = "Diseño de Desarrollo De Simuladores Y Videojuegos";
    //->DISEÑOVIDEOJUGOS
    //->MOSTRAR LA CANTIDAD DE LETRAS O

   

    public int Inicio;
    public int Final;


    public string contains;
    public string startwith;
    public string endwith;

    public string Search;
    public string Replace;

    public char LetterToCount;
    void Start()
    {
        string sub = PlayerName.Substring(Inicio, Final);
        //  PlayerName = sub;
        /* Debug.Log(PlayerName.Contains(contains));
         Debug.Log(PlayerName.StartsWith(startwith));
         Debug.Log(PlayerName.EndsWith(endwith));*/
        // PlayerName = PlayerName.Replace(Search, Replace);
        // PlayerName = PlayerName.Replace(Search, Replace);

        int count = 0;
        for (int i = 0; i < PlayerName.Length; i++)
        {
            Debug.Log(PlayerName[i]);
            if(PlayerName[i] == LetterToCount)
            {
                count++;
            }
        }
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
