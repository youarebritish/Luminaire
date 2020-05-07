using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Level.Nifl
{
    public partial class SequenceActionSetSenseVisualParams : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin in_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin partolPointGroupActor_;
		public bool setToBattleVisual_;
		public bool setPosOffset_;
		public UnityEngine.Vector4 posOffset_;
		public bool setDirOffset_;
		public UnityEngine.Vector4 dirOffset_;
		public bool setViewRangeMax_;
		public float viewRangeMax_;
		public bool setViewAngleYaw_;
		public float viewAngleYaw_;
		public bool setViewAnglePitch_;
		public float viewAnglePitch_;
		public bool setCenterViewRangeMax_;
		public float centerViewRangeMax_;
		public bool setCenterViewAngleYaw_;
		public float centerViewAngleYaw_;
		public bool setRangeFeelPresence_;
		public float rangeFeelPresence_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionSetSenseVisualParams();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Level.Nifl.SequenceActionSetSenseVisualParams", 0, Black.Sequence.Action.Level.Nifl.SequenceActionSetSenseVisualParams.ObjectType, null, properties, 0, 576);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Level.Nifl.SequenceActionSetSenseVisualParams", base.GetFieldProperties(), 247484670, -1237092342);
            return fieldProperties;
        }

		
    }
}