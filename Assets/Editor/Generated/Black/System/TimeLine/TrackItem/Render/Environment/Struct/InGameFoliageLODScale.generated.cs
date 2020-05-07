using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.System.TimeLine.TrackItem.Render.Environment.Struct
{
    public partial class InGameFoliageLODScale : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public float lodScale_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new InGameFoliageLODScale();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.System.TimeLine.TrackItem.Render.Environment.Struct.InGameFoliageLODScale", 0, Black.System.TimeLine.TrackItem.Render.Environment.Struct.InGameFoliageLODScale.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.System.TimeLine.TrackItem.Render.Environment.Struct.InGameFoliageLODScale", base.GetFieldProperties(), -1963424266, 868408913);
            
			
			
			fieldProperties.AddProperty(new Property("lodScale_", 2867814239, "float", 8, 4, 1, Property.PrimitiveType.Float, 0, (char)1));
			
			
			return fieldProperties;
        }

		
    }
}