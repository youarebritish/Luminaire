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
            return fieldProperties;
        }

		
    }
}