using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT
{
    public partial class AIGraphNodeBTControlBase : SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTControlBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTControlBase", 0, SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTControlBase.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTControlBase", base.GetFieldProperties(), -1595200357, -1666818923);
            
			
			
			return fieldProperties;
        }

		
    }
}