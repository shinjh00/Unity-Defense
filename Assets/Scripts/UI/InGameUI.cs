using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUI : BaseUI
{
    public Transform followTarget;  // 게임 오브젝트를 따라다니는 UI
    public Vector3 followOffset;

    private void LateUpdate()
    {
        if (followTarget == null)
            return;

        transform.position = Camera.main.WorldToScreenPoint(followTarget.position) + followOffset;
    }

    public void SetTarget(Transform target)
    {
        followTarget = target;
    }

    public void SetOffset(Vector3 offset)
    {
        followOffset = offset;
    }
}
