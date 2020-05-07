using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionActorUIControl : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin openPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin closePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin onOpenedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin uiEntitiesPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin worldOffsetPin_;
		public SQEX.Ebony.Framework.Sequence.Variable.Primitive.SequenceFlexibleFixidData uiId_;
		public UnityEngine.Vector4 offset_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin assignedUiEntityPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorUIControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionActorUIControl", 0, Black.Sequence.Action.Menu.SequenceActionActorUIControl.ObjectType, null, properties, 0, 880);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionActorUIControl", base.GetFieldProperties(), -195687178, -637601803);
            return fieldProperties;
        }

		
    }
}