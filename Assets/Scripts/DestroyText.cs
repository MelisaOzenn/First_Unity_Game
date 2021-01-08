using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
    public int lifeTime;
    void Start()
    {
        Destroy(gameObject , lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
