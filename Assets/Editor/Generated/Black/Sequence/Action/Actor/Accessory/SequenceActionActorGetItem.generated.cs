using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorGetItem : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint itemId_;
		public int addAmount_;
		public bool checkDouble_;
		public bool drawMenu_;
		public bool randomPlayer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin add_amount_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin add_item_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin add_item_fixid_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetItem", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetItem.ObjectType, null, properties, 0, 1032);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorGetItem", base.GetFieldProperties(), 1411639714, 1280139549);
            return fieldProperties;
        }

		
    }
}