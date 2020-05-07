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
            
			fieldProperties.AddProperty(new Property("playerBankNumber_", 3236749644, "Black.Save.SAVE_PLAYER", 464, 4, 1, Property.PrimitiveType.Enum, 0, (char)0));
			fieldProperties.AddProperty(new Property("equipmentId_", 1889146079, "SQEX.Ebony.Std.Fixid", 468, 4, 1, Property.PrimitiveType.Fixid, 0, (char)0));
			fieldProperties.AddProperty(new Property("equip_", 2344004900, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 472, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("equip_up_", 3968889058, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 568, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("equip_left_", 1171170286, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 664, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("equip_right_", 3694049491, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 760, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("equip_down_", 1905013245, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 856, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			fieldProperties.AddProperty(new Property("not_equip_", 955515074, "SQEX.Ebony.Framework.Node.GraphTriggerOutputPin", 952, 96, 1, Property.PrimitiveType.ClassField, 0, (char)0));
			
			
			return fieldProperties;
        }

		
    }
}