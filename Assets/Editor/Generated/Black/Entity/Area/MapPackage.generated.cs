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
            
			fieldProperties.AddProperty(new Property("triggerEnable_", 1412487753, "bool", 704, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerType_", 1915532364, "Black.Entity.Area.MapPackage.MapLoadTriggerType", 708, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerRadius_", 1726467370, "float", 712, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerHeight_", 3110277449, "float", 716, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerWidth_", 2849620798, "float", 720, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerDepth_", 123604937, "float", 724, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("unloadMargin_", 3851656225, "float", 728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("triggerOffset_", 315293853, "Luminous.Math.VectorA", 736, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("loadDependentPackageName_", 2451455536, "Ebony.Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("lodLowPackageName_", 3550387762, "Ebony.Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("parentPackagePath_", 4129370481, "Ebony.Base.String", 784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddProperty(new Property("exportType_", 2364431068, "Black.Entity.Area.MapPackage.NaviMeshExportType", 800, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("isLowPackageLoad_", 2013131144, "bool", 804, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("isNotLoadedAtFlying_", 2211334970, "bool", 805, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("forceNowLoadingRatio_", 760346460, "float", 808, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("invalidateInitForceLoadRadiusFlag_", 2221496374, "bool", 812, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("noWaitLoadingAtFlying_", 953794724, "bool", 813, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("importantLoading_", 1169917048, "bool", 814, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}