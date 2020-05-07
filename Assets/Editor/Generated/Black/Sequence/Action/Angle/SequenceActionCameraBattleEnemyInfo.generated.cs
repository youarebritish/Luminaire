using SQEX.Luminous.Core.Object;
using System.Collections.Generic;

namespace Black.Sequence.Action.Angle
{
    public partial class SequenceActionCameraBattleEnemyInfo : Black.Sequence.Action.Angle.SequenceActionCameraAngleBase
    {
        new public static ObjectType ObjectType { get; private set; }
        private static PropertyContainer fieldProperties;
		
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin judgePin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerInputPin clearPin_;
		public SQEX.Ebony.Framework.Node.GraphTriggerOutputPin outPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin targetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableInputPin fovPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin heightPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin radiusPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin centerPosPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin heightOffsetPin_;
		public SQEX.Ebony.Framework.Node.GraphVariableOutputPin distancePin_;
		public int autoCompositionBaseType_;
		public float fovDegree_;
		public float marginDistance_;
		public float minDistance_;
		public float maxDistance_;
		
        
        new public static void SetupObjectType()
        {
            if (ObjectType != null)
            {
                return;
            }

            var dummy = new SequenceActionCameraBattleEnemyInfo();
            var properties = dummy.GetFieldProperties();

            ObjectType = new ObjectType("Black.Sequence.Action.Angle.SequenceActionCameraBattleEnemyInfo", 0, Black.Sequence.Action.Angle.SequenceActionCameraBattleEnemyInfo.ObjectType, null, properties, 0, 2176);
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

            fieldProperties = new PropertyContainer("Black.Sequence.Action.Angle.SequenceActionCameraBattleEnemyInfo", base.GetFieldProperties(), -1409304765, -864302090);
            return fieldProperties;
        }

		
    }
}