using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Behavior
{
    public partial class AIGraphNodeBTBehaviorTray : SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorBase
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

            var dummy = new AIGraphNodeBTBehaviorTray();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorTray", 0, SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorTray.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorTray", base.GetFieldProperties(), -963842594, 62843782);
            
			
			
			return fieldProperties;
        }

		
    }
}