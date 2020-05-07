using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionSeamlessInGameTransformActorFromVector : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromBasePositionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fromOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin toActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin toMatrixPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin toOffsetPin_;
		public bool isUpdateEveryFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSeamlessInGameTransformActorFromVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionSeamlessInGameTransformActorFromVector", 0, Black.Sequence.Action.Angle.SequenceActionSeamlessInGameTransformActorFromVector.ObjectType, null, properties, 0, 2144);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionSeamlessInGameTransformActorFromVector", base.GetFieldProperties(), 1019405556, 2045158666);
            
			fieldProperties.AddProperty(new Property("judgePin_", 955830756, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("clearPin_", 2510457522, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 1272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("outPin_", 2732252299, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 1368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromBasePositionPin_", 2289001495, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1464, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromMatrixPin_", 4072289548, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1552, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("fromOffsetPin_", 4195995002, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1640, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("targetActorPin_", 422699493, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 1728, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("toActorPin_", 2674194681, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1816, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("toMatrixPin_", 4222841977, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1904, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("toOffsetPin_", 4254237483, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 1992, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isUpdateEveryFrame_", 2705399801, "bool", 2080, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}