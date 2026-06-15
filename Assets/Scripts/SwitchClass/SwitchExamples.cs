using UnityEngine;

public class SwitchExamples : MonoBehaviour
{
    public enum PokemonType
    {
        None,//0
        Agua,//1
        Planta,//2
        Fuego,//3
        Electrico,//4
        Dragon//5
    }
    public PokemonType type;

    public enum CombatAction
    {
        None,
        Attack,
        Backpack,
        Flee,
        Change
    }
    public CombatAction Action;


    void Start()
    {
        switch (Action)
        {
            case CombatAction.None:
                {
                    Debug.Log("No has seleccionado ninguna accion");
                }
                break;
            case CombatAction.Attack:
                {
                    Debug.Log("atack");
                }
                break;
            case CombatAction.Backpack:
                {
                    Debug.Log("atack");
                }
                break;
            case CombatAction.Flee:
                {
                    Debug.Log("atack");
                }
                break;
            case CombatAction.Change:
                {
                    Debug.Log("atack");
                }
                break;
            default:
                break;
        }


    }
}
