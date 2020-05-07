using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Extend.Node.FSM
{
    public partial class AIGraphNodeFSMStateMindTaskTray : SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFixid id;
		public int nodeIndex_;
		public int layer_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeFSMStateMindTaskTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Extend.Node.FSM.AIGraphNodeFSMStateMindTaskTray", 0, Black.AIGraph.Extend.Node.FSM.AIGraphNodeFSMStateMindTaskTray.ObjectType, null, properties, 0, 368);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Extend.Node.FSM.AIGraphNodeFSMStateMindTaskTray", base.GetFieldProperties(), -1453576406, -1568714731);
            return fieldProperties;
        }

		
    }
}