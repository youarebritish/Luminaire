using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class RBTransitionEntry : Black.Entity.Data.CharacterEntry.CharacterEntryArrayItemBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string name;
		public int transitionType;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new RBTransitionEntry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.RBTransitionEntry", 0, Black.Entity.Data.CharacterEntry.RBTransitionEntry.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.RBTransitionEntry", base.GetFieldProperties(), -843370241, 711716121);
            
			
			
			return fieldProperties;
        }

		
    }
}