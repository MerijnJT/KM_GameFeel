using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
  public static ParticleManager instance;

    public ParticleSystem explodiodiParticleSystem;
    public ParticleSystem explodiodiParticleSystem2;

    private void Awake()
    {
        instance = this;
    }

    public void Explodiodi(Vector2 plek)
    {
        Debug.Log("test");
        var biem = Instantiate(explodiodiParticleSystem, plek, Quaternion.identity);
        Destroy(biem.gameObject, 5f);
    }

    public void Explodiodi2(Vector2 plek)
    {
        var biem = Instantiate(explodiodiParticleSystem2, plek, Quaternion.identity);
        Destroy(biem.gameObject, 5f);
    }
}

