using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Save
{
    public partial class SequenceActionSetCampPoint : Black.Sequence.Action.Save.SequenceActionSaveBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin restartPointPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public uint restartPointId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetCampPoint();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Save.SequenceActionSetCampPoint", 0, Black.Sequence.Action.Save.SequenceActionSetCampPoint.ObjectType, null, properties, 0, 464);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Save.SequenceActionSetCampPoint", base.GetFieldProperties(), 1577885211, 711060250);
            return fieldProperties;
        }

		
    }
}