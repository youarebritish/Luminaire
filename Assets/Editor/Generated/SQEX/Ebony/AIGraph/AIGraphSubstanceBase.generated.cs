using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph
{
    public partial class AIGraphSubstanceBase : SQEX.Ebony.AIGraph.AIGraphRunnableBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphSubstanceBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.AIGraphSubstanceBase", 0, SQEX.Ebony.AIGraph.AIGraphSubstanceBase.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.AIGraphSubstanceBase", base.GetFieldProperties(), -1467150794, 609861188);
            return fieldProperties;
        }

		
    }
}