using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Area
{
    public partial class RotateMapPackage : Black.Entity.Area.MapPackage
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RotateMapPackage();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Area.RotateMapPackage", 0, Black.Entity.Area.RotateMapPackage.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Entity.Area.RotateMapPackage", base.GetFieldProperties(), -1315725765, -347266662);
            
			fieldProperties.AddIndirectlyProperty(new Property("entities_", 798990575, "SQEX.Ebony.Std.IntrusivePointerDynamicArray< SQEX.Ebony.Framework.Entity.Entity >", 64, 16, 1, Property.PrimitiveType.IntrusivePointerArray, 0, (char)5));
			fieldProperties.AddIndirectlyProperty(new Property("hasTransform_", 3096138238, "bool", 88, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("position_", 987254735, "Luminous.Math.VectorA", 96, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("rotation_", 36328192, "Luminous.Math.VectorA", 112, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("scaling_", 3325430311, "float", 128, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("canManipulate_", 3989276646, "bool", 132, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sourcePath_", 341055184, "Base.String", 208, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("name_", 182823483, "Base.String", 224, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isTemplateTraySourceReference_", 3775626232, "bool", 240, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isShared_", 3455118081, "bool", 241, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("startupLoad_", 3202049383, "bool", 242, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadedObjects_", 4286216873, "SQEX.Ebony.Std.IntrusivePointerDynamicArray< Base.Object.Object, MEMORY_CATEGORY_FRAMEWORK >", 304, 16, 1, Property.PrimitiveType.IntrusivePointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadedObjectNames_", 503273934, "SQEX.Ebony.Std.DynamicArray< Base.String, MEMORY_CATEGORY_FRAMEWORK >", 320, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadedObjectPaths_", 453683170, "SQEX.Ebony.Std.DynamicArray< Base.String, MEMORY_CATEGORY_FRAMEWORK >", 336, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sequenceUpdateOrderPreset_", 2630853337, "SQEX.Ebony.Framework.Entity.EntityPackage.SequenceUpdateOrderPreset", 352, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("sequenceUpdateOrderDirect_", 3519507007, "uint16_t", 356, 2, 1, Property.PrimitiveType.Int16, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("entityPackageSharedChildPathList_", 1047969541, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Entity.EntityPackageSharedRefItem*, MEMORY_CATEGORY_FRAMEWORK >", 360, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("packageSearchLabelId_", 1572444187, "SQEX.Ebony.Std.Fixid", 376, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bUmbraBakeTarget_", 26211871, "bool", 380, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("bForbidDuplicatedLoad_", 2326256737, "bool", 381, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("min_", 1418308504, "Luminous.Math.VectorA", 608, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("max_", 3144402738, "Luminous.Math.VectorA", 624, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerEnable_", 1412487753, "bool", 704, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerType_", 1915532364, "Black.Entity.Area.MapPackage.MapLoadTriggerType", 708, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerRadius_", 1726467370, "float", 712, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerHeight_", 3110277449, "float", 716, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerWidth_", 2849620798, "float", 720, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerDepth_", 123604937, "float", 724, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("unloadMargin_", 3851656225, "float", 728, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("triggerOffset_", 315293853, "Luminous.Math.VectorA", 736, 16, 1, Property.PrimitiveType.Vector4, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("loadDependentPackageName_", 2451455536, "Ebony.Base.String", 752, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("lodLowPackageName_", 3550387762, "Ebony.Base.String", 768, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("parentPackagePath_", 4129370481, "Ebony.Base.String", 784, 16, 1, Property.PrimitiveType.String, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("exportType_", 2364431068, "Black.Entity.Area.MapPackage.NaviMeshExportType", 800, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isLowPackageLoad_", 2013131144, "bool", 804, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("isNotLoadedAtFlying_", 2211334970, "bool", 805, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("forceNowLoadingRatio_", 760346460, "float", 808, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("invalidateInitForceLoadRadiusFlag_", 2221496374, "bool", 812, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("noWaitLoadingAtFlying_", 953794724, "bool", 813, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddIndirectlyProperty(new Property("importantLoading_", 1169917048, "bool", 814, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			
			
			return fieldProperties;
        }

		
    }
}