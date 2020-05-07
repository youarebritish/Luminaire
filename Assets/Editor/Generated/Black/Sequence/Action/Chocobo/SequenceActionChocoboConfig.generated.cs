using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Chocobo
{
    public partial class SequenceActionChocoboConfig : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int type_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin chocoboPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fixidPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin boolPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChocoboConfig();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Chocobo.SequenceActionChocoboConfig", 0, Black.Sequence.Action.Chocobo.SequenceActionChocoboConfig.ObjectType, null, properties, 0, 640);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Chocobo.SequenceActionChocoboConfig", base.GetFieldProperties(), 117850346, 593091016);
            return fieldProperties;
        }

		
    }
}