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
            
			
			
			return fieldProperties;
        }

		
    }
}