using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Recog
{
    public partial class WorkingMemoryBase : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new WorkingMemoryBase();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Recog.WorkingMemoryBase", 0, Black.AI.Recog.WorkingMemoryBase.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.AI.Recog.WorkingMemoryBase", base.GetFieldProperties(), -490584834, -2052246125);
            
			
			
			return fieldProperties;
        }

		
    }
}