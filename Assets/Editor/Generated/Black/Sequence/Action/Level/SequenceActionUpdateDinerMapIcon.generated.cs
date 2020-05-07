using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level
{
    public partial class SequenceActionUpdateDinerMapIcon : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin dinerUpdatePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin allUpdatePin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin dinerIdPin_;
		public uint dinerId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionUpdateDinerMapIcon();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.SequenceActionUpdateDinerMapIcon", 0, Black.Sequence.Action.Level.SequenceActionUpdateDinerMapIcon.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.SequenceActionUpdateDinerMapIcon", base.GetFieldProperties(), -103166647, -281961013);
            return fieldProperties;
        }

		
    }
}