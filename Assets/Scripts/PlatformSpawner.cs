using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platform;

    Vector3 lastPos;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        for (int i = 0; i < 6; i++)
        {
            spawnX();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnX()
    {
        Vector3 pos = lastPos;
        
        pos.x += size;
        lastPos = pos;

        Instantiate(platform, pos, Quaternion.identity);
    }

    void spawnZ()
    {
        Vector3 pos = lastPos;
        
        pos.z += size;
        lastPos = pos;

        Instantiate(platform, pos, Quaternion.identity);

    }
}
