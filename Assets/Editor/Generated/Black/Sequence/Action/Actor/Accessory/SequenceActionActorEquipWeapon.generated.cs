using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorEquipWeapon : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int playerBankNumber_;
		public int attack_;
		public uint equipmentId_;
		public bool checkNew_;
		public bool checkDouble_;
		public bool drawMenu_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin success_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public bool bChangeWeaponSlotNum_;
		public int weaponSlotNum_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorEquipWeapon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorEquipWeapon", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorEquipWeapon.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorEquipWeapon", base.GetFieldProperties(), 794752155, 202150544);
            return fieldProperties;
        }

		
    }
}