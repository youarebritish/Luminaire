using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Save.AbilityTree
{
    public partial class SaveAbilityTreeStruct
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Save.AbilityTree.SaveAbilityTreeEntityStruct> enableAbilityTreeEntityList= new List<Black.Save.AbilityTree.SaveAbilityTreeEntityStruct>();
		public IList<uint> releaseBlockAbilityTreeEntityIdList= new List<uint>();
		
        
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
            
			
			
			fieldProperties.AddProperty(new Property("enableAbilityTreeEntityList", 2881457055, "SQEX.Ebony.Std.DynamicArray< Black.Save.AbilityTree.SaveAbilityTreeEntityStruct >", 0, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			fieldProperties.AddProperty(new Property("releaseBlockAbilityTreeEntityIdList", 3454206405, "SQEX.Ebony.Std.DynamicArray< SQEX.Ebony.Std.Fixid >", 16, 16, 1, Property.PrimitiveType.Array, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}