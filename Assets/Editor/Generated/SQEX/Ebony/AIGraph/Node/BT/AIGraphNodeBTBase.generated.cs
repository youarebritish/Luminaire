using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT
{
    public partial class AIGraphNodeBTBase : SQEX.Ebony.AIGraph.Node.AIGraphNodeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase> parentNode_;
		public IList<SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase> childList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase", 0, SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase.ObjectType, null, properties, 0, 200);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.AIGraphNodeBTBase", base.GetFieldProperties(), -1938365506, 1910785854);
            
			
			
			return fieldProperties;
        }

		
    }
}