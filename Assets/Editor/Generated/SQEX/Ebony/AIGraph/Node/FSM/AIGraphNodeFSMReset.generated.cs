using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.FSM
{
    public partial class AIGraphNodeFSMReset : SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeFSMReset();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMReset", 0, SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMReset.ObjectType, null, properties, 0, 192);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMReset", base.GetFieldProperties(), 724210700, 1288043948);
            
			
			
			return fieldProperties;
        }

		
    }
}