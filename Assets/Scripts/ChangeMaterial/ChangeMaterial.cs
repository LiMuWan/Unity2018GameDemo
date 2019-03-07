using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material diffuseMap;

    public Material normalMap;

    private MeshRenderer render;

    private bool normal;
    // Start is called before the first frame update
    void Start()
    {
        normal = false;
        render = this.GetComponent<MeshRenderer>();
        render.materials = new Material[2] { this.diffuseMap, this.diffuseMap };
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.normal = !normal;
            if(normal)
            {
                 render.materials = new Material[2]  { this.normalMap,this.normalMap };
            }
            else
            {
                render.materials = new Material[2] { this.diffuseMap, this.diffuseMap }; 
            }
        }
    }
}
