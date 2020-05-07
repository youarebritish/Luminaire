using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Camera.ObjectiveCamera
{
    public partial class SequenceActionObjectiveCameraMawarikomi : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin toggle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionObjectiveCameraMawarikomi();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraMawarikomi", 0, Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraMawarikomi.ObjectType, null, properties, 0, 560);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Camera.ObjectiveCamera.SequenceActionObjectiveCameraMawarikomi", base.GetFieldProperties(), 568815738, 873724914);
            return fieldProperties;
        }

		
    }
}