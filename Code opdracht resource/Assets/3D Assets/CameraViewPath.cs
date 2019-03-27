using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewPath : MonoBehaviour {
    public Transform cam;
    public Position[] path;
    private int current;
    public float nextDistance;
    private float currentSpeed;
    private float currentRotationSpeed;

    public void Start()
    {
        cam.position = path[0].position;
        cam.rotation = Quaternion.Euler(path[0].rotation);
    }

    public void Update()
    {
        if(current < path.Length)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, path[current].speed, Time.deltaTime);
            currentRotationSpeed = Mathf.Lerp(currentRotationSpeed, path[current].rotationSpeed, Time.deltaTime);
            cam.position = Vector3.MoveTowards(cam.position, path[current].position, Time.deltaTime * currentSpeed);
            cam.rotation = Quaternion.RotateTowards(cam.rotation, Quaternion.Euler(path[current].rotation),Time.deltaTime * currentRotationSpeed);
            if(Vector3.Distance(cam.position,path[current].position) <= nextDistance)
            {
                current++;
            }
        }
    }

    public void OnDrawGizmos()
    {
        if (path.Length != 0)
        {
            for (int i = 0; i < path.Length; i++)
            {
                Gizmos.color = path[i].positionColor;
                Gizmos.DrawSphere(path[i].position, 0.5f);
                Gizmos.DrawCube(path[i].position + (Quaternion.Euler(path[i].rotation) * Vector3.forward), Vector3.one * 0.3f);
                Gizmos.DrawCube(path[i].position + (Quaternion.Euler(path[i].rotation) * (Vector3.forward + Vector3.up * 0.3f)), Vector3.one * 0.1f);
            }
        }
    }


}

[System.Serializable]
public class Position
{
    public Color positionColor;
    public Vector3 position;
    public Vector3 rotation;
    public float speed;
    public float rotationSpeed;
}
