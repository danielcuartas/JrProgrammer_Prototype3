using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject[] prefabs;

    private Vector3 position = new Vector3(35,0,0);
    float startTime = 2;
    float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRepeat", startTime, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRepeat()
    {
        if (playerControllerScript.gameOver == false)
        {
            int prefabIndex = Random.Range(0, prefabs.Length);
            Debug.Log(prefabIndex);
            Instantiate(prefabs[prefabIndex], position, prefab.transform.rotation);
        }
    }
}
