using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorUseItem : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint itemId_;
		public int useAmount_;
		public bool checkDouble_;
		public bool drawMenu_;
		public bool randomPlayer_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin use_amount_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin use_item_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin use_item_fixid_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin menu_finish_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorUseItem();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorUseItem", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorUseItem.ObjectType, null, properties, 0, 1032);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorUseItem", base.GetFieldProperties(), -512226180, -1236149647);
            return fieldProperties;
        }

		
    }
}