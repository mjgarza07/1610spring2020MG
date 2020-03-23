using System;
using System.Collections;
using System.Transactions;
using UnityEngine;

public class PlayerDie : MonoBehaviour
public  gameObject;
{
void Start()
{

}


void Update()
{

}

private void OnCollisionEnter2D(Collision2D other)
{
    if (Collision.gameObject.name == "Spikes")
    {
        StartCoroutine(DieAndRespawn());
    }
}

IEnumerator DieAndRespawn()
{
    Renderer.enabled = false;
    yield return new WaitForSeconds(2.0f);
    Transform.position = new Vector3(11,4,0);
    Transform.rotation = Quaternion.identity;
    Renderer.enabled = true;
}


}
    
