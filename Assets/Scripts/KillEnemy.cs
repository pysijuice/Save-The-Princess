using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    [SerializeField] GameObject lightning;
    [SerializeField] GameObject explosionParticle;
    private void OnMouseDown()
    {
        explosionParticle.SetActive(true);
        explosionParticle.transform.parent = null;
        Destroy(gameObject);
        
        
    }
}
