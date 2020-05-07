using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Behavior
{
    public partial class AIGraphNodeBTBehaviorBase : SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTBehaviorBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorBase", 0, SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorBase.ObjectType, null, properties, 0, 216);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Behavior.AIGraphNodeBTBehaviorBase", base.GetFieldProperties(), -422051325, 1997473953);
            
			
			
			return fieldProperties;
        }

		
    }
}