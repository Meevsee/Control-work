using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour

{
    public GameObject Object;
    public bool Switch = true;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Switch = !Switch;
        }
        if (Switch)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Object);
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                Object = GameObject.CreatePrimitive(PrimitiveType.Cube);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Object.SetActive(false);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                Object.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Object.GetComponent<MeshRenderer>());
            }
            else if (Input.GetKeyDown(KeyCode.I))
            {
                MeshRenderer mesh = Object.AddComponent<MeshRenderer>();
                GameObject primitive = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Material material = primitive.GetComponent<MeshRenderer>().sharedMaterial;
                Destroy(primitive);
                mesh.sharedMaterial = material;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                Object.GetComponent<MeshRenderer>().enabled = false;
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                Object.GetComponent<MeshRenderer>().enabled = true;
            }
        }
    }
}
