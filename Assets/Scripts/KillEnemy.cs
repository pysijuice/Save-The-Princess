using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
