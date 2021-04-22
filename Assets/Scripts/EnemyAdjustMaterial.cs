using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAdjustMaterial : MonoBehaviour
{
    [SerializeField, Range(0.2f, 0.6f)]
    float amount = 0.2f;

    Renderer rend;
    Material material;
    string propertyName = "Cut off";

    void Start()
    {
        rend = GetComponent<Renderer>();
        material = rend.material;

        material.EnableKeyword(propertyName);
        Debug.Log("mat.HasProperty(Cut off) " + material.HasProperty("Cut off"));
    }

    public void Fader()
    {
        StartCoroutine(FadeDeath());
    }




    private void FixedUpdate()
    {
        material.SetFloat("_Cutoff", amount);
        Debug.Log("cut off " + material.GetFloat("_Cutoff"));
    }

    IEnumerator FadeDeath()
    {
        amount += 0.01f;
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(FadeDeath());
    }
}
