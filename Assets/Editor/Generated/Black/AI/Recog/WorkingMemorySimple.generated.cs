using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Recog
{
    public partial class WorkingMemorySimple : Black.AI.Recog.WorkingMemoryBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WorkingMemorySimple();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Recog.WorkingMemorySimple", 0, Black.AI.Recog.WorkingMemorySimple.ObjectType, null, properties, 0, 128);
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

            fieldProperties = new PropertyContainer("Black.AI.Recog.WorkingMemorySimple", base.GetFieldProperties(), 1064348299, 1329186141);
            
			
			
			
			
			return fieldProperties;
        }

		
    }
}