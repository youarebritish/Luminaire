using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT
{
    public partial class AIGraphNodeBTRoot : SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.AIGraph.Data.PropertyData.PropertyBool blockTreeDebugLogs;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTRoot();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTRoot", 0, SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTRoot.ObjectType, null, properties, 0, 240);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTRoot", base.GetFieldProperties(), -1401632846, 1194387278);
            return fieldProperties;
        }

		
    }
}