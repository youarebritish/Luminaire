using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.Labeled
{
    public partial class LabeledVariableManager
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LabeledVariableManager();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.Labeled.LabeledVariableManager", 0, Black.System.Labeled.LabeledVariableManager.ObjectType, null, properties, 0, 312);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.System.Labeled.LabeledVariableManager", null, 1341383050, 1921283349);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}