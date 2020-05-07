using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Quest
{
    public partial class QuestEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint questId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new QuestEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Quest.QuestEntity", 0, Black.Entity.Quest.QuestEntity.ObjectType, null, properties, 0, 72);
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

            fieldProperties = new PropertyContainer("Black.Entity.Quest.QuestEntity", base.GetFieldProperties(), -1868982302, -1976271842);
            return fieldProperties;
        }

		
    }
}