using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Actor.Animation
{
    public partial class SequenceActionActorGetBlackBoardParameter : Black.Sequence.Actor.SequenceActionActorBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public int paramType_;
		public uint bbParamId_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin bbParamIdPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin actorPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin bbParamValuePin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionActorGetBlackBoardParameter();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Actor.Animation.SequenceActionActorGetBlackBoardParameter", 0, Black.Sequence.Action.Actor.Animation.SequenceActionActorGetBlackBoardParameter.ObjectType, null, properties, 0, 456);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Actor.Animation.SequenceActionActorGetBlackBoardParameter", base.GetFieldProperties(), 1563690969, 1486511868);
            return fieldProperties;
        }

		
    }
}