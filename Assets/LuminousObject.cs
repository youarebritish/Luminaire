using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LuminousObject : MonoBehaviour
{
    [SerializeReference]
    public SQEX.Luminous.Core.Object.Object Entity;

    public LuminousSceneObject SceneEntity;
    public class LuminousSceneObject : SQEX.Luminous.Core.Object.Object
    {
        public SQEX.Luminous.Core.Object.Object Entity;
    }
}
