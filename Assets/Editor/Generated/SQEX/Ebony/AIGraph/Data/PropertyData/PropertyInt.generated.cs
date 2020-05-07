using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.PropertyData
{
    public partial class PropertyInt : SQEX.Ebony.AIGraph.Data.PropertyData.PropertyPrimitiveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PropertyInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", 0, SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.PropertyData.PropertyInt", base.GetFieldProperties(), 770109782, 402270521);
            return fieldProperties;
        }

		
    }
}