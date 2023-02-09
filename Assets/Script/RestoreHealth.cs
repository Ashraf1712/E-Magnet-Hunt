using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestoreHealth : MonoBehaviour
{
    public void Restore()
    {
        HealthBar.currentHealth = 3;
    }
}
