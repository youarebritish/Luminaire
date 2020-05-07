using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu
{
    public partial class TimedQuestExchangeItemMenuEntity : Black.Entity.Menu.ExchangeItemMenuEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TimedQuestExchangeItemMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.TimedQuestExchangeItemMenuEntity", 0, Black.Entity.Menu.TimedQuestExchangeItemMenuEntity.ObjectType, null, properties, 0, 528);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.TimedQuestExchangeItemMenuEntity", base.GetFieldProperties(), 860012050, -404906836);
            return fieldProperties;
        }

		
    }
}