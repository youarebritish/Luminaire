using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Data
{
    public partial class LayoutCharacterItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string filePath_;
		public int layoutCreateCharacterMin_;
		public int layoutCreateCharacterMax_;
		public float deleteActorDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new LayoutCharacterItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Data.LayoutCharacterItem", 0, Black.Entity.Data.LayoutCharacterItem.ObjectType, null, properties, 0, 40);
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

            fieldProperties = new PropertyContainer("Black.Entity.Data.LayoutCharacterItem", base.GetFieldProperties(), 2035770701, 932965407);
            
			
			
			return fieldProperties;
        }

		
    }
}