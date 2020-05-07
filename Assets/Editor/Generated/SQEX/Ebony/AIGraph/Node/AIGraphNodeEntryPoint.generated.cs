using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Node
{
    public partial class AIGraphNodeEntryPoint : SQEX.Ebony.AIGraph.Node.AIGraphNodeBase
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

            var dummy = new AIGraphNodeEntryPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint", 0, SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint.ObjectType, null, properties, 0, 176);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Node.AIGraphNodeEntryPoint", base.GetFieldProperties(), 1361212580, -1755612763);
            
			fieldProperties.AddProperty(new Property("trayIndex_", 3648500452, "int", 160, 4, 1, Property.PrimitiveType.Int32, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}