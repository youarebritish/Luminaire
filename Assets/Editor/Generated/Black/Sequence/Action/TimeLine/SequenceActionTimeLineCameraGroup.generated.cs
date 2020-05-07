using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine
{
    public partial class SequenceActionTimeLineCameraGroup : Black.Sequence.Action.TimeLine.SequenceActionTimeLineActorGroupBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin relativeActorPin_;
		public int playMode_;
		public int charaRelativeIndex_;
		public bool bIsGenerateObjectiveCamera_;
		public bool bIsAttach_;
		public float endBlendFrame_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraGroup();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraGroup", 0, Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraGroup.ObjectType, null, properties, 0, 2656);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraGroup", base.GetFieldProperties(), 99242256, -1020291260);
            
			fieldProperties.AddProperty(new Property("relativeActorPin_", 2643541026, "SQEX.Ebony.Framework.Node.GraphVariableInputPin", 440, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("playMode_", 40862441, "Black.Sequence.Action.TimeLine.SequenceActionTimeLineCameraGroup.CameraGroupPLayMode", 528, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("charaRelativeIndex_", 1966693805, "int", 532, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			fieldProperties.AddProperty(new Property("bIsGenerateObjectiveCamera_", 351948659, "bool", 536, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("bIsAttach_", 3675418929, "bool", 537, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("endBlendFrame_", 1927611687, "float", 540, 4, 1, Property.PrimitiveType.Float, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}