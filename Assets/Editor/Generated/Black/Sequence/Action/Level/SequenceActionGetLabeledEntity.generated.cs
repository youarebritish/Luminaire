using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionGetLabeledEntity : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastGetActorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actorListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin lastGetEntityPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin entityListPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin labelIdPin_;
		public uint entityLabelId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionGetLabeledEntity();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionGetLabeledEntity", 0, Black.Sequence.Action.Level.SequenceActionGetLabeledEntity.ObjectType, null, properties, 0, 1008);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionGetLabeledEntity", base.GetFieldProperties(), -317674924, 1161685889);
            
			
			
			return fieldProperties;
        }

		
    }
}