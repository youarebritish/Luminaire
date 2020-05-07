using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Actor.Component.Props.ComponentData
{
    public partial class TurretComponentData : Black.Actor.Component.ActorComponentData
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint pitchBaseJoint_;
		public float turnLimitHorizonal_;
		public float turnLimitVerticalUpper_;
		public float turnLimitVerticalLower_;
		public float turnSpeedVertical_;
		public float turnSpeedHorizontal_;
		public float heatingSpeed_;
		public float coolingSpeed_;
		public float overheatTime_;
		public float recoverTime_;
		public uint overheatVfx_;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> playerAttackParamIDList;
		public IList<SQEX.Ebony.Framework.Utility.FixidArrayItem> enemyAttackParamIDList;
		public uint shotMessageId_;
		public uint shotEndMessageId_;
		public IList<Black.Actor.Component.Props.ComponentData.TurretMaterialParamArrayItem> materialParams_;
		public uint cameraBaseJoint_;
		public bool isCameraYawByJoint_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TurretComponentData();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Actor.Component.Props.ComponentData.TurretComponentData", 0, Black.Actor.Component.Props.ComponentData.TurretComponentData.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("Black.Actor.Component.Props.ComponentData.TurretComponentData", base.GetFieldProperties(), 1051950933, -227847231);
            
			fieldProperties.AddProperty(new Property("pitchBaseJoint_", 3624203653, "SQEX.Ebony.Std.Fixid", 64, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLimitHorizonal_", 610763514, "float", 68, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLimitVerticalUpper_", 1036559970, "float", 72, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnLimitVerticalLower_", 1725427841, "float", 76, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnSpeedVertical_", 634191460, "float", 80, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("turnSpeedHorizontal_", 3286224778, "float", 84, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("heatingSpeed_", 1767655021, "float", 88, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("coolingSpeed_", 2005765912, "float", 92, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("overheatTime_", 3769504385, "float", 96, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("recoverTime_", 601290711, "float", 100, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("overheatVfx_", 965778080, "SQEX.Ebony.Std.Fixid", 104, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("playerAttackParamIDList", 3404331472, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Utility.FixidArrayItem* >", 112, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("enemyAttackParamIDList", 2713679049, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Framework.Utility.FixidArrayItem* >", 128, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("shotMessageId_", 1884903890, "SQEX.Ebony.Std.Fixid", 144, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("shotEndMessageId_", 594746513, "SQEX.Ebony.Std.Fixid", 148, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("materialParams_", 794124923, "SQEX.Ebony.Std.DynamicArray< Black.Actor.Component.Props.ComponentData.TurretMaterialParamArrayItem* >", 152, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			fieldProperties.AddProperty(new Property("cameraBaseJoint_", 684304558, "SQEX.Ebony.Std.Fixid", 168, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCameraYawByJoint_", 3808613065, "bool", 172, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}