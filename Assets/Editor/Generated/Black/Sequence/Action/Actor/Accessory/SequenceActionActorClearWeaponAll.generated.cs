using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorClearWeaponAll : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool deleteEquipment_;
		public bool drawMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorClearWeaponAll();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorClearWeaponAll", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorClearWeaponAll.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorClearWeaponAll", base.GetFieldProperties(), 1558902670, -378697100);
            return fieldProperties;
        }

		
    }
}