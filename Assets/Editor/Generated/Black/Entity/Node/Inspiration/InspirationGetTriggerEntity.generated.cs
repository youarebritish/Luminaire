using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Node.Inspiration
{
    public partial class InspirationGetTriggerEntity : Black.Entity.Node.TriggerEntityBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint inspirationId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InspirationGetTriggerEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Node.Inspiration.InspirationGetTriggerEntity", 0, Black.Entity.Node.Inspiration.InspirationGetTriggerEntity.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Entity.Node.Inspiration.InspirationGetTriggerEntity", base.GetFieldProperties(), -1678184742, -636121227);
            
			
			
			return fieldProperties;
        }

		
    }
}