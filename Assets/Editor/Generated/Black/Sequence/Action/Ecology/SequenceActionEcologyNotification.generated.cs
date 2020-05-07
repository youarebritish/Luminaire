using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Ecology
{
    public partial class SequenceActionEcologyNotification : Black.Sequence.Action.Ecology.SequenceActionEcologyBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin valueId_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamCreatedNotification_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamDeletedDistanceNotification_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin teamDeletedBattleNotification_;
		public bool initEnable_;
		public bool statusChange_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionEcologyNotification();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Ecology.SequenceActionEcologyNotification", 0, Black.Sequence.Action.Ecology.SequenceActionEcologyNotification.ObjectType, null, properties, 0, 776);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Ecology.SequenceActionEcologyNotification", base.GetFieldProperties(), -227970735, -558459953);
            
			
			
			return fieldProperties;
        }

		
    }
}