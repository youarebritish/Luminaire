using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Parameter
{
    public partial class ParameterFloat : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public float value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ParameterFloat();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Parameter.ParameterFloat", 0, Black.Entity.Parameter.ParameterFloat.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Parameter.ParameterFloat", base.GetFieldProperties(), 547622597, -1639696390);
            return fieldProperties;
        }

		
    }
}