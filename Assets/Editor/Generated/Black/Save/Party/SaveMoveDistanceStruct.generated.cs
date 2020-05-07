using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Party
{
    public partial class SaveMoveDistanceStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public bool flag;
		public double distance;
		public SQEX.Luminous.Math.DoubleVector4 position;
		public double distance_ability_point;
		public double distance_exp;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveMoveDistanceStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Party.SaveMoveDistanceStruct", 0, Black.Save.Party.SaveMoveDistanceStruct.ObjectType, null, properties, 0, 64);
        }
		
        public  ObjectType GetObjectType()
        {
            return ObjectType;
        }

        protected  PropertyContainer GetFieldProperties()
        {
            if (fieldProperties != null)
            {
                return fieldProperties;
            }

            fieldProperties = new PropertyContainer("Black.Save.Party.SaveMoveDistanceStruct", null, 386749652, -1450391842);
            
			
			
			fieldProperties.AddProperty(new Property("flag", 3186272471, "bool", 0, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance", 783488098, "double", 8, 8, 1, Property.PrimitiveType.Double, 0, (char)0));
			fieldProperties.AddProperty(new Property("position", 2471448074, "Luminous.Math.DoubleVector4", 16, 32, 1, Property.PrimitiveType.DoubleVector4, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_ability_point", 3444804322, "double", 48, 8, 1, Property.PrimitiveType.Double, 0, (char)0));
			fieldProperties.AddProperty(new Property("distance_exp", 843694430, "double", 56, 8, 1, Property.PrimitiveType.Double, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}