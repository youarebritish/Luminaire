using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Accessory
{
    public partial class SequenceActionActorCheckEquipWeaponNOX : Black.Sequence.Actor.SequenceActionActorStatusOneBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint weaponId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin equipped_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin notEquipped_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCheckEquipWeaponNOX();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckEquipWeaponNOX", 0, Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckEquipWeaponNOX.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Accessory.SequenceActionActorCheckEquipWeaponNOX", base.GetFieldProperties(), -1885435049, 603459830);
            
			
			
			return fieldProperties;
        }

		
    }
}