using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorCheckTag : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin checkActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin checkResult_;
		public int checkType_;
		public int tagCount_;
		public uint checkTag1_;
		public uint checkTag2_;
		public uint checkTag3_;
		public uint checkTag4_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorCheckTag();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorCheckTag", 0, Black.Sequence.Actor.SequenceActionActorCheckTag.ObjectType, null, properties, 0, 384);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorCheckTag", base.GetFieldProperties(), -785962209, 514307036);
            
			
			
			return fieldProperties;
        }

		
    }
}