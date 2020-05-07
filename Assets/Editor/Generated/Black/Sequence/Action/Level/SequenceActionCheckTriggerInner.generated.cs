using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionCheckTriggerInner : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin inner_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin triggerActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin positionPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin checkActorPin_;
		public bool forceCheck_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCheckTriggerInner();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionCheckTriggerInner", 0, Black.Sequence.Action.Level.SequenceActionCheckTriggerInner.ObjectType, null, properties, 0, 840);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionCheckTriggerInner", base.GetFieldProperties(), 32110681, -2085812997);
            return fieldProperties;
        }

		
    }
}