using UnityEngine;

public enum EnemyEnum
{
    None,
    Idle,
    Chase,
    Attack
}



public class EnemyState : MonoBehaviour
{
    public EnemyEnum state = EnemyEnum.Idle;

    public GameObject Target;//->si mi target tiene player
    public float Speed;

    public float damage;

    public float DetectionRadius;
    public float AttackRaius;

    public bool isAbleToAttack = true;
    public float currentTime;
    public float MaxTime = 2f;
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = Target.transform.position;
        Vector3 myPos = transform.position;

        switch (state)
        {
            case EnemyEnum.None:
                break;
            case EnemyEnum.Idle:
                {
                   
                    if (Vector3.Distance(targetPos, myPos) < DetectionRadius)
                        state = EnemyEnum.Chase;
                }
                break;
            case EnemyEnum.Chase:
                {

                    Vector3 direction = (targetPos - myPos).normalized;
                    transform.position += direction * Speed * Time.deltaTime;

                    if (Vector3.Distance(targetPos, myPos) > DetectionRadius)
                        state = EnemyEnum.Idle;

                    if (Vector3.Distance(targetPos, myPos) < AttackRaius)
                        state = EnemyEnum.Attack;
                }
                break;
            case EnemyEnum.Attack:
                {
                    if (isAbleToAttack)
                    {
                        //->GetComponent
                        Debug.Log("Atacando");
                        Target.GetComponent<Player>().Health -= damage;
                        isAbleToAttack = false;
                    }


                    currentTime += Time.deltaTime;
                    if (currentTime >= MaxTime)
                    {
                        //-> ejecutar algo
                        isAbleToAttack = true;

                        currentTime = 0;
                    }


                    if (Vector3.Distance(targetPos, myPos) > AttackRaius)
                        state = EnemyEnum.Chase;
                }
                break;
            default:
                break;
        }
    }
}
