using UnityEngine;

public class SpawnarInimigos : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject prefEnemy;
 
    void Start()
    {
       
        InvokeRepeating("Spawner", 1f, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawner()
    {         Instantiate(prefEnemy, spawnPoint);
    }



}
