using UnityEngine;

public class Rotation_Controller : MonoBehaviour
{
public Vector3 rotationVector;

private void Update()
{
    transform.Rotate(rotationVector*Time.deltaTime);
}
}
