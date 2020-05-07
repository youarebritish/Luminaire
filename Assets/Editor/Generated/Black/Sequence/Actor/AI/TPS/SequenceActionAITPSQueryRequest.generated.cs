using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.TPS
{
    public partial class SequenceActionAITPSQueryRequest : Black.Sequence.Actor.AI.SequenceActionAIBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin unreservePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin centerPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin useRaycastPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outInPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outUnreservePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeededPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin resultPositionPin_;
		public uint queryID_;
		public bool isReserve_;
		public float reserveRadius_;
		public bool bWaitNavMeshoad_;
		public float timeout_;
		public bool useRaycast_;
		public bool addShiftOffset_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAITPSQueryRequest();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.TPS.SequenceActionAITPSQueryRequest", 0, Black.Sequence.Actor.AI.TPS.SequenceActionAITPSQueryRequest.ObjectType, null, properties, 0, 1336);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.TPS.SequenceActionAITPSQueryRequest", base.GetFieldProperties(), 1162646592, -1739270704);
            return fieldProperties;
        }

		
    }
}