using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Render
{
    public partial class SequenceActionSetOceanIndividualSetting : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int paramType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin enableOceanPin_;
		public bool enableOcean_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin projectedGridCameraOffsetPin_;
		public float projectedGridCameraOffset_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suppressionLerpStartRadiusPin_;
		public float suppressionLerpStartRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suppressionLerpEndRadiusPin_;
		public float suppressionLerpEndRadius_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin suppressionMinFactorPin_;
		public float suppressionMinFactor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin drawableAABBScalePin_;
		public float drawableAABBScale_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin drawPriorityPin_;
		public int drawPriority_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fftWindDirectionPin_;
		public float fftWindDirection_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mipmapLodMinPin_;
		public float mipmapLodMin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mipmapLodMaxPin_;
		public float mipmapLodMax_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin mipmapLodBiasPin_;
		public float mipmapLodBias_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin meshLodPin_;
		public int meshLod_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fillHolePin_;
		public bool fillHole_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetOceanIndividualSetting();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Render.SequenceActionSetOceanIndividualSetting", 0, Black.Sequence.Render.SequenceActionSetOceanIndividualSetting.ObjectType, null, properties, 0, 1624);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Render.SequenceActionSetOceanIndividualSetting", base.GetFieldProperties(), -1019367152, 1982178230);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("paramType_", 2933674535, "Black.Sequence.Render.SequenceActionSetOceanIndividualSetting.OCEAN_PARAM_TYPE", 368, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableOceanPin_", 4286910940, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 376, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("enableOcean_", 1364137801, "bool", 464, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("projectedGridCameraOffsetPin_", 1764811643, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 472, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("projectedGridCameraOffset_", 333421936, "float", 560, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressionLerpStartRadiusPin_", 3607729501, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 568, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressionLerpStartRadius_", 483553402, "float", 656, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressionLerpEndRadiusPin_", 869744228, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 664, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressionLerpEndRadius_", 356188065, "float", 752, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressionMinFactorPin_", 1437905291, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 760, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("suppressionMinFactor_", 429285632, "float", 848, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawableAABBScalePin_", 3462885809, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 856, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawableAABBScale_", 290659758, "float", 944, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawPriorityPin_", 1057859959, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 952, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("drawPriority_", 310767724, "int", 1040, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fftWindDirectionPin_", 1400591634, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1048, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fftWindDirection_", 3527525351, "float", 1136, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mipmapLodMinPin_", 2177539028, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1144, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mipmapLodMin_", 3794770641, "float", 1232, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mipmapLodMaxPin_", 427984422, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1240, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mipmapLodMax_", 2294442315, "float", 1328, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("mipmapLodBiasPin_", 1845871913, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1336, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("mipmapLodBias_", 3917820982, "float", 1424, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			fieldProperties.AddProperty(new Property("meshLodPin_", 671639335, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1432, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("meshLod_", 1966924508, "int", 1520, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("fillHolePin_", 2142932962, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fillHole_", 266449847, "bool", 1616, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}