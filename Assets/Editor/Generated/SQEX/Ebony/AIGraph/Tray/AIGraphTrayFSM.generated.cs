using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Tray
{
    public partial class AIGraphTrayFSM : SQEX.Ebony.AIGraph.Tray.AIGraphTrayBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Data.TransitionData> transits_;
		public IList<SQEX.Ebony.AIGraph.Node.FSM.AIGraphNodeFSMRoot> rootNodes_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphTrayFSM();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Tray.AIGraphTrayFSM", 0, SQEX.Ebony.AIGraph.Tray.AIGraphTrayFSM.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Tray.AIGraphTrayFSM", base.GetFieldProperties(), 1210509326, 842769728);
            return fieldProperties;
        }

		
    }
}