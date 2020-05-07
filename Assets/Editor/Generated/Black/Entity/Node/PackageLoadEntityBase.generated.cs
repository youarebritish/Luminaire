using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class PackageLoadEntityBase : Black.Entity.TransformEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool enable_;
		public UnityEngine.Vector4 scaling_;
		public int triggerType_;
		public float height_;
		public float depth_;
		public float width_;
		public float unloadMargin_;
		public string groupName_;
		public UnityEngine.Color areaColor_;
		public string memo_;
		public string loadDependentPackageName_;
		public bool isNotLoadedAtFlying_;
		public float forceNowLoadingRatio_;
		public bool invalidateInitForceLoadRadiusFlag_;
		public bool noWaitLoadingAtFlying_;
		public bool importantLoading_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PackageLoadEntityBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.PackageLoadEntityBase", 0, Black.Entity.Node.PackageLoadEntityBase.ObjectType, null, properties, 0, 416);
        }
		
        public override ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected override PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Entity.Node.PackageLoadEntityBase", base.GetFieldProperties(), 483258878, -1537834647);
            return fieldProperties;
        }

		
    }
}