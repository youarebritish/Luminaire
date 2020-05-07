using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data.CharacterEntry
{
    public partial class BuddyCharacterEntry : Black.Entity.Data.CharacterEntry.CharacterEntry
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> drivingCarVlinkPathList;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem> rideOnChocoboVlinkPathList;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new BuddyCharacterEntry();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.CharacterEntry.BuddyCharacterEntry", 0, Black.Entity.Data.CharacterEntry.BuddyCharacterEntry.ObjectType, null, properties, 0, 1192);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.CharacterEntry.BuddyCharacterEntry", base.GetFieldProperties(), -1711343228, 1608548161);
            
			fieldProperties.AddProperty(new Property("drivingCarVlinkPathList", 2784765687, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 1128, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			fieldProperties.AddProperty(new Property("rideOnChocoboVlinkPathList", 4203102472, "SQEX.Ebony.Std.DynamicArray< Black.Entity.Data.CharacterEntry.CharacterEntryStringArrayItem* >", 1144, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)2));
			
			
			return fieldProperties;
        }

		
    }
}