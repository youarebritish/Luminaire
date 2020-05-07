using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Parameter
{
    public partial class ParameterVector : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name_;
		public UnityEngine.Vector4 value_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new ParameterVector();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Parameter.ParameterVector", 0, Black.Entity.Parameter.ParameterVector.ObjectType, null, properties, 0, 48);
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

            fieldProperties = new PropertyContainer("Black.Entity.Parameter.ParameterVector", base.GetFieldProperties(), 101203540, 1910138398);
            
			
			
			return fieldProperties;
        }

		
    }
}