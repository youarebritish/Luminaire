using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Sequence.Connector
{
    public partial class SequenceConnectorBase : SQEX.Ebony.Framework.Node.GraphNode
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int connectorNo_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceConnectorBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Sequence.Connector.SequenceConnectorBase", 0, SQEX.Ebony.Framework.Sequence.Connector.SequenceConnectorBase.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Sequence.Connector.SequenceConnectorBase", base.GetFieldProperties(), -923848887, 390017147);
            return fieldProperties;
        }

		
    }
}