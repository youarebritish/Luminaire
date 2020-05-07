using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Animation
{
    public partial class SequenceActionActorActivateAnimationLayer : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin activate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin deactivate_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin out_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actor_;
		public string graphName_;
		public float blendTime_;
		public bool isMirrored_;
		public uint layerId_;
		public int matchTrigger_;
		public int rootRotationType_;
		public int rootTranslationType_;
		public bool freezeSource_;
		public bool freezeTarget_;
		public bool noAnimFacingRecompute_;
		public bool noAnimOriginRecompute_;
		public bool lockAnimFacing_;
		public bool lockAnimOrigin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorActivateAnimationLayer();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateAnimationLayer", 0, Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateAnimationLayer.ObjectType, null, properties, 0, 616);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Animation.SequenceActionActorActivateAnimationLayer", base.GetFieldProperties(), -926727241, -1222896761);
            return fieldProperties;
        }

		
    }
}