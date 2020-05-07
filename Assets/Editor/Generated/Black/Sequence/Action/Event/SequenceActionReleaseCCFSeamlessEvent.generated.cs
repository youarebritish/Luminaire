using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Event
{
    public partial class SequenceActionReleaseCCFSeamlessEvent : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool isForce_;
		public uint eventId_;
		public bool isSeamlessEnd_;
		public Black.System.TimeLine.TrackItem.Camera.Struct.InGameCameraSeamlessClone seamlessCloneData_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionReleaseCCFSeamlessEvent();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Event.SequenceActionReleaseCCFSeamlessEvent", 0, Black.Sequence.Action.Event.SequenceActionReleaseCCFSeamlessEvent.ObjectType, null, properties, 0, 424);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Event.SequenceActionReleaseCCFSeamlessEvent", base.GetFieldProperties(), 701799567, 1675190357);
            return fieldProperties;
        }

		
    }
}