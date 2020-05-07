using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Ebony.AIGraph.Data.ConstantValue
{
    public partial class ConstantValueFloat : SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ConstantValueFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueFloat", 0, SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueFloat.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Ebony.AIGraph.Data.ConstantValue.ConstantValueFloat", base.GetFieldProperties(), 1826674779, 804675479);
            return fieldProperties;
        }

		
    }
}