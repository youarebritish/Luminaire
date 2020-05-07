using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Event
{
    public partial class SequenceEventPadInput : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin a_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin b_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin x_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin y_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin left_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin start_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin l3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin r3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsLeft_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsRight_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsUp_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lsDown_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin decide_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr12_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin lr2Sta_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upA_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upB_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upX_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin upY_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downA_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downB_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downX_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin downY_;
		public int simPushType_;
		public int simPushType2_;
		public int padNumber_;
		public int padAction_;
		public bool authoringOnly_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceEventPadInput();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput", 0, SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput.ObjectType, null, properties, 0, 3568);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Event.SequenceEventPadInput", base.GetFieldProperties(), 1992856881, -1394298528);
            
			
			
			return fieldProperties;
        }

		
    }
}