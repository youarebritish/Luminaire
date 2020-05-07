using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Actor
{
    public partial class SequenceActionActorAddPlugin : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public int pluginType_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetActorPin_;
		public float spearInjectionSpeed_;
		public float spearAcceslarateParam_;
		public float spearJumpTimingTime_;
		public float deleteTimer_;
		public float spearSoldierJumpTimingHomingInterpolationTime_;
		public float soldierInterpolationTime_;
		public float targetHitRadius_;
		public float waitLimit_;
		public int homingType_;
		public float anchorInjectionSpeed_;
		public float homingTimer_;
		public float homingEnableTimer_;
		public float homingLimitMaxDeg_;
		public float homingInterpolationTime_;
		public uint anchorRightElementId_;
		public uint anchorLeftElementId_;
		public uint targetRightElementId_;
		public uint targetLeftElementId_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorAddPlugin();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Actor.SequenceActionActorAddPlugin", 0, Black.Sequence.Actor.SequenceActionActorAddPlugin.ObjectType, null, properties, 0, 632);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Actor.SequenceActionActorAddPlugin", base.GetFieldProperties(), 1482449552, -2096577658);
            return fieldProperties;
        }

		
    }
}