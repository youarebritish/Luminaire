using UnityEngine;

namespace Luminaire.Entity
{
    /// <summary>
    /// Thin Unity wrapper around an EntityPackage.
    /// </summary>
    public class EntityPackageAsset : ScriptableObject
    {
        public SQEX.Ebony.Framework.Entity.EntityPackage Package;
    }
}