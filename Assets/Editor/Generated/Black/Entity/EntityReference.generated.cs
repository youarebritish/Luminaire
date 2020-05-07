using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity
{
    public partial class EntityReference : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Entity.Entity entityPointer_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> tags_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new EntityReference();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.EntityReference", 0, Black.Entity.EntityReference.ObjectType, null, properties, 0, 96);
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

            fieldProperties = new PropertyContainer("Black.Entity.EntityReference", base.GetFieldProperties(), 407884740, -1783083912);
            return fieldProperties;
        }

		
    }
}