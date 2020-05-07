using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.MiniGame.Colosseum
{
    public partial class SequenceActionColosseumCamera : SQEX.Ebony.Framework.Sequence.SequenceAction
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin betGroupCenterPin_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionColosseumCamera();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumCamera", 0, Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumCamera.ObjectType, null, properties, 0, 264);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.MiniGame.Colosseum.SequenceActionColosseumCamera", base.GetFieldProperties(), -609496794, -664608638);
            return fieldProperties;
        }

		
    }
}