using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.Framework.Node
{
    public partial class GraphVariableInputPin : SQEX.Ebony.Framework.Node.GraphInputPin
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string pinValueType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new GraphVariableInputPin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.Framework.Node.GraphVariableInputPin", 0, SQEX.Ebony.Framework.Node.GraphVariableInputPin.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.Framework.Node.GraphVariableInputPin", base.GetFieldProperties(), -1698830909, 277083611);
            return fieldProperties;
        }

		
    }
}