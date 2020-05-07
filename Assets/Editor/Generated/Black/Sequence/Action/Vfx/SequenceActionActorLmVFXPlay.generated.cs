using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Vfx
{
    public partial class SequenceActionActorLmVFXPlay : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin play_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin normalStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin forceStop_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin fadeStop_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorListPin_;
		public uint vlinkId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorLmVFXPlay();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Vfx.SequenceActionActorLmVFXPlay", 0, Black.Sequence.Action.Vfx.SequenceActionActorLmVFXPlay.ObjectType, null, properties, 0, 840);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Vfx.SequenceActionActorLmVFXPlay", base.GetFieldProperties(), 1539449747, -1483684952);
            
			
			
			return fieldProperties;
        }

		
    }
}