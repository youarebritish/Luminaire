using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.TimeLine.Camera
{
    public partial class SequenceActionTimeLineCameraInGameTrackBase : Black.Sequence.Action.TimeLine.SequenceActionTimeLineDurationTrackBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin turnDirectionPin_;
		public bool isUseEndReserve_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionTimeLineCameraInGameTrackBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase", 0, Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase.ObjectType, null, properties, 0, 504);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.TimeLine.Camera.SequenceActionTimeLineCameraInGameTrackBase", base.GetFieldProperties(), 424336452, 176967902);
            return fieldProperties;
        }

		
    }
}