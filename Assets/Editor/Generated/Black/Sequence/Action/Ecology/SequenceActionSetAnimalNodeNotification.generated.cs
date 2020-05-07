using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionSetAnimalNodeNotification : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorId_;
		public bool useTimer_;
		public float time0_;
		public bool isRandomTimer0_;
		public float randomMinTimer0_;
		public float randomMaxTimer0_;
		public float time1_;
		public bool isRandomTimer1_;
		public float randomMinTimer1_;
		public float randomMaxTimer1_;
		public float time2_;
		public bool isRandomTimer2_;
		public float randomMinTimer2_;
		public float randomMaxTimer2_;
		public float time3_;
		public bool isRandomTimer3_;
		public float randomMinTimer3_;
		public float randomMaxTimer3_;
		public float time4_;
		public bool isRandomTimer4_;
		public float randomMinTimer4_;
		public float randomMaxTimer4_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int state_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedTime0_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedTime1_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedTime2_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedTime3_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedTime4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetAnimalNodeNotification();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionSetAnimalNodeNotification", 0, Black.Sequence.Action.Ecology.SequenceActionSetAnimalNodeNotification.ObjectType, null, properties, 0, 1032);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionSetAnimalNodeNotification", base.GetFieldProperties(), 340070772, 902937912);
            return fieldProperties;
        }

		
    }
}