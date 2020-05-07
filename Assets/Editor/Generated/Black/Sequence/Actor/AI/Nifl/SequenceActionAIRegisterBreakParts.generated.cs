using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI.Nifl
{
    public partial class SequenceActionAIRegisterBreakParts : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public IList<Black.Entity.Data.CharacterEntry.CharacterEntryFixidArrayItem> breakablePartsIds_;
		public int target_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIRegisterBreakParts();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.Nifl.SequenceActionAIRegisterBreakParts", 0, Black.Sequence.Actor.AI.Nifl.SequenceActionAIRegisterBreakParts.ObjectType, null, properties, 0, 488);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.Nifl.SequenceActionAIRegisterBreakParts", base.GetFieldProperties(), -118295666, 896695839);
            return fieldProperties;
        }

		
    }
}