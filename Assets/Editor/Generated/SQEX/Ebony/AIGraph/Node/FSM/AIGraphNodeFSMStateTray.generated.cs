using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.FSM
{
    public partial class AIGraphNodeFSMStateTray : SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMStateBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int trayIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeFSMStateTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMStateTray", 0, SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMStateTray.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMStateTray", base.GetFieldProperties(), 830993931, -784015606);
            
			
			
			return fieldProperties;
        }

		
    }
}