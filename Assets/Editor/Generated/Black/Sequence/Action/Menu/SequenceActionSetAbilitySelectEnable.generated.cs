using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionSetAbilitySelectEnable : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin isEnablePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public bool isEnable_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetAbilitySelectEnable();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionSetAbilitySelectEnable", 0, Black.Sequence.Action.Menu.SequenceActionSetAbilitySelectEnable.ObjectType, null, properties, 0, 472);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionSetAbilitySelectEnable", base.GetFieldProperties(), -790260184, 83015153);
            return fieldProperties;
        }

		
    }
}