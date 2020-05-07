using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraAngleBase : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cache2InputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cacheInputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cache2RotOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cacheRotOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cache2PosOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cachePosOutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cache2OutputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin cacheOutputPin_;
		public bool isCachePositionAndRotation_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraAngleBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraAngleBase", 0, Black.Sequence.Action.Angle.SequenceActionCameraAngleBase.ObjectType, null, properties, 0, 1176);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraAngleBase", base.GetFieldProperties(), 130570056, 622251262);
            
			fieldProperties.AddProperty(new Property("cache2InputPin_", 727113671, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 176, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cacheInputPin_", 3849432247, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 264, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cache2RotOutputPin_", 1111286803, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 352, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cacheRotOutputPin_", 1550811715, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cache2PosOutputPin_", 3356542976, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 528, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cachePosOutputPin_", 1535137392, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 616, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cache2OutputPin_", 835396212, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 704, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("cacheOutputPin_", 3816269380, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 792, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isCachePositionAndRotation_", 599030782, "bool", 880, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}