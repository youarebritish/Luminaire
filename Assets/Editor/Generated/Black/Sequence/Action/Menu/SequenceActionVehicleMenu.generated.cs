using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Menu
{
    public partial class SequenceActionVehicleMenu : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin open_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin onCameraStarted_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqCameraOpen_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqCameraClose_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqCameraCancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin reqCameraCancelAreaJump_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin ride_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outOfGus_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rideNG_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isOutOfGus_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isCameraRequested_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionVehicleMenu();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Menu.SequenceActionVehicleMenu", 0, Black.Sequence.Action.Menu.SequenceActionVehicleMenu.ObjectType, null, properties, 0, 1320);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Menu.SequenceActionVehicleMenu", base.GetFieldProperties(), 595090793, 1861231413);
            
			
			
			return fieldProperties;
        }

		
    }
}