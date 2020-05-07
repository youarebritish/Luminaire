using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.FSM
{
    public partial class AIGraphNodeFSMEnd : SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int endStatus_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeFSMEnd();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMEnd", 0, SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMEnd.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMEnd", base.GetFieldProperties(), -688769894, 1759618768);
            return fieldProperties;
        }

		
    }
}