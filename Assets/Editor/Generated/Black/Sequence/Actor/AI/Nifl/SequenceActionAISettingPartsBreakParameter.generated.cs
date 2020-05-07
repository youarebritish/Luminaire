using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Nifl
{
    public partial class SequenceActionAISettingPartsBreakParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public uint settingPartsID_;
		public uint breakJoint_;
		public bool isRagdollReverse;
		public uint linkModeLabelFixid_;
		public uint linkModeAnimBBFixid_;
		public float lifeLimit_;
		public float damageLimit_;
		public bool isInCamera_;
		public float cameraDistance_;
		public float probabilityLow_;
		public float probabilityMiddle_;
		public float probabilityHigh_;
		public bool isDiscardWeapon_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> exclusionPartsIDList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> linkBreakingPartsIDList_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> hitCollisions_;
		public uint visiblePartsId_;
		public uint pushCollision_;
		public float timeToEraseParts_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAISettingPartsBreakParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Nifl.SequenceActionAISettingPartsBreakParameter", 0, Black.Sequence.Actor.AI.Nifl.SequenceActionAISettingPartsBreakParameter.ObjectType, null, properties, 0, 584);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Nifl.SequenceActionAISettingPartsBreakParameter", base.GetFieldProperties(), -1232637512, -244202149);
            
			
			
			return fieldProperties;
        }

		
    }
}