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
		public double[] position;
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
            return fieldProperties;
        }

		
    }
}