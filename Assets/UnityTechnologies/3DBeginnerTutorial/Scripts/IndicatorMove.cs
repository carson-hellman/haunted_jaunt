using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorMove : MonoBehaviour
{
    public GameObject john;
    public GameObject G;
    public GameObject G1;
    public GameObject G2;
    public Material safe;

    Renderer rend;
    Color lerpedColor;
    float d;
    float d1;
    float d2;
    float df;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = safe;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (john.transform.position.x, 1.6f, john.transform.position.z);

        d = Vector3.Distance(transform.position, G.transform.position);
        d1 = Vector3.Distance(transform.position, G1.transform.position);
        d2 = Vector3.Distance(transform.position, G2.transform.position);

        if (d < d1 && d < d2) df = d;
        else if (d1 < d2 && d1 < d) df = d1;
        else df = d2;

        lerpedColor = Color.Lerp(Color.red, Color.green, df - 4);
        rend.material.color = lerpedColor;
    }
}
