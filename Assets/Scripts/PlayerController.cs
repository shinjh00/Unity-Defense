using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;

    private void MoveTo(Vector3 point)
    {
        agent.destination = point;
    }

    private void OnRightClick(InputValue value)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if ( Physics.Raycast(ray, out RaycastHit hitInfo) )
        {
            Debug.DrawLine(Camera.main.transform.position, hitInfo.point, Color.red, 0.5f);
            MoveTo(hitInfo.point);
        }
    }
}
