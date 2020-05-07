using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Buddy
{
    public partial class SequenceActionAIBuddyTakeGroupSnapshot : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin centerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin cameraPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeededPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedPin_;
		public int colorType_;
		public uint colorCorrectionID_;
		public uint specifiedMotionID_;
		public uint questPhotoID_;
		public uint specialAttribute_;
		public bool isMarked_;
		public int levelPhotoType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIBuddyTakeGroupSnapshot();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyTakeGroupSnapshot", 0, Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyTakeGroupSnapshot.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Buddy.SequenceActionAIBuddyTakeGroupSnapshot", base.GetFieldProperties(), -122834915, 325760039);
            return fieldProperties;
        }

		
    }
}