using UnityEngine;
using Sirenix.OdinInspector;

public class MyScript : MonoBehaviour
{
    [Title("My Settings")]
    public bool enableFeature;

    [ShowIf("enableFeature")]
    public float featureValue;
}
