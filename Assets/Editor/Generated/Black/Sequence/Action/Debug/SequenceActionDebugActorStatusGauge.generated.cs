using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugActorStatusGauge : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin HP_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin MaxHP_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin MP_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin MaxMP_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugActorStatusGauge();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugActorStatusGauge", 0, Black.Sequence.Action.Debug.SequenceActionDebugActorStatusGauge.ObjectType, null, properties, 0, 920);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugActorStatusGauge", base.GetFieldProperties(), 1677611312, 895138378);
            return fieldProperties;
        }

		
    }
}