using UnityEngine;

public enum EnemyType
{
    None,
    Normal,
    Amalgame,
    ManoLarga
}
public class SpwnerExample : MonoBehaviour
{
    public EnemyType spawnType;


    public GameObject EnemyNormalPreFab;
    public GameObject EnemyAmalgamePreFab;
    public GameObject EnemyManoLargaPreFab;


    public float SpawnTimer = 5f;
    public float range;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TimerMachine();

    }
    public void TimerMachine()
    {
        SpawnTimer -= Time.deltaTime;
        if (SpawnTimer < 0)
        {
            SpawnEnemy();
            SpawnTimer = 5f;
        }
    }
    public void SpawnEnemy()
    {
        Vector3 randomDir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0).normalized;
        Vector3 fullLenghtDir = randomDir * Random.Range(0f, range);
        switch (spawnType)
        {
            case EnemyType.None:
                break;
            case EnemyType.Normal:
              
                GameObject enemy = Instantiate(EnemyNormalPreFab, transform.position, Quaternion.identity);
                enemy.transform.position += fullLenghtDir;
                break;
            case EnemyType.Amalgame:
                GameObject enemy1 = Instantiate(EnemyNormalPreFab, transform.position, Quaternion.identity);
                enemy1.transform.position += fullLenghtDir;
                break;
            case EnemyType.ManoLarga:
                GameObject enemy2 = Instantiate(EnemyNormalPreFab, transform.position, Quaternion.identity);
                enemy2.transform.position += fullLenghtDir;
                break;
            default:
                break;
        }



       

    }
}
