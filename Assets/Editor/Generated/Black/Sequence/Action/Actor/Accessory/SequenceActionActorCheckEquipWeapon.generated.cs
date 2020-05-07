using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorCheckEquipWeapon : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public uint equipmentId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equip_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equip_up_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equip_left_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equip_right_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equip_down_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin not_equip_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCheckEquipWeapon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckEquipWeapon", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckEquipWeapon.ObjectType, null, properties, 0, 1048);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckEquipWeapon", base.GetFieldProperties(), 241915718, -208456008);
            
			
			
			return fieldProperties;
        }

		
    }
}