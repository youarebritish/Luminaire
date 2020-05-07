using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionInteraction : Black.Sequence.Actor.SequenceActionActorStatusBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin stop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin interact_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin interact_camera_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin action_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin action_camera_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin cancel_camera_;
		public bool target_flag_on_;
		public bool update_on_;
		public int action_target_;
		public bool isScopeEnd_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionInteraction();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionInteraction", 0, Black.Sequence.Actor.SequenceActionInteraction.ObjectType, null, properties, 0, 1200);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionInteraction", base.GetFieldProperties(), -2145055822, 1653150500);
            return fieldProperties;
        }

		
    }
}