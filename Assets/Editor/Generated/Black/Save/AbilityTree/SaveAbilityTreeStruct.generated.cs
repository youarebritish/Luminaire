using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.AbilityTree
{
    public partial class SaveAbilityTreeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.AbilityTree.SaveAbilityTreeEntityStruct> enableAbilityTreeEntityList;
		public IList<uint> releaseBlockAbilityTreeEntityIdList;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SaveAbilityTreeStruct();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Save.AbilityTree.SaveAbilityTreeStruct", 0, Black.Save.AbilityTree.SaveAbilityTreeStruct.ObjectType, null, properties, 0, 32);
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

            fieldProperties = new PropertyContainer("Black.Save.AbilityTree.SaveAbilityTreeStruct", null, -1232274275, -1301323288);
            return fieldProperties;
        }

		
    }
}