using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class DebugCampFoodMenuItem : BaseObject
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public IList<Black.Sequence.Action.Debug.DebugCampScriptItem> campScriptItemList_= new List<Black.Sequence.Action.Debug.DebugCampScriptItem>();
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new DebugCampFoodMenuItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.DebugCampFoodMenuItem", 0, Black.Sequence.Action.Debug.DebugCampFoodMenuItem.ObjectType, Construct, properties, 0, 24);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.DebugCampFoodMenuItem", base.GetFieldProperties(), 1829675181, 582608255);
            
			
			
			fieldProperties.AddProperty(new Property("campScriptItemList_", 3569564637, "SQEX.Ebony.Std.DynamicArray< Black.Sequence.Action.Debug.DebugCampScriptItem* >", 8, 16, 1, Property.PrimitiveType.PointerArray, 0, (char)0));
			
			
			return fieldProperties;
        }

		
        private static BaseObject Construct()
        {
            return new DebugCampFoodMenuItem();
        }
		
    }
}