using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Status
{
    public partial class SequenceActionActorGetWeaponEquipmentList : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin weaponElemIdListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin weaponTypeIdListPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetWeaponEquipmentList();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Status.SequenceActionActorGetWeaponEquipmentList", 0, Black.Sequence.Action.Actor.Status.SequenceActionActorGetWeaponEquipmentList.ObjectType, null, properties, 0, 752);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Status.SequenceActionActorGetWeaponEquipmentList", base.GetFieldProperties(), 1588270101, 860629089);
            return fieldProperties;
        }

		
    }
}