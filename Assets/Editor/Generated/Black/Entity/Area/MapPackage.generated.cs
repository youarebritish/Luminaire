using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Area
{
    public partial class MapPackage : Black.Entity.Area.LoadUnitPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool triggerEnable_;
		public int triggerType_;
		public float triggerRadius_;
		public float triggerHeight_;
		public float triggerWidth_;
		public float triggerDepth_;
		public float unloadMargin_;
		public UnityEngine.Vector4 triggerOffset_;
		public string loadDependentPackageName_;
		public string lodLowPackageName_;
		public string parentPackagePath_;
		public int exportType_;
		public bool isLowPackageLoad_;
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

            var dummy = new MapPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Area.MapPackage", 0, Black.Entity.Area.MapPackage.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Entity.Area.MapPackage", base.GetFieldProperties(), -1869229966, -2089591461);
            return fieldProperties;
        }

		
    }
}