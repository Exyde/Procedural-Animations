using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicController : MonoBehaviour
{

    public List<Joint> _joints;

    public Vector3 ForwardKinematics(float[] angles){

        Vector3 previousPoint = _joints[0].transform.position;
        Quaternion rotation = Quaternion.identity;

        for (int i = 0; i < _joints.Count; i++)
        {
            rotation *= Quaternion.AngleAxis(angles[i - 1], _joints[i - 1]._axis);
            Vector3 nextPoint = previousPoint + rotation * _joints[i]._startOffset;

            previousPoint = nextPoint;
        }

        return previousPoint;
    }

    public float DistanceFromTarget(Vector3 target, float[] angles){
        Vector3 point = ForwardKinematics(angles);
        return Vector3.Distance(point, target);
    }
}
