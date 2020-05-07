using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorUseMedal : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int useMedal_;
		public bool drawMenu_;
		public bool randomPlayer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin gil_value_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorUseMedal();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorUseMedal", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorUseMedal.ObjectType, null, properties, 0, 848);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorUseMedal", base.GetFieldProperties(), -790528959, 1672360685);
            return fieldProperties;
        }

		
    }
}