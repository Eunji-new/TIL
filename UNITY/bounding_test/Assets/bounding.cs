using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounding : MonoBehaviour
{
    public GameObject cube;
    public Vector3 position;

    public float ScaleX = 1.1f;
    public float ScaleY = 1.1f;
    public float ScaleZ = 1.1f;
    public bool RecalculateNormals = false;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    void Update()
    {
       
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        int i = 0;
        while (i < vertices.Length)
        {
            vertices[i] += Vector3.up * Time.deltaTime;
            i++;
        }
        mesh.vertices = vertices;
        mesh.RecalculateBounds();


        //  mesh.bounds = new Bounds(mesh.bounds.center, mesh.bounds.size + Vector3.one);
        //   mesh.bounds.size.Set(mesh.bounds.size.x *1.1f, mesh.bounds.size.y * 1.1f, mesh.bounds.size.z * 1.1f);
        // mesh.bounds.SetMinMax(new Vector3(0, 0, 0), new Vector3(1, 1, 1)); //안바뀜
        cube.transform.position = mesh.bounds.min;
        gameObject.transform.localScale += new Vector3(1,1,1);
       // mesh.RecalculateBounds();
        Debug.Log("최대: " + mesh.bounds.max);
        Debug.Log("최소: " + mesh.bounds.min);
      //  Debug.Log("정점: " + _baseVertices[1].x);





    }
}
