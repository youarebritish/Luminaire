using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Event
{
    public partial class SequenceFarProxyFromNode : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool ToExecAtSameFrame_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Sequence.SequenceActivatableNode targetNodePointer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceFarProxyFromNode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Event.SequenceFarProxyFromNode", 0, Black.Sequence.Event.SequenceFarProxyFromNode.ObjectType, null, properties, 0, 288);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Event.SequenceFarProxyFromNode", base.GetFieldProperties(), -572686653, 722256449);
            return fieldProperties;
        }

		
    }
}