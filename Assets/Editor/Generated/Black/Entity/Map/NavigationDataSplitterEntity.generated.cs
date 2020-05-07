using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Entity.Map
{
    public partial class NavigationDataSplitterEntity : SQEX.Ebony.Framework.Entity.Entity
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public string packageName_;
		public int splitterIndex_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new NavigationDataSplitterEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Entity.Map.NavigationDataSplitterEntity", 0, Black.Entity.Map.NavigationDataSplitterEntity.ObjectType, null, properties, 0, 88);
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

            fieldProperties = new PropertyContainer("Black.Entity.Map.NavigationDataSplitterEntity", base.GetFieldProperties(), 1481966789, 1028107364);
            return fieldProperties;
        }

		
    }
}