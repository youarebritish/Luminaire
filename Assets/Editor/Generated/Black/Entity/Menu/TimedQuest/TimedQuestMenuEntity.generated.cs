using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Menu.TimedQuest
{
    public partial class TimedQuestMenuEntity : Black.Entity.Menu.SwfEntryEntity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new TimedQuestMenuEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Menu.TimedQuest.TimedQuestMenuEntity", 0, Black.Entity.Menu.TimedQuest.TimedQuestMenuEntity.ObjectType, null, properties, 0, 720);
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

            fieldProperties = new PropertyContainer("Black.Entity.Menu.TimedQuest.TimedQuestMenuEntity", base.GetFieldProperties(), 788248943, -58644610);
            return fieldProperties;
        }

		
    }
}