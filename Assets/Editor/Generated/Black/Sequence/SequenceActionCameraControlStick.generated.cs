using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence
{
    public partial class SequenceActionCameraControlStick : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin enable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin disable_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin toggle_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int stickType_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraControlStick();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.SequenceActionCameraControlStick", 0, Black.Sequence.SequenceActionCameraControlStick.ObjectType, null, properties, 0, 568);
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

            fieldProperties = new PropertyContainer("Black.Sequence.SequenceActionCameraControlStick", base.GetFieldProperties(), -811629945, 1132462290);
            
			
			
			return fieldProperties;
        }

		
    }
}