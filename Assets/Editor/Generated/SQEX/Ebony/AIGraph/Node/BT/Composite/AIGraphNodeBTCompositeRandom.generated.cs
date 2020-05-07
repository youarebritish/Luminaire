using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node.BT.Composite
{
    public partial class AIGraphNodeBTCompositeRandom : SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<SQEX.Ebony.AIGraph.Data.PropertyData.PropertyFloat> weightList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AIGraphNodeBTCompositeRandom();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeRandom", 0, SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeRandom.ObjectType, null, properties, 0, 224);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.BT.Composite.AIGraphNodeBTCompositeRandom", base.GetFieldProperties(), 175702476, 1805775082);
            return fieldProperties;
        }

		
    }
}