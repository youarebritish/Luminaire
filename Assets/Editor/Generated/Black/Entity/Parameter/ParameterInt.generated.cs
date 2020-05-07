using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Parameter
{
    public partial class ParameterInt : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public int value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ParameterInt();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Parameter.ParameterInt", 0, Black.Entity.Parameter.ParameterInt.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Parameter.ParameterInt", base.GetFieldProperties(), -1283433872, 1429672875);
            return fieldProperties;
        }

		
    }
}