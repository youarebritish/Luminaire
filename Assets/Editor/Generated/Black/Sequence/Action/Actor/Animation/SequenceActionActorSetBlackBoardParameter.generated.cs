using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Animation
{
    public partial class SequenceActionActorSetBlackBoardParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin setPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public uint bbParamId_;
		public int paramType_;
		public int intValue_;
		public float floatValue_;
		public UnityEngine.Vector4 vectorValue_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin floatPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin intPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorSetBlackBoardParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Animation.SequenceActionActorSetBlackBoardParameter", 0, Black.Sequence.Action.Actor.Animation.SequenceActionActorSetBlackBoardParameter.ObjectType, null, properties, 0, 672);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Animation.SequenceActionActorSetBlackBoardParameter", base.GetFieldProperties(), -1194373752, 971070537);
            return fieldProperties;
        }

		
    }
}