using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.MiniGame.Colosseum
{
    public partial class SequenceActionColosseumSendSituation : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin startPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stopPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin updatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin waitTimePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overWriteWaitTimePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin dynamicPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin diePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin randomPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin positionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin targetActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin targetPositionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin countPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isBetGroupPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumSendSituation();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumSendSituation", 0, Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumSendSituation.ObjectType, null, properties, 0, 1648);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumSendSituation", base.GetFieldProperties(), 359838932, 544900440);
            return fieldProperties;
        }

		
    }
}