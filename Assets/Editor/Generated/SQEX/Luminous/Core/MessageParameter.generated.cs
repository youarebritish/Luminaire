using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace SQEX.Luminous.Core
{
    public partial class MessageParameter : SQEX.Luminous.Core.Object.Object
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new MessageParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("SQEX.Luminous.Core.MessageParameter", 0, SQEX.Luminous.Core.MessageParameter.ObjectType, Construct, properties, 1, 16);
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

            fieldProperties = new PropertyContainer("SQEX.Luminous.Core.MessageParameter", base.GetFieldProperties(), 691359947, 221376744);
            
			
			
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new MessageParameter();
        }
		
    }
}