using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.FSM
{
    public partial class AIGraphNodeFSMRoot : SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMInterrupt> interruptNodes_;
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool blockTreeDebugLogs;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeFSMRoot();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot", 0, SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot.ObjectType, null, properties, 0, 256);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot", base.GetFieldProperties(), -985679196, -42135839);
            
			
			
			return fieldProperties;
        }

		
    }
}