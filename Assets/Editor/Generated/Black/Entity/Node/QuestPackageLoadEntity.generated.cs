using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node
{
    public partial class QuestPackageLoadEntity : Black.Entity.Node.PackageLoadAreaEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QuestPackageLoadEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.QuestPackageLoadEntity", 0, Black.Entity.Node.QuestPackageLoadEntity.ObjectType, null, properties, 0, 448);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.QuestPackageLoadEntity", base.GetFieldProperties(), 1037784461, -288819758);
            
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 80, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entitySearchLabelId_", 3840219358, "SQEX.Ebony.Std.Fixid", 112, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("enable_", 3925052483, "bool", 256, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "Luminous.Math.VectorA", 272, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerType_", 1915532364, "Black.Entity.Node.PackageLoadEntityBase.LoadTriggerType", 288, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("height_", 2527956647, "float", 292, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("depth_", 1210636015, "float", 296, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("width_", 2754776768, "float", 300, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadMargin_", 3851656225, "float", 304, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("groupName_", 1077907880, "Ebony.Base.String", 312, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("areaColor_", 1436013180, "Luminous.RenderInterface.Color", 336, 16, 1, Property.PrimitiveType.Color, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("memo_", 3571411732, "Ebony.Base.String", 352, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadDependentPackageName_", 2451455536, "Ebony.Base.String", 384, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isNotLoadedAtFlying_", 2211334970, "bool", 400, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forceNowLoadingRatio_", 760346460, "float", 404, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("invalidateInitForceLoadRadiusFlag_", 2221496374, "bool", 408, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noWaitLoadingAtFlying_", 953794724, "bool", 409, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("importantLoading_", 1169917048, "bool", 410, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadItemList_", 1464061907, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.PackageLoadAreaArrayItem* >", 416, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadItemList_", 832443902, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.Area.PackageLoadAreaUnloadArrayItem* >", 432, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			
			
			return fieldProperties;
        }

		
    }
}