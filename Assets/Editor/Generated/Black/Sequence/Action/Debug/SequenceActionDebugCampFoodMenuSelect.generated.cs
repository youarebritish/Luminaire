using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Debug
{
    public partial class SequenceActionDebugCampFoodMenuSelect : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menuExit_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin successed_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin foodIdValueOutPin_;
		public bool isHotel_;
		public Black.Sequence.Action.Debug.DebugCampFoodMenuItem campFoodShallowDishItemList_;
		public Black.Sequence.Action.Debug.DebugCampFoodMenuItem campFoodDeepDishItemList_;
		public Black.Sequence.Action.Debug.DebugCampFoodMenuItem campFoodStickItemList_;
		public Black.Sequence.Action.Debug.DebugCampFoodMenuItem campFoodCapnoodleItemList_;
		public Black.Sequence.Action.Debug.DebugCampFoodMenuItem hotelItemList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionDebugCampFoodMenuSelect();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Debug.SequenceActionDebugCampFoodMenuSelect", 0, Black.Sequence.Action.Debug.SequenceActionDebugCampFoodMenuSelect.ObjectType, null, properties, 0, 968);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Debug.SequenceActionDebugCampFoodMenuSelect", base.GetFieldProperties(), -665629029, -1403294304);
            
			fieldProperties.AddProperty(new Property("in_", 1827225043, "SQEX.Ebony.Framework.Node.GraphTriggerInputPin", 176, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("out_", 1514340864, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 272, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("menuExit_", 1872607415, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 368, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("successed_", 3410995658, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 464, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("foodIdValueOutPin_", 3243209035, "SQEX.Ebony.Framework.Node.GraphVariableOutputPin", 560, 88, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("isHotel_", 2330252694, "bool", 648, 1, 1, Property.PrimitiveType.Bool, 0, (char)0));
			fieldProperties.AddProperty(new Property("campFoodShallowDishItemList_", 761520384, "Black.Sequence.Action.Debug.DebugCampFoodMenuItem", 656, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("campFoodDeepDishItemList_", 4046008426, "Black.Sequence.Action.Debug.DebugCampFoodMenuItem", 680, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("campFoodStickItemList_", 53858992, "Black.Sequence.Action.Debug.DebugCampFoodMenuItem", 704, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("campFoodCapnoodleItemList_", 887054333, "Black.Sequence.Action.Debug.DebugCampFoodMenuItem", 728, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("hotelItemList_", 3167106447, "Black.Sequence.Action.Debug.DebugCampFoodMenuItem", 752, 24, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}