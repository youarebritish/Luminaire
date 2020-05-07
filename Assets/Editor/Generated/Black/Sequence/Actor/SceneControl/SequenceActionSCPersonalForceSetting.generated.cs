using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.SceneControl
{
    public partial class SequenceActionSCPersonalForceSetting : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outputPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin overwriteForceIdPin_;
		public uint overwriteForceID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorList_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSCPersonalForceSetting();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalForceSetting", 0, Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalForceSetting.ObjectType, null, properties, 0, 552);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SceneControl.SequenceActionSCPersonalForceSetting", base.GetFieldProperties(), 1673147928, -894560365);
            
			
			
			return fieldProperties;
        }

		
    }
}