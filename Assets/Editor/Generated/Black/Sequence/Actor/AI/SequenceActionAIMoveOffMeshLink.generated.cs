using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor.AI
{
    public partial class SequenceActionAIMoveOffMeshLink : SQEX.Ebony.Framework.Sequence.SequenceEvent
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Entity.EntityGroup entityPointer_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin arrivedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin releaseTurnstilePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin activatedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin oppositeSideActivatedPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin finishedPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin actor_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin isActive_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionAIMoveOffMeshLink();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.AI.SequenceActionAIMoveOffMeshLink", 0, Black.Sequence.Actor.AI.SequenceActionAIMoveOffMeshLink.ObjectType, null, properties, 0, 904);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.AI.SequenceActionAIMoveOffMeshLink", base.GetFieldProperties(), -1669295898, -501222727);
            return fieldProperties;
        }

		
    }
}