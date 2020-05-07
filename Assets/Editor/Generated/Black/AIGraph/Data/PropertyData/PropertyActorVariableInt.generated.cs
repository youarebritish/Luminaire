using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AIGraph.Data.PropertyData
{
    public partial class PropertyActorVariableInt : Black.AIGraph.Data.PropertyData.PropertyActorVariableBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int kind_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new PropertyActorVariableInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AIGraph.Data.PropertyData.PropertyActorVariableInt", 0, Black.AIGraph.Data.PropertyData.PropertyActorVariableInt.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AIGraph.Data.PropertyData.PropertyActorVariableInt", base.GetFieldProperties(), -546121937, 1733263317);
            return fieldProperties;
        }

		
    }
}