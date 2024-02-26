using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vfxSource;
    void Start()
    {
        Destroy(gameObject, 1.0f);
    }

    // Update is called once per frame
    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }
        
    
}
