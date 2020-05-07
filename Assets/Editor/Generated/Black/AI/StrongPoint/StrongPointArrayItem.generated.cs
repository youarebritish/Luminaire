using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.StrongPoint
{
    public partial class StrongPointArrayItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int Id_;
		public uint groupId_;
		public uint elementId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new StrongPointArrayItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.StrongPoint.StrongPointArrayItem", 0, Black.AI.StrongPoint.StrongPointArrayItem.ObjectType, null, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.AI.StrongPoint.StrongPointArrayItem", base.GetFieldProperties(), -397032856, -1760687817);
            return fieldProperties;
        }

		
    }
}