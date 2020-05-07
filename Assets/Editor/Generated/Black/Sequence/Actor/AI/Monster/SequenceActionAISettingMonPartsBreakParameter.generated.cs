using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Monster
{
    public partial class SequenceActionAISettingMonPartsBreakParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public uint settingPartsID_;
		public uint breakJoint_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> exclusionPartsIDList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> linkBreakingPartsIDList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> hitCollisions_;
		public uint visiblePartsId_;
		public uint pushCollision_;
		public float timeToEraseParts_;
		public bool isEnableNiflSubOption_;
		public uint linkModeLabelFixid_;
		public uint linkModeAnimBBFixid_;
		public bool isDiscardWeapon_;
		public bool isEnableProability_;
		public float lifeLimit_;
		public bool isInCamera_;
		public float cameraDistance_;
		public float probabilityLow_;
		public float probabilityMiddle_;
		public float probabilityHigh_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISettingMonPartsBreakParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Monster.SequenceActionAISettingMonPartsBreakParameter", 0, Black.Sequence.Actor.AI.Monster.SequenceActionAISettingMonPartsBreakParameter.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Monster.SequenceActionAISettingMonPartsBreakParameter", base.GetFieldProperties(), -311562754, -2035449609);
            
			
			
			return fieldProperties;
        }

		
    }
}