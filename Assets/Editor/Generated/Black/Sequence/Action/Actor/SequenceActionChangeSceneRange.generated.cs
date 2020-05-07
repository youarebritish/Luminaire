using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor
{
    public partial class SequenceActionChangeSceneRange : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin rangeIn_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin rangeOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rangeInOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin rangeOutOut_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public int actorScene_;
		public int priority_;
		public bool changePositionAutomatically_;
		public float changeInterpolation_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneID_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inputSceneIDActor_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin inActorList_;
		public bool backToRegular2_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionChangeSceneRange();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.SequenceActionChangeSceneRange", 0, Black.Sequence.Action.Actor.SequenceActionChangeSceneRange.ObjectType, null, properties, 0, 1136);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.SequenceActionChangeSceneRange", base.GetFieldProperties(), 1540690398, 429478708);
            return fieldProperties;
        }

		
    }
}