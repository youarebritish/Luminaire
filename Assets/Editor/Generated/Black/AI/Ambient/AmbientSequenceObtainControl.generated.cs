using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.AI.Ambient
{
    public partial class AmbientSequenceObtainControl : Black.AI.Ambient.AmbientSequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public uint id_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin fail_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputActor_;
		public bool suspend_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new AmbientSequenceObtainControl();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.AI.Ambient.AmbientSequenceObtainControl", 0, Black.AI.Ambient.AmbientSequenceObtainControl.ObjectType, null, properties, 0, 680);
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

            fieldProperties = new PropertyContainer("Black.AI.Ambient.AmbientSequenceObtainControl", base.GetFieldProperties(), 673267353, -1995593162);
            
			
			
			return fieldProperties;
        }

		
    }
}