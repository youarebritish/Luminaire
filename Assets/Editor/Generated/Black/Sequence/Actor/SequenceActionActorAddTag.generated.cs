using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorAddTag : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin inputIPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorIPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outputOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin succeededOPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin failedOPin_;
		public uint tag_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddTag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorAddTag", 0, Black.Sequence.Actor.SequenceActionActorAddTag.ObjectType, null, properties, 0, 664);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorAddTag", base.GetFieldProperties(), 192769409, -348388615);
            
			
			
			return fieldProperties;
        }

		
    }
}