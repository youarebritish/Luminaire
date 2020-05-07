using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.Ability
{
    public partial class SaveJobCommandStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id;
		public bool exist;
		public int exp;
		public int level;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveJobCommandStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.Ability.SaveJobCommandStruct", 0, Black.Save.Ability.SaveJobCommandStruct.ObjectType, null, properties, 0, 16);
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

            fieldProperties = new PropertyContainer("Black.Save.Ability.SaveJobCommandStruct", null, 2144912215, -347845525);
            return fieldProperties;
        }

		
    }
}