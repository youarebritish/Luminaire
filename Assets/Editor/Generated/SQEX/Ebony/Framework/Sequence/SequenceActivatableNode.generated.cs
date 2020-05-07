using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence
{
    public partial class SequenceActivatableNode : SQEX.Ebony.Framework.Sequence.SequenceNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.Framework.Node.GraphPin> triInPorts_;
		public IList<SQEX.Ebony.Framework.Node.GraphPin> triOutPorts_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActivatableNode();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.SequenceActivatableNode", 0, SQEX.Ebony.Framework.Sequence.SequenceActivatableNode.ObjectType, null, properties, 0, 168);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.SequenceActivatableNode", base.GetFieldProperties(), 1106888044, -729667281);
            return fieldProperties;
        }

		
    }
}